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
        public NewRichTextBox richTextBox;
        private NewMenu newMenu;
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.WhiteSmoke;
            AddMenu();
        }
        private void AddMenu()
        {
            newMenu = new NewMenu(this);
            richTextBox = new NewRichTextBox();
            Controls.Add(richTextBox);

            
        }

    }
}
