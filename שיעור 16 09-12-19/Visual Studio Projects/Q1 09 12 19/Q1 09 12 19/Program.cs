using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_09_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number to stop enter 0");
            num = int.Parse(Console.ReadLine());
            while (!(num == 0))
            {
                Console.WriteLine($" {num-1}  {num}  {num+1} ");
                Console.WriteLine("enter number to stop enter 0");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("thanks bye bye");
        }
    }
}
