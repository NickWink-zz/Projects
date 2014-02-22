using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace dbConn
{
    public partial class Form1 : Form
    {
        string sConn;
        SqlConnection connDB; //= new SqlConnection(sConn); //connect to sql
        SqlCommand sCommnd; //= connDB.CreateCommand();
        SqlDataAdapter sData;
        DataSet ds;
        SqlCommandBuilder sBuild;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                string sConn;
                sConn = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Raw\Desktop\CIS262AD\Customer Records\dbConn\dbConn\customerRecords.mdf;Integrated Security=True"; //connection string *may need to be updated to reflect as local file. 
                connDB = new SqlConnection(sConn); //connect to sql

                connDB.Open();

                sCommnd = connDB.CreateCommand();  

                sCommnd.CommandText = "SELECT * FROM Customer"; //SQL command

                sData = new SqlDataAdapter("SELECT * FROM Customer", connDB); //get data from the customer table

                sBuild = new SqlCommandBuilder(sData);

                ds = new DataSet();  

                sData.Fill(ds);

                dataGridView.DataSource = ds.Tables[0]; //display data from the table to the gridview

            
            }
             catch (Exception exc)
            {
                MessageBox.Show(exc.Message); //exception messagebox
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
                
                this.Close();
                connDB.Close();
      
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            sData.Update(ds);




        }
    }
}
