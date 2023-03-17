using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class commands : System.Web.UI.Page
    { 
        SqlConnection con = new SqlConnection("Data source=Lab-Host\\SQLEXPRESS03; Initial Catalog=e_commerce; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select * from subject", con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            insert.Visible = true;
            delete.Visible = false;
            update.Visible = false;
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = int.Parse(txtsubjectid.Text);
            int num = int.Parse(txtmarks.Text);
            SqlCommand cmd = new SqlCommand("insert into subject(subjectid, name, marks) values('" + id + "', '" + txtname.Text + "', '" + num +"')", con);
            cmd.ExecuteNonQuery();

            Response.Write("Insert Sucess");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            insert.Visible = false;
            delete.Visible = true;
            update.Visible = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            insert.Visible = false;
            delete.Visible = false;
            update.Visible = true;
        }

        protected void submit1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cm = new SqlCommand("delete from subject where marks<67 ", con);
            cm.ExecuteNonQuery();

            Response.Write("delete Sucess");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            con.Open();

        }
    }
}