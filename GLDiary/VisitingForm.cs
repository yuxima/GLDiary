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
        private Database database = new Database();
        private DateTime selectedDate;
        private Database subject = new Database();

        public VisitingForm()
        {
            InitializeComponent();
            database = new Database();
            database.LoadData("Students","ID","Name");

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
            dataGridViewVisiting.Columns[0].ReadOnly = true;
            dataGridViewVisiting.Columns[1].ReadOnly = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Dictionary<int, int> absent = new Dictionary<int, int>();
            DataGridViewCheckBoxCell oCell = new DataGridViewCheckBoxCell();
            foreach (DataGridViewRow row in dataGridViewVisiting.Rows)
            {
                oCell = row.Cells[2] as DataGridViewCheckBoxCell;
                var bChecked = null != oCell && null != oCell.Value && true == (bool) oCell.Value;
                if (true == bChecked) absent.Add(Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row.Cells[2].Value));

            }
            foreach (KeyValuePair<int,int> student in absent) 
            {
                database.SelectDay(comboBoxSelectPair.SelectedValue.ToString(), selectedDate.Date.ToString());
                database.UpdateStudents(comboBoxSelectPair.SelectedValue.ToString(), student.Key, selectedDate.Date.ToString(), student.Value.ToString());
            }
            MessageBox.Show("OK");
  
        }

        public void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            
            selectedDate = monthCalendar.SelectionEnd;
            subject.SheduleOfDay(selectedDate.DayOfWeek.ToString());
            List<string> pairs = new List<string>();
            foreach (var row in subject.DataTable.Select())
            {
                pairs.Add(row.ItemArray[1].ToString());
            }
            comboBoxSelectPair.DataSource = pairs;
        }
    }
}