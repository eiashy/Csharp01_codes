using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_HM11_21_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            byte month;
            Console.WriteLine("enter the month");
            month = byte.Parse(Console.ReadLine());
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    Console.WriteLine($"31 days in this month {month}");
                    break;
                case 4: case 6: case 9: case 11:
                    Console.WriteLine($"30 days in this month {month}");
                    break;
                case 2:
                    Console.WriteLine($"28 days in this month {month}");
                    break;
                default:
                    Console.WriteLine("worng");
                    break;
            }
        }
    }
}
