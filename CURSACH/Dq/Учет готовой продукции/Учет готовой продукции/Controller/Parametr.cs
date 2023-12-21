using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace Учет_готовой_продукции.Controller
{
    internal class Parametr
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;
        public Parametr(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }
        public DataTable upDateParametr() //обновление данных в продаже молочной продукции
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Характеристики", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddParametr(string ID,string name, string processor, string chastota, string yadro, string RAM, string colichRAM, string tip, string V, string Video, string date) // добавление данных в продаже молочной продукции
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Характеристики ([Код продукции], Наименование, Процессор, [Частота процессора], [Кол-во ядер], [Объем ОЗУ], [Кол-во плат ОЗУ], [Тип накопителя], [Объем накопителя], Видеокарта, [Дата сборки]) VALUES( {ID}, {name}, {processor},{chastota}, {yadro}, {RAM}, {colichRAM}, {tip}, {V},{Video}, #{date}#)", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteParametr(int ID) //удаление данных в продаже молочной продукции
        {
            connection.Open();
            command = new OleDbCommand($"DELETE* FROM Характеристики WHERE [Код продукции] = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditParametr(string ID, string name, string processor, string chastota, string yadro, string RAM, string colichRAM, string tip, string V, string Video, string date) //редактирование данных в продаже молочной продукции 
        {
            connection.Open();
            command = new OleDbCommand($"UPDATE Характеристики SET Наименование = {name}, Процессор = {processor}, [Частота процессора] = {chastota}, [Кол-во ядер] = {yadro}, [Объем ОЗУ] = {RAM}, [Кол-во плат ОЗУ] = {colichRAM}, [Тип накопителя] = {tip}, [Объем накопителя]= {V}, Видеокарта = {Video}, [Дата сборки] = #{date}# WHERE  [Код продукции] = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
