using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_13_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter the farst number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the socnd number");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the last number");
            c = int.Parse(Console.ReadLine());
            if (a <= b && b <= c)
                Console.WriteLine($"the numbers {a} , {b} , {c} is mmoynem");
            else
                Console.WriteLine($"the numbers {a} , {b} , {c} is no mmoynem");
        }
    }
}
