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
    class Cover
    {
        public PictureBox box;
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
        }
        public static Image NewImage()
        {
            if (Rnd() == 1) return Properties.Resources.cover1;
            else if (Rnd() == 2) return Properties.Resources.cover2;
            else if (Rnd() == 3) return Properties.Resources.cover3;
            else return Properties.Resources.cover4;
        }
        public static int Rnd()
        {
            return new Random().Next(1, 5);
        }
    }
}
