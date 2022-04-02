using Project_46.Forms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_46
{
    public partial class Form1 : Form
    {
        public NewTabControl newTabControl = new NewTabControl();
        public Form1()
        {
            InitializeComponent();
            newTabControl.Size = ClientSize;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTabControl.Controls.Add(new NewFile(this));
            Controls.Add(newTabControl);
        }

    }
}
