using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_25_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("enter a caracter in small");
            c = char.Parse(Console.ReadLine());
            if(c>='a' && c<='z')
                Console.WriteLine($"the big carcter is {(char)(c-32)}");
            else if(c>='A' && c<='Z')
                Console.WriteLine($"the char {(char)c} is big");
            else
                Console.WriteLine($"this not caructer {(char)c} with a-z or A-Z");
        }   
    }
}
