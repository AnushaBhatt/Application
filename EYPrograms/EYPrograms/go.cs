//using System;

//namespace EYPrograms
//{
//    class ar
//    {
//        int[] arr = new int[10];
//        arr[0] = 1;
//        arr[1] = 2;
//            arr

//    }
////}
//multidimensional or double
using System;

class eyclass
{
    static void Main(string[] args)
    {
        Console.WriteLine("First matrix is:");
        int[,] arr1 = new int[2, 2];
        int i, j;
        arr1[0, 0] = 2;
        arr1[0, 1] = 3;
        arr1[1, 0] = 7;
        arr1[1, 1] = 6;
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.Write(arr1[i, j] + "  ");
            }
            Console.WriteLine();

        }
        Console.WriteLine("Second matrix is:");
        int[,] arr2 = new int[2, 2];
        
        arr2[0, 0] = 2;
        arr2[0, 1] = 4;
        arr2[1, 0] = 10;
        arr2[1, 1] = 7;

        for (i = 0; i< 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.Write(arr2[i, j] + "  ");
            }
            Console.WriteLine();

        }
        Console.WriteLine("Result of addition is: ");
        
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.Write(arr1[i, j] + arr2[i, j] + "  ");

            }
            Console.WriteLine();
        }

        
            Console.ReadLine();
        }

    }
