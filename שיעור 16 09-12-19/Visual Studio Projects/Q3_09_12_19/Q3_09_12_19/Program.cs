using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_09_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("entr char to check to stop #");
            c = char.Parse(Console.ReadLine());
            while (c != '#')
            {
                if(c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
                    Console.WriteLine("this in tav");
                else
                    Console.WriteLine("this in no tav");
                Console.WriteLine("entr char to check to stop #");
                c = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("bye bye");
        }
    }
}
