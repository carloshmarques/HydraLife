using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HydraLife
{
            // background colr transition stop working again -- to be fixed again
        public partial class Form1 : Form
        {

        public static string HydraDataPath =>
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "HydraLife"
                );

        private int blendStepsValue = 60; // field
       

        public int BlendSteps { get; set; } // property

        private string[] appDirectories = {
        "Users",
        "Users\\Admin",
        "Files",
        "Files\\Docs",
        "Files\\Tunes",
        "Files\\Photos",
        "Files\\Downloads",
        "Files\\Films"
        };

        private int dirIndex = 0;
        private Timer directoryTimer;

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

        private string[] spinnerShutDownFrames = { "|", "/", "-", "\\" };
        private int spinnerShutDownFramesIndex = 0;
        private Timer spinnerShutDownFramesTimer;

        private bool waitingForOk = false;

        // smooth background color transitiom
        private Timer colorBlendTimer;
        private int blendStep;
        private int blendSteps;
        private Color startColor;
        private Color endColor;







        // Constructor
        public Form1()
        {
            InitializeComponent();

            bootMessagesRtb.ReadOnly = true;
            bootMessagesRtb.Enabled = true; // ✅ Keep it enabled to preserve BackColor
            bootMessagesRtb.TabStop = false;
            bootMessagesRtb.Cursor = Cursors.Default;
            bootMessagesRtb.BackColor = this.BackColor; // Match form background
            bootMessagesRtb.ForeColor = Color.LimeGreen; // Terminal-style text
            bootMessagesRtb.ScrollBars = RichTextBoxScrollBars.None;
            bootMessagesRtb.SelectionStart = bootMessagesRtb.Text.Length;
            bootMessagesRtb.ScrollToCaret(); // Optional: keeps newest line visible

            // Iniatialize progress bar
            progressBar1.Visible = false;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = appDirectories.Length;
            progressBar1.Value = 0;




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

        private bool showCursor = true;
        private Timer cursorBlinkTimer;

        // Form load event
        private void Form1_Load(object sender, EventArgs e)
        {
            cursorBlinkTimer = new Timer();
            cursorBlinkTimer.Interval = 500; // blink every half second
            cursorBlinkTimer.Tick += CursorBlinkTimer_Tick;
            cursorBlinkTimer.Start();


            // Iniatialize progress bar
            progressBar1.Visible = false;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = appDirectories.Length;
            progressBar1.Value = 0;





            // Hide the control buttons initially  on load
            btnCloseApp.Visible = false;
            btnEndSession.Visible = false;
            btnrestart.Visible = false;

            // set the app date time
            appStartTime = DateTime.Now;

           
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
            Task.Delay(5000).ContinueWith(_ =>
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    btnCloseApp.Visible = true;
                    btnEndSession.Visible = true;
                    btnrestart.Visible = true;

                    // Optional: stop background animation and lock final state
                    bgTimer.Stop();
                    this.BackColor = Color.Black;
                    bootMessagesRtb.BackColor = Color.Black;
                    bootMessagesRtb.ForeColor = Color.LimeGreen;

                    // Recalculate spinner frame here
                    string spinner = spinnerFrames[spinnerIndex];
                    spinnerIndex = (spinnerIndex + 1) % spinnerFrames.Length;

                    lblTimer.Text += $"\r\nLoad completed. Showing login screen... ";
                    // ✅ Start directory creation sequence here
                    directoryTimer = new Timer();
                    directoryTimer.Interval = 1000; // 1 second per directory
                    directoryTimer.Tick += DirectoryTimer_Tick;
                    directoryTimer.Start();
                }));
            });



        }
        private void CursorBlinkTimer_Tick(object sender, EventArgs e)
        {
            showCursor = !showCursor;
            string cursor = showCursor ? "|" : " ";
            lblCursor.Text = cursor; // Use a Label at bottom of RichTextBox
        }
        private void StartDirectoryCheck()
        {
            directoryTimer = new Timer();
            directoryTimer.Interval = 500; // adjust speed if needed
            directoryTimer.Tick += DirectoryTimer_Tick;
            directoryTimer.Start();
        }

        private void DirectoryTimer_Tick(object sender, EventArgs e)
        {
            if (dirIndex < appDirectories.Length)
            {
                progressBar1.Value = dirIndex + 1;

                string fullPath = Path.Combine(HydraDataPath, appDirectories[dirIndex]);

                try
                {
                    if (!Directory.Exists(fullPath))
                    {
                        Directory.CreateDirectory(fullPath);
                        bootMessagesRtb.AppendText($"[{DateTime.Now:HH:mm:ss}] [OK] Created directory: {fullPath}\r\n");
                        bootMessagesRtb.AppendText($"[OK] Created directory with success: Proceeding... {fullPath}\r\n");
                        
                        TriggerBackgroundFade(Color.FromArgb(0, 30, 0)); // 🟢 green for success
                    }
                    else
                    {
                        bool hasFiles = Directory.GetFiles(fullPath).Length > 0;
                        bool hasSubDirs = Directory.GetDirectories(fullPath).Length > 0;

                        if (hasFiles || hasSubDirs)
                        {
                            bootMessagesRtb.AppendText($"[SKIP] Directory already exists and is not empty. Skipping... {fullPath}\r\n");
                            TriggerBackgroundFade(Color.FromArgb(30, 30, 0)); // 🟠 amber for skip
                            

                        }
                        else
                        {
                            bootMessagesRtb.AppendText($"[OK] Directory exists but was empty. Continuing... {fullPath}\r\n");
                            TriggerBackgroundFade(Color.FromArgb(0, 30, 30)); // 🔵 teal for empty but valid
                        }
                    }

                    progressBar1.Value = dirIndex + 1;
                    dirIndex++;
                }
                catch (Exception ex)
                {
                    bootMessagesRtb.AppendText($"[ERROR] Failed to process {fullPath}: {ex.Message}\r\n");
                    TriggerBackgroundFade(Color.DarkRed); // 🔴 red for error
                    dirIndex++;
                }
            }
            else
            {
                bootMessagesRtb.AppendText("All directories initialized. System ready.\r\n");
                TriggerBackgroundFade(Color.FromArgb(20, 20, 20)); // neutral tone
                directoryTimer.Stop();
            }

            bootMessagesRtb.SelectionStart = bootMessagesRtb.Text.Length;
            //bootMessagesRtb.ScrollToCaret();
        }




        // Spinner animation update

        private void SpinnerTimer_Tick(object sender, EventArgs e)
        {
            if (fileCheckIndex < bootFiles.Length)               
            {
                progressBar1.Value = dirIndex + 1;
                string file = bootFiles[fileCheckIndex];

                if (!waitingForOk)
                {
                    bootMessagesRtb.AppendText($"Checking {file}...\r\n");
                    TriggerBackgroundFade(Color.FromArgb(10, 10, 30)); // bluish tone for scanning
                    waitingForOk = true;
                }
                else
                {
                    // Simulate error condition for specific files
                    if (file.Contains("corrupt") || file == "boot.sys")
                    {
                        bootMessagesRtb.AppendText($"[ERROR] Failed to load {file}...\r\n");
                        TriggerBackgroundFade(Color.DarkRed); // 🔴 dramatic red for failure
                    }
                    else
                    {
                        bootMessagesRtb.AppendText($"[OK] {file} loaded successfully...\r\n");
                        TriggerBackgroundFade(Color.FromArgb(0, 30, 0)); // 🟢 dark green for success
                   
                    }

                    fileCheckIndex++;
                    waitingForOk = false;
                }

                bootMessagesRtb.SelectionStart = bootMessagesRtb.Text.Length;
                bootMessagesRtb.ScrollToCaret();
            }
            else
            {
                bootMessagesRtb.AppendText("System ready. Proceding to check app files and directories...\r\n");
                TriggerBackgroundFade(Color.FromArgb(20, 20, 20)); // neutral tone
                dirIndex = 0;
                StartDirectoryCheck(); // ← this must be called

                spinnerTimer.Stop();
            }
        }



        private void TriggerBackgroundFade(Color targetColor)
        {
            startColor = this.BackColor;
            endColor = targetColor;
            blendStep = 0;
            blendSteps = 60;

            if (colorBlendTimer != null)
            {
                colorBlendTimer.Stop();
                colorBlendTimer.Dispose();
            }

            colorBlendTimer = new Timer();
            colorBlendTimer.Interval = 100;
            colorBlendTimer.Tick += ColorBlendTimer_Tick;
            colorBlendTimer.Start();
        }

        private void ColorBlendTimer_Tick(object sender, EventArgs e)
        {
            if (blendStep <= blendSteps)
            {
                int r = startColor.R + (endColor.R - startColor.R) * blendStep / blendSteps;
                int g = startColor.G + (endColor.G - startColor.G) * blendStep / blendSteps;
                int b = startColor.B + (endColor.B - startColor.B) * blendStep / blendSteps;

                // Clamp values to valid range [0, 255]
                r = Math.Max(0, Math.Min(255, r));
                g = Math.Max(0, Math.Min(255, g));
                b = Math.Max(0, Math.Min(255, b));

                Color blendedColor = Color.FromArgb(r, g, b);
                this.BackColor = blendedColor;
                bootMessagesRtb.BackColor = blendedColor;

                blendStep++;
            }
            else
            {
                colorBlendTimer.Stop();
                colorBlendTimer.Dispose();
            }
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
                        lblTimer.Text += $"Checking {bootFiles[fileCheckIndex]}... \r\n";
                        waitingForOk = true; // Wait for next tick to show [OK]
                    }
                    else
                    {

                        lblTimer.Text += $"[OK]\r\n";
                       
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

            // Stop background color changes
            bgTimer?.Stop();

            // Stop spinner updates
            spinnerTimer?.Stop();

            // Lock final background state
            this.BackColor = Color.Black;
            bootMessagesRtb.BackColor = Color.Black;
            bootMessagesRtb.ForeColor = Color.LimeGreen;

            // Show shutdown message
            lblTimer.Text = $"Shutting down... ";


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
}
