using System;
using System.Security.Cryptography;

namespace PR17
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] A = arrA(-80, 80);
            
            int[] S = new int[A.GetLength(0)];
            int[] S = new int[A.GetLength(0)];
            
            S = arrS(A);
            
            EnterA(A);
            EnterS(S);
        }

        static int[,] arrA(int d1, int d2)
        {
            Console.Write("Enter the number of columns: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the number of lines: ");
            int m = Convert.ToInt32(Console.ReadLine());
            
            int[,] A1 = new int[n, m];
            Random r = new Random();

            for (int i = 0; i < A1.GetLength(0); i++)
            {
                for (int j = 0; j < A1.GetLength(1); j++)
                {
                    A1[i, j] = r.Next(d1, d2);
                }
            }

            return A1;
        }

        static int[] arrS(int[,] A)
        {
            int sum;
            int[] S1 = new int[A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                sum = 0;
                
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    sum += A[i,j];
                }

                S1[i] = sum;
            }

            return S1;
        }

        static void EnterA(int[,] A)
        {
            Console.WriteLine("original array:");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"{A[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        static void EnterS(int[] S)
        {
            Console.WriteLine("modified array:");
            foreach (var item in S)
            {
                Console.Write($"{item} ");
            }
        }
    }
}