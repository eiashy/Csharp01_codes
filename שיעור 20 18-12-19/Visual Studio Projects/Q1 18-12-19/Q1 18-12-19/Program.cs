using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_18_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool flag = false;
            Console.WriteLine("enter numbers to stop enter -1");
            num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                if (num % 2 == 0)
                    flag = true;
                Console.WriteLine("enter numbers to stop enter -1");
                num = int.Parse(Console.ReadLine());
            }
            if(flag)
                Console.WriteLine("in this numbers is have in the less even number");
            else
                Console.WriteLine("no have even numbers");
        }
    }
}
