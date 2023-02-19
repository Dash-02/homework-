// Сейдалиев и Семиволос, 2ИСП-2, Вариант 1, Задача 3
using System;

namespace ПР_18_2ИСП_2_Сейдалиев_Семиволос
{
    class MainClass
    {
        // объявление и инициализация массива
        static int[,] gen_massiv(int d1, int d2)
        {
            int[,] mas = new int[4, 4];

            Random r = new Random();

            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    mas[i, j] = r.Next(d1, d2 + 1);
            return mas;
        }

        // вывод массива
        static void vivod_massiv(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write("{0, 6}", mas[i, j]);
                Console.WriteLine();
            }
        }

        // Вычисление суммы элементов, стоящих под главной диагональю матрицы
        static int zadacha3(int[,] mas)
        {
            int sum = 0;

            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    if (i > j)
                        sum += mas[i, j];
            
            return sum;
        }

        public static void Main(string[] args)
        {
            // решение третьей задачи
            int[,] A = gen_massiv(1, 10);
            int s = zadacha3(A);
            Console.WriteLine("Исходный массив:");
            vivod_massiv(A);
            Console.Write($"Сумма элементов, стоящих под главной диагональю матрицы: {s}");
        }
    }
}