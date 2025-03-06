using Nefarius.ViGEm.Client;
using Nefarius.ViGEm.Client.Targets;
using Nefarius.ViGEm.Client.Targets.Xbox360;
using System.Runtime.InteropServices;

namespace FFXLightningDodger
{
    public partial class Form1 : Form
    {
        private static ViGEmClient client;
        private static IXbox360Controller controller;

        private static bool IsRunning;
        private static int boltCounter;

        private static Screen SelectedScreen;

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();

            InitialiseColourSettings();
            InitialiseScreenDetectionSettings();
            InitialiseTimingSettings();
            InitialiseOutputSignalSettings();
            InitialiseController();

            boltCounter = 0;
            tsLblStatus.Text = "Ready";
        }

        private void InitialiseController()
        {
            client = new ViGEmClient();
            controller = client.CreateXbox360Controller();
            controller.Connect();
        }

        private void InitialiseColourSettings()
        {
            numTolerance.Value = 20;

            //numRedVal.Value = 80;
            //numGreenVal.Value = 80;
            //numBlueVal.Value = 99;

            numRedVal.Value = 207;
            numGreenVal.Value = 206;
            numBlueVal.Value = 254;


            lblColourPreview.BackColor = Color.FromArgb(
                (int)numRedVal.Value,
                (int)numGreenVal.Value,
                (int)numBlueVal.Value);
        }

        private void InitialiseScreenDetectionSettings()
        {
            int counter = 0;
            foreach (Screen screen in Screen.AllScreens)
            {
                cboMonitorSelection.Items.Add(screen.DeviceName);

                if (screen.Primary)
                {
                    cboMonitorSelection.SelectedIndex = counter;

                    numXCoord.Maximum = screen.Bounds.Width;
                    numYCoord.Maximum = screen.Bounds.Height;

                    SelectedScreen = screen;
                }

                counter++;
            }

            numXCoord.Value = 600;
            numYCoord.Value = 700;
            numSampleSize.Value = 1;
        }

        private void InitialiseTimingSettings()
        {
            numPreWait.Value = 0;
            numSignalDuration.Value = 100;
            numPostWait.Value = 500;
        }

        private void InitialiseOutputSignalSettings()
        {
            rdoB.Checked = true;
            rdoA.Checked = false;
            rdoX.Checked = false;
            rdoY.Checked = false;
        }

        private async void btnShowMarker_Click(object sender, EventArgs e)
        {
            DrawBoxOnMonitor(
                cboMonitorSelection.SelectedIndex,
                (int)numXCoord.Value,
                (int)numYCoord.Value,
                Color.Red,
                (int)numSampleSize.Value);
            await Task.Delay(500);
        }

        public static void DrawBoxOnMonitor(int monitorIndex, int offsetX, int offsetY, Color color, int sampleSize)
        {
            if (monitorIndex < 0 || monitorIndex >= Screen.AllScreens.Length)
            {
                MessageBox.Show("Invalid monitor index.");
                return;
            }

            Screen selectedScreen = Screen.AllScreens[monitorIndex];
            int x = selectedScreen.Bounds.Left + offsetX;
            int y = selectedScreen.Bounds.Top + offsetY;

            MarkerForm marker = new MarkerForm(x, y, color, sampleSize);
            marker.Show();

            Task.Delay(1000).ContinueWith(_ => marker.Invoke((Action)(() => marker.Close())));
        }

        private bool CheckForWhitePixels()
        {
            var size = (int)numSampleSize.Value;

            using (Bitmap bmp = new Bitmap(size, size))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(
                        SelectedScreen.Bounds.Left + (int)numXCoord.Value,
                        SelectedScreen.Bounds.Top + (int)numYCoord.Value, 
                        0, 
                        0, 
                        new Size(size, size));

                    for (int x = 0; x < size; x++)
                    {
                        for (int y = 0; y < size; y++)
                        {
                            if (!IsPixelThunder(bmp.GetPixel(x, y)))
                            {
                                return false;
                            }
                        }
                    }

                    return true;
                }
            }
        }

        private bool IsPixelThunder(Color colour)
        {
            var redMatch = IsRedChannelWithinRange(colour);
            var greenMatch = IsGreenChannelWithinRange(colour);
            var blueMatch = IsBlueChannelWithinRange(colour);

            return redMatch && greenMatch && blueMatch;
        }

        private bool IsRedChannelWithinRange(Color colour)
        {
            var tolerance = (int)numTolerance.Value;
            var r = (int)numRedVal.Value;

            return
                colour.R >= (r - tolerance) &&
                colour.R <= (r + tolerance);
        }

        private bool IsGreenChannelWithinRange(Color colour)
        {
            var tolerance = (int)numTolerance.Value;
            var g = (int)numGreenVal.Value;

            return
                colour.G >= (g - tolerance) &&
                colour.G <= (g + tolerance);
        }

        private bool IsBlueChannelWithinRange(Color colour)
        {
            var tolerance = (int)numTolerance.Value;
            var b = (int)numBlueVal.Value;

            return
                colour.B >= (b - tolerance) &&
                colour.B <= (b + tolerance);
        }

        private void btnBoltCountReset_Click(object sender, EventArgs e)
        {
            boltCounter = 0;
            lblBoltCounter.Text = $"{boltCounter}";
        }

        private void Detect()
        {
            while (IsRunning)
            {
                if (CheckForWhitePixels())
                {
                    Thread.Sleep((int)numPreWait.Value);

                    controller.SetButtonState(Xbox360Button.B, true);
                    Thread.Sleep((int)numSignalDuration.Value);
                    controller.SetButtonState(Xbox360Button.B, false);

                    boltCounter++;
                    lblBoltCounter.Invoke(new Action(() => lblBoltCounter.Text = $"{boltCounter}"));

                    Thread.Sleep((int)numPostWait.Value);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (IsRunning)
                return;

            boltCounter = 0;
            lblBoltCounter.Text = $"{boltCounter}";

            IsRunning = true;
            tsLblStatus.Text = "Running...";
            Task.Run(() => Detect());
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            IsRunning = false;
            tsLblStatus.Text = "Ready";
        }

        private void cboMonitorSelection_SelectedValueChanged(object sender, EventArgs e)
        {
            numXCoord.Maximum = Screen.AllScreens[cboMonitorSelection.SelectedIndex].Bounds.Width;
            numYCoord.Maximum = Screen.AllScreens[cboMonitorSelection.SelectedIndex].Bounds.Height;

            SelectedScreen = Screen.AllScreens[cboMonitorSelection.SelectedIndex];
        }

        private void numRedVal_ValueChanged(object sender, EventArgs e)
        {
            if (IsRunning)
            {
                MessageBox.Show("Cannot change colour while running.");
                return;
            }

            lblColourPreview.BackColor = Color.FromArgb(
                (int)numRedVal.Value,
                (int)numGreenVal.Value,
                (int)numBlueVal.Value);
        }

        private void numGreenVal_ValueChanged(object sender, EventArgs e)
        {
            if (IsRunning)
            {
                MessageBox.Show("Cannot change colour while running.");
                return;
            }

            lblColourPreview.BackColor = Color.FromArgb(
                (int)numRedVal.Value,
                (int)numGreenVal.Value,
                (int)numBlueVal.Value);
        }

        private void numBlueVal_ValueChanged(object sender, EventArgs e)
        {
            if (IsRunning)
            {
                MessageBox.Show("Cannot change colour while running.");
                return;
            }

            lblColourPreview.BackColor = Color.FromArgb(
                (int)numRedVal.Value,
                (int)numGreenVal.Value,
                (int)numBlueVal.Value);
        }
    }

    public class MarkerForm : Form
    {
        public MarkerForm(int x, int y, Color color, int size)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = color;
            //this.TransparencyKey = color; // Make it a transparent window
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.Bounds = new Rectangle(x, y, size, size);
        }
    }
}
