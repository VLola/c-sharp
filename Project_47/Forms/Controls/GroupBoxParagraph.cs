﻿using Project_47.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_47.Forms.Controls
{
    public class GroupBoxParagraph: GroupBox
    {
        private MenuStrip TopButtons;
        private NewToolStripMenuItem DecreaseIndent;
        private NewToolStripMenuItem IncreaseIndent;
        private ToolStripSplitButton StartList;
        private NewToolStripMenuItem LineSpacing;

        private MenuStrip BottomButtons;
        private NewToolStripMenuItem LeftButton;
        private NewToolStripMenuItem CentreButton;
        private NewToolStripMenuItem RightButton;
        private NewToolStripMenuItem AlignButton;
        private NewToolStripMenuItem ParagraphButton;
        public GroupBoxParagraph()
        {
            TopButtons = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(0, 18), Width = 125 };
            TopButtons.Items.Add(DecreaseIndent = new NewToolStripMenuItem(Resources.DecreaseIndent));
            TopButtons.Items.Add(IncreaseIndent = new NewToolStripMenuItem(Resources.IncreaseIndent));
            TopButtons.Items.Add(StartList = new ToolStripSplitButton(Resources.StartList) { AutoSize = false, Size = new Size(36, 22) });
            TopButtons.Items.Add(LineSpacing = new NewToolStripMenuItem(Resources.LineSpacing));

            BottomButtons = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(0, 50), Width = 125 };
            BottomButtons.Items.Add(LeftButton = new NewToolStripMenuItem(Resources.Left));
            BottomButtons.Items.Add(CentreButton = new NewToolStripMenuItem(Resources.Centre));
            BottomButtons.Items.Add(RightButton = new NewToolStripMenuItem(Resources.Right));
            BottomButtons.Items.Add(AlignButton = new NewToolStripMenuItem(Resources.Align));
            BottomButtons.Items.Add(ParagraphButton = new NewToolStripMenuItem(Resources.Paragraph));

            Label label = new Label();
            label.Text = "Paragraph";
            label.Location = new Point(40, 80);
            label.ForeColor = Color.Gray;
            label.Width = 60;

            Location = new Point(388, 0);
            Size = new Size(130, 105);
            Controls.Add(TopButtons);
            Controls.Add(BottomButtons);
            Controls.Add(label);
        }
    }
}
