using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_02_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number even and '+'");
            num = int.Parse(Console.ReadLine());
            while(!(num>=0 && num%2==0))
            {
                Console.WriteLine("enter number even and '+'");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"the number even ofter is : {num+2}");
        }
    }
}
