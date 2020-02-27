using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9_02_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            byte mony, time;
            Console.WriteLine("enter how many shiks in the time ben 25 - 80");
            mony = byte.Parse(Console.ReadLine());
            while (!(mony >= 25 && mony <= 80))
            {
                Console.WriteLine("Error");
                Console.WriteLine("enter how many shiks in the time ben 25 - 80");
                mony = byte.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter the how many time worked ben 2 - 14");
            time = byte.Parse(Console.ReadLine());
            while (!(time >= 2 && time <= 14))
            {
                Console.WriteLine("Error");
                Console.WriteLine("enter the how many time worked ben 2 - 14");
                time = byte.Parse(Console.ReadLine());
            }
            Console.WriteLine($" many of time {mony} * time of working {time} = {mony * time} shakel ");
        }
    }
}
