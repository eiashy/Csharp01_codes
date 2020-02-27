using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_1
{
    class Program
    {
        static long StrToNum(string str)
        {
            long num = 0;
            int x = 0;
            for(int i = str.Length-1; i >=0 ; i--)
            {
                x = (str[i] - '0');
                Console.WriteLine(x);
            }
            return num;
        }
        static void Main(string[] args)
        {
            string str = "123456";
            long num = StrToNum(str);
            Console.WriteLine(num);
        }
    }
}
