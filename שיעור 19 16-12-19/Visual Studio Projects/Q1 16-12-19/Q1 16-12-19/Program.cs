using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_16_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int max=0, weight, i;
            for(i=1;i<=15;i++)
            {
                Console.WriteLine($"'{i} of 15' : enter the weight up to 0");
                weight = int.Parse(Console.ReadLine());
                while (weight <= 0)
                {
                    Console.WriteLine("try again, enter the weight up to 0");
                    weight = int.Parse(Console.ReadLine());
                }
                if(i==1)
                    max = weight;
                else if (weight > max)
                    max = weight;
            }
            Console.WriteLine($"the max weight is {max}");
        }
    }
}
