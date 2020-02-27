using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static bool CheckSumMat(int[,] mat)
        {
            int count=0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    count += mat[i, j];
                }
            }
            Console.WriteLine(count);
            if (count % 2 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            bool check;
            int[,] mat1 = new int[3, 2] { { 1, 2 }, { 4, 5 }, { 7, 8 } };
            check = CheckSumMat(mat1);
            Console.WriteLine(check);
            int[,] mat2 = new int[3, 2] { { 1, 2 }, { 4, 5 }, { 7, 9 } };
            check = CheckSumMat(mat2);
            Console.WriteLine(check);
        }
    }
}
