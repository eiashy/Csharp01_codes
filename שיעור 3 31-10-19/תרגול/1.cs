using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
      התוכנית מחשבת את שטחו ואת היקפו של מלבן
     */
namespace _31_10_2019cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, width, area, perimeter;
            Console.WriteLine("Enter length: ");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width:");
            width = int.Parse(Console.ReadLine());
            area = length * width;
            perimeter = (width + length) * 2;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);

        }
    }
}
