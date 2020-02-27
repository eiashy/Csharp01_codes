using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_1
{
    class Program
    {
        static void PrintTheNotWordArr(char[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(!(arr[i]>='A' && arr[i]<='Z' || arr[i]>='a' && arr[i]<='z'))
                    Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            char[] arr = new char[] { 'A', 'b', 'c', '/', '5', 'v', 'c' };
            PrintTheNotWordArr(arr);
        }
    }
}
