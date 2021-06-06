﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OpenProductivity
{
    public partial class MainWindow : Form
    {
        int clock_degree = 360;
        bool session_state = false;

        int hour, min, sec;
        float session_degree_per_sec;
        int session_hour, session_min, session_sec;
        double clock_degree_now = 360;
        string[] setting;

        public MainWindow()
        {
            InitializeComponent();

            // Setting file layout
            // Line 1: session time in sec
            // Line 2: break time?
            // Line 3: break time in sec

            // Check if the setting file exist, if not raise an warning and create a new setting file

            if (!System.IO.File.Exists(@"setting.txt"))
            {
                System.Windows.Forms.MessageBox.Show("The setting file \"setting.txt\" not found. New file with default setting will be created for you.\nIf this is the first time you run this app, ignore this message.", "Warning!");
                string[] wsetting = {"2700", "1", "900"};
                System.IO.File.WriteAllLines(@"setting.txt", wsetting);
            }

            setting = System.IO.File.ReadAllLines(@"setting.txt");

            session_degree_per_sec = (float)360 / float.Parse(setting[0]);
            this.sessionTimeHR.Value = session_hour = hour = int.Parse(setting[0]) / 3600; // Get the session hour
            this.sessionTimeMin.Value = session_min = min = int.Parse(setting[0]) % 3600 / 60; // Get the session min
            this.sessionTimeSec.Value = session_sec = sec = int.Parse(setting[0]) % 3600 % 60; // Get the session sec

            // Break time setting

            int breaktime = int.Parse(setting[1]);

            if (breaktime == 1)
            {
                this.enableBreakTime.Checked = true; // Set it to checked
                this.breakTimeMin.Value = int.Parse(setting[2]) / 60;
                this.breakTimeSec.Value = int.Parse(setting[2]) % 60;
            }

            else
            {
                this.enableBreakTime.Checked = false; // Set it to unchecked
                this.breakTimeMin.Value = int.Parse(setting[2]) / 60;
                this.breakTimeSec.Value = int.Parse(setting[2]) % 60;
                this.breakTimeMin.Enabled = false;
                this.breakTimeSec.Enabled = false;
            }
        }

        private void save_setting()
        {
            System.IO.File.WriteAllLines(@"setting.txt", setting);
        }

        private void Clock_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.Clear(System.Drawing.Color.White); // Clear the box
            var pen = System.Drawing.Pens.Black;
            e.Graphics.FillPie(System.Drawing.Brushes.LightBlue, 20, 0, 284, 284, 0, clock_degree);// Draw the first circle and fill it
            e.Graphics.FillPie(System.Drawing.Brushes.White, 40, 20, 244, 244, 0, 360); // Draw the second circle (inside circle)

            // Display the time
            if (this.session_hour > 0)
            {
                e.Graphics.DrawString(this.session_hour.ToString("") + ":" + this.session_min.ToString("00") + ":" + this.session_sec.ToString("00"), new System.Drawing.Font("Segoe UI", 48), System.Drawing.Brushes.Black, new System.Drawing.Point(50, 100));
            }
            else
            {
                e.Graphics.DrawString(this.session_min.ToString("00") + ":" + this.session_sec.ToString("00"), new System.Drawing.Font("Segoe UI", 48), System.Drawing.Brushes.Black, new System.Drawing.Point(75, 100));
            }
        }

        private void ButtonRestart_Click(object sender, System.EventArgs e)
        {
            this.session_state = false; // Stop session

            // Reset the clock
            this.session_hour = this.hour;
            this.session_min = this.min;
            this.session_sec = this.sec;
            this.clock_degree_now = 360;

            // Update the clock
            this.clock.Invalidate(new System.Drawing.Rectangle(0, 0, 326, 284));
            this.clock.Update();
        }

        private void ButtonRestart_Click(object sender, System.EventArgs e)
        {
            this.session_state = false; // Stop session

            // Reset the clock
            this.session_hour = this.hour;
            this.session_min = this.min;
            this.session_sec = this.sec;
            this.clock_degree_now = 360;

            // Update the clock
            this.clock.Invalidate(new System.Drawing.Rectangle(0, 0, 326, 284));
            this.clock.Update();
        }

        private async void ButtonClockStartStop_Click(object sender, System.EventArgs e)
        {
            session_state = !session_state;

            if (session_state)
            {
                // Now start the session

                // Call the function to block app, web,...

                this.buttonClockStartStop.Image = global::OpenProductivity.Properties.Resources.pause_button;

                while (true)
                {
                    await Task.Delay(1000); // Delay 1 sec

                    // Update the clock
                    this.session_sec--;
                    if (this.session_sec < 0)
                    {
                        this.session_min--;
                        this.session_sec = 59;
                        
                        if (this.session_min < 0)
                        {
                            this.session_hour--;
                            this.session_min = 59;
                            if (this.session_hour < 0)
                            {
                                this.session_hour = this.hour;
                                this.session_min = this.min;
                                this.session_sec = this.sec;
                                this.clock_degree_now = 360;
                                break; // Break if timeout
                            }
                        }
                    }

                    // Calculate the clock degree
                    this.clock_degree_now -= this.session_degree_per_sec; // Decrease the clock degree
                    this.clock_degree = Convert.ToInt32(Math.Round(this.clock_degree_now));

                    // Update the clock
                    this.clock.Invalidate(new System.Drawing.Rectangle(0, 0, 326, 284));
                    this.clock.Update();

                    if (!session_state)
                    {
                        // Turn off the blocker

                        // End session
                        break;
                    }
                }

                this.buttonClockStartStop.Image = global::OpenProductivity.Properties.Resources.play_button;
            }
        }

        private void buttonSettingOk1_Click(object sender, System.EventArgs e)
        {
            this.setting[0] = (this.sessionTimeHR.Value * 3600 + this.sessionTimeMin.Value * 60 + this.sessionTimeSec.Value).ToString();
            
            if (enableBreakTime.Checked)
            {
                this.setting[1] = "1";
            }

            else
            {
                this.setting[1] = "0";
            }

            this.setting[2] = (this.breakTimeMin.Value * 60 + this.breakTimeSec.Value).ToString();

            save_setting(); // Save the setting

            session_hour = hour = int.Parse(setting[0]) / 3600; // Get the session hour
            session_min = min = int.Parse(setting[0]) % 3600 / 60; // Get the session min
            session_sec = sec = int.Parse(setting[0]) % 3600 % 60; // Get the session sec

            // Update the clock
            this.clock.Invalidate(new System.Drawing.Rectangle(0, 0, 326, 284));
            this.clock.Update();
        }

        private void buttonApplySetting_Click(object sender, System.EventArgs e)
        {
            this.setting[0] = (this.sessionTimeHR.Value * 3600 + this.sessionTimeMin.Value * 60 + this.sessionTimeSec.Value).ToString();
            
            if (enableBreakTime.Checked)
            {
                this.setting[1] = "1";
            }

            else
            {
                this.setting[1] = "0";
            }

            this.setting[2] = (this.breakTimeMin.Value * 60 + this.breakTimeSec.Value).ToString();

            session_hour = hour = int.Parse(setting[0]) / 3600; // Get the session hour
            session_min = min = int.Parse(setting[0]) % 3600 / 60; // Get the session min
            session_sec = sec = int.Parse(setting[0]) % 3600 % 60; // Get the session sec

            // Update the clock
            this.clock.Invalidate(new System.Drawing.Rectangle(0, 0, 326, 284));
            this.clock.Update();
        }

        private void enableBreakTime_Click(object sender, System.EventArgs e)
        {
            if (this.enableBreakTime.Checked)
            {
                this.breakTimeMin.Enabled = true;
                this.breakTimeSec.Enabled = true;
                this.breakTimeMin.Value = int.Parse(setting[2]) / 60;
                this.breakTimeSec.Value = int.Parse(setting[2]) % 60;
            }

            else
            {
                this.breakTimeMin.Enabled = false;
                this.breakTimeSec.Enabled = false;
            }
        }
    }
}
