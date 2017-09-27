
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

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
                Console.WriteLine("Введите количество строк");
                f = int.TryParse(Console.ReadLine(), out n);
            } while (f == false);
            do
            {
                Console.WriteLine("Введите количество столбцов");
                f = int.TryParse(Console.ReadLine(), out m);
            } while (f == false);
            do
            {
                Console.WriteLine("Введите диапазон чисел");
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
            Matrix.ProductMatrix(matr1, matr2);
        }
    }
}
