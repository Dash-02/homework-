using System;

namespace ПР_18_2ИСП_2_Сейдалиев_Семиволос
{
	class MainClass
	{
		static int[,] gen_massiv(int d1, int d2)
        {
            int[,] mas = new int[4, 5];

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
        static int zadacha1(int[,] mas)
        {
            int m = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    if ((-20 <= mas[i, j] & mas[i, j] < -9) || (mas[i, j] > 9 & mas[i, j] <= 40))
                        m++;
            return m;
        }


        public static void Main(string[] args)
        {
            // решение первой задачи
            int[,] A = gen_massiv(-20, 41);
            int k = zadacha1(A);
            Console.WriteLine("Исходный массив:");
            vivod_massiv2(A);
            Console.WriteLine($"Количество двузначных элементов: {k}");
        }
	}
}
