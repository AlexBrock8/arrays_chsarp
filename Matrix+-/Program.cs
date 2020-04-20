using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число строк матрицы от 1 до 10:");
            int n = int.Parse(Console.ReadLine());

            while ((n < 1) || (n > 9))
            {
                Console.WriteLine("\nПовторите! Введите число от 1 до 10:");
                n = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("\nВведите число столбцов матрицы от 1 до 10:");
            int m = int.Parse(Console.ReadLine());

            while ((m < 1) || (m > 9))
            {
                Console.WriteLine("\nПовторите! Введите число от 1 до 10:");
                m = int.Parse(Console.ReadLine());
            }


            Random rand = new Random();
            int[,] AMatrix = new int[n, m];
            int[,] BMatrix = new int[n, m];

            // генерация данных матриц
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    AMatrix[i, j] = rand.Next(-10, 11);

                    BMatrix[i, j] = rand.Next(-10, 11);

                }

            }

            Console.WriteLine("\nРезультат вычислений:");
            // вывод примера в консоль
            #region сложение

            Console.WriteLine("\nМатрица А");
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    Console.Write(AMatrix[i, j] + "\t  ");
                }

                Console.WriteLine();


            }

            Console.WriteLine("\nМатрица Б");
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    Console.Write(BMatrix[i, j] + "\t  ");
                }

                Console.WriteLine();


            }

            Console.WriteLine("\nСложение матриц");
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    Console.Write(AMatrix[i, j] + BMatrix[i, j] + "\t ");
                }

                Console.WriteLine();


            }
            #endregion
            #region вычитание

            Console.WriteLine("\nВычитание матриц");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(AMatrix[i, j] - BMatrix[i, j] + "\t ");
                }

                Console.WriteLine("\n");
            }
            #endregion


        }
        

    }
}
