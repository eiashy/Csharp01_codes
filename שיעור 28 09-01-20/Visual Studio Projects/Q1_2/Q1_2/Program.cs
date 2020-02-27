using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_2
{
    class Program
    {
        static bool CheckPlindromArr(int[] arr)
        {
            int i, j;
            for(i=0,j=arr.Length-1;i<arr.Length;i++,j--)
            {
                if (arr[i] != arr[j])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            bool check;
            int[] arr = new int[] { 10, 3, 540, 540, 3, 10 };
            check = CheckPlindromArr(arr);
            Console.WriteLine(check);
            arr = new int[] { 10, 3, 540, 540, -3, 10 };
            check = CheckPlindromArr(arr);
            Console.WriteLine(check);
        }
    }
}
