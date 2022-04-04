using System.Windows.Forms;

namespace Project_46.Forms.Controls
{
    public class NewTabPage : TabPage
    {
        public NewRichTextBox newRichTextBox;
        public NewTabPage(string name, string path, SaveFileDialog saveFileDialog)
        {
            Text = name;
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            newRichTextBox = new NewRichTextBox(name ,path, saveFileDialog)
            {
                Multiline = true,
                WordWrap = false,
                Width = Width - 5,
                Height = Height - 30,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            Controls.Add(newRichTextBox);

            saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.Rename);
        }
        private void Rename(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = newRichTextBox.saveFileDialog.FileName;
            string[] array = text.Split('\\');
            Text = array[array.Length - 1];
        }
    }
}
