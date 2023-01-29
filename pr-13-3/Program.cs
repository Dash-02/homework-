using System;

namespace ПР13_Задание3_2ИСП2_Сейдалиев_Семиволос
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] A = new double[n];

            Random r = new Random();

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Convert.ToDouble(r.Next(-100, 51)/10.0);
                Console.WriteLine($"A[{i}] = " + A[i]);
            }

            Console.WriteLine();

            double sr = A.Average();
            double max = A.Max();

            for (int i = 0; i < n; i++) 
            {
                if (max == A[i])
                    A[i] = sr;
                Console.WriteLine($"A[{i}] = " + A[i]);
            }

            Console.WriteLine("Для завершения программы нажмите Enter");
            Console.ReadKey();
        }
    }
}
