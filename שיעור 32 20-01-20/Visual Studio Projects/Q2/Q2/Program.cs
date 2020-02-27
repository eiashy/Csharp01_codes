using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo x = new StudentInfo();
            string[] c = new string[3] { "c#", "html", "math" };
            Console.WriteLine("enter the number of the student");
            x.studentNum = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the name of the student");
            x.studentName = Console.ReadLine();
            float avg=0;
            for(int i = 0; i < x.arr.Length; i++)
            {
                Console.WriteLine($"enter the {i+1} of {3} the grade for {c[i]}: ");
                x.arr[i] = int.Parse(Console.ReadLine());
                avg += x.arr[i];
            }
            avg /= 3.0f;
            Console.WriteLine("student info is: ");
            Console.WriteLine($"\tstudent num {x.studentNum}");
            Console.WriteLine($"\tstudent name {x.studentName}");
            for (int i = 0; i < x.arr.Length; i++)
            {
                Console.WriteLine($"\t    the coruse{i+1} name is: {c[i]} the grade {x.arr[i]} ");
            }
            Console.WriteLine($"the avg is {avg:f2}");

            Console.WriteLine("up 80:***************************************************");
            for (int i = 0; i < x.arr.Length; i++)
            {
                if (x.arr[i] > 80)
                {
                    Console.WriteLine($"the coruse{i + 1} name is: {c[i]} the grade {x.arr[i]} ");
                }
            }
        }
    }
}
