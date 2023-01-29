using System;

namespace ПР13_Задание2_2ИСП2_Сейдалиев_Семиволос
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                A[i] = r.Next(-30, 31);
                Console.WriteLine($"A[{i}] = " + A[i]);
            }

            int sum = 0;
            int pr = 1;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) 
                {
                    pr *= A[i];
                }
                else 
                    sum += A[i];
            }

            int pos = 0;
            int neg = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] != 0)
                {
                    if (A[i] > 0)
                        pos++; 
                    else
                        neg++; 
                }
            }

            if (pos > neg)
                Console.WriteLine($"Произведение элементов, стоящих на четных позициях = {pr}");
            else
                Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");

            Console.WriteLine("Для завершения программы нажмите Enter");
            Console.ReadKey();
        }
    }
}
