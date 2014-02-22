// DBExample.cs
// A windows application is used as the 
// front end to display records retrived
// from an Access database.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace DBExample
{
	public class DbGUI : System.Windows.Forms.Form
	{
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Button btnLoad;
        private IContainer components;
        private OleDbConnection  dbConn; // Connectionn object
        private OleDbCommand  dbCmd;     // Command object
        private OleDbDataReader dbReader;// Data Reader object
        private Member aMember;
        private string sConnection;
        private memberDataSet memberDataSet;
        private BindingSource memberTableBindingSource;
        private memberDataSetTableAdapters.memberTableTableAdapter memberTableTableAdapter;     
        private string sql;

        public DbGUI()
		{
            InitializeComponent();
		}

        protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
        // Note: Windows Generated Code
        // Removed – Due to space constraints

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.btnLoad = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.memberDataSet = new DBExample.memberDataSet();
            this.memberTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableTableAdapter = new DBExample.memberDataSetTableAdapters.memberTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(160, 184);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 37);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.memberTableBindingSource;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(38, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 124);
            this.listBox1.TabIndex = 1;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.Location = new System.Drawing.Point(16, 224);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(264, 55);
            this.lblErrorMsg.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Members";
            // 
            // memberDataSet
            // 
            this.memberDataSet.DataSetName = "memberDataSet";
            this.memberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableBindingSource
            // 
            this.memberTableBindingSource.DataMember = "memberTable";
            this.memberTableBindingSource.DataSource = this.memberDataSet;
            // 
            // memberTableTableAdapter
            // 
            this.memberTableTableAdapter.ClearBeforeFill = true;
            // 
            // DbGUI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLoad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "DbGUI";
            this.Text = "Accessing database records....";
            this.Load += new System.EventHandler(this.DbGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion
		static void Main() 
		{
			Application.Run(new DbGUI());
		}

        private void btnLoad_Click(object sender, 
                   System.EventArgs e)
        {
            try
            {
                // Construct an object of the OleDbConnection 
                // class to store the connection string 
                // representing the type of data provider 
                // (database) and the source (actual db)
                sConnection = 
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=member.accdb";
                dbConn = new OleDbConnection(sConnection);
                dbConn.Open();

                // Construct an object of the OleDbCommand 
                // class to hold the SQL query. Tie the  
                // OleDbCommand object to the OleDbConnection
                // object
                sql = "SELECT * FROM memberTable ORDER " +
                      "BY LastName ASC, FirstName ASC;";
                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                // Create a dbReader object 
                dbReader = dbCmd.ExecuteReader();

                while (dbReader.Read()) 
                {   aMember = new Member
                            (dbReader["FirstName"].ToString(), 
                             dbReader["LastName"].ToString());
                    this.listBox1.Items.Add(aMember);
                }
                dbReader.Close();
                dbConn.Close();
            }
            catch (System.Exception exc)
            {
                this.lblErrorMsg.Text = exc.Message;
            }
        }

        private void DbGUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'memberDataSet.memberTable' table. You can move, or remove it, as needed.
            this.memberTableTableAdapter.Fill(this.memberDataSet.memberTable);

        }
    }
}