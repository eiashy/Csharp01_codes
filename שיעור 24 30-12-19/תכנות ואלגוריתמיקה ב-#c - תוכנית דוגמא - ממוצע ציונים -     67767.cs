using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUM_OF_GRADES = 3;
            int sum = 0;
            int[] grades = new int[NUM_OF_GRADES];
            Console.WriteLine("Enter " + NUM_OF_GRADES + " grades");
            for (int i = 0; i < NUM_OF_GRADES; i++)
            {
                grades[i] = int.Parse(Console.ReadLine());
                sum += grades[i];
            }
            double average = (double)sum / NUM_OF_GRADES;
            Console.WriteLine($"The average is {average:F2}");

            for (int i = 0; i < NUM_OF_GRADES; i++)
            {
                if (grades[i] > average)
                    Console.WriteLine(grades[i]);
            }
            
            
            



        }
    }
}
