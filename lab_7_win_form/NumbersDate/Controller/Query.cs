using System.Data;
using System.Data.OleDb;

namespace NumbersDate.Controller
{
    class Query
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
        public DataTable upDateTeacher()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Преподаватель", connection);
            //очистка данных
            bufferTable.Clear();
            // заполнение таблицы
            dataAdapter.Fill(bufferTable);
            //закрываем соединение
            connection.Close();
            //возвращение результата
            return bufferTable;
        }
        public DataTable UpDateUser()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Преподаватель", connection);
            //очистка данных
            bufferTable.Clear();
            // заполнение таблицы
            dataAdapter.Fill(bufferTable);
            //закрываем соединение
            connection.Close();
            //возвращение результата
            return bufferTable;
        }

        public void Add(string FirstName, string LastName,  string Category, int Experience)
        {
            connection.Open();
            command = new OleDbCommand("INSERT INTO Преподаватель (Фамилия, Имя, Категория, Стаж) VALUES(@FirstName, @LastName, @Category, Experience)", connection);
            command.Parameters.AddWithValue("Фамилия", FirstName);
            command.Parameters.AddWithValue("Имя", LastName);
            command.Parameters.AddWithValue("Категория", Category);
            command.Parameters.AddWithValue("Стаж", Experience);
            command.ExecuteNonQuery();
            connection.Close(); 
        }
        
        public void Delete(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Преподаватель WHERE ID = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}