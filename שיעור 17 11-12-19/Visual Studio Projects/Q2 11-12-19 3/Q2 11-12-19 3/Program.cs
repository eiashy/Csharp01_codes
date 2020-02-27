using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_11_12_19_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterBigw = 0, counterSmallw = 0, counterontherc = 0, counterNum=0;
            char c;
            Console.WriteLine("enter char to stop enter $");
            c = char.Parse(Console.ReadLine());
            while (c != '$')
            {
                if (c >= 'A' && c <= 'Z')
                    counterBigw++;
                else if (c >= 'a' && c <= 'z')
                    counterSmallw++;
                else if (c >= '0' && c <= '9')
                    counterNum++;
                else
                    counterontherc++;
                Console.WriteLine("enter char to stop enter $");
                c = char.Parse(Console.ReadLine());
            }
            Console.WriteLine($"big word {counterBigw}  ,  small word {counterSmallw}  ,  sum of word {counterBigw + counterSmallw}" +
                $"  ,  numbers {counterNum}  ,  chars {counterontherc}  ,  the all {counterBigw + counterSmallw + counterNum + counterontherc}");
        }
    }
}
