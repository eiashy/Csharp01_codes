using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_26_12_19
{
    class Program
    {
        static void CheckNumIsEvenOrNot(int num)
        {
            if(num%2==0)
                Console.WriteLine("the number is even");
            else
                Console.WriteLine("the number is not even");
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            CheckNumIsEvenOrNot(num);
        }
    }
}
