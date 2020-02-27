using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1__1
{
    class Program
    {
        static void PrintSintans(string str)
        {
            string x = "";
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]==' ')
                { 
                    Console.WriteLine(x);
                    x = "";
                }
                else
                {
                    x += str[i];
                }
            }
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            string str = "Hallo World Man";
            PrintSintans(str);
        }
    }
}
