using System;
using System.Web.UI;
using ConsoleApp1.
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.WebService1SoapClient c2 = new ServiceReference1.WebService1SoapClient();

            Console.WriteLine("Enter first number");

            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int n2 = int.Parse(Console.ReadLine());


            int result = (c2.addition(n1, n2)).ToString();
            Console.WriteLine("Result is: "+result);

            Console.ReadLine();
        }
    }
}
