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
    public partial class ShedulrOfPairsForm : Form
    {
        private Database databaseMonday;
        private Database databaseTuesday;
        private Database databaseWednesday;
        private Database databaseThursday;
        private Database databaseFriday;


        public ShedulrOfPairsForm()
        {
            InitializeComponent();
            //databaseMonday = new Database("SheduleOfPairs");
            //databaseTuesday = new Database("SheduleOfPairs");
            //databaseWednesday = new Database("SheduleOfPairs");
            //databaseThursday = new Database("SheduleOfPairs");
            //databaseFriday = new Database("SheduleOfPairs");

            //databaseMonday.SheduleOfDay("Monday");
            //databaseTuesday.SheduleOfDay("Tuesday");
            //databaseWednesday.SheduleOfDay("Wednesday");
            //databaseThursday.SheduleOfDay("Thursday");
            //databaseFriday.SheduleOfDay("Friday");
        }

        private void buttonQuitToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            var form1 = new MenuForm();
            form1.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //dataGridViewSheduleOfMonday.DataSource = databaseMonday.DataTable;
            //dataGridViewSheduleOfTuesday.DataSource = databaseTuesday.DataTable;
            //dataGridViewSheduleOfWednesday.DataSource = databaseWednesday.DataTable;
            //dataGridViewSheduleOfThursday.DataSource = databaseThursday.DataTable;
            //dataGridViewSheduleOfFriday.DataSource = databaseFriday.DataTable;
        }
    }
}