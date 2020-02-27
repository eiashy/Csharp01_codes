using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_07_11_2019
{
    class Q3
    {
        /*
         * קולט שני מספרים ובודק האם שווים
         */
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("enter the farst number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the last number");
            num2 = int.Parse(Console.ReadLine());
            if (num2 == num1)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
