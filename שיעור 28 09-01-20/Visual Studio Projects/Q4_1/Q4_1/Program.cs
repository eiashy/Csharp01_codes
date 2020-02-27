using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_1
{
    class Program
    {
        static int CountTheArr(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                count += arr[i];
            return count;
        }
        static void Main(string[] args)
        {
            int count;
            int[] arr = new int[] { 5, 45, 46, 38, 134, 6, 43 };
            count = CountTheArr(arr);
            Console.WriteLine(count);
        }
    }
}
