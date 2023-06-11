using System;

namespace exam7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();
        }

        static void Task1()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int y = 0;

            if (a < b)
            {
                y = a;
            }
            else
            {
                y = b;
            }
            
            Console.WriteLine($"y = {y}");
        }

        static void Task2()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y;

            if (x < -10 && x >= -12)
            {
                y = Math.Sqrt(x+12);
                Console.WriteLine($"y = {y}, x < -10");
            }
            else if (x >= -10 && x <= 10)
            {
                y = 1 / (x - 5);
                Console.WriteLine($"y = {y}, x >= -10 & x <= 10");
            }
            else if (x > 10)
            {
                y = 1 / (11 - x) + 5;
                Console.WriteLine($"y = {y}, x > 10");
            }
            else
            {
                Console.WriteLine("х не принадлежит ОДЗ");
            }
        }

        static void Task3()
        {
            
        }
    }
}