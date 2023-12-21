using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Учет_готовой_продукции.Controller
{
    internal class Products
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;
        public Products(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }
        public DataTable upDateProducts() //обновление данных в продаже молочной продукции
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT Продукция.[Код продукции], Характеристики.Наименование, Продукция.Цена, Продукция.[Вид продукции] FROM Характеристики INNER JOIN Продукция ON Характеристики.[Код продукции] = Продукция.[Код продукции];\r\n", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddProducts(string ID,  string cena, string vid) // добавление данных в продаже молочной продукции
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Продукция ([Код продукции], Цена, [Вид продукции]) VALUES({ID} ,  {cena},{vid} )", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteProducts(int ID) //удаление данных в продаже молочной продукции
        {
            connection.Open();
            command = new OleDbCommand($"DELETE* FROM Продукция  WHERE [Код продукции] = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditProducts(int ID,  string cena, string vid) //редактирование данных в продаже молочной продукции 
        {
            connection.Open();
            command = new OleDbCommand($"UPDATE  Продукция SET Цена = {cena}, [Вид продукции] = {vid} WHERE   [Код продукции] = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
