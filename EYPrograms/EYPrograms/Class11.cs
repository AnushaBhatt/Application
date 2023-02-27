////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace EYPrograms
////{
////    class india
////    {
////        static int custid = 100;
////        static string custname;

////        public void display()//by default all member functions are private
////        {
////            Console.WriteLine("Customer id is: " + custid);
////        }
////    }//if we keep void display it is not able to access elements 
////    class UK
////    {
////        protected int empid;
////        protected string empname;
////    }
////    class US
////    {
////        public int studid=10;
////        public string studname;
////    }
////    class Class11
////    {
////        static void Main(string[] args)
////        {
////           india obj1 = new india();
////          obj1.display();

////           // UK obj2 = new UK();
////           // obj2.//cannot access

////                US obj3 = new US();
////            obj3.studid = 7 ;
////            Console.ReadLine();
////        }
////    }
////}
////single level inheritance
//using System;

//class vehicle // parent class 
//{
//    public void vehiclecolor()
//    {
//        Console.WriteLine("car colors available are : green, blue, red");

//    }
//}
//class car : vehicle  //hierarchial inheritance
//{
//    public void musicsystem()
//    {
//        Console.WriteLine("Adding music system inside jeep");
//    }
//}
//class scooter : car //scooter is child class and its multilevel inheritence
//{
//    public void wheel()
//    {
//        Console.WriteLine("car has two wheels");
//    }
//}
//class jeep : car  //car is child class
//{
//    public void carcolor()
//    {
//        Console.WriteLine("car colors available are : blue, red");
//    }
//}
//class myclass
//{
//    static void Main(string[] args)
//    {
//        jeep obj = new jeep();
//        obj.carcolor();
//        obj.vehiclecolor();
//        obj.musicsystem();
//        Console.ReadLine();
//    }
//}

//access specifiers with inheritence
using System;
class india
{
    protected indiaid = 34;
        public void function1()
    {
        Console.WriteLine("india class--function1()-- indiaid is " + indiaid);

    }

}
class bangalore : india
{
    int bangid = 10;
    public void function2()
    {
        Console.WriteLine("bangalore class--function2()-- bangid is " + bangid);
    }
}
class tumkur : bangalore
{
    int tumkurid = 10;
    public void function3()
    {
       Console.WriteLine("tumkur class--function3()-- tumkurid is " + tumkurid);
    }
}
class mysore: india
{
    static void Main(string[] args)
    {

    }
}
