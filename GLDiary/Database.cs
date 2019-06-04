using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLDiary
{
    internal class Database
    {
        private SQLiteConnection sqlConnection;
        private SQLiteCommand sqlCommand;
        private SQLiteDataAdapter database;
        private DataSet DataSet = new DataSet();
        private DataTable dataTable = new DataTable();
        private string _table;
        private string _day;

        public DataTable DataTable
        {
            get => dataTable;
            set => dataTable = value;
        }

        public void SetConnection()
        {
            sqlConnection =
                new SQLiteConnection("Data Source = database.sqlite3; Version = 3; New = False; Compress = True");
        }


        public void LoadData(string table, params string[] _params)
        {
            sqlConnection.Open();

            sqlCommand = sqlConnection.CreateCommand();
            
            var CommandText = "SELECT ";
            if (_params[0] == "*")
                CommandText += "*";
            else
                foreach (var str in _params)
                    CommandText += $"\"{str}\"" + ", ";
            CommandText = CommandText.Trim().Trim(',');
            CommandText += $" FROM \"{table}\"";
            
            var database = new SQLiteDataAdapter(CommandText, sqlConnection);
            DataSet.Reset();
            database.Fill(DataSet);
            DataTable = DataSet.Tables[0];
            sqlConnection.Close();
        }

        public void DeleteData(string table, int ID)
        {
            SetConnection();
            sqlConnection.Open();

            var CommandText = $"DELETE FROM \"{table}\" WHERE ID =\"{ID}\" ";
            var database = new SQLiteDataAdapter(CommandText, sqlConnection);
            var sqlCommand = new SQLiteCommand(CommandText, sqlConnection);

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void InsertData(string table, params string[] _params)
        {
            SetConnection();
            sqlConnection.Open();

            var CommandText = $"INSERT INTO \"{table}\"(";
            var _count = _params.Count() / 2;
            for (var i = 0; i < _count; i++) CommandText += $"\"{_params[i]}\"" + ", ";
            CommandText = CommandText.Trim().Trim(',');
            CommandText += ") VALUES (";
            for (var i = _count; i < _params.Count(); i++) CommandText += $"\"{_params[i]}\"" + ",";
            CommandText = CommandText.Trim().Trim(',');
            CommandText += ")";

            var sqlCommand = new SQLiteCommand(CommandText, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }


        public void UpdateData(string table, int ID, params string[] _params)
        {
            SetConnection();
            sqlConnection.Open();
            
            var CommandText = $"UPDATE {table} SET ";
            var _count = _params.Length;
            for (var i = 0; i < _count; i += 2) CommandText += $"{_params[i]} = \"{_params[i + 1]}\"" + ", ";
            CommandText = CommandText.Trim().Trim(',');
            CommandText += $" WHERE ID = {ID}";
            
            var sqlCommand = new SQLiteCommand(CommandText, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void SelectDay(string table)
        {
            SetConnection();
            sqlConnection.Open();

            var CommandText = $"ALTER TABLE {table} ";

            var sqlCommand = new SQLiteCommand(CommandText, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        

        //Form5 виведення в датагріди розкладу, Form3
        //public void SheduleOfDay(string day)
        //{
        //    SetConnection();
        //    sqlConnection.Open();

        //    sqlCommand = sqlConnection.CreateCommand();
        //    var CommandText = $"SELECT Pair, Subject FROM SheduleOfPairs WHERE  DayOfWeek =  \"{day}\"";
        //    var database = new SQLiteDataAdapter(CommandText, sqlConnection);
        //    DataSet.Reset();
        //    database.Fill(DataSet);
        //    DataTable = DataSet.Tables[0];
        //}

        //public void SetDate(string date)
        //{
        //    ExecuteQuery($"ALTER TABLE \"{_table}\" ADD COLUMN \"{date}\"");
        //}
    }
}