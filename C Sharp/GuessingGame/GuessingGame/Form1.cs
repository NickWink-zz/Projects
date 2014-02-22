using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Random r = new Random();  //select random number
        int target;
        int count;

        private void button1_Click(object sender, EventArgs e)
        {
            int guessNum;
            count += 1;

            guessNum = int.Parse(textBox1.Text);  //user enters number

                if (guessNum > target)
                {
                    this.BackColor = Color.Red;   //back color of the form changes color to dispaly "too high" or "too low"
                    label2.Text = "Too High";
                }

                else if (guessNum < target)
                {
                    this.BackColor = Color.Blue;  
                    label2.Text = "Too Low";
                }

                else
                {
                    this.BackColor = Color.Orange;
                    label2.Text = count.ToString();
                    MessageBox.Show("YOU ARE CORRECT!!, GREAT GUESS!");
                }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            target = r.Next(0, 100);    //sets number for the guess and doesn't continue generating numbers until guessed.
        }
    }
}
