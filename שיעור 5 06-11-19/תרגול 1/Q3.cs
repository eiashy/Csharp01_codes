using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_11_19Q3
{
    class Q3
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("enter the number 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number 3");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(num3);
            Console.WriteLine(num3 + "" + num2);
            Console.WriteLine(num3 + "" + num2 + "" + num1);
        }
    }
}
