//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class Employee
//    {


//        public int empid { get; set; }
//        public string empname { get; set; }
//        public char empgender { get; set; }
//        public int empsalary { get; set; }


//    }
//    class CFG
//    {
//        static public void Main()
//        {
//            List<Employee> emp = new List<Employee>()
//            {
//             new Employee() { empid= 1, empname= "anusha", empgender= 'f', empsalary=3400 },
//             new Employee() { empid= 1, empname= "harsh", empgender= 'm', empsalary=5000 },
//            new Employee() { empid = 1, empname = "anvita", empgender = 'f', empsalary = 7400 },
//            new Employee() { empid = 1, empname = "bhoomika", empgender = 'f', empsalary = 3000 }

//            };

//            //count the total number of employees
//            //var res = (from i in emp
//            //           select i.empid).Count();
//            //Console.WriteLine("Empids are: " + res);
//            //var res1 = (from i in emp
//            //           select i.empsalary).Max();
//            //Console.WriteLine("Maximum salary: " + res1 );
//            //var res2 = (from i in emp
//            //            select i.empgender).Count();
//            //Console.WriteLine("Number of female: " + res2);

//            //var query1 = from i in emp
//            //             select i.empgender;
//            //Console.WriteLine("Employee details: ");
//            //foreach(var item in query1)
//            //{
//            //    Console.WriteLine(item);
//            //}

//            //iterate select result
//            //foreach (var item in selectResult)
//            //    Console.WriteLine("Employee name: {0}. gender is: {1}", item.Name, item.Gender);

//            //lambda expession
//            var selectResult1 = emp.Select(s => new { Name = s.empname, Gender = s.empgender });
//            foreach (var item in selectResult1)
//            {
//                Console.WriteLine("Employee Name: {0} , Gender is: {1} ", item.Name, item.Gender);
//            }
//            Console.ReadLine();
//        }
       
//    }
//}
