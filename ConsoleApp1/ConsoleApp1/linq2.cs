//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//////namespace ConsoleApp1
//////{
//////    //class linq2
//////    //{
//////    //    static void Main(string[] args)
//////    //    {
//////    //        string[] countries = { "UK", "US", "India", "China" };
//////    //        int[] number = { 45, 12, 5, 89 };


//////    //        List<string> countryarray = countries.ToList();
//////    //        int[] numarray= number.ToArray();



//////    //        foreach (var item in countryarray)
//////    //        {
//////    //            Console.WriteLine(item);
//////    //        }
//////    //loopup
//////    class Employee
//////    {
//////        public string Name { get; set; }

//////        public string Department { get; set; }

//////        public string Country { get; set; }
////    }

////    class cfg
////    {
////        static void Main(string[] args)
////        {
////            List<Employee> objEmployee = new List<Employee>()
////                    {
////                        new Employee { Name= "anusha", Department= "IT",  Country="India"},
////                        new Employee { Name= "nayan", Department= "IT", Country="India"},
////                        new Employee { Name= "vandana", Department= "Sales", Country="India"},
////                        new Employee { Name= "rashia", Department= "Marketing", Country="China"}
////                    };
////            //        var Emp = objEmployee.ToLookup(x => x.Department);

////            //        Console.WriteLine("Grouping employees by dept");
////            //        foreach(var a in Emp)
////            //        {
////            //            Console.WriteLine(a.Key);//within this key all the departments are stored 
////            //            foreach(var item in Emp[a.Key])//using this box bracket other details about that particular department is extracted
////            //            {
////            //                Console.WriteLine("\t" + item.Name + "\t" + item.Department + "\t" + item.Country);
////            //            }
////            //        }
////            var emp = objEmployee.ToDictionary(x => x.Name, x => x.Department);
////            foreach(var item in emp)
////            {
////                Console.WriteLine(item.Key + "\t" + item.Value);
////            }


////            Console.ReadLine();
////        }
////}
////    }


////IEnu demo
////
////using System;
////using System.Collections;
////using System.Collections.Generic;
////using System.Linq;


////namespace IenumerableandIenumerator
////{
////    class Product: IEnumerable
////    {
////        public string[] ProductList = new string[5];
////        int index = 0;

////        public void AddProduct(string product)
////        {
////            ProductList[index++] = product;
////        }
////        public void RemoveProduct(int index)
////        {
////            ProductList[index] = "";
////        }
////        public IEnumerator GetEnumerator()
////        {
////            return new ProductEnumerator();
////        }

////        class ProductEnumerator: IEnumerator
////        {

////            public object Current => throw new NotImplementedException();

////            public bool MoveNext()
////            {
////                throw new NotImplementedException();
////            }

////            public void Reset()
////            {
////                throw new NotImplementedException();
////            }
////        }

////        public bool MoveNext()
////        {
////            throw new NotImplementedException();
////        }

////        public void Reset()
////        {
////            throw new NotImplementedException();
////        }

////        public void RemoveProduct()
////        {
////            throw new NotImplementedException();
////        }
////    }
////}
//class program
//{
//    static void Main(string[] args)
//    {
//        ////Product p1 = new Product();
//        ////p1.AddProduct("mouse");
//        ////p1.AddProduct("keyboard");
//        ////p1.RemoveProduct(0);
//        ////Console.WriteLine("Product are: ");
//        ////foreach(var item in p1.ProductList)
//        ////{
//        ////    Console.WriteLine(item);
//        ////}
//        ////cast operator
//        //ArrayList obj = new ArrayList();
//        //obj.Add("India");
//        //obj.Add("China");
//        //obj.Add("Us");
//        //obj.Add("Uk");


//        //IEnumerable<string> result = obj.Cast<string>();
//        //foreach(var item in result)
//        //{
//        //    Console.WriteLine(item);
//        //}

//        //string[] obj = { "anu", "dia", "naina", "ben" };
//        //string[] obj1 = {"den" };
//        //var result = obj.ElementAtOrDefault(2);
//        //Console.WriteLine("Element at required position: " + result);
//        // //var result1 = obj1.DefaultIfEmpty();
//        //Console.WriteLine("Element at required position: " + obj1.DefaultIfEmpty());
//        //Console.ReadLine();
//    }
//}
  