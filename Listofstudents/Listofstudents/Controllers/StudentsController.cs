using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Listofstudents.Models;
namespace Listofstudents.Controllers
{
    public class StudentsController : ApiController
    {
         List<Student> students  = new List<Student>
            {
            new Student {Id = 1, name = "anusha", gender="female"},
            new Student {Id = 2, name = "anshila", gender="female"},
            new Student { Id = 3, name = "ranjan", gender = "male" }
};
public IEnumerable<Student> Get()
{
    return students;
}
    }
}
