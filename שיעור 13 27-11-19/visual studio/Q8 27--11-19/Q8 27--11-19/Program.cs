using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8_27__11_19
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            int i,n;
            Console.WriteLine("enter the tav");
            c = char.Parse(Console.ReadLine());
            Console.WriteLine("enter how many nmbers you neet do prent");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write(c);
            }
        }
    }
}
