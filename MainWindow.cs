using System;
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

        public MainWindow()
        {
            InitializeComponent();

            // Setting file layout
            // Line 1: session time in sec
            // Line 2: break time?
            // Line 3: break time in sec

            string[] setting = System.IO.File.ReadAllLines(@"setting.txt");

            session_degree_per_sec = (float)360 / float.Parse(setting[0]);
            session_hour = hour = int.Parse(setting[0]) / 3600; // Get the session hour
            session_min = min = int.Parse(setting[0]) % 3600 / 60; // Get the session min
            session_sec = sec = int.Parse(setting[0]) % 3600 % 60; // Get the session sec
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

        //public async void delay_mlsec(int time_to_wait) { 
        //    await Task.Delay(time_to_wait);
        //}

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
    }
}
