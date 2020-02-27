using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_18_12_19_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.Write("*\t");
            for(i=1;i<=10;i++)
                Console.Write(i+ "\t");
            Console.WriteLine();
            for (i = 1; i <= 10; i++)
            {
                Console.Write(i + "\t");
                for (j = 1; j <= 10; j++)
                {
                    Console.Write(i*j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
