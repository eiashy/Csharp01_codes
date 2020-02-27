using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_14_11_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int time;
            Console.WriteLine("enter the time ");
            time = int.Parse(Console.ReadLine());
            if(time<=55)
            {
                Console.WriteLine("A");
            }
            else if(time>55 && time<=65)
            {
                Console.WriteLine("B");
            }
            else
                Console.WriteLine("C");
        }
    }
}
