using System.Drawing;
using System.Windows.Forms;

namespace Project_46.Forms.Controls
{
    public class NewTabPage : TabPage
    {
        public NewRichTextBox newRichTextBox;
        public NewTabControl newTabControl;
        public SaveFileDialog saveFileDialog;

        
        public NewTabPage(NewTabControl newTabControl, SaveFileDialog saveFileDialog, string name, string path)
        {
            this.newTabControl = newTabControl;
            this.saveFileDialog = saveFileDialog;
            Text = NewName(name);

            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            newRichTextBox = new NewRichTextBox(name, path, saveFileDialog)
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
        private bool CheckName(string name)
        {
            bool check = false;
            foreach (NewTabPage it in newTabControl.TabPages)
            {
                if (it.Text == name )
                {
                    check = true;
                }
            }
            if (check) return true;
            else return false;
        }

        private string NewName(string name)
        {
            string new_name = name;
            if (!CheckName(new_name)) return new_name;
            for (int i = 1; ; i++)
            {
                new_name = name + " " + i.ToString();
                if (!CheckName(new_name)) return new_name;
            }
        }
    }
}
