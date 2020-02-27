using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_3
{
    class Program
    {
        static int[,] FillMat(int ROW, int COL)
        {
            int[,] mat = new int[ROW, COL];
            for(int i = 0; i < ROW; i++)
            {
                for(int j = 0; j < COL; j++)
                {
                    Console.WriteLine($"fill the index of the mat in {i},{j}");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return mat;
        }
        static void PrintMat(int[,] mat)
        {
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
        static void SumMat(int[,] mat)
        {
            int count=0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    count+=mat[i, j];
                }
            }
            Console.WriteLine($"THE SUM OF THE MAT IS {count}");
        }
        static void PosiMat(int[,] mat)
        {
            int count = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] >= 0)
                        count++;
                }
            }
            Console.WriteLine($"THE SUM OF THE MAT IS {count}");
        }
        static void Main(string[] args)
        {
            const int ROW = 3, COL = 2;
            int[,] mat = FillMat(ROW, COL);
            Console.WriteLine("******************************************************************************************");
            PrintMat(mat);
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("all numbers up 10 and the index");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if(mat[i, j] > 10)
                    {
                        Console.Write(mat[i, j] + $"\tthe index is [{i},{j}]");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("all numbers even");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j]%2==0)
                    {
                        Console.Write(mat[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("sum of all numbers in mat");
            SumMat(mat);
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("counter of number positev");
            PosiMat(mat);
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("print all the first row");
            for(int i = 0; i < mat.GetLength(1); i++)
            {
                Console.Write(mat[0, i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("print all the last col");
            int counter = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine(mat[i, mat.GetLength(1)-1]);
                counter += mat[i, mat.GetLength(1) - 1];
            }
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("print sum of last col");
            Console.WriteLine(counter);
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("print sum of socond col");
            for (int i = 0; i < mat.GetLength(1); i++)
            {
                counter += mat[2, i];
            }
            Console.WriteLine(counter);
        }
    }
}
