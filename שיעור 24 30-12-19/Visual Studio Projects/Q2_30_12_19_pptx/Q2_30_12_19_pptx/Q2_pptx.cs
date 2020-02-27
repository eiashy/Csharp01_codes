using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_30_12_19_pptx
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 6;
            int i;
            int[] arr = new int[SIZE];
            for (i = 0; i < SIZE; i++)
            {
                Console.WriteLine($"enter number in the index {i+1} of {SIZE}");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("*****************************************************************************");
            for (i = 0; i < SIZE; i++)
            {
                if(i%2==0)
                    Console.WriteLine($"the even index is {i+1} and the number is {arr[i]}");
            }
            Console.WriteLine("*****************************************************************************");
            for (i = 0; i < SIZE; i++)
            {
                if (arr[i] < 0)
                    Console.WriteLine($"the nig index is {i}");
            }
            Console.WriteLine("*****************************************************************************");
        }
    }
}
