using System;
using System.IO;
using System.Windows.Forms;

namespace Project_46.Forms.Controls
{
    public class NewRichTextBox: RichTextBox
    {
        public SaveFileDialog saveFileDialog;
        public string path = "";
        public string name;
        public NewRichTextBox(string name ,string path, SaveFileDialog saveFileDialog)
        {
            this.saveFileDialog = saveFileDialog;
            this.name = name;
            if (path != "")
            {
                this.path = path;
                Text = File.ReadAllText(path);
            }
        }
        public void Save()
        {
            if(Text != "")
            {
                if (path != "")
                {
                    if (Text != File.ReadAllText(path))
                    {
                        File.WriteAllText(path, Text);
                    }
                }
                else SaveAs();
            }
        }
        public void SaveAs()
        {
            if(Text != "")
            {
                saveFileDialog.FileName = name;
                saveFileDialog.ShowDialog();
                string new_path = saveFileDialog.FileName;
                if(new_path != "")
                {
                    path = new_path;
                    File.WriteAllText(new_path, Text);
                }
                saveFileDialog.Reset();
            }
        }
    }
}
