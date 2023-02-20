// Сейдалиев и Семиволос, 2ИСП-2, Вариант 1, Задание 2
using System;

namespace ПР_17_2_2ИСП2_Сейдалиев_Семиволос
{
	class MainClass
	{
        public static void Main(string[] args)
        {
            int[,] B = gen_massiv(-30, 30);

            Console.WriteLine("Исходный массив = ");
            vivod_massiv2(B);

            Console.WriteLine("Преобразованный массив = ");
            vivod_massiv2(task_2(B));
        }

        static int[,] gen_massiv(int d1, int d2)
        {
            Console.Write("Введите кол-во строк: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите кол-во столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] mas = new int[n, m];

            Random r = new Random();

            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    mas[i, j] = r.Next(d1, d2 + 1);
            return mas;
        }

        static void vivod_massiv2(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write("{0, 6}", mas[i, j]);
                Console.WriteLine();
            }
        }

        static int[,] task_2(int[,] mas)
        {

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] < 0)
                        mas[i, j] *= -1;
                }
            }
            return mas;
        }
    }
}
