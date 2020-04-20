using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixtoNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число строк матрицы:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите число столбцов матрицы:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите число, на которое будет производиться умножение, значением от -100 до 100:");

            int number = int.Parse(Console.ReadLine());

            while ((number < -100) || (number > 100))
            {
                
                Console.WriteLine("Неверный ввод числа, повторите!");
                number = int.Parse(Console.ReadLine());
            }

            Random rand = new Random();
            int[,] matrix = new int[n, m];

            // генерация данных матрицы
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(-9, 10);

                }


            }


            Console.WriteLine("\nМатрица:");
            // вывод примера в консоль
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nУмножение на число:");

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] * number + "\t ");
                }


                Console.WriteLine();
            }
        }

    }
}
