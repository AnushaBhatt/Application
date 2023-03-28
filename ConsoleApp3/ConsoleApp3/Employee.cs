using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_codefirst__EFDemo
{

    class Employee
    {
        public Employee()
            {
            }
    [Key]
    public int empid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    
    }
}
