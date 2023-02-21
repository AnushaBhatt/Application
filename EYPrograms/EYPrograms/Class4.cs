////using System;

////namespace EYPrograms
////{
////    class Class4
////    {
////        static void Main(string[] args)
////        {
////            //const float pi = 3.142f;
////            //float pi1 = 3.142f;

////            //Console.WriteLine("pi :" + pi);
////            //Console.WriteLine("pi1 :" + pi1);
////            //Class4 obj = new Class4();
////            //obj.function1();
////            //function2();
////            //function3();
////            Type t1 = typeof(Class4);
////            Console.WriteLine(t1.Name);
////            Console.WriteLine(t1.FullName);
////            Console.ReadLine();
////        }
////        //public void function1()
////        //{
////        //    const float pi = 4.5678f;
////        //    Console.WriteLine("pi value inside function1()" + pi);
////        //}
////        //public static void function2()
////        //{
////        //    Console.WriteLine("static void function2() is invoked");
////        //}
////        //static void function3()
////        //{
////        //    Console.WriteLine("static void function3() is invoked");
////        //}
////    }
////}
////using System;

////class myclass1 {}
////class myclass2 {}

////class MyClass
////{
////    static void Main(string[] args)
////    {
////        myclass1 myclass1 = new myclass1();
////        myclass2 myclass2 = new myclass2();

////        test(myclass1);
////        test(myclass2);

////        Console.ReadLine();

////    }
////    static void test(object obj)
////    {
////        myclass1 obj1;
////        myclass2 obj2;

////        if (obj is myclass1)
////        {
////            Console.WriteLine("obj is myclass1");
////            obj1 = (myclass1)obj;

////        }
////        else if (obj is myclass2)
////        {
////            Console.WriteLine("obj is myclass2");
////            obj2 = (myclass2)obj;
////        }
////        else
////        {
////            Console.WriteLine("obj is neither class1 and neither class2");
////        }


////    }
////}
//// as operator
////using System;

////class Class1 { }
////class Class2 { }
////class IsTest
////{
////    public static void Main()
////    {
////        object[] myObjects = new object[6];
////        myObjects[0] = new Class1();
////        myObjects[1] = new Class2();

////        myObjects[2] = "string";
////        myObjects[3] = 32;
////        myObjects[4] = null;

////        for (int i = 0; i < myObjects.Length; i++)
////        {
////            string s = myObjects[i] as string;

////            Console.WriteLine("{0}:", i);

////            if (s != null)
////                Console.WriteLine("'" + s + "'");
////            else
////                Console.WriteLine("not a string");
////        }
////        Console.ReadKey();
////    }
////}
////dynamic keyword
//using System;
    

//class myclass
//{
//    static void Main(string[] args)
//    {
//        //dynamic var1 = 100;
//        //Console.WriteLine(var1);

//        //dynamic var2 = "anusha";
//        //Console.WriteLine(var2);

//        //var myvalue = 10;
//        //myvalue = "Hello World";//error
////boxing--vale type to reference type
//        int a = 10;
//        object b = a;
//        Console.WriteLine(b);
//        //unboxing--reference type to value type
//        object c = 100;
//        Console.WriteLine(c);
//        int d = (int)c;
//        Console.WriteLine(d);
//        Console.ReadLine();
//    }
//}
