using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

namespace WebApplication2
{
    public partial class ADO1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection
                ("Data source=Lab-Host\\SQLEXPRESS03;Initial Catalog= e_commerce; Integrated Security=True ");
            con.open();
            Response.Write("Connection is success");
        }
    }
}