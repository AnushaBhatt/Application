//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////namespace ConsoleApp1
////{

////    class Employee
////    {
////        public string Name { get; set; }
////        public int EmpId { get; set; }
////}
////        class Worker
////        {
////            public int WId { get; set; }
////            public string City { get; set; }
////        }



////        class Linq3
////        {
////            static void Main(string[] args)
////            {
////                IList<Employee> employeeList = new List<Employee>()
////            {
////                new Employee() { Name="anusha", EmpId= 50 },
//            //    new Employee() { Name="naina", EmpId= 51},
//            //    new Employee() {Name="rajan", EmpId= 52 },
//            //    new Employee() { Name="ira", EmpId= 53}

//            //                };
//            //    IList<Worker> WorkerList = new List<Worker>()
//            //{
//            //    new Worker() { WId=50, City="kolkata" },
//            //    new Worker() { WId=51, City="kolkata"},
//            //    new Worker() {WId=52, City="raipur" },
//            //    new Worker() { WId=53, City="delhi"}

//            //                };

//            //    var resultDefaultIfEmpty = from emp in employeeList
//            //                               join
//            //                               wor in WorkerList
//            //                               on emp.EmpId equals wor.WId
//            //                               into resultempworker


//            //                               from output in resultempworker.DefaultIfEmpty
//            //                               select new
//            //                               {
//            //                                   EmployeeName = emp.Name,
//            //                                   City = output != null ? output.City : null

////                                           };
////                foreach(var e in resultDefaultIfEmpty)
////                        {
////                    Console.WriteLine("Name: " + e.EmployeeName + "City is: " + e.City);
////                }



////            }
////        }
////    }
////}

////inner join or join
//class Employee1
//{
//    public int empid { get; set; }
//    public string name { get; set; }
//    public string language { get; set; }


//}

//class Employee2
//{
//    public int empid { get; set; }
//    public int salary { get; set; }
//}
//class cfg
//{
//    static void Main(string[] args)
//    {
//        List<Employee1> employee1List = new List<Employee1>()
//            {
//                new Employee1() { empid=1, name="anu", language="c#" },
//    new Employee1() { empid=2, name="naina", language="c"},
//    new Employee1() {empid=3, name="tema", language="java" },
//    new Employee1() { empid=4, name="rajan", language="python"}

//                        };
//        List<Employee2> employee2List = new List<Employee2>()
//            {
//                new Employee2() { empid=1, salary=45600 },
//    new Employee2() { empid=2, salary=78000},
//    new Employee2() {empid=3, salary=21000 },
//    new Employee2() { empid=4, salary=56000}

//                        };
//        //        //query syntax
//        //        var res = from e1 in employee1List
//        //                  join e2 in employee2List
//        //on e1.empid equals e2.empid
//        //                  select new
//        //                  {
//        //                      Emp_Name = e1.name,
//        //                      Emp_Language = e1.language,
//        //                      Emp_Salary = e2.salary
//        //                  };
//        //        foreach(var i in res)
//        //        {
//        //            Console.WriteLine("Name is:" + i.Emp_Name + "   " + "Language is: " + i.Emp_Language+  "  "+ "Salary is:"+i.Emp_Salary );
//        //        }

//        //left join
//        //var result = from e in employee1List
//        //             join d in employee2List
//        //             on e.empid equals d.empid into empids

//        //             from ed in empids.DefaultIfEmpty()
//        //             select new
//        //             {
//        //                 EmployeeName = e.name,
//        //                 Language = ed == null ? "No Language" : e.language
//        //             };

//        //foreach(var i in result)
//        //{
//        //    Console.WriteLine("Name is: " + i.EmployeeName + "  " + "Language is: " + i.Language);
//        //}
//        //cross join
//        //using query syntax

//        //var res = from first in employee1List
//        //          from second in employee2List
//        //          select new
//        //          {
//        //              Employee_name = first.name,
//        //              Salary = second.salary
//        //          };
//        //foreach(var i in res)
//        //{
//        //    Console.WriteLine("Name: " + i.Employee_name + "   " + "Salary is: " + i.Salary);
//        //}
//        string[] count1 = { "uk", "india", "india ", "china" };
//        string[] count2 = { "usa", "india", "germany ", "china" };
//        var result = count1.Union(count2);

//        foreach(var i in result)
//        {
//            Console.WriteLine("Union item is: "+i);
//        }

//        var result1 = count1.Intersect(count2);

//        foreach (var i1 in result1)
//        {
//            Console.WriteLine("Intersect item is: "+i1);
//        }


//        string[] arr1 = { "anu", "niresh", "chen" };
//        string[] arr2 = { "anu", "niresh", "zen" };

//        var result3 = arr1.Except(arr2);
//        foreach (var i4 in result3)
//        {
//            Console.WriteLine("Except item is: "+i4);
//        }
//        Console.ReadLine();
//    }
//}
