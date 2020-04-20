using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
    
        Console.WriteLine("Введите число строк первой матрицы:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("\nВведите число столбцов первой матрицы, оно же число строк второй матрицы:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("\nВведите число столбцов второй матрицы:");
        int k = int.Parse(Console.ReadLine());

        Random rand = new Random();
        int[,] firstMatrix = new int[n, m];
        int[,] secondMatrix = new int[m, k];
        int[,] newMatrix = new int[n, k];

        // генерация данных матриц
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                firstMatrix[i, j] = rand.Next(-9, 10);
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < k; j++)
            {
                secondMatrix[i, j] = rand.Next(-9, 10);
            }
        }

        // подсчет значений финальной матрицы
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < k; j++)
            {
                newMatrix[i, j] = 0;
                for (int l = 0; l < m; l++)
                {
                    newMatrix[i, j] += firstMatrix[i, l] * secondMatrix[l, j];
                }

            }
        }


        Console.WriteLine("\nРезультат вычислений:");

        int line = (n > m) ? n : m; // количество строк вывода
        int column = m + k * 2 + 8; // количество столбцов вывода
        string[,] outputMatrix = new string[line, column]; // общая матрица вывода

        // инициализация матрицы вывода
        for (int i = 0; i < line; i++)
        {
            for (int j = 0; j < column; j++)
            {
                outputMatrix[i, j] = "";
            }
        }

        // заполнение матрицы вывода данными из первой и финальной матриц
        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < m; j++)
            {
                outputMatrix[i, j + 1] = firstMatrix[i, j].ToString();
            }

            for (int j = 0; j < k; j++)
            {
                outputMatrix[i, j + (m + k + 7)] = newMatrix[i, j].ToString();
            }
        }

        // заполнение матрицы вывода данными из второй матрицы
        for (int i = 0; i < m; i++)
        {

            for (int j = 0; j < k; j++)
            {
                outputMatrix[i, j + m + 4] = secondMatrix[i, j].ToString();
            }
        }


        // вывод данных на экран
        for (int i = 0; i < line; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write("{0,5}", outputMatrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
    
