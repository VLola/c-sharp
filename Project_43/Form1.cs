using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_43
{
    public partial class Form1 : Form
    {
        public Cover cover;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"x = {Cursor.Position.X} + y = {Cursor.Position.Y}";
        }
        public int temp = 50;
        private void button1_Click(object sender, EventArgs e)
        {
            cover = new Cover();
            temp = cover.NewCover(this, temp);
        }
        
    }
}
