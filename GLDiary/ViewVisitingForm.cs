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
    public partial class ViewVisitingForm : Form
    {
        private Database database = new Database();
        public ViewVisitingForm()
        {
            InitializeComponent();
        }

        private void ViewVisitingForm_Load(object sender, EventArgs e)
        {
            dataGridViewViewVisiting.Hide();
        }

        private void buttonViewVisiting_Click(object sender, EventArgs e)
        {
            database.LoadData(comboBoxSelectedSubject.Text, "*");
            dataGridViewViewVisiting.DataSource = database.DataTable;
            dataGridViewViewVisiting.Show();
        }

        private void buttonQuitToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void dataGridViewViewVisiting_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewViewVisiting.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
