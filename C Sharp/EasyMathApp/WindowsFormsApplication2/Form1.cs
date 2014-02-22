using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Text = "Easy Math App";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double firstNum, secondNum;
            double sum = 0;

            firstNum = double.Parse(textBox1.Text);
            secondNum = double.Parse(textBox2.Text);

            sum = firstNum + secondNum;

            label2.Text = string.Format("Your total added is: {0}", sum).ToString();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double firstNum, secondNum; //declared my variables
            double sum = 0;

            
            firstNum = double.Parse(textBox1.Text);  
            secondNum = double.Parse(textBox2.Text);


            sum = (firstNum * secondNum); //calculation

            label2.Text = string.Format("Your total multiplied is:  {0}",sum).ToString(); //display the total to the hidden label below
            
                
            
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Enter a number in both text boxes and select the calculation type"); //help menu added
        }
    }
}
