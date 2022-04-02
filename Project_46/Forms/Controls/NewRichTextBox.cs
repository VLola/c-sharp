using System;
using System.Windows.Forms;

namespace Project_46.Forms.Controls
{
    class NewRichTextBox: RichTextBox
    {
        public NewRichTextBox()
        {
            TextChanged += txb_TextChanged;
        }
        private void txb_TextChanged(object sender, EventArgs e)
        {
            SelectionStart = Text.Length;
            ScrollToCaret();
        }
    }
}
