using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_14_11_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("enter the firsy number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the last number");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine($"the big number is {num1}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"the big number is {num2}");
            }
            else
                Console.WriteLine("equal");
        }
    }
}
