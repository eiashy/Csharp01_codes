using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, i, k;
            j = 8;
            i = k = 0;
            while (j != 0)
            {
                for (i = 0; i < (j - i); i++)
                    k++;
                Console.WriteLine("k = " + k);
                j--;
                Console.WriteLine("j = " + j);
                Console.WriteLine("i = " + i);
            }
            Console.WriteLine("k = " + k);

        }
    }
}
