﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8_02_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number ben 10-99");
            num = int.Parse(Console.ReadLine());
            while(!(num>=10 && num<=99))
            {
                Console.WriteLine("Error");
                Console.WriteLine("enter number ben 10-99");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{num / 10} + {num % 10} = {num / 10 + num % 10}");
        }
    }
}
