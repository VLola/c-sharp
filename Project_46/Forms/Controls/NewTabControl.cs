using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_46.Forms.Controls
{
    public class NewTabControl : TabControl
    {
        public int count { get; set; }
        public NewTabControl()
        {
            count = 0;
            Location = new Point(0, 24);
        }
    }
}
