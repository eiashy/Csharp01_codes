using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_13_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            byte age, csharp_exp, javascript_exp;
            Console.WriteLine("enter the age");
            age = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter the exper in csharp");
            csharp_exp = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter the exper in javascrpt");
            javascript_exp = byte.Parse(Console.ReadLine());
            if ((age >= 35 && age <= 45) && (csharp_exp >= 5 || javascript_exp >= 3))
                Console.WriteLine("call as");
            else
                Console.WriteLine("sorry you cant to call");
        }
    }
}
