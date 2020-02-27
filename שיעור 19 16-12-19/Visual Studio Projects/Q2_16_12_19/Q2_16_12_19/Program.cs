using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_16_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            byte max=0, min=0;
            int grade;
            Console.WriteLine("enter the grade to stop enter -1");
            grade = int.Parse(Console.ReadLine());
            while (grade != -1)
            {
                if (!(grade >= 0 && grade <= 100))
                {
                    Console.WriteLine("error");
                    return;
                }
                if (grade > max)
                    max = (byte)grade;
                else if(grade<min)
                    min = (byte)grade;
                Console.WriteLine("enter the grade to stop enter -1");
                grade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"the max grade is {max}\nthe min grade is {min}");
        }
    }
}
