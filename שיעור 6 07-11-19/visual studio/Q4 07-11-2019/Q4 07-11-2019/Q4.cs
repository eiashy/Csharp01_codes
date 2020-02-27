using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_07_11_2019
{
    class Q4
    {
        /*
         * קולט שני מספרים ומדפיס את הגדול מבניהם
         */
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("enter the frist number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the last number");
            num2 = int.Parse(Console.ReadLine());
            if(num1>num2)
                Console.WriteLine(num1);
            else
                Console.WriteLine(num2);
        }
    }
}
