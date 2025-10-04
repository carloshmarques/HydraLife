using System.Drawing;
using System.Windows.Forms;

namespace LifeCicles.Modules.Functions
{
    public class ExButton : Button
    {
        public string ToolTipText { get; set; }

        public ExButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.FromArgb(45, 45, 45);
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }
    }
}
