using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_11_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int conterNotGood = 0, counterVryGood = 0, grade;
            Console.WriteLine("enter the grade (the grade 0-100) :");
            grade = int.Parse(Console.ReadLine());
            while (grade != -1)
            {
                while(grade<-1 || grade > 100)
                {
                    Console.WriteLine("try again, enter the grade (the grade 0-100) :");
                    grade = int.Parse(Console.ReadLine());
                }
                if (grade < 55)
                    conterNotGood++;
                else if (grade > 85)
                    counterVryGood++;
                Console.WriteLine("enter the grade (the grade 0-100) :");
                grade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"number of grades good is: {counterVryGood} \nnumber of grades not good is: {conterNotGood}");
        }
    }
}
