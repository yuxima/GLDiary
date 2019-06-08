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
    public partial class StudentsInfoForm : Form
    {
        private Database database;

        public StudentsInfoForm()
        {
            InitializeComponent();
            database = new Database();
            database.SetConnection();
            database.LoadData("Students", "*");
            for (int i = 0; i < dataGridViewStudents.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewStudents.ColumnCount; j++)
                {
                    if (Convert.ToString(dataGridViewStudents.Rows[i].Cells[j].Value) != "")
                    {
                        dataGridViewStudents.Rows[i].Cells[j].ReadOnly = true;
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            database.InsertData("Students","Name","BirthDate", "PhoneNumber", textBoxName.Text, maskedTextBoxBirthDate.Text, maskedTextBoxPhoneNumber.Text);
            database.LoadData("Students","*");
            dataGridViewStudents.DataSource = database.DataTable;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            database.DeleteData("Students", Convert.ToInt32(textBoxID.Text));
            database.LoadData("Students","*");
            dataGridViewStudents.DataSource = database.DataTable;
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewStudents.SelectedRows[0].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewStudents.SelectedRows[0].Cells[1].Value.ToString();
            maskedTextBoxBirthDate.Text = dataGridViewStudents.SelectedRows[0].Cells[2].Value.ToString();
            maskedTextBoxPhoneNumber.Text = dataGridViewStudents.SelectedRows[0].Cells[3].Value.ToString();
            dataGridViewStudents.CellClick += null;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            database.UpdateStudents("Students", Convert.ToInt32(textBoxID.Text), "Name", textBoxName.Text, "BirthDate",
                maskedTextBoxBirthDate.Text, "PhoneNumber", maskedTextBoxPhoneNumber.Text);
            database.LoadData("Students", "*");
            dataGridViewStudents.DataSource = database.DataTable;
        }

        private void buttonQuitToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            var form1 = new MenuForm();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridViewStudents.DataSource = database.DataTable;
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        
    }
}