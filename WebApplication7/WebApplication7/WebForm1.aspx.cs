using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        class Program
        {
            int studentid;
            string sname;
            string scity;
            int smobile;
        
            protected void Button2_Click(object sender, EventArgs e)
        {
            Program p = new Program();
            Console.WriteLine("Enter student id");
            p.studentid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            p.sname = Console.ReadLine();
            Console.WriteLine("Enter city");
            p.scity = Console.ReadLine();
            Console.WriteLine("Enter mobile");
            p.smobile = Convert.ToInt32(Console.ReadLine());


            DataClasses1DataContext LTS = new DataClasses1DataContext(" Data Source=Lab-Host\\SQLEXPRESS03;Initial Catalog=e_commerce;Integrated Security=True");
           
            obj.studid = p.studentid;
            obj.name = p.sname;
            obj.city = p.scity;
            obj.mobile = p.smobile;

                LTS.SubmitChanges();
            LTS.SubmitChanges(); Console.WriteLine("insert is succesfull");
        }
            protected void Button1_Click(object sender, EventArgs e)
            {
                DataClasses1DataContext LTS = new DataClasses1DataContext(" Data Source=Lab-Host\\SQLEXPRESS03;Initial Catalog=e_commerce;Integrated Security=True");
                var selectquery = from s in LTS
                                  select s;

                foreach (var e in selectquery)
                {
                    Console.WriteLine(e.studid + "\t" + e.name + "\t" + e.city + "\t" + e.mobile);
                }
            }
        }
}