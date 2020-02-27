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
            //char x;
            //Console.WriteLine("Enter a character");
            //x = char.Parse(Console.ReadLine());
            //if (x >= 'A' && x <= 'Z')
            //    Console.WriteLine("This is a capital letter");
            //else if(x>='a'&&x<='z')
            //    Console.WriteLine("This is a small letter");
            //else
            //    Console.WriteLine("This is not a letter");
            /*כתוב תוכנית שקולטת תו המייצג פרי בצורה הבאה:
a - apple		b - banana	 o - orange 	  other character - other fruit
התוכנית תציג את שם הפרי בהתאם לאות שנקלטה.

             */
             //if
            //char fruit;
            //Console.WriteLine("Enter the first letter of your fruit");
            //fruit = char.Parse(Console.ReadLine());
            //if(fruit=='a'||fruit=='A')
            //    Console.WriteLine("Apple");
            //else if(fruit=='b'||fruit=='B')//else if (fruit==98||fruit==66)
            //    Console.WriteLine("Banana");
            //else if(fruit=='o' || fruit=='O')
            //    Console.WriteLine("Orange");
            //else
            //    Console.WriteLine("Another fruit");

            char fruit;
            Console.WriteLine("Enter the first letter of your fruit");
            fruit = char.Parse(Console.ReadLine());
            switch(fruit)
            {
                //case 65:
                case 'A':
                case 'a': Console.WriteLine("Apple");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Banana");
                    break;
                case 'O':
                case 'o':
                    Console.WriteLine("Orange");
                    break;
                default: Console.WriteLine("Another fruit");
                    break;
                  

            }

        }
    }
}
