using System.Runtime.InteropServices;

namespace FFXLightningDodger
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        //public static void DrawBoxOnMonitor(int monitorIndex, int offsetX, int offsetY, Color color, int sampleSize)
        //{
        //    if (monitorIndex < 0 || monitorIndex >= Screen.AllScreens.Length)
        //    {
        //        MessageBox.Show("Invalid monitor index.");
        //        return;
        //    }

        //    Screen selectedScreen = Screen.AllScreens[monitorIndex];
        //    int x = selectedScreen.Bounds.Left + offsetX; // Position relative to monitor
        //    int y = selectedScreen.Bounds.Top + offsetY;

        //    using (Graphics g = Graphics.FromHwnd(IntPtr.Zero)) // Get desktop Graphics
        //    using (SolidBrush brush = new SolidBrush(color))
        //    {
        //        g.FillRectangle(brush, new Rectangle(x, y, sampleSize, sampleSize));
        //    }

        //    Thread.Sleep(1000);
        //}
    }
}