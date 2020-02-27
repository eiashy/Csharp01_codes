using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_13_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;
            Console.WriteLine("enter the first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the scund number");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third number");
            x = int.Parse(Console.ReadLine());
            if ((a <= x && b >= x) || (b <= x && a >= x))
                Console.WriteLine($"the number {x} in the range");
            else
                Console.WriteLine($"the number {x} not in the range");
        }
    }
}
