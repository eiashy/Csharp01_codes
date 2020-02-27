using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_30_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 10;
            int[] arr = new int[SIZE];
            int i,count=0;
            for (i = 0; i < SIZE; i++)
            {
                Console.WriteLine($"enter numbers {i+1} of {SIZE}");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < SIZE; i++)
            {
                if (arr[i] == 8) 
                {
                    count++;
                    Console.WriteLine($"the counter of the number=8 is {count} and the index is {i}");
                }             
            }
        }
    }
}
