using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_48.Forms
{
    public partial class Form3 : Form
    {
        Form2 login;
        Form1 registr;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registr = new Form1();
            registr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login = new Form2();
            login.ShowDialog();
        }
    }
}
