using System;

namespace Semivolos_domashnie_zadanie
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Введите длинну массива: ");

            int n = Convert.ToInt32(Console.ReadLine()); 
            int[] Arr = new int[n];

            Console.Write("Введите номер метода ввода массива (1 - с клавиатуры, 2 - генерация случайных чисел): ");
            int m = Convert.ToInt32(Console.ReadLine());

            switch (m) 
            { 
                case 1: // ввод с клавиатуры
                    Console.WriteLine("Введите элементы массива: ");

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Arr[{i}] = ");
                        Arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    break;

                case 2: // рандом
                    Random r = new Random();

                    for (int i = 0; i < n; i++)
                    {
                        Arr[i] = r.Next(-100, 1000);
                        Console.WriteLine($"Arr[{i}] = " + Arr[i]);
                    }
                    break;

                default:
                    Console.WriteLine("Введен неверный номер метода");
                    break;
            }

            Console.WriteLine("Новый массив: ");

            //int min = Arr.Min();         // need DELETE
            //double avg = Arr.Average(); //  need DELETE

            //Console.WriteLine($"Min = {min}, Avg = {avg}"); // need DELETE

            for (int i = 0; i < n; i++)
            {
                if (Arr[i] < Arr.Average())
                {
                    Arr[i] = Arr.Min();
                }
                Console.WriteLine($"Arr[{i}] = {Arr[i]}");
            }

            Console.WriteLine("Для завершения программы нажмите Enter");
            Console.ReadKey();
        }
    }
}
