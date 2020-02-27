using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_1
{
    class Program
    {
        static void PrintMaxOfArr(int[] arr)
        {
            int max = 0, i;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine("the max number is : " + max);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 45, 46, 38, 134, 6, 43 };
            PrintMaxOfArr(arr);
        }
    }
}
