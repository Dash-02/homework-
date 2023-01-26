// Семиволос, 2ИСП-2, Вариант-1, 08.01.2023
using System;

namespace ПР_11_2ИСП_2_Семиволос
{
    class Program 
    {
        static void z_1() // Задание 1
        {
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            double A = 0;

            for (int i = 0; i <= n; i++)
            {
                A += 1.0 / Math.Pow(n, i);
            }

            Console.WriteLine($"A = {A,5:f2}");
        }

        static void z_2() // Задание 2
        {
            Console.Write("Введите колличество чисел n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a, b, c, d, k = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Введите трехзначное число: ");
                a = Convert.ToInt32(Console.ReadLine());

                b = a / 100;
                c = (a / 10) % 10;
                d = a % 10;

                if ((b + c + d) % 4 == 0)
                    k++;
            }

            Console.WriteLine($"k = {k}");
        }

        static void z_3() // Задание 3
        {
            Console.Write("Введите m и n ( m <= n ) \n m = ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write(" n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            double K = m;

            for (int i = 1; i <= n; i++)
            {
                K *= (m + i);
            }

            Console.WriteLine($" K = {K,7:f4}");
        }

        public static void Main(string[] args)
        {
            ask_number:
            Console.Write("Введите номер задания (для выхода выберите 0): ");

            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 0:
                    Console.WriteLine("Для завершения программы нажмите Enter");
                    break;

                case 1:
                    z_1();
                    goto ask_number;

                case 2:
                    z_2();
                    goto ask_number;

                case 3:
                    z_3();
                    goto ask_number;

                default:
                    Console.WriteLine("Введен неверный номер задачи");
                    break;
            }

            Console.ReadKey();
        }
    }
}