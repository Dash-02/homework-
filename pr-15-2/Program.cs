// Семиволос Дарья, 2ИСП-2, Вариант-2, Задача 2
using System;

namespace ПР15_2_2ИСП2_Семиволос
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write("Введите длинну массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] M = new int[n];

			Random r = new Random();

			for (int i = 0; i < n; i++)
			{
				M[i] = r.Next(10, 100);
				Console.WriteLine($"M[{i}] = {M[i]}");
			}

			Console.WriteLine("Массив K:");
			
			int[] K = new int[n];
			for (int i = 0; i < n; i++) 
			{
				if (M[i] % 3 == 0) 
				{
					K[i] =  M[i];
					Console.WriteLine($"K[{i}] = {M[i]}");
					
				}
			}
			
			for (int i = 0; i < n; i++) 
			{
				if (M[i] % 3 == 0) 
				{
					M[i] = 100;
					Console.WriteLine($"M[{i}] = {M[i]}");
				}
			}
			
			Console.WriteLine("Отсортированный массив:");
			
			for (int i = 0;  i  <  n-1; i++)
			{
				for (int  j = i+1; j < n; j++)
				{
					if (M[i] > M [j])
					{
						var C =  M[j];
						M [j] = M[i];
						M[i] =  C;
					}
				}
			}
			
			foreach (int item in M)
            {
                Console.Write(item + " ");
            }
		}
	}
}
