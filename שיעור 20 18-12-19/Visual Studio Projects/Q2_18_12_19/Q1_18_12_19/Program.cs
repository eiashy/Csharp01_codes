using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_18_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade , i;
            bool flag=false;
            for (i = 1; i <= 15; i++)
            {
                Console.WriteLine($" {i} of 15 : enter the grade 0-100");
                grade = int.Parse(Console.ReadLine());
                while(!(grade>=0 && grade <= 100))
                {
                    Console.WriteLine($"try agin, {i} of 15 : enter the grade 0-100");
                    grade = int.Parse(Console.ReadLine());
                }   
                if (grade < 55)
                    flag = true;
            }
            if(true)
                Console.WriteLine("have an grades not good");
            else
                Console.WriteLine("all the grades is goods");
        }
    }
}
