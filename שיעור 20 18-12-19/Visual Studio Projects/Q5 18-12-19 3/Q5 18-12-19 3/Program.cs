using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_18_12_19_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n,spase,k;
            Console.WriteLine("enter number 1-10");
            n = int.Parse(Console.ReadLine());
            while(n>10 || n<1)
            {
                Console.WriteLine("try again, enter number 1-10");
                n = int.Parse(Console.ReadLine());
            }
            for (i = 1; i <= n; i++)
            {
                for (spase = n-i; spase >= 1; spase--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <=i; j++)
                {
                    Console.Write(j);
                    
                }
                for(k=i-1;k>=1;k--)
                    Console.Write(k);
                Console.WriteLine();
            }

        }
    }
}
