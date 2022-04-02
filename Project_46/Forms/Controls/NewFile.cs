using System.Drawing;
using System.Windows.Forms;

namespace Project_46.Forms.Controls
{
    public class NewFile : TabPage
    {
        public NewFile(Form1 form)
        {
            form.newTabControl.count++;
            Text = "new" + form.newTabControl.count;
            Size = form.ClientSize;
            Controls.Add(new NewRichTextBox() {
                Multiline = true,
                WordWrap = false,
                Width = Width - 10,
                Height = Height - 55,
            });
        }
    }
    
}
