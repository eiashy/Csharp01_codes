using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_2_6_11_19
{
    class Program
    {
        /*
         * ערך מוחלט להפריש בין הגובה
         */
        static void Main(string[] args)
        {
            /*
             * the farst q
            double high1, high2,sum;
            Console.WriteLine("enter the high 1");
            high1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the high 2");
            high2 = double.Parse(Console.ReadLine());
            sum = high1 - high2;
            sum = Math.Abs(sum);
            Console.WriteLine($"the abs is {sum}");
            */
            double high1, high2, min;
            Console.WriteLine("enter the high 1");
            high1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the high 2");
            high2 = double.Parse(Console.ReadLine());
            min = Math.Min(high1, high2);
            Console.WriteLine($"the min is {min}");

        }
    }
}
