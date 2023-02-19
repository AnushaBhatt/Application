using System;


namespace EYPrograms
{
    class Class3
    {
        struct Book
        {
            public int bookid;
            public string title;
            public int bookprice;
        }
        class MyClass
        {
            static void Main(string[] args)
            {
                Book b1 = new Book();
                b1.bookid = 101;
                b1.title = "c# book1";
                b1.bookprice = 800;

                Book b2 = new Book();
                b2.bookid = 101;
                b2.title = "c book2";
                b2.bookprice = 1800;

                Console.WriteLine("Book1 details");
                Console.WriteLine(b1.bookid);
                Console.WriteLine(b1.title);
                Console.WriteLine(b1.bookprice);
                Console.WriteLine("Book2 details");
                Console.WriteLine(b2.bookid);
                Console.WriteLine(b2.title);
                Console.WriteLine(b2.bookprice);
                Console.ReadLine();
            }
        }
    }
}
