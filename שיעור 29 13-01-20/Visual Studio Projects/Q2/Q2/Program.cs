using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void PrintMatDo(int[,] mat)
        {
            for(int i=0;i<mat.GetLength(0);i++)
            {
                for(int j=0;j<mat.GetLength(1);j++)
                {
                    if(mat[i, j]>=10 && mat[i, j]<=99)
                    {
                        Console.WriteLine(mat[i,j]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 2] { { 12, 14 }, { 1, 17 }, { 5, 87 } };
            PrintMatDo(mat);
        }
    }
}
