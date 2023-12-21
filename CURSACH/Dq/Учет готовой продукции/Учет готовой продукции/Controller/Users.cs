using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Учет_готовой_продукции.Controller
{
    internal class Users
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public Users(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }
        public DataTable upDateUsers() //обновление данных в продаже молочной продукции
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Users;", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddUsers(string Log, string Pas) // добавление данных в продаже молочной продукции
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO [Users] (Log, Pas) VALUES({Log} , {Pas} )", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteUsers(int ID) //удаление данных в продаже молочной продукции
        {
            connection.Open();
            command = new OleDbCommand($"DELETE* FROM [Users] WHERE ID = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditUsers(int ID,string Log, string Pas) //редактирование данных в продаже молочной продукции 
        {
            connection.Open();
            command = new OleDbCommand("UPDATE [Продажи молочной продукции] SET Log = @Log, Pas = @Pas WHERE [ID] = @ID;", connection);
            command.Parameters.AddWithValue("@Log", Log);
            command.Parameters.AddWithValue("@Pas",Pas);
            command.Parameters.AddWithValue("@ID", ID);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
