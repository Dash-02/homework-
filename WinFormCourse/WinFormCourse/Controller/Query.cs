using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace WinFormCourse.Controller
{
    internal class Query
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public Query(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }
        public DataTable upDatePerson() //обновление данных
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Владельцы", connection);
            //очистка данных
            bufferTable.Clear();
            // заполнение таблицы
            dataAdapter.Fill(bufferTable);
            //закрываем соединение
            connection.Close();
            //возвращение результата
            return bufferTable;
        }
        public  void Add(int vdalelza, string model, string gosnomer, int strax_stoimost)
        {
            connection.Open();
            command = new OleDbCommand("INSERT INTO Владельцы()", connection)

        }

    }
}
