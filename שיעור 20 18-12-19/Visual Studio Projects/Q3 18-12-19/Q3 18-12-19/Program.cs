using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_18_12_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num , i;
            bool flag=false;
            Console.WriteLine("enter number up to 0");
            num = int.Parse(Console.ReadLine());
            while (num <= 0)
            {
                Console.WriteLine("try agin , enter number up to 0");
                num = int.Parse(Console.ReadLine());
            }
            if (num == 1)
                flag = false;
            else if (num == 2)
                flag = true;
            else for (i = 2; i < num; i++)
                {
                    if (num % i == 0)
                        flag = true;
                }
            if(flag)
                Console.WriteLine("the number not farset");
            else
                Console.WriteLine("the number is far");
        }
    }
}
