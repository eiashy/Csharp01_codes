using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_07_11_19
{
    class Q6
    {
        static void Main(string[] args)
        {
            const float PRICE1 = 39.90f, PRICE2 = 29.90f;
            int num;
            Console.WriteLine("enter how many sims you need");
            num = int.Parse(Console.ReadLine());
            if(num>=4)
                Console.WriteLine($"{num*PRICE2} shakle");
            else
                Console.WriteLine($"{num * PRICE1} shakle");
        }
    }
}
