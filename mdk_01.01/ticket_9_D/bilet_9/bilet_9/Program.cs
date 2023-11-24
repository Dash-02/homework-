using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilet_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявление рабочих переменных
            int firstNum;
            int secondNum;
            int thirdNum;
            int fourthNum;
            // метод Random() позволяет генерировать случайные значения, интервал которых указан в Next()
            int r = new Random().Next(999, 10000);

            // вывод значения переменной r в консоль
            Console.WriteLine($"Число: {r}");

            // проверка принадлежности числа к тому или иному интервалу
            if (r >= 0 && r <= 9) // интервал чисел от 0 до 9
            {
                Console.WriteLine($"Число {r} является палиндромом");
            }
            else if (r >= 10 && r <= 99) // интервал двухзначных чисел
            {
                // разбиение числа на цифры
                firstNum = r / 10; // получаем первую цифру
                secondNum = r % 10; // получаем вторую цифру

                // проверка равенства цифр числа
                if (firstNum == secondNum)
                {
                    Console.WriteLine($"Число {r} является палиндромом");
                }
                else
                {
                    Console.WriteLine($"Число {r} не является палиндромом");
                }
            }
            else if (r >= 100 && r <= 999) // интервал трехзначных чисел
            {
                // разбиение числа на цифры
                firstNum = r / 100; // получаем первую цифру
                secondNum = (r % 100) / 10; // получаем вторую цифру
                thirdNum = r % 10; // получаем третью цифру

                // проверка равенства второй и третьей цифр числа
                if (firstNum == thirdNum)
                {
                    Console.WriteLine($"Число {r} является палиндромом");
                }
                else
                {
                    Console.WriteLine($"Число {r} не является палиндромом");
                }
            }
            else if (r >= 1000 && r <= 9999) // интервал четырехзначных чисел
            {
                // разбиение числа на цифры
                firstNum = r / 1000; // получаем первую цифру
                secondNum = (r % 1000) / 100; // получаем вторую цифру
                thirdNum = (r % 100) / 10; // получаем третью цифру
                fourthNum = r % 10; // получаем четвертую цифру

                // проверка равенства первой и четвертой, второй и третьей цифр числа
                if (firstNum == fourthNum && secondNum == thirdNum)
                {
                    Console.WriteLine($"Число {r} является палиндромом");
                }
                else
                {
                    Console.WriteLine($"Число {r} не является палиндромом");
                }
            }




            // объявление рабочих переменных
            //string str;
            //string newStr = "";
            //int k;

            //// вывод в консоль сообщения пользователю
            //Console.WriteLine("Введите строку, которую необходимо склеить: ");
            //// инициализация строки, путем ввода в консоль
            //str = Console.ReadLine();

            //// вывод в консоль сообщения пользователю
            //Console.WriteLine("Введите количество склеиваний: ");
            //// инициализация строки, путем конвертации введенной строки в целочисленный тип
            //k = Convert.ToInt32(Console.ReadLine());

            //// цикл для конкатеканации строк k раз
            //while (k != 0)
            //{
            //    newStr += str; // конкатенация строк newStr и str
            //    k--; // дикремент k для избежания бесконечного цикла
            //}
            ////for (int i = 0; i < k; i++)
            ////{
            ////    newStr += str; // конкатенация строк newStr и str
            ////}

            //// вывод получившийся строки на экран
            //Console.WriteLine(newStr);
        }
    }
}
