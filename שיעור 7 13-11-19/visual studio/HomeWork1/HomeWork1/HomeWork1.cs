using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class HomeWork1
    {
        static void Main(string[] args)
        {
            int num1, num2, num3,  number;
            double numstk;
            Console.WriteLine("enter the number 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number 3");
            num3 = int.Parse(Console.ReadLine());
            number = num1 * 100 + num2 * 10 + num3;
            numstk = Math.Pow(num1, 3) + Math.Pow(num2, 3) + Math.Pow(num3, 3);
            if (numstk == number)
                Console.WriteLine($"the number {number} is stekles");
            else
                Console.WriteLine($"the number {number} is no");
        }
    }
}
