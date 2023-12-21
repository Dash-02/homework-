using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Учет_готовой_продукции.Controller
{
    internal class Customers
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;
        public Customers(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }
        public DataTable upDateCustomers() //обновление данных в продаже молочной продукции
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Клиенты", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddCustomers(string FIO, string telefon, string adres) // добавление данных в продаже молочной продукции
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Клиенты ( ФИО, Телефон, Адрес) VALUES({FIO} , '{telefon}', {adres} )", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteCustomers(int ID) //удаление данных в продаже молочной продукции
        {
            connection.Open();
            command = new OleDbCommand($"DELETE* FROM Клиенты  WHERE [Код клиента] = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditCustomers(int ID, string FIO, string telefon, string adres) //редактирование данных в продаже молочной продукции 
        {
            connection.Open();
            command = new OleDbCommand($"UPDATE  Сделки SET ФИО = {FIO}, Телефон = {telefon}, Адрес = {adres} WHERE  [Код клиента] = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
