using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_04_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, size, i;
            Console.WriteLine("enter how many times you need");
            size = int.Parse(Console.ReadLine());
            while (!(size>0))
            {
                Console.WriteLine("enter how many times you need");
                size = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < size; i++)
            {
                Console.WriteLine("enter the first number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the last number");
                num2 = int.Parse(Console.ReadLine());
                if (num1 == num2)
                    Console.WriteLine("the two numbers equal");
                else
                    if (num1 > num2)
                        Console.WriteLine($"{num1}");
                    else
                        Console.WriteLine($"{num2}");
            }
        }
    }
}
