using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGui
{
    public partial class Form1 : Form
    {
        Image img1 = Properties.Resources.cat1;
        Image img2 = Properties.Resources.cat2;
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Image = img1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Don't click me!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == img2)
            {
                pictureBox2.Image = img1;
            } else
            {
                pictureBox2.Image = img2;
            }
        }

    }
}

