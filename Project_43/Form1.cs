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
        public int temp = 50;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cover = new Cover(this);
            temp = cover.NewCover(this, temp);
        }

    }
}
