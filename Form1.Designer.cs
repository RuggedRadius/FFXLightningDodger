namespace FFXLightningDodger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            statusStrip1 = new StatusStrip();
            tsLblStatus = new ToolStripStatusLabel();
            groupBox1 = new GroupBox();
            lblColourPreview = new Label();
            label4 = new Label();
            numTolerance = new NumericUpDown();
            numBlueVal = new NumericUpDown();
            label3 = new Label();
            numGreenVal = new NumericUpDown();
            label2 = new Label();
            numRedVal = new NumericUpDown();
            label1 = new Label();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            rdoA = new RadioButton();
            rdoX = new RadioButton();
            rdoB = new RadioButton();
            rdoY = new RadioButton();
            groupBox3 = new GroupBox();
            numPostWait = new NumericUpDown();
            label7 = new Label();
            numSignalDuration = new NumericUpDown();
            label6 = new Label();
            numPreWait = new NumericUpDown();
            label5 = new Label();
            groupBox4 = new GroupBox();
            btnShowMarker = new Button();
            numSampleSize = new NumericUpDown();
            label13 = new Label();
            numYCoord = new NumericUpDown();
            label12 = new Label();
            numXCoord = new NumericUpDown();
            label11 = new Label();
            label10 = new Label();
            cboMonitorSelection = new ComboBox();
            groupBox5 = new GroupBox();
            btnStop = new Button();
            btnStart = new Button();
            btnBoltCountReset = new Button();
            label9 = new Label();
            lblBoltCounter = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTolerance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBlueVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGreenVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRedVal).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPostWait).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSignalDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPreWait).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSampleSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYCoord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numXCoord).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FFRK_Thunder_Plains;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(531, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsLblStatus });
            statusStrip1.Location = new Point(0, 670);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(554, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsLblStatus
            // 
            tsLblStatus.Name = "tsLblStatus";
            tsLblStatus.Size = new Size(118, 17);
            tsLblStatus.Text = "toolStripStatusLabel1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblColourPreview);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numTolerance);
            groupBox1.Controls.Add(numBlueVal);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numGreenVal);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numRedVal);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 252);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Colour Detection Settings";
            // 
            // lblColourPreview
            // 
            lblColourPreview.Location = new Point(15, 158);
            lblColourPreview.Name = "lblColourPreview";
            lblColourPreview.Size = new Size(246, 85);
            lblColourPreview.TabIndex = 8;
            lblColourPreview.Text = "Preview";
            lblColourPreview.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(15, 121);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 7;
            label4.Text = "Tolerance";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numTolerance
            // 
            numTolerance.Location = new Point(141, 119);
            numTolerance.Name = "numTolerance";
            numTolerance.Size = new Size(120, 23);
            numTolerance.TabIndex = 6;
            // 
            // numBlueVal
            // 
            numBlueVal.Location = new Point(141, 90);
            numBlueVal.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numBlueVal.Name = "numBlueVal";
            numBlueVal.Size = new Size(120, 23);
            numBlueVal.TabIndex = 5;
            numBlueVal.ValueChanged += numBlueVal_ValueChanged;
            // 
            // label3
            // 
            label3.Location = new Point(15, 92);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 4;
            label3.Text = "Blue Channel Value";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numGreenVal
            // 
            numGreenVal.Location = new Point(141, 61);
            numGreenVal.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numGreenVal.Name = "numGreenVal";
            numGreenVal.Size = new Size(120, 23);
            numGreenVal.TabIndex = 3;
            numGreenVal.ValueChanged += numGreenVal_ValueChanged;
            // 
            // label2
            // 
            label2.Location = new Point(15, 63);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 2;
            label2.Text = "Green Channel Value";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numRedVal
            // 
            numRedVal.Location = new Point(141, 32);
            numRedVal.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numRedVal.Name = "numRedVal";
            numRedVal.Size = new Size(120, 23);
            numRedVal.TabIndex = 1;
            numRedVal.ValueChanged += numRedVal_ValueChanged;
            // 
            // label1
            // 
            label1.Location = new Point(15, 34);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Red Channel Value";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(rdoA);
            groupBox2.Controls.Add(rdoX);
            groupBox2.Controls.Add(rdoB);
            groupBox2.Controls.Add(rdoY);
            groupBox2.Location = new Point(12, 411);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 253);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output Signal";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.xbox_controller_buttons_md;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(47, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 160);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // rdoA
            // 
            rdoA.AutoSize = true;
            rdoA.Location = new Point(124, 223);
            rdoA.Name = "rdoA";
            rdoA.Size = new Size(33, 19);
            rdoA.TabIndex = 7;
            rdoA.Text = "A";
            rdoA.UseVisualStyleBackColor = true;
            // 
            // rdoX
            // 
            rdoX.AutoSize = true;
            rdoX.Location = new Point(19, 128);
            rdoX.Name = "rdoX";
            rdoX.Size = new Size(32, 19);
            rdoX.TabIndex = 6;
            rdoX.Text = "X";
            rdoX.UseVisualStyleBackColor = true;
            // 
            // rdoB
            // 
            rdoB.AutoSize = true;
            rdoB.Checked = true;
            rdoB.Location = new Point(227, 128);
            rdoB.Name = "rdoB";
            rdoB.Size = new Size(32, 19);
            rdoB.TabIndex = 5;
            rdoB.TabStop = true;
            rdoB.Text = "B";
            rdoB.UseVisualStyleBackColor = true;
            // 
            // rdoY
            // 
            rdoY.AutoSize = true;
            rdoY.Location = new Point(124, 32);
            rdoY.Name = "rdoY";
            rdoY.Size = new Size(32, 19);
            rdoY.TabIndex = 4;
            rdoY.Text = "Y";
            rdoY.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numPostWait);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(numSignalDuration);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(numPreWait);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(297, 328);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(246, 120);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Timing Settings";
            // 
            // numPostWait
            // 
            numPostWait.Location = new Point(111, 80);
            numPostWait.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numPostWait.Name = "numPostWait";
            numPostWait.Size = new Size(120, 23);
            numPostWait.TabIndex = 13;
            // 
            // label7
            // 
            label7.Location = new Point(15, 82);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 12;
            label7.Text = "Post-Signal Wait";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numSignalDuration
            // 
            numSignalDuration.Location = new Point(111, 51);
            numSignalDuration.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSignalDuration.Name = "numSignalDuration";
            numSignalDuration.Size = new Size(120, 23);
            numSignalDuration.TabIndex = 11;
            // 
            // label6
            // 
            label6.Location = new Point(15, 53);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 10;
            label6.Text = "Signal Duration";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numPreWait
            // 
            numPreWait.Location = new Point(111, 22);
            numPreWait.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPreWait.Name = "numPreWait";
            numPreWait.Size = new Size(120, 23);
            numPreWait.TabIndex = 9;
            // 
            // label5
            // 
            label5.Location = new Point(15, 24);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 8;
            label5.Text = "Pre-signal Wait";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnShowMarker);
            groupBox4.Controls.Add(numSampleSize);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(numYCoord);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(numXCoord);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(cboMonitorSelection);
            groupBox4.Location = new Point(297, 153);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(246, 169);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Screen Detection Settings";
            // 
            // btnShowMarker
            // 
            btnShowMarker.Location = new Point(6, 135);
            btnShowMarker.Name = "btnShowMarker";
            btnShowMarker.Size = new Size(225, 23);
            btnShowMarker.TabIndex = 16;
            btnShowMarker.Text = "Show Marker";
            btnShowMarker.UseVisualStyleBackColor = true;
            btnShowMarker.Click += btnShowMarker_Click;
            // 
            // numSampleSize
            // 
            numSampleSize.Location = new Point(102, 107);
            numSampleSize.Name = "numSampleSize";
            numSampleSize.Size = new Size(129, 23);
            numSampleSize.TabIndex = 13;
            // 
            // label13
            // 
            label13.Location = new Point(6, 109);
            label13.Name = "label13";
            label13.Size = new Size(90, 15);
            label13.TabIndex = 12;
            label13.Text = "Sample Size";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numYCoord
            // 
            numYCoord.Location = new Point(102, 78);
            numYCoord.Name = "numYCoord";
            numYCoord.Size = new Size(129, 23);
            numYCoord.TabIndex = 11;
            // 
            // label12
            // 
            label12.Location = new Point(6, 80);
            label12.Name = "label12";
            label12.Size = new Size(90, 15);
            label12.TabIndex = 10;
            label12.Text = "Y-Coordinate";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numXCoord
            // 
            numXCoord.Location = new Point(102, 49);
            numXCoord.Name = "numXCoord";
            numXCoord.Size = new Size(129, 23);
            numXCoord.TabIndex = 9;
            // 
            // label11
            // 
            label11.Location = new Point(6, 51);
            label11.Name = "label11";
            label11.Size = new Size(90, 15);
            label11.TabIndex = 8;
            label11.Text = "X-Coordinate";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Location = new Point(6, 24);
            label10.Name = "label10";
            label10.Size = new Size(90, 15);
            label10.TabIndex = 8;
            label10.Text = "Monitor";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboMonitorSelection
            // 
            cboMonitorSelection.FormattingEnabled = true;
            cboMonitorSelection.Location = new Point(102, 20);
            cboMonitorSelection.Name = "cboMonitorSelection";
            cboMonitorSelection.Size = new Size(129, 23);
            cboMonitorSelection.TabIndex = 0;
            cboMonitorSelection.SelectedValueChanged += cboMonitorSelection_SelectedValueChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnStop);
            groupBox5.Controls.Add(btnStart);
            groupBox5.Controls.Add(btnBoltCountReset);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(lblBoltCounter);
            groupBox5.Location = new Point(297, 454);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(246, 210);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Control";
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(255, 192, 192);
            btnStop.Location = new Point(6, 162);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(234, 35);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(192, 255, 192);
            btnStart.Location = new Point(6, 121);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(234, 35);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnBoltCountReset
            // 
            btnBoltCountReset.Location = new Point(6, 90);
            btnBoltCountReset.Name = "btnBoltCountReset";
            btnBoltCountReset.Size = new Size(234, 23);
            btnBoltCountReset.TabIndex = 2;
            btnBoltCountReset.Text = "Reset Counter";
            btnBoltCountReset.UseVisualStyleBackColor = true;
            btnBoltCountReset.Click += btnBoltCountReset_Click;
            // 
            // label9
            // 
            label9.Location = new Point(6, 64);
            label9.Name = "label9";
            label9.Size = new Size(234, 23);
            label9.TabIndex = 1;
            label9.Text = "Bolts Detected";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblBoltCounter
            // 
            lblBoltCounter.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBoltCounter.Location = new Point(6, 19);
            lblBoltCounter.Name = "lblBoltCounter";
            lblBoltCounter.Size = new Size(234, 45);
            lblBoltCounter.TabIndex = 0;
            lblBoltCounter.Text = "0";
            lblBoltCounter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 692);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "FFX Lightning Dodger";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numTolerance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBlueVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGreenVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRedVal).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numPostWait).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSignalDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPreWait).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numSampleSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYCoord).EndInit();
            ((System.ComponentModel.ISupportInitialize)numXCoord).EndInit();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsLblStatus;
        private GroupBox groupBox1;
        private Label label4;
        private NumericUpDown numTolerance;
        private NumericUpDown numBlueVal;
        private Label label3;
        private NumericUpDown numGreenVal;
        private Label label2;
        private NumericUpDown numRedVal;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rdoA;
        private RadioButton rdoX;
        private RadioButton rdoB;
        private RadioButton rdoY;
        private GroupBox groupBox3;
        private NumericUpDown numPostWait;
        private Label label7;
        private NumericUpDown numSignalDuration;
        private Label label6;
        private NumericUpDown numPreWait;
        private Label label5;
        private GroupBox groupBox4;
        private NumericUpDown numSampleSize;
        private Label label13;
        private NumericUpDown numYCoord;
        private Label label12;
        private NumericUpDown numXCoord;
        private Label label11;
        private Label label10;
        private ComboBox cboMonitorSelection;
        private GroupBox groupBox5;
        private Button btnStop;
        private Button btnStart;
        private Button btnBoltCountReset;
        private Label label9;
        private Label lblBoltCounter;
        private Button btnShowMarker;
        private PictureBox pictureBox2;
        private Label lblColourPreview;
    }
}
