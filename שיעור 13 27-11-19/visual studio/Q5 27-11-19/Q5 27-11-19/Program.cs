using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_27_11_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i , n;
            Console.WriteLine("enter number of starts");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
                Console.WriteLine("*");
        }
    }
}
