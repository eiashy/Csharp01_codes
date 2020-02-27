using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_04_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num1, num2;
            for(i=0;i<100;i++)
            {
                Console.WriteLine("enter the first number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the last number");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($" {num1}  +  {num2}  =  {num1+num2}");
            }
        }
    }
}
