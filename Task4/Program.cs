
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, min, max;
            bool f;
            do
            {
                Console.WriteLine("Введите количество");
                f = int.TryParse(Console.ReadLine(), out n);
            } while (f == false);
            do
            {
                Console.WriteLine("");
                f = int.TryParse(Console.ReadLine(), out m);
            } while (f == false);
            do
            {
                Console.WriteLine("");
                f = int.TryParse(Console.ReadLine(), out min);
            } while (f == false);
            do
            {
                Console.WriteLine("");
                f = int.TryParse(Console.ReadLine(), out max);
            } while (f == false);
            int[,] matr1 = new int[n, m];
            int[,] matr2 = new int[m, n];
            int[,] matr3 = new int[m, n];
            Random rnd = new Random();
            Console.WriteLine("First matrix");
            for (int i=0; i<matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    matr1[i, j] = rnd.Next(min, max + 1);
                    Console.WriteLine($"{matr1[i, j],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Second matrix");
            for (int i = 0; i < matr2.GetLength(0); i++)
            {
                for (int j = 0; j < matr2.GetLength(1); j++)
                {
                    matr2[i, j] = rnd.Next(min, max + 1);
                    Console.WriteLine($"{matr2[i, j],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Result matrix");
            for (int i = 0; i < matr3.GetLength(0); i++)
            {
                for (int j = 0; j < matr3.GetLength(1); j++)
                {
                    for (int q=0; q<n-1; q++)
                    {
                        matr3[i, j] += matr1[i, q] * matr2[q, j];
                    }
                    Console.WriteLine($"{matr3[i, j],4}");
                }
                Console.WriteLine();

            }
        }
    }
}
