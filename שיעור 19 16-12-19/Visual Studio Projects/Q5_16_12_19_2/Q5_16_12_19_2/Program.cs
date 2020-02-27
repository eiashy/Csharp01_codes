using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_16_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter pass for ksrfet withup zeros an up 0");
            num = int.Parse(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("the pass not good");
                return;
            }else while (num != 0)
                {
                    if (num % 10 == 0)
                    {
                        Console.WriteLine("the pass not good");
                        return;
                    }
                    num /= 10;
                }
            Console.WriteLine("the pass is good");
        }
    }
}
