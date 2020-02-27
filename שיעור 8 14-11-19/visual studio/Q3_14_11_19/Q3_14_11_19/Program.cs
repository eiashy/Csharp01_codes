using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_14_11_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter the line a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the line b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the line c");
            c = int.Parse(Console.ReadLine());
            if (a == b && a == c)
            {
                Console.WriteLine("shave tsla3ot");
            }
            else if(a==b || a==c || b==c)
            {
                Console.WriteLine("shave shokayem");
            }
            else
                Console.WriteLine("shone tsl30t");
        }
    }
}
