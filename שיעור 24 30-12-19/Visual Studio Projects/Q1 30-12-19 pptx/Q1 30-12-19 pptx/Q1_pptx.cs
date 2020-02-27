using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_30_12_19_pptx
{
    class Q1_pptx
    {
        static void Main(string[] args)
        {
            const int SIZE = 8;
            int i;
            int[] arr = new int[SIZE];
            for (i = 0; i < SIZE; i++)
            {
                Console.WriteLine($"enter number {i+1} of {SIZE}");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("******************************************************************");
            for (i = 0; i < SIZE; i++)
            {
                Console.WriteLine($"the number of the index {i + 1} is {arr[i]}");
            }
            Console.WriteLine("******************************************************************");
            for (i = 0; i < SIZE; i++)
            {
                if(arr[i]%2==0)
                    Console.WriteLine($"the index is {i+1} and the number {arr[i]} is even");
            }
            Console.WriteLine("******************************************************************");
            for (i = 0; i < SIZE; i++)
            {
                if(arr[i]>=0)
                    Console.WriteLine($"the index is {i + 1} and the number {arr[i]} is up with 0");
            }
            Console.WriteLine("******************************************************************");
            for (i = SIZE-1; i >=0; i--)
            {
                Console.WriteLine($"the number of the index {i + 1} is {arr[i]}");
            }
            Console.WriteLine("******************************************************************");
            arr[0] = 5;
            arr[SIZE - 1] = 100;
            for (i = 0; i < SIZE; i++)
            {
                Console.WriteLine($"the number of the index {i + 1} is {arr[i]}");
            }
            Console.WriteLine("******************************************************************");
        }
    }
}
