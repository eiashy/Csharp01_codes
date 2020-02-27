using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7_07_11_19
{
    class Q7
    {
        /*
         * קולט שני מספרים ובודק מי מהם גדול ומדביס הפסיד או הרוויח
         */
        static void Main(string[] args)
        {
            const byte PRICEBUY = 5, PRICESALE = 10;
            int numofbuy, numofsale;
            Console.WriteLine("enter how many buys");
            numofbuy = int.Parse(Console.ReadLine());
            Console.WriteLine("enter how many sales");
            numofsale = int.Parse(Console.ReadLine());
            if ((PRICEBUY * numofbuy) > (PRICESALE * numofsale))
                Console.WriteLine("not winner");
            else
                Console.WriteLine("winner");
        }
    }
}
