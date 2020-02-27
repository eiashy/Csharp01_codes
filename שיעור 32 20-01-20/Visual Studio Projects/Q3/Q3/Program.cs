using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Car c2 = new Car();
            Car c3 = new Car();
            Console.WriteLine($"enter the info for car {1} of {3}");
            Console.WriteLine("car name: ");
            c1.carName = Console.ReadLine();
            Console.WriteLine("car color: ");
            c1.color = Console.ReadLine();

            Console.WriteLine($"enter the info for car {2} of {3}");
            Console.WriteLine("car name: ");
            c2.carName = Console.ReadLine();
            Console.WriteLine("car color: ");
            c2.color = Console.ReadLine();

            Console.WriteLine($"enter the info for car {3} of {3}");
            Console.WriteLine("car name: ");
            c3.carName = Console.ReadLine();
            Console.WriteLine("car color: ");
            c3.color = Console.ReadLine();

            Console.WriteLine($"the Info for the car {1} is : \n car name: {c1.carName} , color: {c1.color}");
            Console.WriteLine($"the Info for the car {2} is : \n car name: {c2.carName} , color: {c2.color}");
            Console.WriteLine($"the Info for the car {3} is : \n car name: {c3.carName} , color: {c3.color}");
        }
    }
}
