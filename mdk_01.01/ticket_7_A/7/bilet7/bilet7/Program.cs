//using System;

//class Program
//{
//    static void Main()
//    {
//        const int range = 1000; // Задаем верхнюю границу диапазона

//        bool[] primes = new bool[range + 1]; // Инициализируем массив для хранения информации о простых числах
//        for (int i = 2; i <= range; i++)
//        {
//            primes[i] = true; // Предполагаем, что все числа являются простыми
//        }

//        // Применение алгоритма Эратосфена
//        for (int p = 2; p * p <= range; p++)
//        {
//            if (primes[p] == true)
//            {
//                // Помечаем числа, кратные p, как "не простые"
//                for (int i = p * p; i <= range; i += p)
//                {
//                    primes[i] = false;
//                }
//            }
//        }

//        // Вывод простых чисел
//        Console.WriteLine("Простые числа в диапазоне от 1 до 1000:");
//        for (int i = 2; i <= range; i++)
//        {
//            if (primes[i] == true)
//            {
//                Console.Write(i + " ");
//            }
//        }
//    }
//}

using System;

class Program
{
    // Метод для вычисления факториала числа
    static long Factorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }

        return number * Factorial(number - 1);
    }

    static void Main()
    {
        Console.WriteLine("Введите число (от 1 до 15): ");
        // конвертация введенного пользователем числа в числовой формат
        int number = Convert.ToInt32(Console.ReadLine());

        // Проверяем, что число находится в диапазоне от 1 до 15
        if (number >= 1 && number <= 15)
        {
            // объявление переменной для вызова метода вычисления факториала передаваемого числа number
            long factorial = Factorial(number);
            Console.WriteLine($"Факториал числа {number} = {factorial}");
        }
        else // обработка неверного ввода числа пользователем
        {
            Console.WriteLine("Число должно быть в диапазоне от 1 до 15.");
        }
    }
}
