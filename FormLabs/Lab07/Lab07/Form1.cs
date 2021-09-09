using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07
{
    public partial class Form1 : Form
    {
        Image img1 = Properties.Resources.rock;
        Image img2 = Properties.Resources.paper;
        Image img3 = Properties.Resources.sciscors;

        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
        }

        private void changeAIImage(int value)
        {
            switch (value)
            {
                case 0:
                    pictureBox2.Image = img1;
                    break;
                case 1:
                    pictureBox2.Image = img2;
                    break;
                case 2:
                    pictureBox2.Image = img3;
                    break;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "Paper")
                pictureBox1.Image = img2;
            else if (listBox1.SelectedItem.ToString() == "Rock")
                pictureBox1.Image = img1;
            else if (listBox1.SelectedItem.ToString() == "Scissors")
                pictureBox1.Image = img3;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randValue = rand.Next(0, 3);
            changeAIImage(randValue);
            bool playerWins = ((pictureBox1.Image == img1 && pictureBox2.Image == img3) ||
                   (pictureBox1.Image == img2 && pictureBox2.Image == img1) ||
                   (pictureBox1.Image == img3 && pictureBox2.Image == img2));
            bool AIWins = ((pictureBox1.Image == img1 && pictureBox2.Image == img2) ||
                           (pictureBox1.Image == img2 && pictureBox2.Image == img3) ||
                           (pictureBox1.Image == img3 && pictureBox2.Image == img1));

            if (playerWins)
            {
                richTextBox1.Text = "Player 1 has won!";
                //MessageBox.Show("Player 1 has won!");
            } else if (AIWins)
            {
                richTextBox1.Text = "Player AI has won!";
                //MessageBox.Show("Player AI has won!");
            } else
            {
                richTextBox1.Text = "The game is a tie!";
                //MessageBox.Show("The game is a tie!");
            }
                
        }       
    }
}
