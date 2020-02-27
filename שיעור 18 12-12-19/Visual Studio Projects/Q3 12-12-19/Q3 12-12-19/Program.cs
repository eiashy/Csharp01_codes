using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_12_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            long sumstoper = 1;
            int i, N;
            Console.WriteLine("enter number up 1");
            N = int.Parse(Console.ReadLine());
            while (!(N > 1))
            {
                Console.WriteLine("try agin, enter number up 1");
                N = int.Parse(Console.ReadLine());
            }
            for (i = 1; i <= N; i++)
            {
                sumstoper *= i;
            }
            Console.WriteLine($" {N}! = {sumstoper}");
        }
    }
}
