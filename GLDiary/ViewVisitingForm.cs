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
            database.LoadData(textBoxChooseSubject.Text, "*");
            dataGridViewViewVisiting.DataSource = database.DataTable;
            dataGridViewViewVisiting.Show();
        }
    }
}
