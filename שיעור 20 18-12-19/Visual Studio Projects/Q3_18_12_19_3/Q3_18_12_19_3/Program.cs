using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_18_12_19_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,sumDigit=0,numCopy;
            Console.WriteLine("enter number negatev");
            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("error");
                return;
            }
            numCopy = num*num;
            while (numCopy != 0)
            {
                sumDigit += (numCopy % 10);
                numCopy /= 10;
            }
            if (sumDigit == num)
            {
                Console.WriteLine($"the fung {num} * {num} = {num*num} , YES");
            }else
            {

            }
        }
    }
}
