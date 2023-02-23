// Сейдалиев и Семиволос, 2ИСП-2, Вариант 1, Задание 3
using System;

namespace ПР_17_3_2ИСП2_Сейдалиев_Семиволос
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] A = gen_massiv(-15, 15);
            int[] S = new int[A.GetLength(0)];

            S = Task_3(A);

            Console.WriteLine("Исходный массив = ");
            vivod_massiv2(A);

            Console.WriteLine("Преобразованный массив = ");
            vivod_massiv1(S);
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

        static void vivod_massiv1(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
                Console.Write("{0, 6}", mas[i]);
        }

        static int[] Task_3(int[,] mas)
        {
            int[] b = new int[mas.GetLength(0) * mas.GetLength(1)];
            int index = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] > 0)
                    {
                        b[index] = mas[i, j];
                        index++;
                    }
                }

                //    int[] sum = new int[mas.GetLength(0)];
                //int s;

                //for (int i = 0; i < mas.GetLength(0); i++)
                //{

                //    s = 0;

                //    for (int j = 0; j < mas.GetLength(1); j++)
                //    {
                //        if (mas[i, j] > 0)
                //            s = mas[i, j];
                //    }
                //    sum[i] = s;
                //}
                //foreach (int item in mas)
                //{
                //    if (item > 0)
                //        s = item;
                //}
                //for (int i = 0; i < mas.Length; i++)
                //{
                //    if (mas[i, j] > 0)
                //        s = mas[i, j];

                //}

            }
            return b;
        }
    }
}
