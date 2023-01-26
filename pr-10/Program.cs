//ПР10_2ИСП2_Сейдалиев_Семиволос_Вариант-2
using System;

namespace ПР10_2ИСП2_Сейдалиев_Семиволос
{
	class MainClass
	{
		static void Method1()
        	{
			Console.Write("Укажите интервал [a, b] \nВведите a: ");
           		double a = Convert.ToDouble(Console.ReadLine());

           		Console.Write("Введите b: ");
           		double b = Convert.ToDouble(Console.ReadLine());

		   	Console.Write("Введите шаг: ");
		   	double dx = Convert.ToDouble(Console.ReadLine());

		   	double y, x = a;

		  	 for (int i = 0; i < 35; i++) Console.Write("-");
		   	Console.WriteLine();
		   	Console.Write("\tx\t|\ty");
		   	Console.WriteLine();
		   	for (int i = 0; i < 35; i++) Console.Write("-");
		   	Console.WriteLine();

		    	while (x <= b)
		    	{
		        	y = x * x - 3;
		        	Console.WriteLine($"\t{x:f1}\t|\t{y:f1}");
				x += dx;
		    	}
        	}

		static void Method2()
		{
		    Console.Write("Укажите интервал [a, b] \nВведите a: ");
		    double a = Convert.ToDouble(Console.ReadLine());

		    Console.Write("Введите b: ");
		    double b = Convert.ToDouble(Console.ReadLine());

		    Console.Write("Введите шаг: ");
		    double dx = Convert.ToDouble(Console.ReadLine());

		    double y, x = a;

		    for (int i = 0; i < 35; i++) Console.Write("-");
		    Console.WriteLine();
		    Console.Write("\tx\t|\t y");
		    Console.WriteLine();
		    for (int i = 0; i < 35; i++) Console.Write("-");
		    Console.WriteLine();

		    do
		    {
			y = x * x - 3;
			Console.WriteLine($"\t{x:f1}\t|\t{y:f1}");
			x += dx;
		    } 
		    while (x <= b);
		}
		
		static void Method3()
		{
		    Console.Write("Укажите интервал [a, b] \nВведите a: ");
		    double a = Convert.ToDouble(Console.ReadLine());

		    Console.Write("Введите b: ");
		    double b = Convert.ToDouble(Console.ReadLine());

		    Console.Write("Введите шаг: ");
		    double dx = Convert.ToDouble(Console.ReadLine());

		    double x, y;

		    for (int i = 0; i < 35; i++) Console.Write("-");
		    Console.WriteLine();
		    Console.Write("\tx\t|\ty");
		    Console.WriteLine();
		    for (int i = 0; i < 35; i++) Console.Write("-");
		    Console.WriteLine();

		    for (x = a; x <= b; x += dx)
		    {
			y = x * x - 3;
			Console.WriteLine($"\t{x:f1}\t|\t{y:f1}");
		    }
		}

		public static void Main(string[] args)
		{
		    Console.Write("Введите номер метода решения: ");
		    int n = Convert.ToInt32(Console.ReadLine());

		    switch (n)
		    {
			case 1:
			    Method1();
			    break;

			case 2:
			    Method2();
			    break;

			case 3:
			    Method3();
			    break;

			default:
			    Console.WriteLine("Введен неверный номер метода");
			    break;
		    }
		    for (int i = 0; i < 35; i++) Console.Write("-");

		    Console.Write("\nНажмите Enter для завершения программы.");
		    Console.ReadKey();
		}
	}
}
