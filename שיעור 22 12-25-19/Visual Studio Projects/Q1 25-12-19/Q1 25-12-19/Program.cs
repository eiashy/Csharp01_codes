using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_25_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum;
            Console.WriteLine("enter number (10-99)");
            num = int.Parse(Console.ReadLine());
            while(num<10 || num > 99)
            {
                Console.WriteLine("try agin , enter number (10-99)");
                num = int.Parse(Console.ReadLine());
            }
            sum = SumOfDight(num);
            Console.WriteLine($"1- the sum of digat is {sum}");
            Console.WriteLine($"2- the sum of digat is {SumOfDight(num)}");
            Console.WriteLine("3- the sum of digat is " + SumOfDight(num));       
        }
        static int SumOfDight(int num)
        {
            int sum = 0;
            sum += (num / 10);
            sum += (num % 10);
            return sum;
        }
    }
}
