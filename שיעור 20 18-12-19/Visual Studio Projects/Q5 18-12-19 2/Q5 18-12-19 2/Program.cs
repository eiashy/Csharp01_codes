using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_18_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, i, j;
            Console.WriteLine("enter number to print * up 0");
            size = int.Parse(Console.ReadLine());
            while (size <= 0)
            {
                Console.WriteLine("try agin , enter number to print * up 0");
                size = int.Parse(Console.ReadLine());
            }
            for (i = size; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
        }
    }
}
