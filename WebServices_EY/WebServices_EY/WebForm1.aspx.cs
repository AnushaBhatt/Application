using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServices_EY
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient c1 = new ServiceReference1.WebService1SoapClient();
            

            int n1 = int.Parse(TextBox1.Text);
            int n2 = int.Parse(TextBox2.Text);


            Label3.Text = (c1.addition(n1, n2)).ToString();
            //Label3.Text = (c1.multiplication(n1, n2)).ToString();

        }
    }
}