using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LifeCicles.Helpers
{
    public static class PathValidator
    {
        public static void EnsurePathExists(string path, RichTextBox terminal = null)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                terminal?.AppendText($"[PathValidator] Criado: {path}\n");
            }
            else
            {
                terminal?.AppendText($"[PathValidator] OK: {path}\n");
            }
        }
    }

    public static void ValidateMultiplePaths(string[] paths, RichTextBox terminal = null)
        {
            foreach (var path in paths)
            {
                EnsurePathExists(path, terminal);
            }
        }



    }

}
