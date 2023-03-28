using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3_codefirst__EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            mydbcontext context = new mydbcontext();
            Employee emp = new Employee() { empid = 1, name = "Anusha", address = "kolkata" };
            context.Employees.Add(emp);
            context.SaveChanges();

            Console.WriteLine("sucess");
            Console.ReadLine();
               

        }
}
}
