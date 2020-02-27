using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_1
{
    class Program
    {
        static bool CheckPositive(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            bool check;
            int[] arr = new int[] { 5, 45, 46, 38, 134, 6, 43 };
            check = CheckPositive(arr);
            Console.WriteLine("arr1:");
            if(check)
                Console.WriteLine("all numbers is positive");
            else
                Console.WriteLine("have numbers not positive");
            arr = new int[] { 5, 45, -46, 38, 134, -6, 43 };
            Console.WriteLine("arr2:");
            check = CheckPositive(arr);
            if (check)
                Console.WriteLine("all numbers is positive");
            else
                Console.WriteLine("have numbers not positive");
        }
    }
}
