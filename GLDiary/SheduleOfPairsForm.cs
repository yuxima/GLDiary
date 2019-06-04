using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLDiary
{
    public partial class SheduleOfPairsForm : Form
    {
        public SheduleOfPairsForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void buttonQuitToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            var form1 = new MenuForm();
            form1.Show();
        }

        private SQLiteConnection sqlConnection;
        private SQLiteCommand sqlCommand;
        private SQLiteDataAdapter database;
        private DataSet DataSet = new DataSet();
        private DataTable DataTable = new DataTable();

        private void SetConnection()
        {
            sqlConnection =
                new SQLiteConnection("Data Source = database.sqlite3; Version = 3; New = False; Compress = True");
        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = txtQuery;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void LoadData()
        {
            SetConnection();
            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();
            var CommandText = "SELECT * FROM SheduleOfCalls";
            database = new SQLiteDataAdapter(CommandText, sqlConnection);
            DataSet.Reset();
            database.Fill(DataSet);
            DataTable = DataSet.Tables[0];
            dataGridViewSheduleOfCalls.DataSource = DataTable;
            sqlConnection.Close();
        }
    }
}