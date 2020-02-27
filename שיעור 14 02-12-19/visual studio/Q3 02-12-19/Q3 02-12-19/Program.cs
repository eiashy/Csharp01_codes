using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_02_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("enter tav ben a-z or A-Z");
            c = char.Parse(Console.ReadLine());
            if(!(c>='A' && c<='Z' || c>='a' && c <= 'z'))
            {
                Console.WriteLine("Error");
                return;
            }
            if(c >= 'A' && c <= 'Z')
                Console.WriteLine("the tav is big");
            else
                Console.WriteLine("the tav is small");
        }
    }
}
