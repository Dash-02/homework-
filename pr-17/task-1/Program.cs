// Сейдалиев и Семиволос, 2ИСП-2, Вариант 1, Задание 1
using System;
using System.Linq;

namespace ПР_17_2ИСП_2_Сейдалиев_Семиволос
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[,] A = gen_massiv(-80, 81);
			int[] S = new int[A.GetLength(0)];
			S = sum_str(A);
			
			vivod_massiv2(A);
			
			vivod_massiv1(S);
		}
		static int[,] gen_massiv(int d1, int d2)
		{
			Console.Write("Введите кол-во строк: ");
			int n = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Введите кол-во столбцов: ");
			int m = Convert.ToInt32(Console.ReadLine());
			
			int[,] mas = new int[n,m];
			
			Random r = new Random();
			
			for (int i=0; i<mas.GetLength(0); i++)
				for (int j=0; j<mas.GetLength(1); j++)
					mas[i,j] = r.Next(d1,d2+1);
			return mas;
		}
		
		static void vivod_massiv2(int[,] mas)
		{
			for (int i=0; i<mas.GetLength(0); i++)
			{
				for (int j=0; j<mas.GetLength(1); j++)
					Console.Write("{0, 6}", mas[i,j]);
				Console.WriteLine();
			}
		}
		
		static void vivod_massiv1(int[] mas)
		{
			for (int i=0; i<mas.Length; i++)
				Console.Write("{0, 6}", mas[i]);
		}
		static int[] sum_str(int[,] mas)
		{
			int[] sum = new int[mas.GetLength(0)];
			int s;
			
			for (int i=0; i<mas.GetLength(0); i++)
			{
				s=0;
				
				for (int j=0; j<mas.GetLength(1); j++)
					s += mas[i,j];
					sum[i] = s;
			}
			return sum;
		}
	}
}
