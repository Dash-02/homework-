// Сейдалиев и Семиволос, 2ИСП-2, Вариант 1, Задача 4
using System;

namespace ПР_18_4_2ИСП_2_Сейдалиев_Семиволос
{
    class MainClass
    {
        // объявление и инициализация массива
        static int[,] gen_massiv(int d1, int d2)
        {
            int[,] mas = new int[3, 3];

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

        // изменение четных и нечетных элементов
        static int[,] zadacha4(int[,] mas)
        {

            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    if (mas[i, j] % 2 == 0)
                        mas[i, j] = 0;
                    else
                        mas[i, j] = 1;
            vivod_massiv(mas);
            return mas;
        }

        public static void Main(string[] args)
        {
            // решение четвертой задачи
            int[,] A = gen_massiv(0, 100);
            Console.WriteLine("Исходный массив:");
            vivod_massiv(A);
            Console.WriteLine("Обработанный массив:");
            zadacha4(A);
        }
    }
}