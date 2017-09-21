using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, min, max;
            bool f;
            do
            {
                Console.WriteLine("Введите количество строк: ");
                f = int.TryParse(Console.ReadLine(), out n);
            } while (f == false);
            do
            {
                Console.WriteLine("Введите количество столбцов: ");
                f = int.TryParse(Console.ReadLine(), out m);
            } while (f == false);
            do
            {
                Console.WriteLine("Введите диапазон чисел: ");
                f = int.TryParse(Console.ReadLine(), out min);
            } while (f == false);
            do
            {
                f = int.TryParse(Console.ReadLine(), out max);
            } while (f == false);
            int[,] matr1 = new int[n, m];
            Random rnd = new Random();
            Console.WriteLine("Matrix");
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    matr1[i, j] = rnd.Next(min, max + 1);
                    Console.WriteLine($"{matr1[i, j],4}");
                }
                Console.WriteLine();
            }
            int k = 0;
            int x = 1;
            for (int i=0; i < matr1.GetLength(0); i++)
            {
                for (int j=0; j< matr1.GetLength(1); j++)
                {
                    if (matr1[i, j] > 0)
                        k = k + 1;
                }
                x++;
            }
            Console.WriteLine($"Количество положительных чесел выше диагонали: {k}");
            int s = 0, z = 0;
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    s = s + matr1[i, j];
                    Console.WriteLine(s);
                }
                z++;
            }
            Console.WriteLine($"Сумма чисел ниже диагонали: {s}");
        }
    }
}
