using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_19_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, i, num;
            for (i = 1; i <= 20; i++)
            {
                max = 0;
                Console.WriteLine($" {i} of 20 : enter number from 0");
                num = int.Parse(Console.ReadLine());
                while (num < 0)
                {
                    Console.WriteLine($" {i} of 20 : try agine , enter number from 0");
                    num = int.Parse(Console.ReadLine());
                }
                while (num != 0)
                {
                    if (num % 10 > max)
                        max = num % 10;
                    num /= 10;
                }
                Console.WriteLine($"the max sefra is {max}");
            }
        }
    }
}
