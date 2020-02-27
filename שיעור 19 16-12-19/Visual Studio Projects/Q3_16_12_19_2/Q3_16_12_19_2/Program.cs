using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_16_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int min=0, max = 0, num;
            Console.WriteLine("enter number up 0");
            num = int.Parse(Console.ReadLine());
            if (!(num >= 0))
            {
                Console.WriteLine("error");
                return;
            }
            if (num != 0)
            {
                min = num % 10;
                while (num!=0)
                {
                    if ((num % 10) > max)
                        max = num % 10;
                    if ((num % 10) < min)
                        min = num % 10;
                    num /= 10;
                }
            }
            Console.WriteLine($"the bigger is {max}\nthe smaller is {min}");
        }
    }
}
