using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GLDiary
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new StudentsInfoForm();
            form2.Show();
        }

        private void buttonCheckVisiting_Click(object sender, EventArgs e)
        {
            Hide();
            var form3 = new VisitingForm();
            form3.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            var form4 = new SheduleOfCallsForm();
            form4.Show();
        }

        private void buttonPairsShedule_Click(object sender, EventArgs e)
        {
            Hide();
            var form5 = new SheduleOfPairsForm();
            form5.Show();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click a button 'Check visiting' to mark absent students. A button 'Information about students' is used to change student`s personal data.");


        }

        private void buttonViewVisiting_Click(object sender, EventArgs e)
        {
            Hide();
            var form6 = new ViewVisitingForm();
            form6.Show();
        }
    }
}