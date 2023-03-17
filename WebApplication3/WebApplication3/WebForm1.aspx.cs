//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//using System.Data;
//using System.Data.SqlClient;

//namespace WebApplication3
//{
//    public partial class WebForm1 : System.Web.UI.Page
//    {
//        SqlConnection con = new SqlConnection("Data Source=Lab-Host\\SQLEXPRESS03;Initial Catalog=e_commerce;Integrated Security=True");
        

//        protected void Button1_Click(object sender, EventArgs e)
//        {
//            //con.Open();
//            //SqlDataAdapter ad = new SqlDataAdapter("select * from student where city='kolkata' ", con);
//            //DataSet ds = new DataSet();
//            //ad.Fill(ds);
//            //GridView1.DataSource = ds;
//            //GridView1.DataBind();
//        }

//        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
//        {

//        }

//        protected void Button2_Click(object sender, EventArgs e)
//        {
//            con.Open();
//                SqlDataAdapter a1 = new SqlDataAdapter("select studid from student where city='kolkata' ", con);
//            SqlDataAdapter a2 = new SqlDataAdapter("select name from student where city='kolkata' ", con);
//            SqlDataAdapter a3 = new SqlDataAdapter("select mobile from student where city='kolkata' ", con);
//            DataSet d1 = new DataSet();
//               a1.Fill(d1);
//               DropDownList1.DataSource = d1;
//            DropDownList1.DataTextField = "studid";
//            DropDownList1.DataBind();

//            DataSet d2 = new DataSet();

//            a2.Fill(d2);
//            RadioButtonList1.DataSource = d2;
//            RadioButtonList1.DataTextField = "name";

//            RadioButtonList1.DataBind();

//            DataSet d3 = new DataSet();

//            a3.Fill(d3);
//            CheckBoxList1.DataSource = d3;
//            CheckBoxList1.DataTextField = "mobile";
//            CheckBoxList1.DataBind();
            
//        }

//        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
//        {

//            //Label1.Text = "selected date is: " + Calendar1.SelectedDate.Date.ToString();//if we want both time and date
//           // Label1.Text = "selected date is: " + Calendar1.SelectedDate.Date.ToShortDateString();//if we want only date
//            Label1.Text = "selected date is: " + Calendar1.SelectedDate.Date.ToShortTimeString();
//        }

//        protected void Button3_Click(object sender, EventArgs e)
//        {
//            Calendar2.Visible = true;
//            Calendar3.Visible = false;
//        }

//        protected void Calendar3_SelectionChanged(object sender, EventArgs e)
//        {
//            TextBox2.Text =  +Calendar3.SelectedDate.ToString();
//        }
//    }
//}