// Сейдалиев, 2ИСП-2, Вариант-2, 08.01.2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_11_2ИСП_2_Сейдалиев
{
    internal class Program
    {
        static void task_1() //задание 1
        {
            Console.Write("Введите число n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double A = 1;

            for (int i = 1; i <= n; i++)
            {
                A += 1.0 / Math.Pow(n, i);
            }
            Console.WriteLine($"A = {A,5:f2}");
        }
        static void task_2() //задание 2
        {
            Console.Write("Введите колличество чисел n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a, a1, a2, a3, k = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Введите трехзначное число: ");
                a = Convert.ToInt32(Console.ReadLine());

                a1 = a / 100;
                a2 = (a / 10) % 10;
                a3 = a % 10;

                if ((a1 + a2 + a3) % 5 == 0)
                    k++;
            }

            Console.WriteLine($"k = {k}");
        }
        static void task_3() //задание 3
        {
            Console.Write("Введите m и n ( m <= n ) \n m = ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write(" n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            double P = 1.0 / m;

            for (int i = 1; i <= n; i++)
            {
                P += 1.0 / (m + i);
            }

            Console.WriteLine($" P = {P,7:f4}");
        }
        public static void Main(string[] args)
        {
            number_task:
            Console.Write("Введите номер задания (0 - выход): ");

            int num = Convert.ToInt32(Console.ReadLine());

               switch (num)
                {
                    case 0:
                        Console.WriteLine("Для завершения программы нажмите Enter");
                        break;

                    case 1:
                        task_1();
                        goto number_task;

                    case 2:
                        task_2();
                        goto number_task;

                    case 3:
                        task_3();
                        goto number_task;

                    default:
                        Console.WriteLine("Введен неверный номер задачи");
                        break;
                }

            Console.ReadKey();
        }
    }
}
