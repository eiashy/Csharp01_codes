using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_10_2019cSharp
{
    class t6
    {
        static void Main(string[] args)
        {
            int a, area=0, volume=0;
            Console.Write("Enter number: ");
            a = int.Parse(Console.ReadLine());
            area = 6 * a * a;
            volume = a * a * a;
            Console.WriteLine(area);
            Console.WriteLine(volume);

        }
    }
}
