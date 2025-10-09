using LifeCicles.Modules;
using LifeCicles.Modules.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LifeCicles.Modules
{
    public static class HydraThemeManager
    {
        public static void AdaptVisual(Form targetForm, string mood)
        {
            switch (mood)
            {
                case "Sereno":
                    targetForm.BackColor = Color.LightBlue;
                    break;
                case "Eufórico":
                    targetForm.BackColor = Color.OrangeRed;
                    break;
                case "Melancólico":
                    targetForm.BackColor = Color.Gray;
                    break;
                case "Ritualístico":
                    targetForm.BackColor = Color.Purple;
                    break;
                default:
                    targetForm.BackColor = Color.Black;
                    break;
            }

            Console.WriteLine($"🎨 Visual adaptado para o mood: {mood}");
        }

    }
}
