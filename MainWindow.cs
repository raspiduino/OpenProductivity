using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security;
using System.Security.AccessControl;


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

        string[] applist, weblist;

        RegistryKey block_key;

        public MainWindow()
        {
            InitializeComponent();

            // Setting file layout
            // Line 1: session time in sec
            // Line 2: break time?
            // Line 3: break time in sec
            // Line 4: apps to block
            // Line 4: block all internet?
            // Line 5: webs to block
            // Line 6: block method
            // Line 7: advanced setting

            // Check if the setting file exist, if not raise an warning and create a new setting file

            if (!System.IO.File.Exists(@"setting.txt"))
            {
                System.Windows.Forms.MessageBox.Show("The setting file \"setting.txt\" not found. New file with default setting will be created for you.\nIf this is the first time you run this app, please run this app as admin once this time.", "Warning!");

                string[] wsetting = { "2700", "1", "900", "", "0", "1", "" };

                // First run, so ask for block method
                Form blockmethod = new Form();
                blockmethod.Width = 371;
                blockmethod.Height = 424;
                blockmethod.Text = "Block method selecting";
                Label textLabel = new Label() { AutoSize = true, Left = 1, Top = 10, Size = new System.Drawing.Size(354, 165), Text = "This tab let you choose your block method.\nThere are two block method available:\n    - First method: block using registry (might\n      require to run as admin)\n    - Second method: block using task kill (use more CPU!)\n\nYou can choose to use first method if you want to have more CPU\nfor you work (recommended & default method)\nBut if there is some reason the first method doesn't work well, you\nshould switch to the second one." };
                RadioButton r1 = new RadioButton() { AutoSize = true, Left = 5, Top = 191, Size = new System.Drawing.Size(347, 19), Text = "Use the first method: Blocking using registry (recommended)", Checked = true };
                RadioButton r2 = new RadioButton() { AutoSize = true, Left = 5, Top = 217, Size = new System.Drawing.Size(276, 19), Text = "Use the second method: Blocking using task kill" };
                Button confirm = new Button() { Left = 184, Top = 320, Text = "OK" };
                confirm.Click += (sender, e) => {
                    if (r1.Checked)
                    {
                        wsetting[5] = "1";
                        RegistryKey r = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\explorer", true);

                        RegistrySecurity rs = new RegistrySecurity();
                        rs.AddAccessRule(new RegistryAccessRule(Environment.UserDomainName + "\\" + Environment.UserName, RegistryRights.ReadKey | RegistryRights.WriteKey | RegistryRights.Delete, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow));

                        r.SetAccessControl(rs);
                        r.SetValue("DisallowRun", 1);
                    }

                    else wsetting[5] = "2";
                    blockmethod.Close(); // Close it
                };

                blockmethod.Controls.Add(textLabel);
                blockmethod.Controls.Add(r1);
                blockmethod.Controls.Add(r2);
                blockmethod.Controls.Add(confirm);
                blockmethod.ShowDialog();

                System.IO.File.WriteAllLines(@"setting.txt", wsetting);
            }

            setting = System.IO.File.ReadAllLines(@"setting.txt");

            session_degree_per_sec = (float)360 / float.Parse(setting[0]);
            this.sessionTimeHR.Value = session_hour = hour = int.Parse(setting[0]) / 3600; // Get the session hour
            this.sessionTimeMin.Value = session_min = min = int.Parse(setting[0]) % 3600 / 60; // Get the session min
            this.sessionTimeSec.Value = session_sec = sec = int.Parse(setting[0]) % 3600 % 60; // Get the session sec

            this.applist = setting[3].Split(',');
            this.weblist = setting[5].Split(',');

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
                this.breakTimeMin.Enabled = this.breakTimeSec.Enabled = false;
            }

            // Update the app block list
            foreach (string appname in applist)
            {
                this.appListBox.Items.Add(appname);
            }

            // Update the web block list
            foreach (string webname in weblist)
            {
                this.webListBox.Items.Add(webname);
            }

            // Update blocking method setting
            if (this.setting[5] == "1")
            {
                this.m1.Checked = true;

                // Registry block method
                this.block_key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\explorer\DisallowRun", true);
            }
            else this.m2.Checked = true;
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

        private async void ButtonClockStartStop_Click(object sender, System.EventArgs e)
        {
            session_state = !session_state;

            if (session_state)
            {
                // Now start the session

                // Call the function to block app, web,...
                // Turn on the blocker
                this.blocker.RunWorkerAsync();

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
                        // End session

                        // If in method 1, remove keys
                        if (this.setting[5] == "1")
                        {
                            for (int i = 0; i < applist.Length; i++)
                            {
                                this.block_key.DeleteValue(i.ToString());
                            }
                        }

                        break;
                    }
                }

                this.buttonClockStartStop.Image = global::OpenProductivity.Properties.Resources.play_button;
            }
        }

        private void m1_Click(object sender, System.EventArgs e)
        {
            if (this.m1.Checked)
            {
                this.m2.Checked = false;
                setting[5] = "1";
                save_setting(); // Save it
            }
        }

        private void m2_Click(object sender, System.EventArgs e)
        {
            if (this.m2.Checked)
            {
                this.m1.Checked = false;
                setting[5] = "2";
                save_setting();
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
                this.breakTimeMin.Enabled = this.breakTimeSec.Enabled = true;
            }

            else
            {
                this.breakTimeMin.Enabled = this.breakTimeSec.Enabled = false;
            }
        }

        private void blocker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (this.setting[5] == "1")
            {
                // Method 1
                
                var tmplist = this.applist.ToList();
                foreach (string appname in this.applist)
                {
                    this.block_key.SetValue((tmplist.IndexOf(appname)+1).ToString(), appname);
                }
            }

            else
            {
                // Method 2

                do
                {
                    // In session -> Block app and web

                    // Block app
                    foreach (string appname in applist)
                    {
                        foreach (var process in System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(appname)))
                        {
                            process.Kill(); // Kill the process
                        }
                    }
                } while (this.session_state);
            }
        }

        private void checkBoxBlockInternet_Click(object sender, System.EventArgs e)
        {
            if (this.checkBoxBlockInternet.Checked)
            {
                this.setting[4] = "1";
                save_setting();
            }

            else
            {
                this.setting[4] = "";
                save_setting();
            }
        }

        private void buttonAddApp_Click(object sender, System.EventArgs e)
        {
            string appname = this.addAppInput.Text;

            if (appname == "")
            {
                // Empty input, probably a mistake
                System.Windows.Forms.MessageBox.Show("Cannot add empty name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                this.appListBox.Items.Add(appname); // Add app to app list
                this.applist = this.applist.Append(appname).ToArray(); // Add app to setting

                this.addAppInput.Clear(); // Clear

                this.setting[3] = System.String.Join(",", applist);
                save_setting(); // Save setting
            }
        }

        private void buttonAddWeb_Click(object sender, System.EventArgs e)
        {
            string webname = this.textBoxAddWeb.Text;

            if (webname == "")
            {
                // Empty input, probably a mistake
                System.Windows.Forms.MessageBox.Show("Cannot add empty name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                this.webListBox.Items.Add(webname); // Add web to web list
                this.weblist = this.weblist.Append(webname).ToArray(); // Add web to setting

                this.textBoxAddWeb.Clear(); // Clear

                this.setting[5] = System.String.Join(",", weblist);
                save_setting(); // Save setting
            }   
        }

        private void buttonRemoveWeb_Click(object sender, System.EventArgs e)
        {
            for (int counter = 0; counter <= this.weblist.Length; counter++)
            {
                if (counter < this.weblist.Length && this.webListBox.GetItemChecked(counter))
                {
                    this.weblist = this.weblist.Where(i => i != this.webListBox.Items[counter].ToString()).ToArray(); // Remove from setting
                    this.webListBox.Items.RemoveAt(counter); // Remove from list
                    counter--; // Move backward one element (we just deleted it!)
                }
            }

            this.setting[5] = System.String.Join(",", weblist);
            save_setting(); // Save setting
        }

        private void buttonRemoveApp_Click(object sender, System.EventArgs e)
        {
            for (int counter = 0; counter <= this.applist.Length; counter++)
            {
                if (counter < this.applist.Length && this.appListBox.GetItemChecked(counter))
                {
                    this.applist = this.applist.Where(i => i != this.appListBox.Items[counter].ToString()).ToArray(); // Remove from setting
                    this.appListBox.Items.RemoveAt(counter); // Remove from list
                    counter--; // Move backward one element (we just deleted it!)
                }
            }

            this.setting[3] = System.String.Join(",", applist);
            save_setting(); // Save setting
        }
    }
}
