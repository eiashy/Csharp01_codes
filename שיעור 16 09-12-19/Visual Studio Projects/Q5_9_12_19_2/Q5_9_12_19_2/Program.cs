using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_9_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            int chois;
            float num1, num2;
            do
            {
                Console.WriteLine("1. enter a mathematical expression");
                Console.WriteLine("2. exit");
                Console.WriteLine("enter your choice");
                chois = int.Parse(Console.ReadLine());
                switch (chois)
                {
                    case 1:
                        Console.Write("enter the first num:  ");
                        num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("enter one of { + , - , / , * } :  ");
                        c = char.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("enter the last num:  ");
                        num2 = float.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if(c=='+')
                        {
                            Console.WriteLine($" {num1}  {c}  {num2}  =  {num1 + num2}");
                        }else if (c == '-')
                        {
                            Console.WriteLine($" {num1}  {c}  {num2}  =  {num1 - num2}");
                        }
                        else if (c == '*')
                        {
                            Console.WriteLine($" {num1}  {c}  {num2}  =  {num1 * num2}");
                        }
                        else if (c == '/')
                        {
                            if (num2==0)
                                Console.WriteLine("error");
                            else
                                Console.WriteLine($" {num1}  {c}  {num2}  =  {num1 / num2}");
                        }
                        else
                            Console.WriteLine("this char is not have");
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
