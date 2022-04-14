using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_47.Forms.Controls
{
    public class NewToolStripContainer: ToolStripContainer
    {
        public NewRichTextBox newRichTextBox;
        public NewToolStripContainer()
        {
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContentPanel.Controls.Add(newRichTextBox = new NewRichTextBox(this));
            ContentPanel.Size = new System.Drawing.Size(1036, 390);
            Location = new System.Drawing.Point(12, 173);
            Size = new System.Drawing.Size(1036, 415);
            Padding = new Padding(120,0,120,0);
        }
    }
}
