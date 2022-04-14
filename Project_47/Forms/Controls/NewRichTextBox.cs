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
        NewToolStripContainer newToolStripContainer;
        public NewRichTextBox(NewToolStripContainer newToolStripContainer)
        {
            this.newToolStripContainer = newToolStripContainer;
            Location = new Point(3, 3);
            Size = new Size(1030, 359);
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            BorderStyle = BorderStyle.Fixed3D; 
            Multiline = true;
            BackColor = Color.White;

            MouseWheel += NewToolStripContainer_MouseWheel;
        }

        private void NewToolStripContainer_MouseWheel(object sender, MouseEventArgs e)
        {
            if(ModifierKeys == Keys.Control) newToolStripContainer.Padding = new Padding(newToolStripContainer.Padding.Left - e.Delta / 10, 0, newToolStripContainer.Padding.Left - e.Delta / 10, 0);
        }
    }
}
