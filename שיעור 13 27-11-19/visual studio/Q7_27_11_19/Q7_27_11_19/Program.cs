using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7_27_11_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,grade;
            for(i=0;i<15;i++)
            {
                Console.WriteLine($"{i+1} of 15 :- enter the grade:");
                grade = int.Parse(Console.ReadLine());
                if (grade < 80)
                    Console.WriteLine(grade += 5);
            }
        }
    }
}
