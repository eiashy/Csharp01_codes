using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_04_2019q2
{
    class Program
    {
        /*
         *    קולטת שני מספרים ומחלקת כל מספר ב 4 ואז מחשבת סכום שני המספרים אחרי חילוק כל משתנה
         * 
         */
        static void Main(string[] args)
        {
            double num1, num2, sum;
            Console.WriteLine("enter number 1");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter number 2");
            num2 = double.Parse(Console.ReadLine());
            num1 = num1 / 4;
            Console.WriteLine("num1 / 4 = "+num1);
            num2 = num2 / 4;
            Console.WriteLine("num2 / 4 = "+num2);
            sum = num1 + num2;
            Console.WriteLine(sum);

        }
    }
}
