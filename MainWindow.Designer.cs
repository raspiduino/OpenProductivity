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
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonClockStartStop = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.PictureBox();
            this.tabPageSetting = new System.Windows.Forms.TabPage();
            this.tabControlSetting = new System.Windows.Forms.TabControl();
            this.tabPageSettingGeneral = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonApplySetting = new System.Windows.Forms.Button();
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
            this.appListBox = new System.Windows.Forms.CheckedListBox();
            this.buttonRemoveApp = new System.Windows.Forms.Button();
            this.buttonAddApp = new System.Windows.Forms.Button();
            this.addAppInput = new System.Windows.Forms.TextBox();
            this.tabPageSettingWebBlocking = new System.Windows.Forms.TabPage();
            this.buttonRemoveWeb = new System.Windows.Forms.Button();
            this.buttonAddWeb = new System.Windows.Forms.Button();
            this.textBoxAddWeb = new System.Windows.Forms.TextBox();
            this.checkBoxBlockInternet = new System.Windows.Forms.CheckBox();
            this.webListBox = new System.Windows.Forms.CheckedListBox();
            this.tabPageSettingAdvanced = new System.Windows.Forms.TabPage();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.buttonApplyAdv = new System.Windows.Forms.Button();
            this.buttonOKAdv = new System.Windows.Forms.Button();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.aboutTextBox = new System.Windows.Forms.RichTextBox();
            this.blocker = new System.ComponentModel.BackgroundWorker();
            this.blocktab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.m1 = new System.Windows.Forms.RadioButton();
            this.m2 = new System.Windows.Forms.RadioButton();
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
            this.tabPageSettingAppBlocking.SuspendLayout();
            this.tabPageSettingWebBlocking.SuspendLayout();
            this.tabPageSettingAdvanced.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.blocktab.SuspendLayout();
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
            this.tabPageSession.Controls.Add(this.buttonRestart);
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
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.White;
            this.buttonRestart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRestart.FlatAppearance.BorderSize = 0;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Image = global::OpenProductivity.Properties.Resources.restart_button;
            this.buttonRestart.Location = new System.Drawing.Point(90, 333);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(41, 37);
            this.buttonRestart.TabIndex = 2;
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += ButtonRestart_Click;
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
            this.tabControlSetting.Controls.Add(this.blocktab);
            this.tabControlSetting.Location = new System.Drawing.Point(4, 4);
            this.tabControlSetting.Name = "tabControlSetting";
            this.tabControlSetting.SelectedIndex = 0;
            this.tabControlSetting.Size = new System.Drawing.Size(362, 392);
            this.tabControlSetting.TabIndex = 0;
            // 
            // tabPageSettingGeneral
            // 
            this.tabPageSettingGeneral.Controls.Add(this.label7);
            this.tabPageSettingGeneral.Controls.Add(this.buttonApplySetting);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "The setting will be apply right away";
            // 
            // buttonApplySetting
            // 
            this.buttonApplySetting.Location = new System.Drawing.Point(269, 320);
            this.buttonApplySetting.Name = "buttonApplySetting";
            this.buttonApplySetting.Size = new System.Drawing.Size(75, 23);
            this.buttonApplySetting.TabIndex = 15;
            this.buttonApplySetting.Text = "Apply";
            this.buttonApplySetting.UseVisualStyleBackColor = true;
            this.buttonApplySetting.Click += buttonApplySetting_Click;
            // 
            // buttonSettingOk1
            // 
            this.buttonSettingOk1.Location = new System.Drawing.Point(184, 320);
            this.buttonSettingOk1.Name = "buttonSettingOk1";
            this.buttonSettingOk1.Size = new System.Drawing.Size(75, 23);
            this.buttonSettingOk1.TabIndex = 14;
            this.buttonSettingOk1.Text = "Ok";
            this.buttonSettingOk1.UseVisualStyleBackColor = true;
            this.buttonSettingOk1.Click += buttonSettingOk1_Click;
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
            this.enableBreakTime.Click += enableBreakTime_Click;
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
            this.tabPageSettingAppBlocking.Controls.Add(this.appListBox);
            this.tabPageSettingAppBlocking.Controls.Add(this.buttonRemoveApp);
            this.tabPageSettingAppBlocking.Controls.Add(this.buttonAddApp);
            this.tabPageSettingAppBlocking.Controls.Add(this.addAppInput);
            this.tabPageSettingAppBlocking.Location = new System.Drawing.Point(4, 24);
            this.tabPageSettingAppBlocking.Name = "tabPageSettingAppBlocking";
            this.tabPageSettingAppBlocking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettingAppBlocking.Size = new System.Drawing.Size(354, 364);
            this.tabPageSettingAppBlocking.TabIndex = 1;
            this.tabPageSettingAppBlocking.Text = "App blocking";
            this.tabPageSettingAppBlocking.UseVisualStyleBackColor = true;
            // 
            // appListBox
            // 
            this.appListBox.FormattingEnabled = true;
            this.appListBox.Location = new System.Drawing.Point(3, 2);
            this.appListBox.Name = "appListBox";
            this.appListBox.Size = new System.Drawing.Size(348, 328);
            this.appListBox.TabIndex = 5;
            // 
            // buttonRemoveApp
            // 
            this.buttonRemoveApp.Location = new System.Drawing.Point(263, 336);
            this.buttonRemoveApp.Name = "buttonRemoveApp";
            this.buttonRemoveApp.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveApp.TabIndex = 4;
            this.buttonRemoveApp.Text = "Remove";
            this.buttonRemoveApp.UseVisualStyleBackColor = true;
            this.buttonRemoveApp.Click += buttonRemoveApp_Click;
            // 
            // buttonAddApp
            // 
            this.buttonAddApp.Location = new System.Drawing.Point(160, 336);
            this.buttonAddApp.Name = "buttonAddApp";
            this.buttonAddApp.Size = new System.Drawing.Size(75, 23);
            this.buttonAddApp.TabIndex = 3;
            this.buttonAddApp.Text = "Add";
            this.buttonAddApp.UseVisualStyleBackColor = true;
            this.buttonAddApp.Click += buttonAddApp_Click;
            // 
            // addAppInput
            // 
            this.addAppInput.Location = new System.Drawing.Point(13, 337);
            this.addAppInput.Name = "addAppInput";
            this.addAppInput.Size = new System.Drawing.Size(141, 23);
            this.addAppInput.TabIndex = 2;
            // 
            // tabPageSettingWebBlocking
            // 
            this.tabPageSettingWebBlocking.Controls.Add(this.buttonRemoveWeb);
            this.tabPageSettingWebBlocking.Controls.Add(this.buttonAddWeb);
            this.tabPageSettingWebBlocking.Controls.Add(this.textBoxAddWeb);
            this.tabPageSettingWebBlocking.Controls.Add(this.checkBoxBlockInternet);
            this.tabPageSettingWebBlocking.Controls.Add(this.webListBox);
            this.tabPageSettingWebBlocking.Location = new System.Drawing.Point(4, 24);
            this.tabPageSettingWebBlocking.Name = "tabPageSettingWebBlocking";
            this.tabPageSettingWebBlocking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettingWebBlocking.Size = new System.Drawing.Size(354, 364);
            this.tabPageSettingWebBlocking.TabIndex = 2;
            this.tabPageSettingWebBlocking.Text = "Web blocking";
            this.tabPageSettingWebBlocking.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveWeb
            // 
            this.buttonRemoveWeb.Location = new System.Drawing.Point(264, 339);
            this.buttonRemoveWeb.Name = "buttonRemoveWeb";
            this.buttonRemoveWeb.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveWeb.TabIndex = 4;
            this.buttonRemoveWeb.Text = "Remove";
            this.buttonRemoveWeb.UseVisualStyleBackColor = true;
            this.buttonRemoveWeb.Click += buttonRemoveWeb_Click;
            // 
            // buttonAddWeb
            // 
            this.buttonAddWeb.Location = new System.Drawing.Point(159, 339);
            this.buttonAddWeb.Name = "buttonAddWeb";
            this.buttonAddWeb.Size = new System.Drawing.Size(75, 23);
            this.buttonAddWeb.TabIndex = 3;
            this.buttonAddWeb.Text = "Add";
            this.buttonAddWeb.UseVisualStyleBackColor = true;
            this.buttonAddWeb.Click += buttonAddWeb_Click;
            // 
            // textBoxAddWeb
            // 
            this.textBoxAddWeb.Location = new System.Drawing.Point(14, 339);
            this.textBoxAddWeb.Name = "textBoxAddWeb";
            this.textBoxAddWeb.Size = new System.Drawing.Size(139, 23);
            this.textBoxAddWeb.TabIndex = 2;
            // 
            // checkBoxBlockInternet
            // 
            this.checkBoxBlockInternet.AutoSize = true;
            this.checkBoxBlockInternet.Location = new System.Drawing.Point(14, 3);
            this.checkBoxBlockInternet.Name = "checkBoxBlockInternet";
            this.checkBoxBlockInternet.Size = new System.Drawing.Size(220, 19);
            this.checkBoxBlockInternet.TabIndex = 1;
            this.checkBoxBlockInternet.Text = "Block the entire Internet connection?";
            this.checkBoxBlockInternet.UseVisualStyleBackColor = true;
            this.checkBoxBlockInternet.Click += checkBoxBlockInternet_Click;
            // 
            // webListBox
            // 
            this.webListBox.FormattingEnabled = true;
            this.webListBox.Location = new System.Drawing.Point(0, 22);
            this.webListBox.Name = "webListBox";
            this.webListBox.Size = new System.Drawing.Size(354, 310);
            this.webListBox.TabIndex = 0;
            // 
            // tabPageSettingAdvanced
            // 
            this.tabPageSettingAdvanced.Controls.Add(this.checkBox13);
            this.tabPageSettingAdvanced.Controls.Add(this.checkBox12);
            this.tabPageSettingAdvanced.Controls.Add(this.buttonApplyAdv);
            this.tabPageSettingAdvanced.Controls.Add(this.buttonOKAdv);
            this.tabPageSettingAdvanced.Controls.Add(this.checkBox11);
            this.tabPageSettingAdvanced.Controls.Add(this.checkBox10);
            this.tabPageSettingAdvanced.Controls.Add(this.checkBox9);
            this.tabPageSettingAdvanced.Controls.Add(this.checkBox8);
            this.tabPageSettingAdvanced.Controls.Add(this.checkBox7);
            this.tabPageSettingAdvanced.Controls.Add(this.checkBox6);
            this.tabPageSettingAdvanced.Controls.Add(this.checkBox5);
            this.tabPageSettingAdvanced.Controls.Add(this.checkBox4);
            this.tabPageSettingAdvanced.Controls.Add(this.checkBox3);
            this.tabPageSettingAdvanced.Controls.Add(this.checkBox2);
            this.tabPageSettingAdvanced.Controls.Add(this.checkBox1);
            this.tabPageSettingAdvanced.Location = new System.Drawing.Point(4, 24);
            this.tabPageSettingAdvanced.Name = "tabPageSettingAdvanced";
            this.tabPageSettingAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettingAdvanced.Size = new System.Drawing.Size(354, 364);
            this.tabPageSettingAdvanced.TabIndex = 3;
            this.tabPageSettingAdvanced.Text = "Advanced";
            this.tabPageSettingAdvanced.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(13, 316);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(168, 19);
            this.checkBox13.TabIndex = 15;
            this.checkBox13.Text = "Select all the things above?";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(13, 290);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(119, 19);
            this.checkBox12.TabIndex = 14;
            this.checkBox12.Text = "Start with the OS?";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // buttonApplyAdv
            // 
            this.buttonApplyAdv.Location = new System.Drawing.Point(266, 328);
            this.buttonApplyAdv.Name = "buttonApplyAdv";
            this.buttonApplyAdv.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyAdv.TabIndex = 13;
            this.buttonApplyAdv.Text = "Apply";
            this.buttonApplyAdv.UseVisualStyleBackColor = true;
            // 
            // buttonOKAdv
            // 
            this.buttonOKAdv.Location = new System.Drawing.Point(182, 328);
            this.buttonOKAdv.Name = "buttonOKAdv";
            this.buttonOKAdv.Size = new System.Drawing.Size(75, 23);
            this.buttonOKAdv.TabIndex = 12;
            this.buttonOKAdv.Text = "OK";
            this.buttonOKAdv.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(13, 264);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(331, 19);
            this.checkBox11.TabIndex = 10;
            this.checkBox11.Text = "Block self-blocking? (Prevent user from blocking this app)";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(13, 238);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(314, 19);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "Block sleeping/hibernating the system in session time?";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(13, 212);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(316, 19);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Block shutting down/restarting system in session time?";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(13, 186);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(236, 19);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Block the Control Panel in session time?";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(13, 160);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(328, 19);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Block anything trying to stop the process in session time?";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(13, 134);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(264, 19);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Block start/stop/reset button in session time?";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(13, 108);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(202, 19);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Block PowerShell in session time?";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(13, 82);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(244, 19);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Block Command Prompt in session time?";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(13, 56);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(216, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Block Task Manager in session time?";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 30);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(220, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Block system setting in session time?";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(203, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Block app setting in session time?";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            // blocker
            // 
            this.blocker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.blocker_DoWork);
            // 
            // blocktab
            // 
            this.blocktab.Controls.Add(this.m2);
            this.blocktab.Controls.Add(this.m1);
            this.blocktab.Controls.Add(this.label8);
            this.blocktab.Location = new System.Drawing.Point(4, 24);
            this.blocktab.Name = "blocktab";
            this.blocktab.Padding = new System.Windows.Forms.Padding(3);
            this.blocktab.Size = new System.Drawing.Size(354, 364);
            this.blocktab.TabIndex = 4;
            this.blocktab.Text = "Blocker";
            this.blocktab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(354, 165);
            this.label8.TabIndex = 0;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // m1
            // 
            this.m1.AutoSize = true;
            this.m1.Location = new System.Drawing.Point(5, 191);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(347, 19);
            this.m1.TabIndex = 1;
            this.m1.TabStop = true;
            this.m1.Text = "Use the first method: Blocking using registry (recommended)";
            this.m1.UseVisualStyleBackColor = true;
            this.m1.Click += m1_Click;
            // 
            // m2
            // 
            this.m2.AutoSize = true;
            this.m2.Location = new System.Drawing.Point(5, 217);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(276, 19);
            this.m2.TabIndex = 2;
            this.m2.TabStop = true;
            this.m2.Text = "Use the second method: Blocking using task kill";
            this.m2.UseVisualStyleBackColor = true;
            this.m2.Click += m2_Click;
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
            this.tabPageSettingAppBlocking.ResumeLayout(false);
            this.tabPageSettingAppBlocking.PerformLayout();
            this.tabPageSettingWebBlocking.ResumeLayout(false);
            this.tabPageSettingWebBlocking.PerformLayout();
            this.tabPageSettingAdvanced.ResumeLayout(false);
            this.tabPageSettingAdvanced.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.blocktab.ResumeLayout(false);
            this.blocktab.PerformLayout();
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
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonAddApp;
        private System.Windows.Forms.TextBox addAppInput;
        private System.Windows.Forms.Button buttonRemoveApp;
        private System.Windows.Forms.CheckedListBox appListBox;
        private System.Windows.Forms.Button buttonAddWeb;
        private System.Windows.Forms.TextBox textBoxAddWeb;
        private System.Windows.Forms.CheckBox checkBoxBlockInternet;
        private System.Windows.Forms.CheckedListBox webListBox;
        private System.Windows.Forms.Button buttonRemoveWeb;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.Button buttonApplyAdv;
        private System.Windows.Forms.Button buttonOKAdv;
        private System.Windows.Forms.Button buttonApplySetting;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker blocker;
        private System.Windows.Forms.TabPage blocktab;
        private System.Windows.Forms.RadioButton m2;
        private System.Windows.Forms.RadioButton m1;
        private System.Windows.Forms.Label label8;
    }
}
