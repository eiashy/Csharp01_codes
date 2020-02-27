using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_21_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("1. sunday\n2. monday\n3. tuesday\n4. wednesday\n5. thursday\n6. friday\n7. saturday");
            Console.WriteLine("enter your chios");
            day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("sunday");
                    break;
                case 2:
                    Console.WriteLine("monday");
                    break;
                case 3:
                    Console.WriteLine("tuesday");
                    break;
                case 4:
                    Console.WriteLine("wednesday");
                    break;
                case 5:
                    Console.WriteLine("thursday");
                    break;
                case 6:
                    Console.WriteLine("friday");
                    break;
                case 7:
                    Console.WriteLine("saturday");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

        }
    }
}
