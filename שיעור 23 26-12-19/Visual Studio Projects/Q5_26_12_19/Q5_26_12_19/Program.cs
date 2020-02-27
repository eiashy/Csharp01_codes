using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_26_12_19
{
    class Program
    {
        static void PrintSqrt(int size)
        {
            for(int i = 1; i <= size; i++)
            {
                for(int j = 1; j <= size; j++)
                {
                    if(i==1 || i == size)
                    {
                        Console.Write("* ");
                    }else if(j==1 || j == size)
                    {
                        Console.Write("* ");
                    }else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("enter the size of the sqrt: ");
            size = int.Parse(Console.ReadLine());
            while (size <= 0)
            {
                Console.WriteLine("enter the size of the sqrt: ");
                size = int.Parse(Console.ReadLine());
            }
            PrintSqrt(size);
        }
    }
}
