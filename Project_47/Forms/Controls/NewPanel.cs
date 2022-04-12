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

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;

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

        public NewPanel()
        {
            Location = new Point(0, 18);
            Size = new Size(800, 105);
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            BackColor = Color.White;
            

            Button = new MenuStrip() { BackColor = Color.White, ImageScalingSize = new Size(36, 36), AutoSize = false, Dock = DockStyle.None, Location = new Point(10, 10), Size = new Size(60, 45) };
            Button.Items.Add(ButtonInsert = new ToolStripMenuItem(Resources.Insert));

            Home = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(10, 55), Size = new Size(60, 24) };
            Home.Items.Add(HomeInsert = new ToolStripMenuItem("Insert"));

            HomeInsert.DropDownItems.AddRange(new ToolStripItem[] {
                Insert = new NewToolStripMenuItem("Insert", Resources.Create)
                ,SpecialInsert = new NewToolStripMenuItem("Special insert", Resources.Open)
            });

            TextChange = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(70, 10), Size = new Size(60,50), LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow};
            TextChange.Items.Add(Cut = new NewToolStripMenuItem("Cut", Resources.OfficeOpenXML_document));
            TextChange.Items.Add(Copy = new NewToolStripMenuItem("Copy", Resources.Open));

            Label label1 = new Label();
            label1.Text = "Сlipboard";
            label1.Location = new Point(40, 80);
            label1.ForeColor = Color.Gray;

            groupBox1 = new GroupBox();
            groupBox1.Location = new Point(0, 0);
            groupBox1.Size = new Size(150, 105);
            groupBox1.Controls.Add(Home);
            groupBox1.Controls.Add(Button);
            groupBox1.Controls.Add(TextChange);
            groupBox1.Controls.Add(label1);
            Controls.Add(groupBox1);

            FontName = new ComboBox();
            FontName.DataSource = FontFamily.Families.Select(it => it.Name).ToList();
            FontName.Location = new Point(10, 20);

            FontSize = new ComboBox();
            FontSize.DataSource = new int[]{8,9,10,11,12,14,16,18,20,24,26,28,36,48,72};
            FontSize.Location = new Point(135, 20);
            FontSize.Size = new Size(40,10);

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

            groupBox2 = new GroupBox();
            groupBox2.Location = new Point(149, 0);
            groupBox2.Size = new Size(240, 105);
            groupBox2.Controls.Add(FontName);
            groupBox2.Controls.Add(FontSize);
            groupBox2.Controls.Add(Buttons1);
            groupBox2.Controls.Add(Buttons2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(Buttons3);
            groupBox2.Controls.Add(Buttons4);
            Controls.Add(groupBox2);

            Buttons5 = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(0, 18), Width = 125};
            Buttons5.Items.Add(Button9 = new NewToolStripMenuItem(Resources.DecreaseIndent));
            Buttons5.Items.Add(Button10 = new NewToolStripMenuItem(Resources.IncreaseIndent));
            Buttons5.Items.Add(Button11 = new NewToolStripMenuItem(Resources.StartList) {Margin = new Padding(5,0,0,0)});
            Buttons5.Items.Add(Button12 = new NewToolStripMenuItem(Resources.ArrowDown) { Size = new Size(10, 22) });
            Buttons5.Items.Add(Button13 = new NewToolStripMenuItem(Resources.LineSpacing) { Margin = new Padding(5, 0, 0, 0) });

            Buttons6 = new MenuStrip() { BackColor = Color.White, AutoSize = false, Dock = DockStyle.None, Location = new Point(0, 50), Width = 125 };
            Buttons6.Items.Add(Button14 = new NewToolStripMenuItem(Resources.Centre));
            Buttons6.Items.Add(Button15 = new NewToolStripMenuItem(Resources.Centre));
            Buttons6.Items.Add(Button16 = new NewToolStripMenuItem(Resources.Right));
            Buttons6.Items.Add(Button17 = new NewToolStripMenuItem(Resources.Align));
            Buttons6.Items.Add(Button18 = new NewToolStripMenuItem(Resources.Paragraph));

            Label label3 = new Label();
            label3.Text = "Paragraph";
            label3.Location = new Point(40, 80);
            label3.ForeColor = Color.Gray;
            label3.Width = 60;

            groupBox3 = new GroupBox();
            groupBox3.Location = new Point(388, 0);
            groupBox3.Size = new Size(130, 105);
            groupBox3.Controls.Add(Buttons5);
            groupBox3.Controls.Add(Buttons6);
            groupBox3.Controls.Add(label3);

            Controls.Add(groupBox3);
        }
        
    }
}
