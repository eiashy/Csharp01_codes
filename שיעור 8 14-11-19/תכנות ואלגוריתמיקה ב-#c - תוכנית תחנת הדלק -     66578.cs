using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double fuel;
            const float PRICE = (float)5.96;
            //const float PRICE = 5.96f;
            Console.WriteLine("How much liters?");
            fuel = double.Parse(Console.ReadLine());
            double amount_to_pay;
            amount_to_pay = fuel * PRICE;
            amount_to_pay = Math.Round(amount_to_pay, 2);
            Console.WriteLine($"You must pay {amount_to_pay:F2} shekels");
            //Console.WriteLine("You must pay "+amount_to_pay+" shekels");
            //Console.WriteLine("You must pay {0} shekels",amount_to_pay);
            Console.WriteLine("How much do you pay?");
            double payment;//מה שהלקוח שילם
            payment = double.Parse(Console.ReadLine());
            if (payment > amount_to_pay)
            {
                Console.WriteLine($"Your change is {payment - amount_to_pay:f2} shekels");
            }
            else
            {
                Console.WriteLine($"You need to add {amount_to_pay - payment:f2} shekels");
            }

            Console.WriteLine("Thank you for your purchase");
        }  
        }
}
