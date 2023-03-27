using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.Controllers
{
    public class CRUDController : Controller
    {
        // GET: CRUD
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult display()
        {
            DataClasses1DataContext LTS = new DataClasses1DataContext(" Data Source=Lab-Host\\SQLEXPRESS03;Initial Catalog=e_commerce;Integrated Security=True");
            var selectquery = from s in LTS.employeees
                              select s;

            ViewBag.result = selectquery;
            return View();
        }
    }
}