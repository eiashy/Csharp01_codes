using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Count
    {
        private int value;
        public void Initialize(int value)
        {
            this.value = value;
        }
        public void Increment(int value)
        {
            this.value = value;
        }
        public void Decrement(int value)
        {
            this.value = value;
        }
        public void Go()
        {
            for(int i=0;i<=this.value;i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
    }
}
