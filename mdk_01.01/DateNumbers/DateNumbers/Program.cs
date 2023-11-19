using System;
using System.Collections.Generic;
using System.Linq;

namespace DateNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату рождения в формате ДД.ММ.ГГГГ:");
            string input = Console.ReadLine();

            string modified = "";
            List<int> dateNum = new List<int>();

            Dictionary<int, int> countsNum = new Dictionary<int, int>();
            int result;

            for (int i = 0; i < input.Length; i++)
            {
               if (input[i] != '.')
               {
                    modified += input[i];
               }
            }
             
            int[] numbers = modified.Select(x => int.Parse(x.ToString())).ToArray();
            // проверочный вывод массива
            /*for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();*/
            
            dateNum.Add(numbers[0]);
            int el = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    el = numbers[i] + numbers[i + 1];
                    dateNum.Add(el);
                }
                else if (i != 1) 
                { 
                    el += numbers[i];
                    dateNum.Add(el);
                }
            }
            // проверочный вывод списка
            /*for (int i = 0; i < dateNum.Count; i++)
            {
                Console.Write($"d = {dateNum[i]} ");
            }*/

            // цикл для обработки 0 и чисел > 9
            for (int i = 0; i < dateNum.Count; i++)
            {
                while (dateNum[i] > 9)
                {
                    int a = dateNum[i] / 10;
                    int b = dateNum[i] % 10;

                    if (i == 7)
                    {
                        result = a + b;
                        dateNum.Add(result);
                        dateNum[i] = (a != 0 && b == 0) ? a : (b != 0 && a == 0) ? b : a;
                        if (a != 0 && b != 0)
                        {
                            dateNum.Add(b);
                        }
                    }
                    else
                    {
                        dateNum[i] = (a != 0 && b == 0) ? a : (b != 0 && a == 0) ? b : a;
                        if (a != 0 && b != 0)
                        {
                            dateNum.Add(b);
                        }
                    }
                }
            }
            //проверочный вывод списка
            /*for (int i = 0; i < dateNum.Count; i++)
            {
                Console.Write($"d1 = {dateNum[i]} ");
            }*/

            foreach (int num in dateNum)
            {
                if (countsNum.ContainsKey(num))
                {
                    countsNum[num]++;
                }
                else
                {
                    countsNum[num] = 1;
                }
            }

            foreach (KeyValuePair<int, int> kvp in countsNum.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine($"Число: {kvp.Key}, Количество: {kvp.Value}");
            }
        }
    }
}
