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
    public partial class servicesForm : Form
    {
        public servicesForm()
        {
            InitializeComponent();
            UpBtn.BackColor = Color.FromArgb(254, 128, 0);
            SaveBtn.BackColor = Color.FromArgb(254, 128, 0);
            closeBtn.BackColor = Color.FromArgb(254, 128, 0);
            ViewBtn.BackColor = Color.FromArgb(254, 128, 0);
            delBtn.BackColor = Color.FromArgb(254, 128, 0);
        }

        private void servicesForm_Load(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.Services;
            SaveBtn.Visible = true;
            UpBtn.Visible = false;
            dataGridView1.Columns["id_service"].HeaderText = "код услуги";
            dataGridView1.Columns["title"].HeaderText = "Название";
            dataGridView1.Columns["cost"].HeaderText = "Цена";

        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
            
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            titlebx.Text = (string)dataGridView1.Rows[index].Cells[1].Value;
            pricebx.Text = (Convert.ToString(dataGridView1.Rows[index].Cells[2].Value));

            SaveBtn.Visible = false;
            UpBtn.Visible = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            titlebx.Clear();
            pricebx.Clear();
            dataGridView1.DataSource = from n in db.Services select n;
            SaveBtn.Visible = true;
            UpBtn.Visible = false;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Attantion", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                var db = new DataClasses1DataContext();
                var ids = new List<int>();
                var selected = dataGridView1.SelectedRows;
                foreach (DataGridViewRow row in selected)
                {
                    ids.Add((int)row.Cells["id_service"].Value);
                }
                var query = from n in db.Services
                            where ids.Contains(n.id_service)
                            select n;
                foreach (var q in query)
                {
                    db.Services.DeleteOnSubmit(q);
                }
                db.SubmitChanges();

                dataGridView1.DataSource = from n in db.Services select n;
            }
        }
    }
}
