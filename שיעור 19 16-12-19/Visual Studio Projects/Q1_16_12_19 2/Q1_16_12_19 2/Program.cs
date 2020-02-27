using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_16_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number up 0");
            num = int.Parse(Console.ReadLine());
            if (!(num >= 0))
            {
                Console.WriteLine("error");
                return;
            }
            if(num==0)
                Console.WriteLine(num);
            else while (num != 0)
                {
                    if((num % 10) % 2 == 0)
                    {
                        Console.WriteLine(num%10);
                    }
                    num/= 10;
                }

        }
    }
}
