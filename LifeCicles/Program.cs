using System;
using System.Windows.Forms;

namespace LifeCicles
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // TEMPORARY: Launch Hydra Desktop directly
            Application.Run(new HydraLife.SplashScreen());


        }
    }
}
