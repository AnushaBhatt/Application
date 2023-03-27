using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class linq1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source = Lab - Host\SQLEXPRESS03;Initial Catalog = e_commerce; Integrated Security = True");
        con.Open();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
        }
    }
}