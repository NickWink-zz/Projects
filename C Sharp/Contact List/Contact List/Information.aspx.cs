using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;


namespace Contact_List
{
    public partial class ContactList : System.Web.UI.Page
    {
        //director gridview
        string sConn;
        SqlConnection connDB;
        SqlCommand sCommnd;
        SqlDataAdapter sData;
        DataSet ds;
        SqlCommandBuilder sBuild;

        //faculty gridview
        string sConnFaculty;
        SqlConnection connFaculty;
        SqlCommand sCommndFaculty;
        SqlDataAdapter sDataFaculty;
        DataSet cf;
        SqlCommandBuilder sBuildFaculty;


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string sConn;
                sConn = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\RawMX\Desktop\CIS262AD\Contact List\Contact List\App_Data\InstructorsRecords.mdf;Integrated Security=True"; //connection string *may need to be updated to reflect as local file. 
                connDB = new SqlConnection(sConn); //connect to sql

                connDB.Open();

                sCommnd = connDB.CreateCommand();

                sCommnd.CommandText = "SELECT * FROM Instructor"; //SQL command

                sData = new SqlDataAdapter("SELECT * FROM Instructor", connDB); //get data from the customer table

                sBuild = new SqlCommandBuilder(sData);

                ds = new DataSet();

                sData.Fill(ds);

                this.GridViewDirector.DataBind();
                
                
            }
            catch (Exception)
            {
               
            }

            connDB.Close();

            //faculty gridview
            try
            {
                string sConnFaculty;
                sConnFaculty = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\RawMX\Desktop\CIS262AD\Contact List\Contact List\App_Data\InstructorsRecords.mdf;Integrated Security=True";
                connFaculty = new SqlConnection(sConnFaculty);

                connFaculty.Open();

                sCommndFaculty.CommandText = "SELECT * FROM CourseFaculty"; //SQL Command

                sDataFaculty = new SqlDataAdapter("SELECT * FROM CourseFaculty", connFaculty);

                sBuildFaculty = new SqlCommandBuilder(sDataFaculty);

                cf = new DataSet();

                sDataFaculty.Fill(cf);

                this.GridViewFaculty.DataBind();
            }
            catch (Exception)
            {

            }
            connFaculty.Close();
        }

        
    }
}