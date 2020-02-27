using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_25_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            float avg;
            Console.WriteLine("enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the first number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the first number: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"the avg of the numbers is {Avrage(num1, num2, num3):f2}");
            avg = Avrage(num1, num2, num3);
            Console.WriteLine($"the avg of the numbers is {avg:f2}");
            Console.WriteLine("the avg of the numbers {" + num1 + " , " + num2 + " , " + num3 + " } is =" + avg);
        }
        static float Avrage(int num1, int num2, int num3)
        {
            float avg;
            avg = num1 + num2 + num3;
            avg =avg / 3.0f;
            return avg;
        }
    }
}
