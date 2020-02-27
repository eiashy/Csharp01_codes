using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_09_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, choise;
            do
            {
                Console.WriteLine("1. enter number do sefrte do sum yiu sefrot");
                Console.WriteLine("2. exit");
                Console.WriteLine("enter the chois");
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("enter number do sefrte");
                        num = int.Parse(Console.ReadLine());
                        if(num>=10 && num <= 99)
                        {
                            Console.WriteLine($" {num / 10}  +  {num % 10}  =  {num / 10 + num % 10}");
                        }
                        else
                            Console.WriteLine("the number not do sefrte");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("bye bye");
                        break;
                    default:
                        Console.WriteLine("the chois is not good");
                        break;
                }
            } while (choise != 2);

        }
    }
}
