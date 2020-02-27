using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_26_12_19
{
    class Program
    {
        static void Print1ToNum(int num)
        {
            for(int i = 1; i <= num; i++)
            {
                Console.Write(i+" ");
            }
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number up 0");
            num = int.Parse(Console.ReadLine());
            while (num <= 0)
            {
                Console.WriteLine("try agin , enter number up 0");
                num = int.Parse(Console.ReadLine());
            }
            Print1ToNum(num);
        }
    }
}
