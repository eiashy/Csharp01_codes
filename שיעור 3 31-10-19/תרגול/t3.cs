using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_10_2019cSharp
{
    class t2
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine(c);
        }
    }
}
