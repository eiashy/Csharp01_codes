using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_25_11_19__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            char c;
            Console.WriteLine("Enter a mathematical expression:");
            num1 = float.Parse(Console.ReadLine());
            c = char.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());
            switch (c)
            {
                case '+':
                    Console.WriteLine($"{num1} {c} {num2} = {num1+num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} {c} {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} {c} {num2} = {num1 * num2}");
                    break;
                case '/':
                    if(num2!=0)
                        Console.WriteLine($"{num1} {c} {num2} = {num1 / num2}");
                    else
                        Console.WriteLine($"{num1} {c} {num2} = cant do");
                    break;
                default:
                    Console.WriteLine("the chois in not good");
                    break;
            }
        }
    }
}
