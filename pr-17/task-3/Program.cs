// Сейдалиев и Семиволос, 2ИСП-2, Вариант 1, Задание 3
using System;

namespace ПР_17_3_2ИСП2_Сейдалиев_Семиволос
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] A = gen_massiv(-15, 15);
            int[] S;

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
            int[] b = new int[mas.Length];

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
            }
            ResizeArr(ref b, index);
            SortArr(b);
            return b;
        }

        static void ResizeArr(ref int[] b, int index)
        {
            int[] newArr = new int[index];
            for (int i = 0; i < newArr.Length && i < newArr.Length; i++)
            {
                newArr[i] = b[i];
            }
            b = newArr;
        }

        static int[] SortArr(int[] b)
        {
            for (int i = 0; i < b.Length - 1; i++)
            {
                for (int j = i + 1; j < b.Length; j++)
                {
                    if (b[i] < b[j])
                    {
                        var C = b[j];
                        b[j] = b[i];
                        b[i] = C;
                    }
                }
            }
            return b;
        }
    }
}