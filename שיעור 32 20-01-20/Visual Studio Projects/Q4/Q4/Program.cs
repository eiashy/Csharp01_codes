using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            Box b2 = new Box();
            Console.WriteLine($"enter the info for the {1} box: ");
            Console.WriteLine("enter the lenght of the box");
            b1.lenght = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the color of the box");
            b1.color = Console.ReadLine();

            Console.WriteLine($"enter the info for the {2} box: ");
            Console.WriteLine("enter the lenght of the box");
            b2.lenght = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the color of the box");
            b2.color = Console.ReadLine();

            Console.WriteLine($"\nthe info for the box {1} is :\n lenght {b1.lenght:f1} , color {b1.color}");
            Console.WriteLine($"the info for the box {2} is :\n lenght {b2.lenght:f1} , color {b2.color}");
        }
    }
}
