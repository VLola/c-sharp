using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_47.Forms.Controls
{
    public class NewRichTextBox: RichTextBox
    {
        public NewRichTextBox()
        {
            Location = new Point(50, 150);
            Size = new Size(700, 300);
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            BorderStyle = BorderStyle.None; 
            Multiline = true;
        }
    }
}
