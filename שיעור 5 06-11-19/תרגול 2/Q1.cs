using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_2_6_11_19
{
    class Q1
    {
        static void Main(string[] args)
        {
            const int PRICE1=50, PRICE2=1;
            int num1, num2, num3, sum, a;
            Console.WriteLine("enter the farst shakel up 20 sh");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the scond shakel up 20 sh");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the last shakel up 20 sh");
            num3 = int.Parse(Console.ReadLine());
            sum = num1 + num2 + num3;
            a = sum -PRICE1;
            a = a / PRICE2;
            Console.WriteLine($"can buy {a} mastiks");
        }
    }
}
