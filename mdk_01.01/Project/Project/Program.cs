using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя слитно, используя заглавные буквы: ");
            string userName = Console.ReadLine();

            string resultName = "";

            for (int i = 0; i < userName.Length; i++)
            {
                if (Convert.ToString(userName[i]).ToUpper() == Convert.ToString(userName[i]))
                {
                    resultName += $" {userName[i]}";
                }
                else
                {
                    resultName += userName[i];
                }
            }

            Console.WriteLine(resultName.Remove(0, 1));
        }
    }
}
