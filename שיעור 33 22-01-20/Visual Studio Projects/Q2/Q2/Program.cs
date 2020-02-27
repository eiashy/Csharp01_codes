using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Count c1 = new Count();
            Count c2 = new Count();
            Count c3 = new Count();
            Console.WriteLine("the first one: ");
            c1.Initialize(4);
            c1.Go();
            Console.WriteLine("the socnd one: ");
            c2.Initialize(6);
            c2.Go();
            Console.WriteLine("the threed one: ");
            c3.Initialize(9);
            c3.Go();
        }
    }
}
