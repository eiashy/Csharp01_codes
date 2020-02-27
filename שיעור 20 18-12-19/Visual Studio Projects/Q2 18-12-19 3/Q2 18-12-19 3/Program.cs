using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_18_12_19_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char c;
            int flag;
            Console.WriteLine("enter the first number 1-99: ");
            num1 = int.Parse(Console.ReadLine());
            while(!(num1>=1 && num1 <= 99))
            {
                Console.WriteLine("Try agin , enter the first number 1-99: ");
                num1 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter the char -, +, /, *");
            c = char.Parse(Console.ReadLine());
            Console.WriteLine("enter the last number 1-99: ");
            num2 = int.Parse(Console.ReadLine());
            while (!(num2 >= 1 && num2 <= 99))
            {
                Console.WriteLine("Try agin , enter the first number 1-99: ");
                num2 = int.Parse(Console.ReadLine());
            }
            do
            {
                flag = 0;
                switch (c)
                {
                    case '+':
                        Console.WriteLine($"{num1} {c} {num2} = {num1+num2}");
                        break;
                    case '-':
                        Console.WriteLine($"{num1} {c} {num2} = {num1 - num2}");
                        break;
                    case '*':
                        int result = num1 * num2, counter=0;
                        while (result != 0)
                        {
                            counter++;
                            result /= 10;
                        }
                        Console.WriteLine($"{num1} {c} {num2} = {num1 * num2}  , number of digit of the result is: {counter}");
                        break;
                    case '/':
                        Console.WriteLine($"{num1} {c} {num2} = {num1 / num2} , {num1 % num2}");
                        break;
                    default:
                        flag = 1;
                        Console.WriteLine("Try agin, enter the char -, +, /, *");
                        c = char.Parse(Console.ReadLine());
                        break;
                }
            } while (flag != 0);
        }
    }
}
