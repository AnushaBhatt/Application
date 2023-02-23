//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EYPrograms
//{
//    class Class6
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Matrix is:");
//            int[,] arr1 = new int[2, 2];
//            int i, j;
//            arr1[0, 0] = 2;
//            arr1[0, 1] = 3;
//            arr1[1, 0] = 7;
//            arr1[1, 1] = 6;
//            for (i = 0; i < 2; i++)
//            {
//                for (j = 0; j < 2; j++)
//                {
//                    Console.Write(arr1[i, j] + "  ");
//                }
//                Console.WriteLine();
//            }
//            int a = 0;
            
//            for(i=0; i<=1; i++)
//            {
                
//                a = arr1[i, i] + a;
               
//            }
//            Console.WriteLine("Addition of principal diagonal elements is: "+a);
//            int b = 0;
//                for(i=0; i<=1; i++)
//                {
//                    for(j=0; j<=1;j++)
//                    {
//                        b = arr1[i, j] + b;

//                    }
//                }
//            Console.WriteLine("Addition of all elements in the matrix is: " + b);

//            Console.ReadLine();
          
//        }
        
//    }
    
//}
