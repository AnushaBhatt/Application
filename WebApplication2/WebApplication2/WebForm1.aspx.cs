using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //    int num1 = Convert.ToInt32(TextBox4.Text);
        //    int num2 = Convert.ToInt32(TextBox5.Text);

        //    Response.Write("Addition result is" +(num1+num2));
        //}

        protected void Button1_Click1(object sender, EventArgs e)
        {
           Label6.Text = "Addition result is " + (Convert.ToInt32(TextBox4.Text) + Convert.ToInt32 (TextBox5.Text));
           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label7.Text = "selected city is " + DropDownList1.SelectedItem.Text.ToString();
            //selected value
            //selected item
            //selected index
        }
    }
}