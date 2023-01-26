using System;
using System.Security.Cryptography;

namespace ПР9_2ИСП2_Сейдалиев_Семиволос
{
    class MainClass
    {
        static double z1(double m1, double m2) // задача 1

        {
            if (m1 < m2) return m1;
            else return m2;

        }
        static void z2() // задача 2

        {
            Console.Write("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double y;
            
            if (x < -12)
            {
                y = 2 / (x - 7);
                Console.WriteLine("y = " + y);
            }
            else
            {
                if (x > -12 && x < 12)
                {
                    y = Math.Sqrt(x + 20);
                    Console.WriteLine("y = " + y);
                }

                else
                {
                    y = 1 / (15 - x) + 1;
                    Console.WriteLine("y = " + y);
                }
            }

        }
        static void z3() // задача 3
        {
            Console.WriteLine("Введите значения x и y: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > -1 && x < 0 && y < 0 && y > -1)
            {
                Console.WriteLine($"Точка с координатами ({x};{y}) попадает в указанную заштрихованную область плоскости");
            }
            else if (x > -2 && x < -1 && y > 1 && y < 2)
            {
                Console.WriteLine($"Точка с координатами ({x};{y}) попадает в указанную заштрихованную область плоскости");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x};{y}) не попадает в указанную заштрихованную область плоскости");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи ");
            int n = Convert.ToInt32(Console.ReadLine());
            double k1;
            switch (n)
            {
                case 1:
                    Console.WriteLine("Введите два числа ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double b = Convert.ToDouble(Console.ReadLine());
                    k1 = z1(a, b);
                    Console.WriteLine("Меньшее значение " + k1);
                    break;
                case 2:
                    z2();
                    break;
                case 3:
                    z3();
                    break;
            }
            Console.WriteLine("Для завершения программы нажмите Enter");
            Console.ReadKey();
        }
    }
}