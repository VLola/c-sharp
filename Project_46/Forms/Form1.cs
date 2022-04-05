using Project_46.Forms.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project_46
{
    public partial class Form1 : Form
    {
        public SaveFileDialog saveFileDialog = new SaveFileDialog();
        public OpenFileDialog openFileDialog = new OpenFileDialog();
        public NewTabControl newTabControl = new NewTabControl();
        public ToolStrip toolStrip = new ToolStrip();
        private NewMenu newMenu;
        public Form1()
        {
            InitializeComponent();
            AddToolStrip();
            AddMenu();
            AddNewTabControl();

            saveFileDialog.FileOk += new CancelEventHandler(NewPathFile);
        }
        private void AddMenu()
        {
            newMenu = new NewMenu(this);
            newMenu.New.Click += new EventHandler(New);
            newMenu.Open.Click += new EventHandler(Open);
            newMenu.Close.Click += new EventHandler(Close);
            newMenu.CloseAll.Click += new EventHandler(CloseAll);
            newMenu.Save.Click += new EventHandler(Save);
            newMenu.SaveAll.Click += new EventHandler(SaveAll);
            newMenu.SaveAs.Click += new EventHandler(SaveAs);
        }
        private void AddToolStrip()
        {
            toolStrip.Items.Add("", Properties.Resources.New, New);
            toolStrip.Items.Add("", Properties.Resources.Open, Open);
            toolStrip.Items.Add("", Properties.Resources.Save, Save);
            toolStrip.Items.Add("", Properties.Resources.SaveAll, SaveAll);
            toolStrip.Items.Add("", Properties.Resources.Close, Close);
            toolStrip.Items.Add("", Properties.Resources.CloseAll, CloseAll);
            //toolStrip.Items.Add("", Properties.Resources.Print, Open);
            Controls.Add(toolStrip);
        }
        private void AddNewTabControl()
        {
            newTabControl.Size = ClientSize;
            newTabControl.Selecting += Selecting;
            Controls.Add(newTabControl);
        }
        private void Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (newTabControl.TabPages.Count > 0)
            {
                NewTabPage tabPage = (NewTabPage)e.TabPage;
                if (tabPage.newRichTextBox.path == "") Text = tabPage.Text + " - Notepad++";
                else Text = tabPage.newRichTextBox.path;
            }
            else Text = "Notepad++";
        }
        private NewTabPage SelectTabPage()
        {
            return (NewTabPage)newTabControl.SelectedTab;
        }
        private void NewPathFile(object sender, CancelEventArgs e)
        {
            Text = saveFileDialog.FileName;
        }
        private void Open(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            string path = "";
            path += openFileDialog.FileName;
            if (path != "")
            {
                Text = path;
                string name = openFileDialog.SafeFileName;
                AddPage(newTabControl, name, path);
            }
            openFileDialog.Reset();
        }
        private void Close(object sender, EventArgs e)
        {
            newTabControl.TabPages.Remove(newTabControl.SelectedTab);
        }
        private void CloseAll(object sender, EventArgs e)
        {
            newTabControl.TabPages.Clear();
        }
        private void New(object sender, EventArgs e)
        {
            AddPage(newTabControl, "new", "");
        }
        private void AddPage(NewTabControl newTabControl, string name, string path)
        {
            NewTabPage newTabPage = new NewTabPage(newTabControl, name, path);
            newTabControl.TabPages.Add(newTabPage);
            newTabControl.SelectedTab = newTabPage;
            if (path == "") Text = newTabPage.Text + " - Notepad++";
        }
        private void Save(object sender, EventArgs e)
        {
            NewTabPage tabPage = SelectTabPage();
            if (tabPage.newRichTextBox.Text != "")
            {
                if (tabPage.newRichTextBox.path != "")
                {
                    if (tabPage.newRichTextBox.Text != File.ReadAllText(tabPage.newRichTextBox.path))
                    {
                        File.WriteAllText(tabPage.newRichTextBox.path, tabPage.newRichTextBox.Text);
                    }
                }
                else SaveAs(sender, e);
            }
        }
        private void SaveAll(object sender, EventArgs e)
        {
            foreach (NewTabPage it in newTabControl.TabPages)
            {
                if (it.newRichTextBox.Text != "")
                {
                    if (it.newRichTextBox.path != "")
                    {
                        if (it.newRichTextBox.Text != File.ReadAllText(it.newRichTextBox.path))
                        {
                            File.WriteAllText(it.newRichTextBox.path, it.newRichTextBox.Text);
                        }
                    }
                }
            }
        }
        private void SaveAs(object sender, EventArgs e)
        {
            NewTabPage tabPage = SelectTabPage();

            if (tabPage.newRichTextBox.Text != "")
            {
                saveFileDialog.FileName = tabPage.newRichTextBox.Name;
                saveFileDialog.ShowDialog();
                string new_path = saveFileDialog.FileName;
                if (new_path != "")
                {
                    tabPage.newRichTextBox.path = new_path;
                    File.WriteAllText(new_path, tabPage.newRichTextBox.Text);
                    // Rename TabPage
                    string[] array = new_path.Split('\\');
                    tabPage.Text = array[array.Length - 1];
                }
                saveFileDialog.Reset();
            }
        }
        
    }
}
