using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_12_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int grades = 0, counter = 0, choise, grade;
            double avg=0;
            do {
                Console.WriteLine("1. to add grade");
                Console.WriteLine("2. exit");
                Console.Write("enter the choise: ");
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:

                        Console.WriteLine("enter the grade (0-100)");
                        grade = int.Parse(Console.ReadLine());
                        while(grade<0 || grade > 100)
                        {
                            Console.WriteLine("try agin, enter the grade (0-100)");
                            grade = int.Parse(Console.ReadLine());
                        }
                        counter++;
                        grades += grade;
                        break;
                    case 2:
                        if (counter == 0) {
                            Console.WriteLine("no grades was enter");
                        } else
                            avg = (double)grades / counter;
                            Console.WriteLine($"the grades sum is {grades}  /  the count of grades {counter}  =  the avg is {avg:f2}");
                        break;
                    default:
                        Console.WriteLine("the chois in not good");
                        break;
                }
            } while (choise!=2);
        }
    }
}
