using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_1_1_2020
{
    class Program
    {
        static int[] initArr(int size)
        {
            int[] arr = new int[size];
            int i;
            for (i = 0; i < size; i++)
            {
                Console.WriteLine($"enter number {i+1} of {size}");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static void Main(string[] args)
        {
            const int SIZE = 10;
            int sum = 0;
            int[] arr = initArr(SIZE);
            foreach(int num in arr)
            {
                sum += num;
            }
            Console.WriteLine($"the sum of the numbers is {sum}");
        }
    }
}
