using System.Windows.Forms;

namespace Project_46.Forms.Controls
{
    public class NewFile : TabPage
    {
        public NewFile(Form1 form)
        {
            string text = "new 1";
            Text = text;
            Size = form.ClientSize;

            Controls.Add(new NewRichTextBox() { 
                Multiline = true, 
                WordWrap = false, 
                Width = Width - 10, 
                Height = Height - 30, 
                SelectionStart = Text.Length 
            }) ;
        }
    }
    
}
