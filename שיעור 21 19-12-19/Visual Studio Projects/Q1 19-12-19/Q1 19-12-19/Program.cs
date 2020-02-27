using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_19_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, max = 0;
            Console.WriteLine("enter numbers from zero to stop enter -1");
            num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                while (num < 0)
                {
                    Console.WriteLine("try again , enter numbers from zero to stop enter -1");
                    num = int.Parse(Console.ReadLine());
                }
                if (num > max)
                    max = num;
                Console.WriteLine("enter numbers from zero to stop enter -1");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"the max number is {max}");
        }
    }
}
