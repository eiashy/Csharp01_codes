using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_07_11_19
{
    class Q5
    {
        static void Main(string[] args)
        {
            const byte AGEPNS =65;
            byte age;
            Console.WriteLine("enter a age");
            age = byte.Parse(Console.ReadLine());
            if(age>=AGEPNS)
                Console.WriteLine("yes");
            else 
                Console.WriteLine($"no {AGEPNS-age} years");
        }
    }
}
