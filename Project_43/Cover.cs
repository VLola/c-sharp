using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Project_43
{
    public class Cover
    {
        public PictureBox box;
        public string name { get; set; }
        public int page { get; set; }
        public ArrayList list;

        public int NewCover(Control control, int temp)
        {
            if (temp < 530)
            {
                NewBox();
                box.Location = new Point(temp, 16 + 176 - box.Image.Height);
                control.Controls.Add(box);
                temp += box.Image.Width;
                return temp;
            }
            else if (temp < 1000)
            {
                NewBox();
                box.Location = new Point(temp - 480, 16 + 377 - box.Image.Height);
                control.Controls.Add(box);
                temp += box.Image.Width;
                return temp;
            }
            else if (temp < 1450)
            {
                NewBox();
                box.Location = new Point(temp - 950, 16 + 570 - box.Image.Height);
                control.Controls.Add(box);
                temp += box.Image.Width;
                return temp;
            }
            else { 
                MessageBox.Show("Shelf full!");
                return temp;
            }
        }
        public void NewBox()
        {
            box = new PictureBox();
            box.Image = NewImage();
            box.Size = new Size(box.Image.Width, box.Image.Height);
            box.Click += new EventHandler(button2_Click);
            name = NewName();
            page = 1;
        }
        public static Image NewImage()
        {
            int number = new Random().Next(1, 5);
            if (number == 1) return Properties.Resources.cover1;
            else if (number == 2) return Properties.Resources.cover2;
            else if (number == 3) return Properties.Resources.cover3;
            else return Properties.Resources.cover4;
        }

        public static string NewName()
        {
            return "book1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }
    }
}
