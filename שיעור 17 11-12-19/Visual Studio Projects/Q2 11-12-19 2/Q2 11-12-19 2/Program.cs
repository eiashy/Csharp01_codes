using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_11_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float hight;
            int chois, conter=0;
            do
            {
                Console.WriteLine("1- to enter hight");
                Console.WriteLine("2- to stop ");
                Console.Write("enter the chois:");
                chois = int.Parse(Console.ReadLine());
                switch (chois)
                {
                    case 1:
                        Console.WriteLine("enter the high than big 0");
                        hight = float.Parse(Console.ReadLine());
                        while (hight <= 0)
                        {
                            Console.WriteLine("try agin, enter the high than big 0");
                            hight = float.Parse(Console.ReadLine());
                        }
                        if (hight > 1.6)
                            conter++;
                        break;
                    case 2:
                        Console.WriteLine($"number of the hight up 1.6 is {conter} \nbye bye");
                        break;
                    default:
                        Console.WriteLine("the chois not good");
                        break;
                }

            } while (chois != 2);
        }
    }
}
