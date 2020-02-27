using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_27_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i=20;i<=80;i++)
            {
                Console.Write(i);
                if (i != 80)
                    Console.Write(" , ");
            }
        }
    }
}
