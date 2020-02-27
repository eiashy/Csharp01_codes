using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_18_12_19_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, max, min, sum = 0, counter = 30, i;
            float avg;
            Console.WriteLine(" 1 of 30 : enter the number");
            num = int.Parse(Console.ReadLine());
            sum += num;
            max = num;
            min = num;
            for (i = 2; i <= 30; i++)
            {
                Console.WriteLine($" {i} of 30 : enter the number");
                num = int.Parse(Console.ReadLine());
                sum += num;
                if(num>max)
                    max = num;
                if(num<min)
                    min = num;
            }
            avg = (float)sum / counter;
            Console.WriteLine($@"the sum of the numbers is {sum}
the count of the numbers is {counter}
the max number is {max}
the min number is {min}
the avg of the numbers is {avg:f2}");

        }
    }
}
