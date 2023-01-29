using System;

namespace ПР13_Задание1_2ИСП2_Сейдалиев_Семиволос
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];

            Random r = new Random();

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = r.Next(0, 11);
                Console.WriteLine($"A[{i}] = " + A[i]);
            }

            int sum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 5 == 0) 
                {
                    sum += A[i];
                }
            }
            Console.WriteLine($"Сумма элементов, кратных 5 = {sum}");

            Console.WriteLine("Для завершения программы нажмите Enter");
            Console.ReadKey();
        }
    }
}
