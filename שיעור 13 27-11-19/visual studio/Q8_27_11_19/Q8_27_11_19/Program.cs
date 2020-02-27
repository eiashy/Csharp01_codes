using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8_27_11_19
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            int i;
            Console.WriteLine("enter the tav");
            c = char.Parse(Console.ReadLine());
            for (i= 0;i < 50;i++)
            {
                Console.Write(c);
            }
        }
    }
}
