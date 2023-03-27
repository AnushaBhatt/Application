//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;
//namespace ConsoleApp1
//{
//    //class Linq1
//    //{
//    //    static void Main(string[] args)
//    //    {


//    //int[] number = { 3, 54, 87, 34, 5, 9, 24 };
//    //var result = number.Where((n, i) => ((n % 3 == 0) && (i >= 5)));//if we take same variable then checking for both condition
//    ////if we take diff then(first one number, second one index)
//    //foreach (var e in result)
//    //{
//    //    Console.WriteLine(e);
//    //}

//    //string[] words = { "oak", "tree", "ink", "waterfal" };
//    ////normal method
//    //Console.WriteLine("Elements at position 2: " + words.ElementAt(2));
//    //Console.WriteLine("Elements at first position: " + words.First());
//    //Console.WriteLine("Elements at last position: " + words.Last());

//    ////using lambda expression
//    //foreach (var e in words)
//    //{
//    //    Console.WriteLine("words.(word => word.length==3): " + words.First(word => word.Length == 3));
//    //}

//    //int[] vals = { 2, 3, 4, 5, 6 };

//    //vals.Prepend(0);
//    //vals.Append(4);
//    ////if we just write the above two it will not work
//    //var vals2 = vals.Prepend(0);
//    //var vals3 = vals.Append(4);
//    //Console.WriteLine(string.Join(" , ", vals2));

//    //var powered = vals.Select(e => Math.Pow(e, 2));
//    //Console.WriteLine(string.Join(" , ", powered));

//    ////string.join can only be accessed by creating an object

//    //TypeOf

//    //class student
//    //{
//    //    public int studentid { get; set; }
//    //    public string studentname { get; set; }
//    //}

//    //class cfg
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        IList mixedList = new ArrayList();

//    //        mixedList.Add(0);
//    //        mixedList.Add("One");
//    //        mixedList.Add("Two");
//    //        mixedList.Add(3);
//    //        mixedList.Add(4.5f);
//    //        mixedList.Add(6.9f);
//    //        mixedList.Add('f');
//    //        mixedList.Add('h');

//    //        mixedList.Add(new student() { studentid = 1, studentname = "anusha" });
//    //        var stringresult = from s in mixedList.OfType<string>()
//    //                           select s;
//    //        var intResult = from s in mixedList.OfType<int>()
//    //                        select s;
//    //        var floatResult = from s in mixedList.OfType<float>()
//    //                        select s;

//    //        //foreach (var e in intResult)
//    //        //{
//    //        //    Console.WriteLine(e);
//    //        //}
//    //        foreach (var e in floatResult)
//    //        {
//    //            Console.WriteLine(e);
//    //        }//print using foreach loop

//    //        //Console.WriteLine(String.Join(" ,",stringresult));//print using stringjoin


//    //selectmany
//    //class cfg
//    //{
//    //    static void Main(string[] args)
//    //    {




//    //int[][] vals =
//    //{
//    //    new[] {1, 2, 3},
//    //    new[] {4},
//    //    new[] {4, 7, 8, 40}
//    //};
//    //var res = vals.SelectMany(a => a).OrderByDescending(x => x);//by default its ascending like sql
//    //Console.WriteLine(string.Join(" , ", res));
//    //        Console.ReadLine();
//    //    }
//    //}
//    //}
//    //thenby
//    class Student
//    {
//        public int StudentId { get; set; }

//        public string StudentName { get; set; }

//        public int Age { get; set; }
//    }

//    class Linq2
//    {
//        static void Main(string[] args)
//        {
//            IList<Student> studentList = new List<Student>()
//            {
//                new Student() { StudentId = 1, StudentName = "anusha", Age = 23 },
//                new Student() { StudentId = 2, StudentName = "ranjan", Age = 45 },
//                new Student() { StudentId = 3, StudentName = "rupa", Age = 18 },
//                new Student() { StudentId = 4, StudentName = "nandani", Age = 50 }

//            };
//            var thenbyresult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);
//            foreach (var e in thenbyresult)
//            {
//                Console.WriteLine("Name is:" + e.StudentName + "and Age is: " +e.Age);
//            }
//            Console.ReadLine();
//        }
//    }
//}


////           
////    }
////    }
////}
