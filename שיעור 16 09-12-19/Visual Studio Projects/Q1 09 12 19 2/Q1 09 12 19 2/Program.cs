using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_09_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, choise;
            do
            {
                Console.WriteLine("1. enter number to sqrt");
                Console.WriteLine("2. exit");
                Console.WriteLine("enter the chois");
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("enter number to sqrt");
                        num = int.Parse(Console.ReadLine());
                        while (!(num > 0))
                        {
                            Console.WriteLine("The number not good try agin, enter number to sqrt");
                            num = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine($" {num} sqrt 2 = {Math.Sqrt((double)num)}");
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
