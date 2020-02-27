using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_02_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number even:");
            num = int.Parse(Console.ReadLine());
            if(!(num>=0 && num%2==0))
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine($"the number even ofter {num+2}");
        }
    }
}
