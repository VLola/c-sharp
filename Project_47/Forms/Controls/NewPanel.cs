using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_47.Forms.Controls
{
    public class NewPanel: Panel
    {
        public NewPanel()
        {
            Location = new Point(0, 22);
            Size = new Size(800, 100);
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            BackColor = Color.Aqua;
        }
    }
}
