using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    class Program
    {
        static string SwapStrr(string str)
        {
            string x = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                x += str[i];
            }
            return x;
        }
        static void Main(string[] args)
        {
            string str = "hello";
            str = SwapStrr(str);
            Console.WriteLine(str);
        }
    }
}
