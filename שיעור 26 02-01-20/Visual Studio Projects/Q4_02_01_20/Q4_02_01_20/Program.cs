using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_02_01_20
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 8;
            int[] arr = new int[SIZE];
            bool flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"fill the arr {i} of {SIZE - 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 2; i < arr.Length; i++)
            {
                if(arr[i-2] + arr[i-1] == arr[i])
                {
                    flag = true;
                    break;
                }
            }
            if(flag)
                Console.WriteLine("we have two numbers with sums");
            else
                Console.WriteLine("dont have");
        }
    }
}
