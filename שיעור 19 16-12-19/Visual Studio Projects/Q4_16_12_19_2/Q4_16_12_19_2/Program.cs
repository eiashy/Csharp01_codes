using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_16_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter1 = 0, counter2 = 0, num;
            Console.WriteLine("enter number up 0");
            num = int.Parse(Console.ReadLine());
            while (num < 0)
            {
                Console.WriteLine("try agin, enter number up 0");
                num = int.Parse(Console.ReadLine());
            }
            if (num == 0)
                counter1++;
            else while (num != 0)
                {
                    if ((num % 10) % 2 == 0)
                        counter1++;
                    else
                        counter2++;
                    num /= 10;
                }
            Console.WriteLine($"the sefrot zoke in {counter1}\nthe eezoge is {counter2}");
        }
    }
}
