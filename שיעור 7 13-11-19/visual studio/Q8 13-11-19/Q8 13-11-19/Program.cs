using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8_13_11_19
{
    class Program
    {
        static void Main(string[] args)
        {
            float grade1, grade2, grade3, avg;
            Console.WriteLine("enter the farst grade:");
            grade1 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the scond number:");
            grade2 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the therd number:");
            grade3 = float.Parse(Console.ReadLine());
            avg = (grade1 + grade2 + grade3) / 3;
            if (grade1 > 90 && grade2 > 90 && grade3 > 90 && avg > 95)
                Console.WriteLine("you can to be airfly");
            else
                Console.WriteLine("acsisdeny");
        }
    }
}
