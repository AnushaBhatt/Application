using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console4_DatabaseApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var con= new e_commerceEntities())
            {
                var result = con.student;
                foreach(var item in result)
                {
                    Console.WriteLine("student id is: " + item.studid);
                    Console.WriteLine("student name is: " + item.name);
                    Console.WriteLine("student city is: " + item.city);
                    Console.WriteLine("student mobile is: " + item.mobile);

                }
                Console.ReadLine();
            }

        }
    }
}
