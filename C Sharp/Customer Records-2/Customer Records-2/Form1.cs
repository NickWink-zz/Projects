using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;


namespace Customer_Records_2
{
    public partial class Form1 : Form
    {

   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerRecordsDataSet.Customer' table. You can move, or remove it, as needed.
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          try
          {
              string sConnection;
              sConnection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Raw\Desktop\CIS262AD\Customer Records-2\Customer Records-2\customerRecords.mdf;Integrated Security=True;Connect Timeout=30";


              SqlConnection dbConn = new SqlConnection(sConnection);

              dbConn.Open();

              SqlDataAdapter sData = new SqlDataAdapter("SELECT * FROM Customer", dbConn);

              DataSet dataS = new DataSet();
              
              SqlCommandBuilder sBuilder = new SqlCommandBuilder(sData);

              sData.Update(dataS);

              
              



              dbConn.Close();

          }

          catch (Exception exc)
          {
              MessageBox.Show("Unable to continue", exc.Message);
          }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
