using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_04_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            int i;
            for (i = 0; i < 50; i++)
            {
                Console.WriteLine($"enter char 50 of {i+1} to check");
                c = char.Parse(Console.ReadLine());
                if(c>='A' && c<='Z')
                    Console.WriteLine($"the {c} is big world");
                else if(c>='a' && c<='z')
                    Console.WriteLine($"the {c} is smal world");
                else
                    Console.WriteLine("no word");
            }
        }
    }
}
