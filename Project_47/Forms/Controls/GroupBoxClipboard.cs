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
    public class GroupBoxClipboard: GroupBox
    {
        private MenuStrip Button;
        private ToolStripMenuItem ButtonInsert;
        private MenuStrip Home;
        private ToolStripMenuItem HomeInsert;
        private ToolStripMenuItem Insert;
        private ToolStripMenuItem SpecialInsert;

        private MenuStrip TextChange;
        private NewToolStripMenuItem Cut;
        private NewToolStripMenuItem Copy;
        public GroupBoxClipboard()
        {
            Button = new MenuStrip() { BackColor = Color.White, ImageScalingSize = new Size(36, 36), AutoSize = false, Dock = DockStyle.None, Location = new Point(10, 10), Size = new Size(60, 45) };
            Button.Items.Add(ButtonInsert = new ToolStripMenuItem(Resources.Insert));

            Home = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(10, 55), Size = new Size(60, 24) };
            Home.Items.Add(HomeInsert = new ToolStripMenuItem("Insert"));

            HomeInsert.DropDownItems.AddRange(new ToolStripItem[] {
                Insert = new NewToolStripMenuItem("Insert", Resources.Insert_20x20)
                ,SpecialInsert = new NewToolStripMenuItem("Special insert", Resources.SpecialInsert)
            });

            TextChange = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(70, 10), Size = new Size(70, 50), LayoutStyle = ToolStripLayoutStyle.Flow };
            TextChange.Items.Add(Cut = new NewToolStripMenuItem("Cut", Resources.Cut));
            TextChange.Items.Add(Copy = new NewToolStripMenuItem("Copy", Resources.Copy));

            Label label = new Label();
            label.Text = "Сlipboard";
            label.Location = new Point(50, 80);
            label.ForeColor = Color.Gray;
            label.Width = 60;


            Location = new Point(0, 0);
            Size = new Size(150, 105);
            Controls.Add(Home);
            Controls.Add(Button);
            Controls.Add(TextChange);
            Controls.Add(label);
        }
    }
}
