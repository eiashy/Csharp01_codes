using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_1
{
    class Program
    {
        static string SwapStrEven(string str)
        {
            string x= "";
            int i;
            if (str.Length%2==0)
            {
                for (i = 0; i < str.Length; i+=2)
                {
                    x += str[i + 1];
                    x += str[i];
                }
            }else
            {
                for (i = 0; i < str.Length-1; i += 2)
                {
                    x += str[i + 1];
                    x += str[i];
                }
                x += str[str.Length - 1];
            }
           
            return x;
        }
        static void Main(string[] args)
        {
            string str = "good";
            str = SwapStrEven(str);
            Console.WriteLine(str);
            str = "goodg";
            str = SwapStrEven(str);
            Console.WriteLine(str);
        }
    }
}
