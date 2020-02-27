using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_11_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,num,i,counter=0;
            Console.WriteLine("enter number up 0");
            n = int.Parse(Console.ReadLine());
            while (n<=0)
            {
                Console.WriteLine("try agin, enter number up 0");
                n = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("enter number");
                num = int.Parse(Console.ReadLine());
                if (num >= 0)
                    counter++;
            }
            Console.WriteLine($" sum of the up from 0 is : {counter}");
        }
    }
}
