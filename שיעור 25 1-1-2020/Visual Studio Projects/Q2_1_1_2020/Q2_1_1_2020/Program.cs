using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_1_1_2020
{
    class Program
    {
        static void PrintArr(int num)
        {
            Console.Write(num + " ");
        }
        static int[] initArr(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = i;
            return arr;
        }
        static void Main(string[] args)
        {
            const int SIZE = 100;
            int[] arr = initArr(SIZE);
            foreach(int num in arr)
            {
                PrintArr(num);
            }
            Console.WriteLine();
        }
    }
}
