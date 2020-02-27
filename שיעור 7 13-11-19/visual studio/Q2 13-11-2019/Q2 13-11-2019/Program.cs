using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_13_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ente number:");
            num = int.Parse(Console.ReadLine());
            if (num >= 0 && num <= 9)
                Console.WriteLine($"the number {num} is had sfrate");
            else
                Console.WriteLine($"the number {num} is had No sfrate");
        }
    }
}
