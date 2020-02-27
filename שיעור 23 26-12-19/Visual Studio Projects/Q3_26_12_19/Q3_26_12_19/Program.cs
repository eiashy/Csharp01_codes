using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_26_12_19
{
    class Program
    {
        static void PrintSumOfDig(int num)
        {
            Console.WriteLine($"the sum of digit is {num%10+num/10}");
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number 10-99");
            num = int.Parse(Console.ReadLine());
            while (!(num>10 && num<99)) 
            {
                Console.WriteLine("enter number 10-99");
                num = int.Parse(Console.ReadLine());
            }
            PrintSumOfDig(num);
        }
    }
}
