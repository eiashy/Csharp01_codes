using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10_02_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter num gdol shve 0");
            num = int.Parse(Console.ReadLine());
            while(!(num>=0))
            {
                Console.WriteLine("Error");
                Console.WriteLine("enter num gdol shve 0");
                num = int.Parse(Console.ReadLine());
            }
            if(num%2==0)
                Console.WriteLine($"the number is even {num} / 2 = {num/2}");
             else
                Console.WriteLine($"the number is not even {num} * 3 + 1 = {num * 3 + 1}");
        }
    }
}
