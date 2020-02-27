using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        ////דרך 1
        //static void Main(string[] args)
        //{
        //    int[] A = new int[] { 2, 11, 43, 32, 10 };
        //    int[] B;
        //    B = new int[] { 1, 12, 2, 20, 5 };
        //    int[] C = new int[A.Length + B.Length];
        //    int i;
        //    for (i = 0; i < A.Length; i++)
        //        C[i] = A[i];
        //    for ( int j = 0; i < C.Length; i++, j++)
        //        C[i] = B[j];
        //    foreach (int item in A)
        //    {
        //        Console.Write(item + "\t");
        //    }
        //    Console.WriteLine();
        //    for (i = 0; i < B.Length; i++)
        //    {
        //        Console.Write(B[i]+ "\t");
        //    }
        //    Console.WriteLine();

        //    foreach ( int item in C)
        //    {
        //        Console.Write(item + "\t");
        //    }
        //    Console.WriteLine();
        //}
        //דרך 2
        static void Main(string[] args)
        {
            int[] A = new int[] { 2, 11, 43, 32, 10 };
            int[] B;
            B = new int[] { 1, 12, 2, 20, 5 };
            int[] C = new int[A.Length + B.Length];
            int i;
            for (i = 0; i < B.Length; i++)
            {
                C[i] = A[i];
                C[i + B.Length] = B[i];
            }
           
            foreach (int item in A)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            for (i = 0; i < B.Length; i++)
            {
                Console.Write(B[i] + "\t");
            }
            Console.WriteLine();

            foreach (int item in C)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
    }
}
