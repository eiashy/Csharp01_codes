using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_19_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i,counter=0;
            for (i = 1; i <= 15; i++)
            {
                Console.WriteLine("enter number from 0");
                num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("error bye");
                    return;
                }
                if (num>=0 && num <= 9)
                {
                    counter++;
                }else while (num != 0)
                    {
                        num /= 10;
                        counter++;
                    }
                Console.WriteLine($"to sum of the sefrot is {counter}");
                counter = 0;
            }
        }
    }
}
