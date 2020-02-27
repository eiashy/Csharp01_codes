using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_2
{
    class Program
    {
        static int CheckCountNumOfArr(int[] arr, int n)
        {
            int count = 0;
            for(int i=0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 3, 3, 3, 2, 4, 5, 10 };
            int count;
            count = CheckCountNumOfArr(arr, 3);
            Console.WriteLine(count);
            count = CheckCountNumOfArr(arr, 12);
            Console.WriteLine(count);
        }
    }
}
