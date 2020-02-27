using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_25_12_19
{
    class Program
    {
        static int SumOf1ToNum(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
                sum += i;
            return sum;
        }
        static void Main(string[] args)
        {
            int num,sum;
            Console.WriteLine("enter number up 1");
            num = int.Parse(Console.ReadLine());
            sum = SumOf1ToNum(num);
            Console.WriteLine($"the sum of numbers from 1-{num} is {sum}");
            Console.WriteLine($"the sum of numbers from 1-"+num +" is " + sum);
            Console.WriteLine($"the sum of numbers from 1-{num} is {SumOf1ToNum(num)}");
        }
    }
}
