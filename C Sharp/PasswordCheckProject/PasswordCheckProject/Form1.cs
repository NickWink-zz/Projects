using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordCheckProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //It's been a month and almost forgot how to code :-/.

            //password masking for entered characters.

            string passWord;

            passWord = textBox1.Text;

            textBox1.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //display all other forms
            textBox2.Visible = true;
            button2.Visible = true;
            label2.Visible = true;

            MessageBox.Show("Please reenter your password");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //validation for inputted password
            if (textBox2.Text == textBox1.Text)
            {
                MessageBox.Show("CONGRATULATIONS, your passwords match!.");
                
            }
            else 
            {
                MessageBox.Show("Please enter the same password");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            //password character masking.
            string passWord;

            passWord = textBox2.Text;

            textBox2.PasswordChar = '*';
        }
    }
}
