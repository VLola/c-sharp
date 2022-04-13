using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_47.Forms.Controls
{
    public class PanelMain: Panel
    {
        public GroupBoxClipboard boxClipboard = new GroupBoxClipboard();
        public GroupBoxFont boxFont = new GroupBoxFont();
        public GroupBoxParagraph boxParagraph = new GroupBoxParagraph();
        public GroupBoxInsert boxInsert = new GroupBoxInsert();
        public GroupBoxEditing boxEditing = new GroupBoxEditing();
        public PanelMain()
        {
            Location = new Point(0, 18);
            Size = new Size(1060, 105);
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            BackColor = Color.White;

            Controls.Add(boxClipboard);
            Controls.Add(boxFont);
            Controls.Add(boxParagraph);
            Controls.Add(boxInsert);
            Controls.Add(boxEditing);
        }
    }
}
