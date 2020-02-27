using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_9_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, chois;
            do
            {
                Console.WriteLine("1. enter data");
                Console.WriteLine("2. exit");
                Console.WriteLine("enter your choice");
                chois = int.Parse(Console.ReadLine());
                switch (chois)
                {
                    case 1:
                        Console.Write("enter the first number:");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("enter the first number:");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($" {num1}  +  {num2}  =  {num1+num2}");
                        break;
                    case 2:
                        Console.WriteLine("good bye");
                        break;
                    default:
                        Console.WriteLine("this opthion is not good try agin");
                        break;
                }

            } while (chois != 2);
        }
    }
}
