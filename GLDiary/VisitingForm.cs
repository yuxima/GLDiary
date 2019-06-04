using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLDiary
{
    public partial class VisitingForm : Form
    {
        private Database database;
        private Database databaseMath;
        private DateTime date;
        private Database subject;

        public VisitingForm()
        {
            InitializeComponent();
            //database = new Database("Students");
            //database.LoadStudents();
        }

        private void buttonQuitToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            var form1 = new MenuForm();
            form1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridViewVisiting.DataSource = database.DataTable;
            var dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dataGridViewCheckBoxColumn.ValueType = typeof(bool);
            dataGridViewCheckBoxColumn.Name = "IsAbsent";
            dataGridViewVisiting.Columns.Add(dataGridViewCheckBoxColumn);
            foreach (DataGridViewRow dgvr in dataGridViewVisiting.Rows) dgvr.Cells[2].Value = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var absent = new List<int>();
            DataGridViewCheckBoxCell oCell;
            foreach (DataGridViewRow row in dataGridViewVisiting.Rows)
            {
                oCell = row.Cells[2] as DataGridViewCheckBoxCell;
                var bChecked = null != oCell && null != oCell.Value && true == (bool) oCell.Value;
                if (true == bChecked) absent.Add(Convert.ToInt32(row.Cells[0].Value));
            }

            subject.SheduleOfDay(date.DayOfWeek.ToString());
        }

        public void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //subject = new Database("SheduleOfPairs");
            //date = monthCalendar1.SelectionEnd;
            //List<string> pairs = new List<string>();
            //foreach (var row in subject.DataTable.Select())
            //{
            //    pairs.Add(row.ItemArray[1].ToString());
            //}
            //comboBox1.DataSource = pairs;
        }
    }
}