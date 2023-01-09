// ���������, 2���-2, �������-2, 08.01.2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ��_11_2���_2_���������
{
    internal class Program
    {
        static void task_1() //������� 1
        {
            Console.Write("������� ����� n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double A = 1;

            for (int i = 1; i <= n; i++)
            {
                A += 1.0 / Math.Pow(n, i);
            }
            Console.WriteLine($"A = {A,5:f2}");
        }
        static void task_2() //������� 2
        {
            Console.Write("������� ����������� ����� n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a, a1, a2, a3, k = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("������� ����������� �����: ");
                a = Convert.ToInt32(Console.ReadLine());

                a1 = a / 100;
                a2 = (a / 10) % 10;
                a3 = a % 10;

                if ((a1 + a2 + a3) % 5 == 0)
                    k++;
            }

            Console.WriteLine($"k = {k}");
        }
        static void task_3() //������� 3
        {
            Console.Write("������� m � n ( m <= n ) \n m = ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write(" n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            double P = 1.0 / m;

            for (int i = 1; i <= n; i++)
            {
                P += 1.0 / (m + i);
            }

            Console.WriteLine($" P = {P,7:f4}");
        }
        public static void Main(string[] args)
        {
            number_task:
            Console.Write("������� ����� ������� (0 - �����): ");

            int num = Convert.ToInt32(Console.ReadLine());

               switch (num)
                {
                    case 0:
                        Console.WriteLine("��� ���������� ��������� ������� Enter");
                        break;

                    case 1:
                        task_1();
                        goto number_task;

                    case 2:
                        task_2();
                        goto number_task;

                    case 3:
                        task_3();
                        goto number_task;

                    default:
                        Console.WriteLine("������ �������� ����� ������");
                        break;
                }

            Console.ReadKey();
        }
    }
}
