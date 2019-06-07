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
    public partial class SheduleOfCallsForm : Form
    {
        private Database databaseCalls = new Database();

        public SheduleOfCallsForm()
        {
            InitializeComponent();

            databaseCalls.LoadData("SheduleOfCalls", "*");
        }

        private void buttonQuitToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            var form1 = new MenuForm();
            form1.Show();
        }

        private void SheduleOfCallsForm_Load(object sender, EventArgs e)
        {
            dataGridViewSheduleOfCalls.DataSource = databaseCalls.DataTable;
        }
    }
}