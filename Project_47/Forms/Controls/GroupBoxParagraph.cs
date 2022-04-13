using Project_47.Properties;
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
        private MenuStrip Buttons5;
        private NewToolStripMenuItem Button9;
        private NewToolStripMenuItem Button10;
        private NewToolStripMenuItem Button11;
        private NewToolStripMenuItem Button12;
        private NewToolStripMenuItem Button13;

        private MenuStrip Buttons6;
        private NewToolStripMenuItem Button14;
        private NewToolStripMenuItem Button15;
        private NewToolStripMenuItem Button16;
        private NewToolStripMenuItem Button17;
        private NewToolStripMenuItem Button18;
        public GroupBoxParagraph()
        {
            Buttons5 = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(0, 18), Width = 125 };
            Buttons5.Items.Add(Button9 = new NewToolStripMenuItem(Resources.DecreaseIndent));
            Buttons5.Items.Add(Button10 = new NewToolStripMenuItem(Resources.IncreaseIndent));
            Buttons5.Items.Add(Button11 = new NewToolStripMenuItem(Resources.StartList) { Margin = new Padding(5, 0, 0, 0) });
            Buttons5.Items.Add(Button12 = new NewToolStripMenuItem(Resources.ArrowDown) { Size = new Size(10, 22) });
            Buttons5.Items.Add(Button13 = new NewToolStripMenuItem(Resources.LineSpacing) { Margin = new Padding(5, 0, 0, 0) });

            Buttons6 = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(0, 50), Width = 125 };
            Buttons6.Items.Add(Button14 = new NewToolStripMenuItem(Resources.Left));
            Buttons6.Items.Add(Button15 = new NewToolStripMenuItem(Resources.Centre));
            Buttons6.Items.Add(Button16 = new NewToolStripMenuItem(Resources.Right));
            Buttons6.Items.Add(Button17 = new NewToolStripMenuItem(Resources.Align));
            Buttons6.Items.Add(Button18 = new NewToolStripMenuItem(Resources.Paragraph));

            Label label3 = new Label();
            label3.Text = "Paragraph";
            label3.Location = new Point(40, 80);
            label3.ForeColor = Color.Gray;
            label3.Width = 60;

            Location = new Point(388, 0);
            Size = new Size(130, 105);
            Controls.Add(Buttons5);
            Controls.Add(Buttons6);
            Controls.Add(label3);
        }
    }
}
