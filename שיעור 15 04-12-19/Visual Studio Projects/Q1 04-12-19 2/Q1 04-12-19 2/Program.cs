using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_04_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, size;
            Console.WriteLine("enter how many you need to read");
            size = int.Parse(Console.ReadLine());
            while (!(size > 0))
            {
                Console.WriteLine("enter how many you need to read");
                size = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < size; i++)
            {
                Console.WriteLine("enter how many you need to read");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($" {num-1}  {num}  {num+1}");
            }
        }
    }
}
