using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_12_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0,i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"enter how mach students in the clas {i+1} of 10");
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"all the school {sum}");
        }
    }
}
