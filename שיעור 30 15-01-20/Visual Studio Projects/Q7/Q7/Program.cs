using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Program
    {
        static string BackStr(string str)
        {
            string strNew = "";
            strNew += str[1];
            strNew += str[0];
            for (int i = 2; i < str.Length; i++)
            {
                strNew += str[i];
            }
            return strNew;
        }
        static void Main(string[] args)
        {
            string str = "Smile", strNew;
            strNew = BackStr(str);
            Console.WriteLine(strNew);
        }
    }
}
