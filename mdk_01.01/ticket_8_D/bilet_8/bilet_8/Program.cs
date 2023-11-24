using System;

namespace bilet_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявление и инициализация рабочих переменных
            int sumFirst = 0;
            int sumSecond = 0;
            int sumAll = 0;
            int mult = 1;
            int a;
            string numStr = "";
            string numStr2 = "";
            string numStr3 = "";
            string numStr4 = "";

            Console.WriteLine("Введите четырехзначное число: ");
            // объявление и инициализация числа путем конвертирования строки в целочисленный тип
            int num = Convert.ToInt32(Console.ReadLine());

            // обработка исключения, если число не удовлетворяет условию решаемой задачи
            if (num.ToString().Length != 4)
            {
                // сообщение, получаемое пользователем при вводе не чытерхзначного числа
                Console.WriteLine("Введено неверное значение"); 
            }

            // объявление и инициализация строки путем преобразования числа в стрковый тип
            string nums = num.ToString();
            // разделение строки nums на отдельные строки
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    numStr += nums[i]; // первая строка
                }
                if (i == 1)
                {
                    numStr2 += nums[i]; // вторая строка
                }
                if (i == 2)
                {
                    numStr3 += nums[i]; // третья строка
                }
                if (i == 3)
                {
                    numStr4 += nums[i]; // четвертая строка
                }
            }
            
            // конвертация строк в целочисленный тип
            int first = Convert.ToInt32(numStr);
            int second = Convert.ToInt32(numStr2);
            int third = Convert.ToInt32(numStr3);
            int fourth = Convert.ToInt32(numStr4);

            // сума первой пары цифр
            sumFirst = first + second;
            // сумма второй пары цифр
            sumSecond = third + fourth;
            // если суммы равны, выводится сообщение об этом
            if (sumFirst == sumSecond)
            {
                Console.WriteLine($"Сумма первых 2-х цифр = {sumFirst}, равна сумме 2-х двух последних цифр = {sumSecond}");
            }
            else // сообщение, когда суммы не равны
            {
                Console.WriteLine($"Сумма первых 2-х цифр = {sumFirst}, не равна сумме 2-х двух последних цифр = {sumSecond}");
            }

            sumAll = first + second + third + fourth; // сумма всех цифр
            
            if (sumAll % 3 == 0) // проверка кратности суммы
            {
                Console.WriteLine($"Сумма цифр = {sumAll}, кратна 3"); // сумма кратна трем
            }
            else
            {
                Console.WriteLine($"Сумма цифр = {sumAll}, не кратна 3"); // сумма не кратна трем
            }

            // произведение всех цифр
            mult = first * second * third * fourth;
            if (mult % 4 == 0) // проверка кратности произведения
            {
                Console.WriteLine($"Произведение цифр {mult}, кратно 4"); // произведение кратно четырем
            }
            else
            {
                Console.WriteLine($"Произведение цифр {mult}, не кратно 4"); // произведение не кратно четырем
            }

            Console.WriteLine("Введите число a: ");
            // инициализация переменной а
            a = Convert.ToInt32(Console.ReadLine());

            if (mult % a == 0) // проверка кратности произведения
            {
                Console.WriteLine($"Произведение цифр {mult}, кратно a = {a}"); // произведение кратно a
            }
            else
            {
                Console.WriteLine($"Произведение цифр {mult}, не кратно a = {a}"); // произведение не кратно a
            }
        }
        static void task2()
        {
            // вывод сообщения в консоль
            Console.WriteLine("Введите число: ");
            // объявление и инициализация числа путем конвертирования строки в целочисленный тип
            int d = Convert.ToInt32(Console.ReadLine());

            // проверка числа на принадлежность к диапазону от 90 до 110 включительно
            if (d >= 90 && d <= 110)
            {
                Console.WriteLine("Близко"); // при выполнении условия true выводится в консоль слово "Близко"
            }
            else
            {
                Console.WriteLine("Далеко"); // при false выводится в консоль слово "Далеко"
            }
        }
    }
}
