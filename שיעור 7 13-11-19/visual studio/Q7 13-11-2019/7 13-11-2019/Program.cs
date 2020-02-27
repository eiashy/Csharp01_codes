using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_13_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            float gradebgr;
            int gradebsco;
            Console.WriteLine("enter the grade of bgrot");
            gradebgr = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the grade of bseco");
            gradebsco = int.Parse(Console.ReadLine());
            if (gradebgr > 90 || gradebsco > 600)
                Console.WriteLine("you joined");
            else
                Console.WriteLine("you cant join");
        }
    }
}
