using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web_Application.Controllers
{
    public class EYController : Controller
    {
        public IActionResult Index(int id)
        {
            ViewBag.ID = id; 
            return View();
        }

        public IActionResult mypage()
        {
            return View();
        }

        public IActionResult employeedetail;

    }
}
