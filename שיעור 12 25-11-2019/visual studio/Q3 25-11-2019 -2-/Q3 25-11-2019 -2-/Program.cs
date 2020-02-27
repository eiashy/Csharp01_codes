using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_25_11_2019__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("enter the cracter");
            c = char.Parse(Console.ReadLine());
            if (c >= 'A' && c <= 'Z')
                Console.WriteLine("the char is big");
            else if (c >= 'a' && c <= 'z')
                Console.WriteLine("the char is small");
            else
                Console.WriteLine("theis not carcter");
        }
    }
}
