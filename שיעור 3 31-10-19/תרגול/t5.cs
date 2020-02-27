using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_10_2019cSharp
{
    class t5
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, diff1 = 0, diff2=0;
            Console.Write("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            num3 = int.Parse(Console.ReadLine());
            diff1 = num1 * num2 - num3;
            diff2 = num2 * num3 - num1;
            Console.WriteLine(diff1);
            Console.WriteLine(diff2);

        }
    }
}
