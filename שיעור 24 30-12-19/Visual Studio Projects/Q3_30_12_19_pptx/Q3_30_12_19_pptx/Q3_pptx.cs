using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_30_12_19_pptx
{
    class Q3_pptx
    {
        static void Main(string[] args)
        {
            const int SIZE = 8;
            char[] c = new char[SIZE];
            int i;
            for (i = 0; i < SIZE; i++)
            {
                Console.WriteLine($"enter the char of the index {i+1} of {SIZE}");
                c[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("**************************************************************");
            for (i = 0; i < SIZE; i++)
            {
                Console.Write(c[i]);
            }
            Console.WriteLine();
        }
    }
}
