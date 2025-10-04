using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeCicles.Helpers
{
    internal class RescueSplashFunction
    {
        public static void NormalizeSplashLayout(Form splashForm)
        {
            splashForm.Opacity = 1;
            splashForm.BackColor = Color.Black;
            splashForm.FormBorderStyle = FormBorderStyle.None;
            splashForm.StartPosition = FormStartPosition.CenterScreen;
        }

        public static void CleanVisualArtifacts(RichTextBox terminal)
        {
            terminal.ScrollBars = RichTextBoxScrollBars.None;
            terminal.BorderStyle = BorderStyle.None;
            terminal.ForeColor = Color.Lime;
            terminal.Font = new Font("Consolas", 10);
        }

    }
}
