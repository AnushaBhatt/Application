using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] arr = { "anusha", "harshit", "bhoomika", "anvita" };
            //var query1 = from i in arr
            //             select i;
            //Console.WriteLine("Enter names of students");
            //foreach(var item in query1)
            //{
            //    Console.WriteLine(item);
            //}

            //var query2 = from i in arr
            //             where i.Contains('a')
            //             select i;

            //Console.WriteLine("Enter names of students contains 'a' ");
            //foreach (var item in query2)

            //{
            //    Console.WriteLine(item);
            //}

            //var query3 = from i in arr
            //             where i.StartsWith("a")
            //             select i;
            //Console.WriteLine("Enter names of students starts with 'a' ");
            //foreach (var item in query3)
            //{
            //    Console.WriteLine(item);
            //}
            //var query5 = from i in arr
            //             where i.Length==4
            //             select i;
            //Console.WriteLine("Enter names of students" );
            //foreach (var item in query5)
            //{
            //    Console.WriteLine(item);
            //}



            //var query4 = from i in arr
            //             where i.Distinct<>

            //             select i;
            //Console.WriteLine("Enter names of students");
            //foreach (var item in query1)
            //{
            //    Console.WriteLine(item);
            //}
            
            int[] arr = { 1, 5, 7, 23, 76, 98, 90, 35, 28, 67 };
            var query1 = from i in arr
                             // where i >= 40
                        where i >7 && i<=100 
                        
                         select i;
            foreach(var item in query1)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
       
    }
    
}
