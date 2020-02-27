using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            string max = "";
            string str="";
            do
            {
                int counter = 0;
                Console.WriteLine("enter the name: ");
                str = Console.ReadLine();
                if(str=="end")
                    continue;
                if (str.Length >= max.Length)
                    max = str;
            } while (str != "end");
            Console.WriteLine(max);
        }
    }
}
