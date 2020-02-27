using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_09_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("enter char to check frout * stop");
            c = char.Parse(Console.ReadLine());
            while (!(c == '*'))
            {
                if(!(c>='A' && c<='Z' || c>='a' && c <= 'z'))
                {
                    Console.WriteLine("the char is error");
                    return;
                }
                switch (c)
                {
                    case 'A':
                    case 'a':
                        Console.WriteLine("Apple");
                        break;
                    case 'B':
                    case 'b':
                        Console.WriteLine("Banana");
                        break;
                    case 'O':
                    case 'o':
                        Console.WriteLine("Orange");
                        break;
                    default:
                        Console.WriteLine("other fruit");
                        break;
                }
                Console.WriteLine("enter char to check frout * stop");
                c = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("thank you bye bye");
        }
    }
}
