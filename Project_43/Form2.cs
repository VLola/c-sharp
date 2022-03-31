using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Project_43
{
    public partial class Form2 : Form
    {
        Cover cover;
        public string path = Path.Combine(System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "");
        public Form2(Cover COVER)
        {
            InitializeComponent();
            cover = COVER;
            Start(cover);
        }
        public void Start(Cover cover)
        {
            double count = 1;
            string temp = "";
            cover.list = new ArrayList();
            foreach (string line in File.ReadLines(path + "/Books/" + cover.name + ".txt"))
            {
                temp += line;
                if(count % 20 == 0)
                {
                    cover.list.Add(temp);
                    temp = "";
                }
                count += 1;
            }
            textBox1.Text = cover.list[cover.page].ToString();
            textBox2.Text = cover.list[cover.page + 1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cover.page++; 
            textBox1.Text = cover.list[cover.page].ToString();
            textBox2.Text = cover.list[cover.page + 1].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cover.page != 0)
            {
                cover.page--;
                textBox1.Text = cover.list[cover.page].ToString();
                textBox2.Text = cover.list[cover.page + 1].ToString();
            }
        }
    }
}
