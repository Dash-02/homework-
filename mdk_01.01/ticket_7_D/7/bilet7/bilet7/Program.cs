using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilet7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1000;
            int k = 2;

            int[] allNumbers = new int[N];
            //List<int> num = new List<int>();

            for (int i = 0; i < N; i++)
            {
                allNumbers[i] += i;
            }

            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine(allNumbers[i]);
            //}
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        if (k < N)
            //        {
            //            if (allNumbers[i] != 0)
            //            {
            //                j = k * k;

            //                if (j <= N)
            //                {
            //                    allNumbers[j] = 0;
            //                    j = j + k;
            //                }
            //                else
            //                {
            //                    k += 1;
            //                }
            //            }
            //        }

            //    }
            //}
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(allNumbers[i]);
            }
        }
        static void task2()
        {

        }
    }
}
