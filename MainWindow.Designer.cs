namespace OpenProductivity
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSession = new System.Windows.Forms.TabPage();
            this.buttonClockStartStop = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.PictureBox();
            this.tabPageSetting = new System.Windows.Forms.TabPage();
            this.tabControlSetting = new System.Windows.Forms.TabControl();
            this.tabPageSettingGeneral = new System.Windows.Forms.TabPage();
            this.buttonSettingOk1 = new System.Windows.Forms.Button();
            this.enableBreakTime = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.breakTimeSec = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.breakTimeMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sessionTimeSec = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.sessionTimeMin = new System.Windows.Forms.NumericUpDown();
            this.label0 = new System.Windows.Forms.Label();
            this.sessionTimeHR = new System.Windows.Forms.NumericUpDown();
            this.labelSessionTime = new System.Windows.Forms.Label();
            this.tabPageSettingAppBlocking = new System.Windows.Forms.TabPage();
            this.tabPageSettingWebBlocking = new System.Windows.Forms.TabPage();
            this.tabPageSettingAdvanced = new System.Windows.Forms.TabPage();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.aboutTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clock)).BeginInit();
            this.tabPageSetting.SuspendLayout();
            this.tabControlSetting.SuspendLayout();
            this.tabPageSettingGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakTimeSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakTimeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTimeSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTimeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTimeHR)).BeginInit();
            this.tabPageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageSession);
            this.tabControlMain.Controls.Add(this.tabPageSetting);
            this.tabControlMain.Controls.Add(this.tabPageAbout);
            this.tabControlMain.Location = new System.Drawing.Point(-1, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(374, 427);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageSession
            // 
            this.tabPageSession.Controls.Add(this.buttonClockStartStop);
            this.tabPageSession.Controls.Add(this.clock);
            this.tabPageSession.Location = new System.Drawing.Point(4, 24);
            this.tabPageSession.Name = "tabPageSession";
            this.tabPageSession.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSession.Size = new System.Drawing.Size(366, 399);
            this.tabPageSession.TabIndex = 1;
            this.tabPageSession.Text = "Session";
            this.tabPageSession.UseVisualStyleBackColor = true;
            // 
            // buttonClockStartStop
            // 
            this.buttonClockStartStop.BackColor = System.Drawing.Color.White;
            this.buttonClockStartStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonClockStartStop.FlatAppearance.BorderSize = 0;
            this.buttonClockStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClockStartStop.Image = global::OpenProductivity.Properties.Resources.play_button;
            this.buttonClockStartStop.Location = new System.Drawing.Point(146, 315);
            this.buttonClockStartStop.Name = "buttonClockStartStop";
            this.buttonClockStartStop.Size = new System.Drawing.Size(73, 73);
            this.buttonClockStartStop.TabIndex = 1;
            this.buttonClockStartStop.TabStop = false;
            this.buttonClockStartStop.UseVisualStyleBackColor = false;
            this.buttonClockStartStop.Click += ButtonClockStartStop_Click;
            // 
            // clock
            // 
            this.clock.Location = new System.Drawing.Point(19, 14);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(326, 284);
            this.clock.TabIndex = 0;
            this.clock.TabStop = false;
            this.clock.Paint += Clock_Paint;
            // 
            // tabPageSetting
            // 
            this.tabPageSetting.Controls.Add(this.tabControlSetting);
            this.tabPageSetting.Location = new System.Drawing.Point(4, 24);
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetting.Size = new System.Drawing.Size(366, 399);
            this.tabPageSetting.TabIndex = 2;
            this.tabPageSetting.Text = "Setting";
            this.tabPageSetting.UseVisualStyleBackColor = true;
            // 
            // tabControlSetting
            // 
            this.tabControlSetting.Controls.Add(this.tabPageSettingGeneral);
            this.tabControlSetting.Controls.Add(this.tabPageSettingAppBlocking);
            this.tabControlSetting.Controls.Add(this.tabPageSettingWebBlocking);
            this.tabControlSetting.Controls.Add(this.tabPageSettingAdvanced);
            this.tabControlSetting.Location = new System.Drawing.Point(4, 4);
            this.tabControlSetting.Name = "tabControlSetting";
            this.tabControlSetting.SelectedIndex = 0;
            this.tabControlSetting.Size = new System.Drawing.Size(362, 392);
            this.tabControlSetting.TabIndex = 0;
            // 
            // tabPageSettingGeneral
            // 
            this.tabPageSettingGeneral.Controls.Add(this.buttonSettingOk1);
            this.tabPageSettingGeneral.Controls.Add(this.enableBreakTime);
            this.tabPageSettingGeneral.Controls.Add(this.label6);
            this.tabPageSettingGeneral.Controls.Add(this.breakTimeSec);
            this.tabPageSettingGeneral.Controls.Add(this.label5);
            this.tabPageSettingGeneral.Controls.Add(this.label2);
            this.tabPageSettingGeneral.Controls.Add(this.breakTimeMin);
            this.tabPageSettingGeneral.Controls.Add(this.label4);
            this.tabPageSettingGeneral.Controls.Add(this.label3);
            this.tabPageSettingGeneral.Controls.Add(this.sessionTimeSec);
            this.tabPageSettingGeneral.Controls.Add(this.label1);
            this.tabPageSettingGeneral.Controls.Add(this.sessionTimeMin);
            this.tabPageSettingGeneral.Controls.Add(this.label0);
            this.tabPageSettingGeneral.Controls.Add(this.sessionTimeHR);
            this.tabPageSettingGeneral.Controls.Add(this.labelSessionTime);
            this.tabPageSettingGeneral.Location = new System.Drawing.Point(4, 24);
            this.tabPageSettingGeneral.Name = "tabPageSettingGeneral";
            this.tabPageSettingGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettingGeneral.Size = new System.Drawing.Size(354, 364);
            this.tabPageSettingGeneral.TabIndex = 0;
            this.tabPageSettingGeneral.Text = "General";
            this.tabPageSettingGeneral.UseVisualStyleBackColor = true;
            // 
            // buttonSettingOk1
            // 
            this.buttonSettingOk1.Location = new System.Drawing.Point(184, 320);
            this.buttonSettingOk1.Name = "buttonSettingOk1";
            this.buttonSettingOk1.Size = new System.Drawing.Size(75, 23);
            this.buttonSettingOk1.TabIndex = 14;
            this.buttonSettingOk1.Text = "Ok";
            this.buttonSettingOk1.UseVisualStyleBackColor = true;
            // 
            // enableBreakTime
            // 
            this.enableBreakTime.AutoSize = true;
            this.enableBreakTime.Location = new System.Drawing.Point(18, 61);
            this.enableBreakTime.Name = "enableBreakTime";
            this.enableBreakTime.Size = new System.Drawing.Size(125, 19);
            this.enableBreakTime.TabIndex = 13;
            this.enableBreakTime.Text = "Enable break time?";
            this.enableBreakTime.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "sec";
            // 
            // breakTimeSec
            // 
            this.breakTimeSec.Location = new System.Drawing.Point(269, 95);
            this.breakTimeSec.Name = "breakTimeSec";
            this.breakTimeSec.Size = new System.Drawing.Size(45, 23);
            this.breakTimeSec.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1035, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "min";
            // 
            // breakTimeMin
            // 
            this.breakTimeMin.Location = new System.Drawing.Point(184, 95);
            this.breakTimeMin.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.breakTimeMin.Name = "breakTimeMin";
            this.breakTimeMin.Size = new System.Drawing.Size(45, 23);
            this.breakTimeMin.TabIndex = 8;
            this.breakTimeMin.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Break time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "sec";
            // 
            // sessionTimeSec
            // 
            this.sessionTimeSec.Location = new System.Drawing.Point(269, 21);
            this.sessionTimeSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.sessionTimeSec.Name = "sessionTimeSec";
            this.sessionTimeSec.Size = new System.Drawing.Size(45, 23);
            this.sessionTimeSec.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "min";
            // 
            // sessionTimeMin
            // 
            this.sessionTimeMin.Location = new System.Drawing.Point(185, 21);
            this.sessionTimeMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.sessionTimeMin.Name = "sessionTimeMin";
            this.sessionTimeMin.Size = new System.Drawing.Size(44, 23);
            this.sessionTimeMin.TabIndex = 3;
            this.sessionTimeMin.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(161, 23);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(18, 15);
            this.label0.TabIndex = 2;
            this.label0.Text = "hr";
            // 
            // sessionTimeHR
            // 
            this.sessionTimeHR.Location = new System.Drawing.Point(110, 21);
            this.sessionTimeHR.Name = "sessionTimeHR";
            this.sessionTimeHR.Size = new System.Drawing.Size(45, 23);
            this.sessionTimeHR.TabIndex = 1;
            // 
            // labelSessionTime
            // 
            this.labelSessionTime.AutoSize = true;
            this.labelSessionTime.Location = new System.Drawing.Point(18, 23);
            this.labelSessionTime.Name = "labelSessionTime";
            this.labelSessionTime.Size = new System.Drawing.Size(73, 15);
            this.labelSessionTime.TabIndex = 0;
            this.labelSessionTime.Text = "Session time";
            // 
            // tabPageSettingAppBlocking
            // 
            this.tabPageSettingAppBlocking.Location = new System.Drawing.Point(4, 24);
            this.tabPageSettingAppBlocking.Name = "tabPageSettingAppBlocking";
            this.tabPageSettingAppBlocking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettingAppBlocking.Size = new System.Drawing.Size(354, 364);
            this.tabPageSettingAppBlocking.TabIndex = 1;
            this.tabPageSettingAppBlocking.Text = "App blocking";
            this.tabPageSettingAppBlocking.UseVisualStyleBackColor = true;
            // 
            // tabPageSettingWebBlocking
            // 
            this.tabPageSettingWebBlocking.Location = new System.Drawing.Point(4, 24);
            this.tabPageSettingWebBlocking.Name = "tabPageSettingWebBlocking";
            this.tabPageSettingWebBlocking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettingWebBlocking.Size = new System.Drawing.Size(354, 364);
            this.tabPageSettingWebBlocking.TabIndex = 2;
            this.tabPageSettingWebBlocking.Text = "Web blocking";
            this.tabPageSettingWebBlocking.UseVisualStyleBackColor = true;
            // 
            // tabPageSettingAdvanced
            // 
            this.tabPageSettingAdvanced.Location = new System.Drawing.Point(4, 24);
            this.tabPageSettingAdvanced.Name = "tabPageSettingAdvanced";
            this.tabPageSettingAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettingAdvanced.Size = new System.Drawing.Size(354, 364);
            this.tabPageSettingAdvanced.TabIndex = 3;
            this.tabPageSettingAdvanced.Text = "Advanced";
            this.tabPageSettingAdvanced.UseVisualStyleBackColor = true;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.aboutTextBox);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 24);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(366, 399);
            this.tabPageAbout.TabIndex = 3;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.Location = new System.Drawing.Point(0, 5);
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.Size = new System.Drawing.Size(365, 391);
            this.aboutTextBox.TabIndex = 0;
            this.aboutTextBox.Text = resources.GetString("aboutTextBox.Text");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 424);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "OpenProductivity";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSession.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clock)).EndInit();
            this.tabPageSetting.ResumeLayout(false);
            this.tabControlSetting.ResumeLayout(false);
            this.tabPageSettingGeneral.ResumeLayout(false);
            this.tabPageSettingGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakTimeSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakTimeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTimeSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTimeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTimeHR)).EndInit();
            this.tabPageAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSession;
        private System.Windows.Forms.TabPage tabPageSetting;
        private System.Windows.Forms.TabControl tabControlSetting;
        private System.Windows.Forms.TabPage tabPageSettingGeneral;
        private System.Windows.Forms.TabPage tabPageSettingAppBlocking;
        private System.Windows.Forms.TabPage tabPageSettingWebBlocking;
        private System.Windows.Forms.TabPage tabPageSettingAdvanced;
        private System.Windows.Forms.Button buttonClockStartStop;
        private System.Windows.Forms.PictureBox clock;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.RichTextBox aboutTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown breakTimeSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.NumericUpDown ktime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sessionTimeSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sessionTimeMin;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.NumericUpDown sessionTimeHR;
        private System.Windows.Forms.Label labelSessionTime;
        private System.Windows.Forms.NumericUpDown breakTimeMin;
        private System.Windows.Forms.CheckBox enableBreakTime;
        private System.Windows.Forms.Button buttonSettingOk1;
    }
}

