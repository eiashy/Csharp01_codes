using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void PrintMatSmall(char[,] mat)
        {
            for(int i=0;i<mat.GetLength(0);i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if(mat[i,j]>='a' && mat[i,j]<='z')
                    {
                        Console.Write(mat[i, j]+"\t");
                    }
                }
            }
            Console.WriteLine();
        }
        static void PrintMatBig(char[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] >= 'A' && mat[i, j] <= 'Z')
                    {
                        Console.Write(mat[i, j] + "\t");
                    }
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            char[,] mat = new char[3, 3] { { 'A', 'B', 'a' }, { 'l', 'L', 'm' }, { 'Z', 'z', 'M' } };
            PrintMatSmall(mat);
            PrintMatBig(mat);
        }
    }
}
