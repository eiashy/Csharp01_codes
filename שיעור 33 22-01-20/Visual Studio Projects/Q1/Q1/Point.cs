using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Point
    {
        private double x, y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void show()
        {
            Console.Write($"({this.x} , {this.y})");
        }

    }
}
