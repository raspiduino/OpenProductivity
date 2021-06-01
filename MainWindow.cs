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

        int hour, min, sec, session_degree_per_sec;
        int session_hour, session_min, session_sec;

        // Read setting
        string[] setting = System.IO.File.ReadAllLines(@"setting.txt");

        public void get_setting()
        {
            // Setting file layout
            // Line 1: session time in sec
            // Line 2: break time in sec

            session_degree_per_sec = 360 / int.Parse(setting[0]);
            session_hour = hour = int.Parse(setting[0]) / 3600; // Get the session hour
            session_min = min = int.Parse(setting[0]) % 3600 / 60; // Get the session min
            session_sec = sec = int.Parse(setting[0]) % 3600 % 60; // Get the session sec
        }

        public MainWindow()
        {
            InitializeComponent();
            get_setting();
        }

        private void Clock_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.Clear(System.Drawing.Color.White); // Clear the box
            var pen = System.Drawing.Pens.Black;
            e.Graphics.FillPie(System.Drawing.Brushes.LightBlue, 20, 0, 284, 284, 0, clock_degree);// Draw the first circle and fill it
            e.Graphics.FillPie(System.Drawing.Brushes.White, 40, 20, 244, 244, 0, 360); // Draw the second circle (inside circle)

            // Display the time
            if (session_hour > 0)
            {
                e.Graphics.DrawString(session_hour.ToString("") + ":" + session_min.ToString("00") + ":" + session_sec.ToString("00"), new System.Drawing.Font("Segoe UI", 48), System.Drawing.Brushes.Black, new System.Drawing.Point(50, 100));
            }
            else
            {
                e.Graphics.DrawString(session_min.ToString("00") + ":" + session_sec.ToString("00"), new System.Drawing.Font("Segoe UI", 48), System.Drawing.Brushes.Black, new System.Drawing.Point(75, 100));
            }
        }

        public async void delay_mlsec(int time_to_wait) { 
            await Task.Delay(time_to_wait);
        }

        private void ButtonClockStartStop_Click(object sender, System.EventArgs e)
        {
            session_state = !session_state;

            if (session_state)
            {
                // Now start the session

                // Call the function to block app, web,...

                while (true)
                {
                    delay_mlsec(1000); // Delay 1 sec

                    // Update the clock
                    session_sec--;
                    if (session_sec < 0)
                    {
                        session_min--;
                        session_sec = 59;
                        
                        if (session_min < 0)
                        {
                            session_hour--;
                            if (session_hour < 0)
                            {
                                session_hour = hour;
                                session_min = min;
                                session_sec = sec;
                                break; // Break if timeout
                            }
                        }
                    }

                    clock_degree -= session_degree_per_sec; // Decrease the clock degree
                    this.clock.Invalidate(); // Update the clock

                    if (!session_state)
                    {
                        // Turn off the blocker

                        // End session
                        break;
                    }
                }
            }
        }
    }
}
