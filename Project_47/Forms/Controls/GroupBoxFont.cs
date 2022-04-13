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
    public class GroupBoxFont: GroupBox
    {
        private ComboBox FontName;
        private ComboBox FontSize;
        private MenuStrip Buttons1;
        private NewToolStripMenuItem Button1;
        private NewToolStripMenuItem Button2;
        private MenuStrip Buttons2;
        private NewToolStripMenuItem Button3;
        private NewToolStripMenuItem Button4;
        private NewToolStripMenuItem Button5;
        private NewToolStripMenuItem Button6;
        private NewToolStripMenuItem Button7;
        private NewToolStripMenuItem Button8;
        private MenuStrip Buttons3;
        private NewToolStripMenuItem FontColor;
        private NewToolStripMenuItem FontColors;
        private MenuStrip Buttons4;
        private NewToolStripMenuItem TextBackground;
        private NewToolStripMenuItem TextBackgrounds;
        public GroupBoxFont()
        {
            FontName = new ComboBox();
            FontName.DataSource = FontFamily.Families.Select(it => it.Name).ToList();
            FontName.Location = new Point(10, 20);

            FontSize = new ComboBox();
            FontSize.DataSource = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 24, 26, 28, 36, 48, 72 };
            FontSize.Location = new Point(135, 20);
            FontSize.Size = new Size(40, 10);

            Buttons1 = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(170, 18), Width = 55 };
            Buttons1.Items.Add(Button1 = new NewToolStripMenuItem(Resources.IncreaseTheSize));
            Buttons1.Items.Add(Button2 = new NewToolStripMenuItem(Resources.ReduceTheSize));
            Buttons2 = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(5, 50), Width = 150 };
            Buttons2.Items.Add(Button3 = new NewToolStripMenuItem(Resources.Bold));
            Buttons2.Items.Add(Button4 = new NewToolStripMenuItem(Resources.Italic));
            Buttons2.Items.Add(Button5 = new NewToolStripMenuItem(Resources.Underlined));
            Buttons2.Items.Add(Button6 = new NewToolStripMenuItem(Resources.CrossedOut));
            Buttons2.Items.Add(Button7 = new NewToolStripMenuItem(Resources.Subscripr));
            Buttons2.Items.Add(Button8 = new NewToolStripMenuItem(Resources.Superscript));


            Buttons3 = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(150, 50), Width = 40 };
            Buttons3.Items.Add(FontColor = new NewToolStripMenuItem(Resources.TextColor));
            Buttons3.Items.Add(FontColors = new NewToolStripMenuItem(Resources.ArrowDown) { Size = new Size(10, 22) });

            Buttons4 = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(190, 50), Width = 40 };
            Buttons4.Items.Add(TextBackground = new NewToolStripMenuItem(Resources.TextBackground));
            Buttons4.Items.Add(TextBackgrounds = new NewToolStripMenuItem(Resources.ArrowDown) { Size = new Size(10, 22) });

            Label label2 = new Label();
            label2.Text = "Font";
            label2.Location = new Point(100, 80);
            label2.ForeColor = Color.Gray;

            Location = new Point(149, 0);
            Size = new Size(240, 105);
            Controls.Add(FontName);
            Controls.Add(FontSize);
            Controls.Add(Buttons1);
            Controls.Add(Buttons2);
            Controls.Add(label2);
            Controls.Add(Buttons3);
            Controls.Add(Buttons4);
        }
    }
}
