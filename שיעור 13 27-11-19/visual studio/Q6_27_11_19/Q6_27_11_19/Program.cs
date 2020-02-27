using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_27_11_19
{
    class Program
    {
        static void Main(string[] args)
        {
            const float KM = 1.6f;
            int i;
            for(i=0;i<20;i++)
            {
                Console.WriteLine($" {i+1} of 20 :- enter the dis for the mils to print to km");
                Console.WriteLine((float.Parse(Console.ReadLine()))*KM);
            }
        }
    }
}
