using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_02_01_20
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 5;
            int[] arr1 = new int[SIZE], arr2 = new int[SIZE];
            int i, j;
            Console.WriteLine("arr1:  ");
            for(i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"fill the first arr {i} of {SIZE-1}: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("arr2:  ");
            for (i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine($"fill the last arr {i} of {SIZE - 1}: ");
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int[] arr3 = new int[arr1.Length + arr2.Length];
            for(i=0,j=0;i<arr1.Length;i++,j++)
            {
                arr3[j] = arr1[i];
            }
            for (i = arr2.Length-1; i >=0; i--,j++)
            {
                arr3[j] = arr2[i];
            }
            foreach (int item in arr3)
            {
                Console.Write(item + " | ");
            }
        }
    }
}
