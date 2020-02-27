using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_25_11_2019__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("enter big char ");
            c = char.Parse(Console.ReadLine());
            if (c == 'A')
                Console.WriteLine($"{'Z'}  {c}  {(char)(c+1)}");
            else if (c == 'Z')
                Console.WriteLine($"{(char)(c-1)}  {c}  {'A'}");
            else
                Console.WriteLine($"{(char)(c - 1)}  {c}  {(char)(c + 1)}");
        }
    }
}
