using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_16_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, counter = 0, num;
            Console.WriteLine("enter number up 0");
            num = int.Parse(Console.ReadLine());
            if(!(num >= 0))
            {
                Console.WriteLine("error");
                return;
            }
            if (num == 0)
                counter++;
            else while (num != 0)
                {
                    sum += (num % 10);
                    counter++;
                    num /= 10;
                }
            Console.WriteLine($"the counter of the sefrot for number is {counter} \nthe sum of the sefrot for number is {sum}");
        }
    }
}
