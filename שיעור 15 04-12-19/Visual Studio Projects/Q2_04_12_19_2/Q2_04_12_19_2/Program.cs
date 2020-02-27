using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_04_12_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i;
            float dolar;
            Console.WriteLine("enter how much the dolar");
            dolar = float.Parse(Console.ReadLine());
            while(!(dolar>0))
            {
                Console.WriteLine("enter how much the dolar");
                dolar = float.Parse(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("enter the dolar to shakel");
                num = int.Parse(Console.ReadLine());
                while (!(num > 0))
                {
                    Console.WriteLine("enter the dolar to shakel");
                    num = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"{num}  *  {dolar}  =  {num*dolar} nis");
            }
        }
    }
}
