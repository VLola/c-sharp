using Project_47.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_47.Forms.Controls
{
    public class NewToolStripMenuItem: ToolStripMenuItem
    {
        public NewToolStripMenuItem(string text, Image image)
        {
            BackColor = Color.White;
            Text = text;
            Image = image;
        }
        public NewToolStripMenuItem(Image image)
        {
            BackColor = Color.White;
            Image = image;
            AutoSize = false;
            ImageScaling = ToolStripItemImageScaling.None;
            Size = new Size(23, 22);
        }
    }
}
