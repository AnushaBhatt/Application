using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq_Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void RetrieveUserDetails()
        {
            Data1DataContext dtContext = new Data1DataContext();
            GridView1.DataSource = from customerDetails in dtContext.customer
                                   select customerDetails;
            GridView1.DataBind();

        }
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            RetrieveUserDetails();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (Data1DataContext dtContext = new Data1DataContext()) ;
            {
                customer details = new customer
                {
                    custid = 89;
                custname = "tina";
                custsalary = 8000;
            };
            dtContext.customer.InserObSubmit(details);
            dtContext.SubmitChanges();


                }
        RetrieveUserDetails();

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (Data1DataContext dtContext = new Data1DataContext()) ;
            {
                customer details = dtContext.customer, SingleOrDefault(x => x.custid == 1);
                details.custsalary = 4000;
                dtContext.SubmitChanges();
            }
            RetrieveUserDetails();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (Data1DataContext dtContext = new Data1DataContext()) ;
            {
                customer details = dtContext.customer.SingleOrDefault(x => x.custid == 4);
                dtContext.customer.DeleteOnSubmit(details);
                dtContext.customer.DeleteOnSubmit(details);
                dtContext.SubmitChanges();
            }
            RetrieveUserDetails();

        

        }
    }
}