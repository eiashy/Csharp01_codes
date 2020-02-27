using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_09_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter grade to stop -1");
            num = int.Parse(Console.ReadLine());
            while (!(num == -1))
            {
                if(num>75)
                    Console.WriteLine($" {num+5}");
                Console.WriteLine("enter grade to stop -1");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("bye bye");
        }
    }
}
