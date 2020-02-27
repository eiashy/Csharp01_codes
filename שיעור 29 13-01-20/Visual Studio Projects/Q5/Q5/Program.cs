using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Program
    {
        static bool CheckZeroOne(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] != 0 && mat[i, j] != 1)
                        return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            bool check;
            int[,] mat1 = new int[3, 2] { { 1, 0 }, { 4, 5 }, { 7, 8 } };
            check = CheckZeroOne(mat1);
            Console.WriteLine(check);
            int[,] mat2 = new int[3, 2] { { 1, 0 }, { 1,0 }, { 0,1 } };
            check = CheckZeroOne(mat2);
            Console.WriteLine(check);
        }
    }
}
