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
        public RichTextBox text;
        public NewMenu newMenu;
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.WhiteSmoke;
            AddMenu();
            AddEvents();
            text = newToolStripContainer.newRichTextBox;
        }
        private void AddMenu()
        {
            newMenu = new NewMenu(this);
            newToolStripContainer = new NewToolStripContainer();
            Controls.Add(newToolStripContainer);
        }
        private void AddEvents()
        {
            newToolStripContainer.newRichTextBox.SelectionChanged += NewRichTextBox_SelectionChanged;
            newMenu.panelMain.boxClipboard.HomeInsert.Click += Insert;
            newMenu.panelMain.boxClipboard.Insert.Click += Insert;
            newMenu.panelMain.boxClipboard.Cut.Click += Cut;
            newMenu.panelMain.boxClipboard.Copy.Click += Copy;
            newMenu.panelMain.boxFont.FontName.SelectedIndexChanged += FontName;
            newMenu.panelMain.boxFont.FontSize.SelectedIndexChanged += FontSize;
            newMenu.panelMain.boxFont.IncreaseTheSize.Click += IncreaseTheSize_Click;
            newMenu.panelMain.boxFont.ReduceTheSize.Click += ReduceTheSize_Click;
            newMenu.panelMain.boxFont.Bold.Click += Bold_Click;
            newMenu.panelMain.boxFont.Italic.Click += Italic_Click;
            newMenu.panelMain.boxFont.Underlined.Click += Underlined_Click;
            newMenu.panelMain.boxFont.StrikeOut.Click += StrikeOut_Click;
        }

        private void StrikeOut_Click(object sender, EventArgs e) { FontStyleCheck(); }
        private void Underlined_Click(object sender, EventArgs e) { FontStyleCheck(); }
        private void Italic_Click(object sender, EventArgs e) { FontStyleCheck(); }
        private void Bold_Click(object sender, EventArgs e) { FontStyleCheck(); }
        private void FontStyleCheck()
        {
            Font font = text.SelectionFont;
            bool bold = newMenu.panelMain.boxFont.Bold.Checked;
            bool italic = newMenu.panelMain.boxFont.Italic.Checked;
            bool underlined = newMenu.panelMain.boxFont.Underlined.Checked;
            bool strikeout = newMenu.panelMain.boxFont.StrikeOut.Checked;
            if (bold && italic && underlined && strikeout) text.SelectionFont = new Font(font.FontFamily, font.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline | FontStyle.Strikeout);
            else if (!bold && italic && underlined && strikeout) text.SelectionFont = new Font(font.FontFamily, font.Size, FontStyle.Italic | FontStyle.Underline | FontStyle.Strikeout);
            else if(bold && !italic && underlined && strikeout) text.SelectionFont = new Font(font.FontFamily, font.Size, FontStyle.Bold | FontStyle.Underline | FontStyle.Strikeout);
            else if (bold && italic && !underlined && strikeout) text.SelectionFont = new Font(font.FontFamily, font.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout);
            else if (bold && italic && underlined && !strikeout) text.SelectionFont = new Font(font.FontFamily, font.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline );
            else if (!bold && !italic && underlined && strikeout) text.SelectionFont = new Font(font.FontFamily, font.Size, FontStyle.Underline | FontStyle.Strikeout);
            else if (bold && !italic && !underlined && strikeout) text.SelectionFont = new Font(font.FontFamily, font.Size, FontStyle.Bold | FontStyle.Strikeout);
            else if (bold && italic && !underlined && !strikeout) text.SelectionFont = new Font(font.FontFamily, font.Size, FontStyle.Bold | FontStyle.Italic);
            else if (!bold && italic && underlined && !strikeout) text.SelectionFont = new Font(font.FontFamily, font.Size, FontStyle.Italic | FontStyle.Underline);
            else if (!bold && !italic && !underlined && strikeout) text.SelectionFont = new Font(font.FontFamily, font.Size, FontStyle.Strikeout);
            else if (bold && !italic && !underlined && !strikeout) text.SelectionFont = new Font(font.FontFamily, font.Size, FontStyle.Bold);
            else if (!bold && !italic && underlined && !strikeout) text.SelectionFont = new Font(font.FontFamily, font.Size, FontStyle.Underline);
            else if (!bold && italic && !underlined && !strikeout) text.SelectionFont = new Font(font.FontFamily, font.Size, FontStyle.Italic);
        }

        private void ReduceTheSize_Click(object sender, EventArgs e)
        {
            if(newMenu.panelMain.boxFont.FontSize.SelectedIndex > 0)
            {
                newMenu.panelMain.boxFont.FontSize.SelectedIndex = newMenu.panelMain.boxFont.FontSize.SelectedIndex - 1;
                FontSizeChanged();
            }
        }

        private void IncreaseTheSize_Click(object sender, EventArgs e)
        {
            if (newMenu.panelMain.boxFont.FontSize.SelectedIndex < 14)
            {
                newMenu.panelMain.boxFont.FontSize.SelectedIndex = newMenu.panelMain.boxFont.FontSize.SelectedIndex + 1;
                FontSizeChanged();
            }
        }

        private void NewRichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            if (text.SelectionLength > 0) newMenu.panelMain.boxClipboard.TextChange.Enabled = true;
            else newMenu.panelMain.boxClipboard.TextChange.Enabled = false;
            if (text.Text.Length > 0) newMenu.panelMain.boxEditing.Editing.Enabled = true;
            else newMenu.panelMain.boxEditing.Editing.Enabled = false;
        }

        private void Insert(object sender, EventArgs e) { SendKeys.Send("^v"); }
        private void Cut(object sender, EventArgs e) { SendKeys.Send("^x"); }
        private void Copy(object sender, EventArgs e) { SendKeys.Send("^c"); }
        private void FontName(object sender, EventArgs e)
        {
            Font font = text.SelectionFont;
            text.SelectionFont = new Font(newMenu.panelMain.boxFont.FontName.SelectedItem.ToString(), font.Size, font.Style);
        }
        private void FontSize(object sender, EventArgs e)
        {
            FontSizeChanged();
        }
        private void FontSizeChanged()
        {
            Font font = text.SelectionFont;
            float newSize = (float)Convert.ToDouble(newMenu.panelMain.boxFont.FontSize.SelectedItem);
            text.SelectionFont = new Font(font.FontFamily, newSize, font.Style);
        }

    }
}
