using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_13_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3;
            Console.WriteLine("enter the size of the tsel3 1");
            num1= float.Parse(Console.ReadLine());
            Console.WriteLine("enter the size of the tsel3 2");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the size of the tsel3 3");
            num3 = float.Parse(Console.ReadLine());
            if ((num1 > 0 && num2 > 0 && num3 > 0) && (num1 + num2 > num3 && num1 + num3 > num2 && num2 + num3 > 0))
                Console.WriteLine("the mesholsh is corect");
            else
                Console.WriteLine("cant do mesholsh");
        }
    }
}
