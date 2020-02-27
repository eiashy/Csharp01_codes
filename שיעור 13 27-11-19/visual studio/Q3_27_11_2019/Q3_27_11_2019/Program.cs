using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_27_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num1, num2;
            Console.WriteLine("enter the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the last number");
            num2 = int.Parse(Console.ReadLine());
            if(num2>=num1)
            {
                for(i=num1;i<=num2;i++)
                {
                    Console.Write(i);
                    if (i != num2)
                        Console.Write(" , ");
                }
            }
            else
                for (i = num1; i >= num2; i--)
                {
                    Console.Write(i);
                    if (i != num2)
                        Console.Write(" , ");
                }
        }
    }
}
