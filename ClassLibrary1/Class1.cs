using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Matrix
    {
        public static void ProductMatrix (int [,] integers, int[,] matrix)
        {
           int [,] matr3 = new int[integers.GetLength(1), integers.GetLength(0)];
            for (int i = 0; i < matr3.GetLength(0); i++)
            {
                for (int j = 0; j < matr3.GetLength(1); j++)
                {
                    for (int q = 0; q < integers.GetLength(0) - 1; q++)
                    {
                        matr3[i, j] += integers[i, q] * matrix[q, j];
                    }
                    Console.WriteLine($"{matr3[i, j],4}");
                }
                Console.WriteLine();
            }
        }
        public static void Sum(int[,] integers)
        {
            for (int i = 0; i < integers.GetLength(0); i++)
            {
                for (int j = 0; j < integers.GetLength(0); j++)
                {
                    Console.Write($"{integers[i, j],4}");
                }
                Console.WriteLine();
            }
        }
         public static void SumDiagonal(int[,] integers)
         {
            int s = 0, z = 0;
            for (int i = 0; i < integers.GetLength(0); i++)
            {
                for (int j = 0; j < integers.GetLength(1); j++)
                {
                    s = s + integers[i, j];
                    Console.WriteLine(s);
                }
                z++;
            }
         }
        public static int PositineDiagonal(int[,] integers)
        {
            int k = 0;
            int x = 1;
            for (int i = 0; i < integers.GetLength(0); i++)
            {
                for (int j = 0; j < integers.GetLength(1); j++)
                {
                    if (integers[i, j] > 0)
                        k = k + 1;
                }
                x++;
            }
            return k;
        }
    }
}
