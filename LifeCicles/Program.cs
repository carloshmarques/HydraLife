using LifeCicles.Modules;
using System;
using System.Windows.Forms;

namespace LifeCicles
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.

      
        public class HydraLauncher : Form
        {

     
            public HydraLauncher()
            {
                // Inicialização cerimonial da janela
                Text = "🌀 HydraLauncher";
                Width = 800;
                Height = 600;

            }
            [STAThread]

            static void Main()
            {
              
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Invocação cerimonial da Hydra
                Application.Run(new HydraLauncher());
            }
        }          
        
    }
}
