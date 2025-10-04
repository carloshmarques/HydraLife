using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace LifeCicles.Helpers
{
    public static class BootSanitizer
    {
        public static void PrepareTerminal(RichTextBox terminal)
        {
            terminal.Clear();
            terminal.ScrollBars = RichTextBoxScrollBars.None;
            terminal.BorderStyle = BorderStyle.None;
            terminal.ForeColor = Color.Lime;
            terminal.BackColor = Color.Black;
            terminal.Font = new Font("Consolas", 10);
        }

        public static void InjectBootMessage(RichTextBox terminal, string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                terminal.AppendText($"{message}\n");
            }
        }

        public static void SimulateTyping(RichTextBox terminal, string[] messages, int delayMs = 100)
        {
            var timer = new Timer { Interval = delayMs };
            int index = 0;

            timer.Tick += (s, e) =>
            {
                if (index < messages.Length)
                {
                    InjectBootMessage(terminal, messages[index]);
                    index++;
                }
                else
                {
                    ((Timer)s).Stop();
                }
            };

            timer.Start();
        }
    }
}

