using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Sample.Controller
{
    class Query
    {
        OleDbConnection     connection;
        OleDbCommand        command;
        OleDbDataAdapter    dataAdapter;
        DataTable           bufferTable;

        public Query(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        public DataTable UpdatePerson()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Teachers", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateUsers()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Users", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public void AddUsers(string Log, string Pas)
        {
            connection.Open();
            command= new OleDbCommand($"INSERT INTO Users(Log, Pas) VALUES(@Log, @Pas)", connection);
            command.Parameters.AddWithValue("Log",Log);
            command.Parameters.AddWithValue("Pas", Pas);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Add(string FirstName, string LastName, string Category, int Expirience)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Teachers(FirstName, LastName, Category, Expirience) VALUES(@FirstName, @LastName, @Category, @Expirience)", connection);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.Parameters.AddWithValue("Category", Category);
            command.Parameters.AddWithValue("Expirience", Expirience);


            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Edit(string FirstName, string LastName, string Category, int Expirience, int ID)
        {
            connection.Open();
            command = new OleDbCommand($"UPDATE Teachers SET FirstName={FirstName}, LastName={LastName}, Category={Category}, Expirience={Expirience} WHERE ID={ID}", connection);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.Parameters.AddWithValue("Category", Category);
            command.Parameters.AddWithValue("Expirience", Expirience);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Teachers WHERE ID = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteUsers(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Users WHERE ID = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public bool CheckAdminLogin(string FirstName)
        {
            bool isValid = false;
            connection.Open();
            command = new OleDbCommand($"SELECT FirstName FROM Teachers WHERE FirstName ={FirstName}", connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.ExecuteNonQuery();
            // Выполняем запрос
            OleDbDataReader reader = command.ExecuteReader();

            // Проверяем, есть ли записи с таким логином
            if (reader.HasRows)
            {
                isValid = true;
            }
            // Закрываем ридер и соединение
            reader.Close();
            connection.Close();
            return isValid;
        }  
        public bool CheckAdminPassword(string Expirience)
        {
            bool isValid = false;
            connection.Open();
            command = new OleDbCommand($"SELECT Expirience FROM Teachers WHERE Expirience ={Expirience}", connection);
            command.Parameters.AddWithValue("@Expirience", Expirience);
            command.ExecuteNonQuery();
            // Выполняем запрос
            OleDbDataReader reader = command.ExecuteReader();

            // Проверяем, есть ли записи с таким логином
            if (reader.HasRows)
            {
                isValid = true;
            }

            // Закрываем ридер и соединение
            reader.Close();
            connection.Close();
            return isValid;
        }
        public bool CheckAdminAdmin(string FirstName)
        {
            bool isValid = false;
            connection.Open();
            command = new OleDbCommand($"SELECT IsAdmin FROM Teachers WHERE FirstName = {FirstName}", connection);
            command.ExecuteNonQuery();
            // Выполняем запрос
            OleDbDataReader reader = command.ExecuteReader();

            // Проверяем, есть ли записи с таким логином
            if (reader.HasRows)
            {
                isValid = true;
            }
            // Закрываем ридер и соединение
            reader.Close();
            connection.Close();
            return isValid;
        }
    }
}
