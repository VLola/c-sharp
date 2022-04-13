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
    public class GroupBoxEditing: GroupBox
    {
        private MenuStrip Editing;
        private NewToolStripMenuItem Search;
        private NewToolStripMenuItem Replacement;
        private NewToolStripMenuItem SelectAll;
        public GroupBoxEditing()
        {
            Editing = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(10, 10), Size = new Size(120, 65), LayoutStyle = ToolStripLayoutStyle.Flow };
            Editing.Items.Add(Search = new NewToolStripMenuItem("Search", Resources.Search));
            Editing.Items.Add(Replacement = new NewToolStripMenuItem("Replacement", Resources.Replacement));
            Editing.Items.Add(SelectAll = new NewToolStripMenuItem("SelectAll", Resources.SelectAll));

            Label label = new Label();
            label.Text = "Editing";
            label.Location = new Point(50, 80);
            label.ForeColor = Color.Gray;
            label.Width = 50;

            Location = new Point(729, 0);
            Size = new Size(140, 105);
            Controls.Add(Editing);
            Controls.Add(label);
        }
    }
}
