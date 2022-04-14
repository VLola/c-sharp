using Project_47.Forms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_47
{
    public partial class Form1 : Form
    {
        public NewToolStripContainer newToolStripContainer;
        public NewMenu newMenu;
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.WhiteSmoke;
            AddMenu();
            AddEvents();
        }
        private void AddMenu()
        {
            newMenu = new NewMenu(this);
            newToolStripContainer = new NewToolStripContainer();
            Controls.Add(newToolStripContainer);
        }
        private void AddEvents()
        {
            newMenu.panelMain.boxClipboard.HomeInsert.Click += Insert;
            newMenu.panelMain.boxClipboard.Insert.Click += Insert;
            newMenu.panelMain.boxClipboard.Cut.Click += Cut;
            newMenu.panelMain.boxClipboard.Copy.Click += Copy;
            newMenu.panelMain.boxFont.FontName.SelectedIndexChanged += FontName;
            newMenu.panelMain.boxFont.FontSize.SelectedIndexChanged += FontSize;
        }
        private void Insert(object sender, EventArgs e) { SendKeys.Send("^v"); }
        private void Cut(object sender, EventArgs e) { SendKeys.Send("^x"); }
        private void Copy(object sender, EventArgs e) { SendKeys.Send("^c"); }
        private void FontName(object sender, EventArgs e)
        {
            Font font = newToolStripContainer.newRichTextBox.SelectionFont;
            newToolStripContainer.newRichTextBox.SelectionFont = new Font(newMenu.panelMain.boxFont.FontName.SelectedItem.ToString(), font.Size, font.Style);
        }
        private void FontSize(object sender, EventArgs e)
        {
            Font font = newToolStripContainer.newRichTextBox.SelectionFont;
            float newSize = (float)Convert.ToDouble(newMenu.panelMain.boxFont.FontSize.SelectedItem);
            newToolStripContainer.newRichTextBox.SelectionFont = new Font(font.FontFamily, newSize, font.Style);
        }

    }
}
