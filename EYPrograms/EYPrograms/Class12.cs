////////////////using System;
////////////////using System.Collections.Generic;
////////////////using System.Linq;
////////////////using System.Text;
////////////////using System.Threading.Tasks;
//////////////////implicit interface implementation
////////////////namespace EYPrograms
////////////////{

////////////////    public void remove()
////////////////    {
////////////////        Console.WriteLine("")
////////////////    }
////////////////    class Class12
////////////////    {
////////////////        static void Main(string[] args)
////////////////        {
////////////////            myclass m1 = new myclass();
////////////////            m1.add();
////////////////            m1.remove();
////////////////            m1.clear();
////////////////        }
////////////////    }
////////////////}
////////////////explicit implementation
//////////////using System;

//////////////class myclass : 
//////////////    class Day11
//////////////{
//////////////    static void Main(string[] args)
//////////////    {
//////////////        //myclass m1= new myclass();
//////////////        Imyinterface m2 = new myclass();
//////////////        m2.add();
//////////////        m2.remove();
//////////////        Inewinterface m3 = new myclass();
//////////////        m3.clear();

//////////////        //Imyinterface
//////////////    }
//////////////}
//////////////sealed keyword which helps to stop the inheritance
////////////using System;
////////////sealed class A
////////////{
////////////    public void function1()
////////////    {
////////////        Console.WriteLine("A -- function1()");

////////////    }
////////////}
////////////class myclass
////////////{
////////////    static void Main(string[] args)
////////////    {
////////////        A obj = new A();
////////////        obj.function1();
////////////        Console.ReadLine();
////////////    }
////////////}
////////////constructor
//////////using System;
//////////class myclass
//////////{
//////////    int k = 10;
//////////    int j = 20;
//////////    public myclass()
//////////    {
//////////        Console.WriteLine("Default constructor is invoked");
//////////    }
//////////    public myclass(int a, int b)
//////////    {
//////////        k = a;
//////////        j = b;

//////////    }
//////////    public void display()
//////////    {
//////////        Console.WriteLine("k value is: " + k);
//////////        Console.WriteLine("j value is: " + j);
//////////    }
//////////}
//////////class newclass
//////////{
//////////    static void Main(string[] args)
//////////    {

//////////    }
//////////}
//////////copy constructor
////////using System;
////////class employee
////////{
////////    private string name;
////////    private int age;

////////    public employee(employee emp)
////////    {
////////        name = emp.name;
////////        age = emp.age;

////////    }
////////    public employee(string name, int age)
////////    {
////////        this.name = name;
////////        this.age = age;
////////    }
////////    public void display()
////////    {
////////        Console.WriteLine("Name is: " + name);
////////        Console.WriteLine("Age is: " + age);
////////    }
////////}
////////class newE
////////{
////////    static void Main(string[] args)
////////    {

////////    }
////////}
//////using System;
//////class Geeks
//////{
//////    //variables
//////    public static string name;
//////    public static int num;
//////    //creating private constructor using private keyword
//////    private Geeks()//not accesible
//////    {
//////        Console.WriteLine(" Default constructor is invoked");
//////    }
//////    //default constructor with parameters
//////    public Geeks(string a, int b)
//////    {
//////        name = a;
//////        num = b;
//////    }

//////}
////////driver class
//////class GFG
//////{
//////    static void Main(string[] args)
//////    {
//////        //this line raises error because the constructor is inaccesible
//////        Geeks obj2 = new Geeks("Anusha", 23);
//////        Console.WriteLine(Geeks.name + " , " + Geeks.num);
//////        Console.ReadLine();
//////    }
//////}
//////static constructor
////using System;
////class Account
////{
////    public int id;
////    public string name;
////    public static float rateOfInterest;
////    public Account(int id, String name)
////    {
////        this.id = id;
////        this.name = name;
////        //this.rate
////    }
////    static Account()
////    {
////        rateOfInterest = 9.5f;

////    }
////    public void display()
////    {
////        Console.WriteLine(id + " " + name + " " + rateOfInterest);
////    }
////}

////class TestEmployee
////{
////    public static void Main(string[] args)
////    {
////        Account a1 = new Account(101, "Harshit");
////        Account a2 = new Account(102, "Anusha");

////        a1.display();
////        a2.display();
////        Console.ReadLine();
////    }
////}

////abstract class
//using System;
//abstract class myclass1
//{
//    public abstract void function1();
//    public abstract void function2();
//    public void function3()
//    {
//        Console.WriteLine("Welcome to abstract classes");
//    }
//}

//class  US : myclass1
//{
//    public override void function1()
//    {
//        Console.WriteLine("Us class--- function1()");
//    }
//    public override void function2()
//    {
//        Console.WriteLine("US class---function2()");
//    }
//}

//class india
//{
//    static void Main(string[] args)
//    {
//        US obj = new US();
//        obj.function1();
//        obj.function2();
//        obj.function3();
//        Console.ReadLine();
//    }
//}
//upcasting and downcasting
using System;
public class shape
{
    protected int m_xpos;
    protected int m_ypos;
}

public class square: shape
{
    public square()
    {
    }
    public square(int x, int y): base(x,y)
    { }
    public new void draw()
    {
        Console.WriteLine("drawing a square at {0},{1}", m_xpos, m_ypos);
    }
}

public class circle : shape
{
    public circle()
    { }
    public circle(int x, int y): base(x,y)
    { }
    public new void draw()
    {
        Console.WriteLine("drawing a circle at {0},{1}", m_xpos, m_ypos);
    }
}
public void draw
{
    Console.WriteLine("Drawing a shape at {0},{1}" );
        static void Main(string[] args)
{
    shape sh = new shape(100, 100);
    sh.draw();
    square sq = new square(200, 200);
    sq.draw();
    circle ci = new circle(300, 300);
    ci.draw();

    shape[] shapes = new shape[3];
    shapes[0] = new shape(100, 100);
    shapes[1] = new square(200, 200);
    shapes[2]= new circle(300, 300);

    foreach()
}