using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Учет_готовой_продукции.Controller
{
    internal class Transaction
    {

        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;
        public Transaction(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }
        public DataTable upDateTransaction() //обновление данных в продаже молочной продукции
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT Сделки.[Код сделки], Характеристики.Наименование, Клиенты.ФИО, Сделки.[Дата сделки], Сделки.Количество, Сделки.[Количество]*Продукция.[Цена] AS [Итоговая цена], Сделки.[Код клиента], Сделки.[Код продукции]\r\nFROM Характеристики INNER JOIN (Продукция INNER JOIN (Клиенты INNER JOIN Сделки ON Клиенты.[Код клиента] = Сделки.[Код клиента]) ON Продукция.[Код продукции] = Сделки.[Код продукции]) ON (Характеристики.[Код продукции] = Продукция.[Код продукции]) AND (Характеристики.[Код продукции] = Сделки.[Код продукции]);\r\n", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddTransaction(string customer, string product, string date, string colich) // добавление данных в продаже молочной продукции
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO  Сделки ( [Код клиента], [Код продукции], [Дата сделки], [Количество]) VALUES({customer} , {product}, #{date}#, {colich} )", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteTransaction(int ID) //удаление данных в продаже молочной продукции
        {
            connection.Open();
            command = new OleDbCommand($"DELETE* FROM Сделки WHERE [Код сделки] = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditTransaction(int ID, string customer, string product, string date, string colich) //редактирование данных в продаже молочной продукции 
        {
            connection.Open();
            command = new OleDbCommand($"UPDATE  Сделки SET [Код клиента] = {customer}, [Код продукции] = {product}, [Дата сделки] = #{date}#, [Количество] = {colich} WHERE  [Код сделки] = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
