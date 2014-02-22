using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCalc
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double firstNum, secondNum;
            double sum = 0;

            firstNum = double.Parse(TextBox1.Text);
            secondNum = double.Parse(TextBox2.Text);

            sum = firstNum + secondNum;

            TextBox3.Text = string.Format("Your total added is: {0}", sum).ToString();


        }
    }
}