using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_18_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("enter number");
                n = int.Parse(Console.ReadLine());
                for (j = 1; j <= n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
