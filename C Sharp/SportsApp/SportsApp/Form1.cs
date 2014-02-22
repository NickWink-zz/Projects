using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            
            if (radioButton1.Checked == true)
            {
                
                MessageBox.Show("Score the GOAL!");
                pictureBox1.Visible = true;
                pictureBox1.Image = SportsApp.Properties.Resources.soccer;

            }

            else
            {
                pictureBox1.Visible = false;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           

            if (radioButton2.Checked == true)
            {
                MessageBox.Show("Ready for the TOUCHDOWN dance??");
                pictureBox1.Visible = true;
                pictureBox1.Image = SportsApp.Properties.Resources.touchdown;
            }

            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                MessageBox.Show("SHAZAAAAM");
                pictureBox1.Visible = true;
                pictureBox1.Image = SportsApp.Properties.Resources.basketball;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                MessageBox.Show("30 LOVE");
                pictureBox1.Visible = true;
                pictureBox1.Image = SportsApp.Properties.Resources.tennis;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                MessageBox.Show("HOMERUN!!!!");
                pictureBox1.Visible = true;
                pictureBox1.Image = SportsApp.Properties.Resources.baseball;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }
    }
}
