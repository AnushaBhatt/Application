using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Exercise_1.Models;
namespace MVC_Exercise_1.Controllers
{
    public class StudentController : Controller
    {
        IList<student> studdetails = new List<student>()
            {
             new student() { studid= 1, studname= "anusha", studmarks=400 },
             new student() { studid= 1, studname= "harsh", studmarks=200 },
            new student() { studid = 1, studname = "anvita", studmarks=400 }


            };
        public ActionResult StudentList ()

        {


            //ViewBag.details = studdetails;
            //return View();
            ViewData["details"] = studdetails;
            return View();
        }
    }
}
