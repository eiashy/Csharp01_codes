using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_9_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            int chois;
            do
            {
                Console.WriteLine("1. enter data");
                Console.WriteLine("2. exit");
                Console.WriteLine("enter your choice");
                chois = int.Parse(Console.ReadLine());
                switch (chois)
                {
                    case 1:
                        Console.Write("enter char:   ");
                        c = char.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($" {c}  is  {(int)c}");
                        break;
                    case 2:
                        Console.WriteLine("good bye");
                        break;
                    default:
                        Console.WriteLine("this opthion is not good try agin");
                        break;
                }
            } while (chois != 2);
        }
    }
}
