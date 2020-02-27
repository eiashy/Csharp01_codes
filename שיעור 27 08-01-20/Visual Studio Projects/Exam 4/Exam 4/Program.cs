using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_4
{
    class Program
    {
        static int CountOfNumber(int[] arr,int num)
        {
            int count = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == num)
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[]{ 5, 10, 5, 15, 7, 8, 5, 5, 5, 5, 3 };
            int count = CountOfNumber(arr, 5);
            Console.WriteLine($"number of the number 5 is {count}");
        }
    }
}
