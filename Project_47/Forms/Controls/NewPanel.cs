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
    public class NewPanel: Panel
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

        public NewPanel()
        {
            Location = new Point(0, 22);
            Size = new Size(800, 100);
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            BackColor = Color.White;

            Button = new MenuStrip() { BackColor = Color.White, ImageScalingSize = new Size(36, 36), AutoSize = false, Dock = DockStyle.None, Location = new Point(0, 0), Size = new Size(60, 60) };
            Button.Items.Add(ButtonInsert = new ToolStripMenuItem(Resources.FastPrinting));

            Home = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(0, 60), Size = new Size(60, 24) };
            Home.Items.Add(HomeInsert = new ToolStripMenuItem("Insert"));

            HomeInsert.DropDownItems.AddRange(new ToolStripItem[] {
                Insert = new NewToolStripMenuItem("Insert", Resources.Create)
                ,SpecialInsert = new NewToolStripMenuItem("Special insert", Resources.Open)
            });
            Controls.Add(Home);
            Controls.Add(Button);

            TextChange = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(55, 10), Size = new Size(60,50), LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow};
            TextChange.Items.Add(Cut = new NewToolStripMenuItem("Cut", Resources.OfficeOpenXML_document));
            TextChange.Items.Add(Copy = new NewToolStripMenuItem("Copy", Resources.Open));

            Controls.Add(TextChange);
        }
    }
}
