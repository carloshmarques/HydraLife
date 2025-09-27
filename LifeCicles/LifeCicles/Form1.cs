using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydraLife
{

    public partial class Form1 : Form
    {
        // Set the Date time
        private DateTime appStartTime;

        // Timer for periodic actions
        System.Timers.Timer timer;
        int m, S;

        // Uptime  message settings
        private bool uptimeStopped = false;
        private int uptimeSeconds = 0;


        // Spinner animation variables
        private string[] spinnerFrames = { "|", "/", "-", "\\" };
        private int spinnerIndex = 0;
        private Timer spinnerTimer;

        private int fileCheckIndex = 0;
        private string[] bootFiles = { "boot.sys", "kernel.img", "drivers.dll", "config.ini" };

        private bool waitingForOk = false;



        // Constructor
        public Form1()
        {
            InitializeComponent();

        }
        // Background color change variables
        private Color[] bgColors = new Color[]
        {
            Color.FromArgb(0, 120, 215), // Windows blue
            Color.FromArgb(0, 153, 188), // Cyan-ish
            Color.FromArgb(51, 51, 51),  // Dark gray
            Color.Black
        };

        // Index to track current background color
        private int bgIndex = 0;
        private Timer bgTimer;

        // Form load event
        private void Form1_Load(object sender, EventArgs e)
        {

           // BgTimer_Tick(null, null); // Force one background change


            // Hide the control buttons initially  on load
            btnCloseApp.Visible = false;
            btnEndSession.Visible = false;
            btnrestart.Visible = false;

            // set the app date time
            appStartTime = DateTime.Now;

            // Set up the background color timer
            bgTimer = new Timer();
            bgTimer.Interval = 5000; // Change every 5 seconds
            bgTimer.Tick += BgTimer_Tick;
            bgTimer.Start();

            // Set up the spinner timer
            spinnerTimer = new Timer();
            spinnerTimer.Interval = 500; // Speed of animation (500ms)
            spinnerTimer.Tick += SpinnerTimer_Tick;
            spinnerTimer.Start();
            // Initialize and start the timer
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            // Make the form full screen
            this.Size = Screen.PrimaryScreen.Bounds.Size;
            this.BringToFront();

            // Simulate settings save (replace with actual logic if needed)
            // Properties.Settings.Default.Console.Clear(); // if you have a Console setting
            LifeCicles.Properties.Settings.Default.Save();

            // Show the button after 10 seconds
            Task.Delay(10000).ContinueWith(_ =>
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    btnCloseApp.Visible = true;
                    btnEndSession.Visible = true;
                    btnrestart.Visible = true;

                    // Optional: stop background animation and lock final state
                    //bgTimer.Stop();
                    this.BackColor = Color.Black;
                    bootMessagesRtb.BackColor = Color.Black;
                    bootMessagesRtb.ForeColor = Color.LimeGreen;

                    // Recalculate spinner frame here
                    string spinner = spinnerFrames[spinnerIndex];
                    spinnerIndex = (spinnerIndex + 1) % spinnerFrames.Length;

                    lblTimer.Text += $"\r\nLoad completed. Showing login screen... {spinner}";
                }));
            });



        }

        // Spinner animation update

        private void SpinnerTimer_Tick(object sender, EventArgs e)
        {
            // Code to match bootMessagesRtb background color with form background color
            bootMessagesRtb.BackColor = this.BackColor;
            // Get the current spinner frame
            string spinner = spinnerFrames[spinnerIndex];
            // Move to the next frame
            spinnerIndex = (spinnerIndex + 1) % spinnerFrames.Length;

            string message = $"Checking files and directories... {spinner}";
            bootMessagesRtb.Text = message;           

            // Emulate boot file system check unix sys
            string[] files = { "boot.sys", "kernel.img", "drivers.dll", "config.ini" };
            // concatinate ' files '
            // lblTimer.Text += $"Checking {files[spinnerIndex]}... {spinner}\r\n";

        }

        // Background color change update
        private void BgTimer_Tick(object sender, EventArgs e)
        {
            this.BackColor = bgColors[bgIndex];
            bgIndex = (bgIndex + 1) % bgColors.Length;
        }

        // Timer elapsed event handler
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (!uptimeStopped)
                {
                    uptimeSeconds++;

                    TimeSpan elapsed = DateTime.Now - appStartTime;
                    string startTimeFormatted = appStartTime.ToString("yyyy-MM-dd HH:mm:ss");
                    string uptimeFormatted = $"{elapsed.Minutes:D2}:{elapsed.Seconds:D2}";

                    lblTimer.Text = $"Application started at: {startTimeFormatted}\r\n";
                    label2.Text = $"Uptime: {uptimeFormatted}\r\n";

                    if (uptimeSeconds >= 7)
                    {
                        uptimeStopped = true;
                        label2.Text = $"Counting... {spinnerFrames[spinnerIndex]}";
                    }
                }
                else
                {
                    string spinner = spinnerFrames[spinnerIndex];
                    spinnerIndex = (spinnerIndex + 1) % spinnerFrames.Length;
                    label2.Text = $"Counting... {spinner}";
                }

                // Show one boot file per tick
                if (fileCheckIndex < bootFiles.Length)
                {
                    string spinner = spinnerFrames[spinnerIndex];
                    spinnerIndex = (spinnerIndex + 1) % spinnerFrames.Length;

                    if (!waitingForOk)
                    {
                        lblTimer.Text += $"Checking {bootFiles[fileCheckIndex]}... {spinner}\r\n";
                        waitingForOk = true; // Wait for next tick to show [OK]
                    }
                    else
                    {
                        
                        //lblTimer.Text += $"[OK]\r\n";
                        /*
                        Random rand = new Random();
                        bool success = rand.Next(0, 10) > 1; // 90% chance of success  
                        */
                        // after write success "Sucees" instead of freazing in [Ok]!
                       // lblTimer.Text += $"{success}\r\n";   // may be a string message = "Success!"
                        fileCheckIndex++;
                        waitingForOk = false;
                    }
                }

            }));
        }

        private void bootMessagesRtb_TextChanged(object sender, EventArgs e)
        {

        }



        // Button click event to close the application
        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            // Stop the spinner so it doesn't overwrite the shutdown message
            //spinnerTimer.Stop();
            // Get the current spinner frame
            string spinner = spinnerFrames[spinnerIndex];         
            spinnerIndex = (spinnerIndex + 1) % spinnerFrames.Length;
            // Show shutdown message with spinner
            // spinnerTimer.Start();
            lblTimer.Text = $"Shutting down... {spinner}";
            

            // Let spinnerTimer keep running for animation
            Task.Delay(10000).ContinueWith(_ =>
            {
                this.Invoke((MethodInvoker)(() =>
                {
                   // spinnerTimer.Stop(); // Stop right before killing the app
                    Process.GetCurrentProcess().Kill();
                }));
            });

        }
    }

    // Custom RichTextBox with double buffering to reduce flicker
    public class SmoothRichTextBox : RichTextBox
    {
        public SmoothRichTextBox()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
    }
}
