using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7_26_12_19
{
    class Program
    {
        static void MathPow(int x, int y)
        {
            long pow=1;
            if (x == 1)
            {
                pow = 1;
            }else for(int i = 1; i <= y; i++)
                {
                    pow *= x;
                }
            Console.WriteLine($"the pow of {x}^{y} = {pow}");
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter the number: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the pow:");
            y = int.Parse(Console.ReadLine());
            MathPow(x, y);
        }
    }
}
