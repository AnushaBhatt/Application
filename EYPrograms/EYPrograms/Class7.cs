//using System;
//using System.Collections.Generic;


//namespace EYPrograms
//{
//    class Class7
//    {
//        static void Main(string[] args)
//        {
//            //Stack<string> s1 = new Stack<string>();
//            //s1.Push("aa");
//            //s1.Push("bb");
//            //s1.Push("cc");
//            //s1.Push("dd");

//            //Console.WriteLine("Stack(strings) elements are: ");
//            //foreach (var item in s1)
//            //{
//            //    Console.WriteLine(item);
//            //}
//            //Stack<int> sl1 = new Stack<int>();
//            //sl1.Push(11);
//            //sl1.Push(12);
//            //sl1.Push(13);
//            //sl1.Push(14);

//            //Console.WriteLine("Stack (int) elements are: ");
//            //foreach (var item in sl1)
//            //{
//            //    Console.WriteLine(item);
//            //}
//            //Queue<string> s2 = new Queue<string>();
//            //s2.Enqueue("aa");
//            //s2.Enqueue("bb");
//            //s2.Enqueue("cc");
//            //s2.Enqueue("dd");

//            //Console.WriteLine("Queue(strings) elements are: ");
//            //foreach (var item in s2)
//            //{
//            //    Console.WriteLine(item);
//            //}
//            //Queue<int> sl2 = new Queue<int>();
//            //sl2.Enqueue(11);
//            //sl2.Enqueue(12);
//            //sl2.Enqueue(13);
//            //sl2.Enqueue(14);

//            //Console.WriteLine("Queue (int) elements are: ");
//            //foreach (var item in sl2)
//            //{
//            //    Console.WriteLine(item);
//            //}

//            LinkedList<int> l = new LinkedList<int>();
            
//            l.AddFirst(9);
//            l.AddLast(8);
//            l.AddLast(7);
//            l.AddLast(6);
//            var node2 = l.Find(7);
//            l.AddBefore(node2, 10);
//            var node1 = l.AddLast(5);
//            l.AddBefore(node1, 11);
//            Console.WriteLine("LinkedList (int) elements are: ");
//            foreach (var item in l)
//            {
//                Console.WriteLine(item);
//            }
//            Console.ReadLine();
//        }
//    }
//}
