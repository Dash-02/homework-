using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int result, one = 0, two = 0, three = 0, four = 0, five = 0, six = 0, seven = 0, eight = 0, nine = 0;

            for (int i = 0; i < input.Length; i++)
            {
               if (input[i] != '.')
               {
                    modified += input[i];
               }
            }
             
            int[] numbers = modified.Select(x => int.Parse(x.ToString())).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    dateNum.Add(numbers[i]);
            //    //Console.Write($"d = {dateNum[i]} ");
            //}

            dateNum.Add(numbers[0]);
            int el = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    el = numbers[i] + numbers[i + 1];
                    dateNum.Add(el);
                }
                else if (i == 1) { }
                else
                {
                    el += numbers[i];
                    dateNum.Add(el);
                }
            }

            for (int i = 0; i < dateNum.Count; i++)
            {
                Console.Write($"d = {dateNum[i]} ");
            }

            // цикл для обработки 0 и чисел > 9
            for (int i = 0; i < dateNum.Count; i++)
            {
                while (dateNum[i] > 9)
                {
                    int a, b;
                    a = dateNum[i] / 10;
                    b = dateNum[i] % 10;
                    if (i == 7)
                    {
                        result = a + b;
                        dateNum[i] = result;
                    }
                    else if (a != 0 && b == 0)
                    {
                        dateNum[i] = a;
                    }
                    else if (b != 0 && a == 0)
                    {
                        dateNum[i] = b;
                    }
                    else
                    {
                        dateNum[i] = a;
                        dateNum.Add(b);
                    }
                }
            }
            for (int i = 0; i < dateNum.Count; i++)
            {
                Console.Write($"d1 = {dateNum[i]} ");
            }

            // цикл для подчета количества цифр
            //for (int i = 0; i < dateNum.Count; i++)
            //{
            //    if (dateNum[i] == 1)
            //    {
            //        one++;
            //        countsNum.Add(one);
            //    }
            //    else if (dateNum[i] == 2)
            //    {
            //        two++;
            //        countsNum.Add(two);
            //    }
            //    else if (dateNum[i] == 3)
            //    {
            //        three++;
            //        countsNum.Add(three);
            //    }
            //    else if (dateNum[i] == 4)
            //    {
            //        four++;
            //        countsNum.Add(four);
            //    }
            //    else if (dateNum[i] == 5)
            //    {
            //        five++;
            //        countsNum.Add(five);
            //    }
            //    else if (dateNum[i] == 6)
            //    {
            //        six++;
            //        countsNum.Add(six);
            //    }
            //    else if (dateNum[i] == 7)
            //    {
            //        seven++;
            //        countsNum.Add(seven);
            //    }
            //    else if (dateNum[i] == 8)
            //    {
            //        eight++;
            //        countsNum.Add(eight);
            //    }
            //    else if (dateNum[i] == 9)
            //    {
            //        nine++;
            //        countsNum.Add(nine);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Было получено неудовлетворительное число.");
            //    }
            //}

            //for (int i = 0; i < countsNum.Count; i++)
            //{
            //    Console.WriteLine($"чисел {i+1} = {countsNum[i]}; ");
            //}

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

            foreach (KeyValuePair<int, int> kvp in countsNum)
            {
                Console.WriteLine("Number: " + kvp.Key + ", Count: " + kvp.Value);
            }
        }
    }
}
