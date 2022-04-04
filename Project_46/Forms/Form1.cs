using Project_46.Forms.Controls;
using System;
using System.Windows.Forms;

namespace Project_46
{
    public partial class Form1 : Form
    {
        public SaveFileDialog saveFileDialog = new SaveFileDialog();
        public NewTabControl newTabControl = new NewTabControl();
        public Form1()
        {
            InitializeComponent();
            newTabControl.Size = ClientSize;
            Controls.Add(newTabControl);

            newToolStripMenuItem.Click += new EventHandler(newToolStripMenuItem_Click);
            saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.NewPathFile);
        }
        private void NewPathFile(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Text = saveFileDialog.FileName;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            Text = path;
            string name = openFileDialog1.SafeFileName;
            AddPage(name, path);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTabControl.TabPages.Remove(newTabControl.SelectedTab);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTabControl.TabPages.Clear();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPage("new " + (newTabControl.TabPages.Count + 1).ToString(), "");
        }
        private void AddPage(string name, string path)
        {
            newTabControl.TabPages.Add(new NewTabPage(name, path, saveFileDialog));
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPage = newTabControl.SelectedTab;
            foreach(NewTabPage it in newTabControl.TabPages)
            {
                if(it == tabPage)
                {
                    it.newRichTextBox.Save();
                }
            }
        }
        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (NewTabPage it in newTabControl.TabPages)
            {
                it.newRichTextBox.Save();
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPage = newTabControl.SelectedTab;
            foreach (NewTabPage it in newTabControl.TabPages)
            {
                if (it == tabPage)
                {
                    it.newRichTextBox.SaveAs();
                }
            }
        }
    }
}
