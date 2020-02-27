using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class Program
    {


        static void Main(string[] args)
        {

            int x = 25;

            //alignment - יישור לימין לשמאל
            Console.WriteLine($"Aligned to the right {x,10}, aligned to the left {x,-10}.");
            //Output: Aligned to the right         25, aligned to the left 25        .
            
            //floating point - מספרים ממשיים
            Console.WriteLine($"real number x.xx:{1.23456:F2}");
            //Output: real number x.xx:1.23

            //left and right zeros
            Console.WriteLine($"minimum 3 numbers left of the point and exactely 4 to the right {123456789.123456789:000.0000}");
            Console.WriteLine($"minimum 3 numbers left of the point and exactely 4 to the right {12.12:000.0000}");
            //Output:
            //minimum 3 numbers left of the point and exactely 4 to the right 123456789.1235
            //minimum 3 numbers left of the point and exactely 4 to the right 012.1200
            

            //with commas
            Console.WriteLine($"123456789 with commas:{123456789:N}");
            //Output: 123456789 with commas:123,456,789.00
            
            
            //special characters

            // \n  = enter
            Console.WriteLine("line1\nline2");
            //Output: 
            //line1
            //line2

            // \b one char back
            Console.WriteLine("123456\b7890");
            //Output: 123457890


            // \r goto line start 
            Console.WriteLine("1234567\r89");
            //Output: 8934567
            
            // \t one tab forward (8 chars)
            Console.WriteLine("12345\t6789");
            //Output: 12345   6789

        }
    }

}

     
