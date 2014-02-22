using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Average
{
    public partial class Form1 : Form
    {
        int total = 0;  //class level initiation for my counter and total.
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //accidently clicked on the form. 
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {      
            double averageTestScore;
            string grade;


            try
            {
                averageTestScore = total / count;  //calculate the average
                label2.Text = averageTestScore.ToString();  //displays the average

                if (averageTestScore >= 90)
                {
                    grade = "A"; //letter grade A is displayed
                }
                else if (averageTestScore >= 80)
                {
                    grade = "B";  //letter grade B is displayed
                }
                else if (averageTestScore >= 70)
                {
                    grade = "C";  //letter grade C is displayed
                }
                else if (averageTestScore >= 60)
                {
                    grade = "D";   //letter grade D is displayed
                }
                else
                {
                    grade = "F";  //letter grade F is displayed
                }

                label4.Text = grade;  //display grade
            }

            catch (System.DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by 0, Please enter a number");
            }

            catch (System.ArithmeticException)
            {
                MessageBox.Show("Errors in arithmetic, casting, or conversion");
            }

            catch (System.Exception)
            {
                MessageBox.Show("Error, Please restart the program.");
            }
        
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                count++;
                total += int.Parse(textBox1.Text);
                label7.Text = total.ToString();
                textBox1.Clear();
            }

            catch (System.MissingFieldException)
            {
                MessageBox.Show("Please enter a number");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();  //clears textbox and resets count to 0.
            label2.Text = "";  
            label7.Text = "";
            label4.Text = "";

            count = 0;
            total = 0;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closes program
        }
    }
}


