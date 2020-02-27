using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_26_12_19
{
    class Program
    {
        static void TwoNumForDiv(int num1, int num2)
        {
            Console.WriteLine($"the div of the tow numbers is {(double)num1/num2:f1}");
            Console.WriteLine($"the div is {num1/num2}");
            Console.WriteLine($"the mod is {num1%num2}");
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("the first number is");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("the first number is");
            num2 = int.Parse(Console.ReadLine());
            TwoNumForDiv(num1, num2);
        }
    }
}
