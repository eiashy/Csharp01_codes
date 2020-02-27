using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_2_06_11_19
{
    class Q3
    {
        static void Main(string[] args)
        {
            int a, b , s;
            double c;
            Console.WriteLine("enter the number a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number b");
            b = int.Parse(Console.ReadLine());
            s = a * b;
            c = Math.Pow(a , 2) + Math.Pow(b , 2);
            c = Math.Sqrt(c);
            Console.WriteLine($"the S is {s} ");
            Console.WriteLine($"the C is {c} ");

        }
    }
}
