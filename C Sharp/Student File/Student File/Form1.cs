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

namespace Student_File
{
    public partial class Form1 : Form
    {
           

        public Form1()
        {
            InitializeComponent();

        }

        private void buttonNewStdnt_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string fileName = "studentfile.txt";  //filename
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, true)) //new file and append text so it doesn't overwrite existing data.
                {
                    writer.WriteLine("\n"); //new space before entry

                    writer.WriteLine(textBoxName.Text); 
                    this.textBoxName.Text = "";  //clears textbox after user submits new student
                    writer.WriteLine(textBoxEmail.Text);
                    this.textBoxEmail.Text = ""; 
                    writer.WriteLine(textBoxMeid.Text);
                    this.textBoxMeid.Text = "";

                    writer.WriteLine("\n"); //space after user entries.

                }
            }
            catch (InvalidDataException exc)
            {
                MessageBox.Show("Invalid Directory", exc.Message);
            }
            catch (FileNotFoundException exc)
            {
                MessageBox.Show("File not found", exc.Message);
            }
            catch (Exception exc) //catching any other exceptions
            {
                MessageBox.Show("Error", exc.Message);
            }             
        }

        private void buttonShowFile_Click(object sender, EventArgs e)
        {
            this.Close(); //close program
        }
    }
}
