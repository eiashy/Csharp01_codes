using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_26_12_19
{
    class Program
    {
        static void PrintTriangWithC(int size, char c)
        {
            for(int i=1;i<=size; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            char c;
            int size;
            Console.WriteLine("enter the size up 0 : ");
            size = int.Parse(Console.ReadLine());
            while (size <= 0)
            {
                Console.WriteLine("try agin , enter the size up 0 : ");
                size = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("inter the char");
            c = char.Parse(Console.ReadLine());
            PrintTriangWithC(size, c);
        }
    }
}
