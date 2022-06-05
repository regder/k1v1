using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K1.Forms
{
    public partial class WorkersForm : Form
    {
        public WorkersForm()
        {
            InitializeComponent();
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            dataGridView1.DataSource = from n in db.Workers select n;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpBtn_Click(object sender, EventArgs e)
        {

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
