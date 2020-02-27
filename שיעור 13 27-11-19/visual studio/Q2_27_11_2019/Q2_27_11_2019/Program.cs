using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_27_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 40; i >= 1; i--)
            {
                Console.Write(i);
                if (i != 1)
                    Console.Write(" , ");
            }
        }
    }
}
