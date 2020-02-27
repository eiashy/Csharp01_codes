using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3,4);
            Console.Write("the first point is : ");
            p1.show();
            Console.WriteLine();
            Point p2 = new Point(5,6);
            Console.Write("the last point is : ");
            p2.show();
            Console.WriteLine();
        }
    }
}
