using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Table> tables = new List<Table>();

            Console.Write("Enter count tables: ");
            int countTable = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < countTable; i++)
            {
                
                tables.Add(new Table("newTable", 410, 450, 500, 10000.99, 6));
            }
            
            for (int i = 0; i < tables.Count; i++)
            {
                Console.WriteLine($"name = {tables[i].name} height = {tables[i].height} " +
                    $"width = {tables[i].width} length = {tables[i].length} " +
                    $"cost = {tables[i].cost} count = {tables[i].count}");
            }
        }
    }
    internal class Table
    {
        public string name;
        public int height;
        public int width;
        public int length;
        public double cost;
        public int count;

        public Table(string n, int h, int w, int l, double c, int cnt)
        {
            name = n;
            height = h;
            width = w;
            length = l;
            cost = c;
            count = cnt;
        }
    }
}
