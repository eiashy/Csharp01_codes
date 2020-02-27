using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil7
{
    class Program
    {
        /*
         התוכנית קולטת מספר דו ספרתי.
         לאחר מכן נותן תפריט עם אופציות
         ולפי הבחירה ניא תדפיס את התובה הרצויה עד שתיהיה בקשה להפיס את התוכנית.
         */
         /*
            //דרך 1
        static void Main(string[] args)
        {
            int num=0, choice;

            do
            {
                if(num==0) // בדיקה האם num = 0 בשביל שלא ירוץ כל הזמן
                { 
                Console.Write("Please enter 2 digit numbers: "); // קליטה ראשונית
                num = int.Parse(Console.ReadLine());
                while (!((num >= 10 && num <= 99) || (num >= -99 && num <= -10))) //בודק שבאמת דו ספרתי
                {
                    Console.Write("you did mistake, please try again remember enter 2-didgit number: ");
                    num = int.Parse(Console.ReadLine());
                }
                }
                Console.WriteLine("1. enter a two digits number\n2. test if even\n3. sum of digits \n4. number*4\n5.test if positive\n6.exit"); //תפריט
                Console.Write("enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Please enter 2 digit numbers: "); // קליטה ראשונית
                        num = int.Parse(Console.ReadLine());
                        while (!((num >= 10 && num <= 99) || (num >= -99 && num <= -10)))//בודק שבאמת דו ספרתי
                        {
                            Console.Write("you did mistake, please try again remember enter 2-didgit number: ");
                            num = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        if(num%2==0)// בדיקה אם המספר הוא זוגי
                        {
                            Console.WriteLine($"the num {num} is even!");
                        }
                        else//אם לא הוא אי זוגי
                        {
                            Console.WriteLine($"the num {num} is odd!");

                        }
                        break;
                    case 3:
                        Console.WriteLine($"The sum of the digits in the number {num} is {Math.Abs(num) / 10 + Math.Abs(num) % 10}"); //סכום ספרותיו
                        break;
                    case 4:
                        Console.WriteLine($"{num}*4 = {num * 4}");//המספר כפול 4
                        break;
                    case 5:
                        if(num<0)
                        {
                            Console.WriteLine("The number is negative");// המספר שלילי
                        }
                        else
                        {
                            Console.WriteLine("The number is positive");// המספר חיובי

                        }
                        break;
                    case 6:
                        Console.WriteLine("you chose to exit the system");
                        break;
                    default:
                        Console.WriteLine("you chose option that not in the range, please try again!");
                        break;
                }
                Console.WriteLine("please clean the screen by presssing any key");
                Console.ReadKey();
                Console.Clear();
            } while (!(choice == 6));
        }
        */
        
         //דרך 2
        //כאן ישר יראה את התפריט אך יחייב במקרה שלא בחר באפשרות 1 להכניס מספר דו ספרתי
        static void Main(string[] args)
        {
            int num = 0, choice;

            do
            {
                Console.WriteLine("1. enter a two digits number\n2. test if even\n3. sum of digits \n4. number*4\n5.test if positive\n6.exit"); //תפריט
                Console.Write("enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Please enter 2 digit numbers: "); // קליטה ראשונית
                        num = int.Parse(Console.ReadLine());
                        while (!((num >= 10 && num <= 99) || (num >= -99 && num <= -10)))//בודק שבאמת דו ספרתי
                        {
                            Console.Write("you did mistake, please try again remember enter 2-didgit number: ");
                            num = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        if (num == 0) // בדיקה האם num = 0 בשביל שלא ירוץ כל הזמן
                        {
                            Console.Write("Please enter 2 digit numbers: "); // קליטה ראשונית
                            num = int.Parse(Console.ReadLine());
                            while (!((num >= 10 && num <= 99) || (num >= -99 && num <= -10))) //בודק שבאמת דו ספרתי
                            {
                                Console.Write("you did mistake, please try again remember enter 2-didgit number: ");
                                num = int.Parse(Console.ReadLine());
                            }
                        }
                        if (num % 2 == 0)// בדיקה אם המספר הוא זוגי
                        {
                            Console.WriteLine($"the num {num} is even!");
                        }
                        else//אם לא הוא אי זוגי
                        {
                            Console.WriteLine($"the num {num} is odd!");

                        }
                        break;
                    case 3:
                        if (num == 0) // בדיקה האם num = 0 בשביל שלא ירוץ כל הזמן
                        {
                            Console.Write("Please enter 2 digit numbers: "); // קליטה ראשונית
                            num = int.Parse(Console.ReadLine());
                            while (!((num >= 10 && num <= 99) || (num >= -99 && num <= -10))) //בודק שבאמת דו ספרתי
                            {
                                Console.Write("you did mistake, please try again remember enter 2-didgit number: ");
                                num = int.Parse(Console.ReadLine());
                            }
                        }
                        Console.WriteLine($"The sum of the digits in the number {num} is {Math.Abs(num) / 10 + Math.Abs(num) % 10}"); //סכום ספרותיו
                        break;
                    case 4:
                        if (num == 0) // בדיקה האם num = 0 בשביל שלא ירוץ כל הזמן
                        {
                            Console.Write("Please enter 2 digit numbers: "); // קליטה ראשונית
                            num = int.Parse(Console.ReadLine());
                            while (!((num >= 10 && num <= 99) || (num >= -99 && num <= -10))) //בודק שבאמת דו ספרתי
                            {
                                Console.Write("you did mistake, please try again remember enter 2-didgit number: ");
                                num = int.Parse(Console.ReadLine());
                            }
                        }
                        Console.WriteLine($"{num}*4 = {num * 4}");//המספר כפול 4
                        break;
                    case 5:
                        if (num == 0) // בדיקה האם num = 0 בשביל שלא ירוץ כל הזמן
                        {
                            Console.Write("Please enter 2 digit numbers: "); // קליטה ראשונית
                            num = int.Parse(Console.ReadLine());
                            while (!((num >= 10 && num <= 99) || (num >= -99 && num <= -10))) //בודק שבאמת דו ספרתי
                            {
                                Console.Write("you did mistake, please try again remember enter 2-didgit number: ");
                                num = int.Parse(Console.ReadLine());
                            }
                        }
                        if (num < 0)
                        {
                            Console.WriteLine("The number is negative");// המספר שלילי
                        }
                        else
                        {
                            Console.WriteLine("The number is positive");// המספר חיובי

                        }
                        break;
                    case 6:
                        Console.WriteLine("you chose to exit the system");
                        break;
                    default:
                        Console.WriteLine("you chose option that not in the range, please try again!");
                        break;
                }
                Console.WriteLine("please clean the screen by presssing any key");
                Console.ReadKey();
                Console.Clear();
            } while (!(choice == 6));
        }
    }
}

