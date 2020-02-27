using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_21_11_19
{
    class Program
    {
        static void Main(string[] args)
        {
            const float COLA = 5.5f, WATER = 4.8f, SPRITE = 6.4f, PRIGAT = 5.8f;
            byte chois;
            float pyment;
            Console.WriteLine(@"1.	cola 5.5 nis
2.	water 4.8 nis
3.	sprite 6.4 nis
4.	prigat  5.8 nis
choose a drink:");
            chois = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter your payment:");
            pyment = float.Parse(Console.ReadLine());
            switch(chois)
            {
                case 1:
                    Console.WriteLine($"you've choose cola 5.5 nis  you've paid {pyment} shekels and your change is {pyment-COLA}");
                    break;
                case 2:
                    Console.WriteLine($"you've choose water 4.8 nis  you've paid {pyment} shekels and your change is {pyment - WATER}");
                    break;
                case 3:
                    Console.WriteLine($"you've choose sprite 6.4 nis  you've paid {pyment} shekels and your change is {pyment - SPRITE}");
                    break;
                case 4:
                    Console.WriteLine($"you've choose prigat  5.8 nis  you've paid {pyment} shekels and your change is {pyment - PRIGAT}");
                    break;
                default:
                    Console.WriteLine("worng chois");
                    break;
            }
        }
    }
}
