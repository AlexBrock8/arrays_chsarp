using System;
using System.Collections.Generic;
using System.Text;

namespace PascalTriangle
{

    class PascalTriangle
    {
        static void Main(string[] args)
        {

            Console.Write("Введите желаемое количество строк треугольника < 25\n");


            int n = int.Parse(Console.ReadLine()); ;
            
            while ((n > 24) || (n < 1))
            {

                Console.WriteLine("Некорректный ввод, повторите , число < 25");
                n = int.Parse(Console.ReadLine());
                
            }

                for (int y = 0; y < n; y++)
                {
                    int c = 1;
                    for (int q = 0; q < n - y; q++)
                    {
                        Console.Write("   ");
                    }

                    for (int x = 0; x <= y; x++)
                    {
                        Console.Write("   {0:D} ", c);
                        c = c * (y - x) / (x + 1);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine();
           

            }
        }  
    }







