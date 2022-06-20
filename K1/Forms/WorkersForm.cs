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
            UpBtn.BackColor = Color.FromArgb(73, 101, 214);
            SaveBtn.BackColor = Color.FromArgb(73, 101, 214);
            closeBtn.BackColor = Color.FromArgb(73, 101, 214);
            ViewBtn.BackColor = Color.FromArgb(73, 101, 214);
            delBtn.BackColor = Color.FromArgb(73, 101, 214);
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            dataGridView1.DataSource = from n in db.Workers select n;
            SaveBtn.Visible = true;
            UpBtn.Visible = false;
            dataGridView1.Columns["id_worker"].HeaderText = "код сотрудника";
            dataGridView1.Columns["firstName"].HeaderText = "Имя";
            dataGridView1.Columns["lastName"].HeaderText = "Фамилия";
            dataGridView1.Columns["patronymic"].HeaderText = "Отчество";
            dataGridView1.Columns["birthday"].HeaderText = "Дата рождения";
            dataGridView1.Columns["salary"].HeaderText = "Зарплата";
            dataGridView1.Columns["experience"].HeaderText = "Стаж";
            dataGridView1.Columns["telephone"].HeaderText = "Телефон";
            dataGridView1.Columns["position"].HeaderText = "Должность";
            dataGridView1.Columns["address"].HeaderText = "Адрес";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();

            if (nameworker.Text != "")
            {
                var n = new Workers();
                n.firstName = nameworker.Text;
                n.lastName = famWorker.Text;
                n.patronymic = otchWorker.Text;
                n.birthday = dateTimePicker.Value;

                n.salary = Convert.ToDecimal(Salary.Text);

                n.telephone = telbox.Text;
                n.experience = expbox.Text;
                n.position = posBox.Text;
                n.address = addressbx.Text;
                db.Workers.InsertOnSubmit(n);
                MessageBox.Show("=Сотрудник успешно добавлен=");
            }
            else if (nameworker.Text == "")
            {
                MessageBox.Show("Ошибка!");
            }
            db.SubmitChanges();
            dataGridView1.DataSource = from n in db.Workers select n;
            nameworker.Clear();
            famWorker.Clear();
            otchWorker.Clear();
            Salary.Clear();
            telbox.Clear();
            expbox.Clear();
            posBox.Clear();
            addressbx.Clear();
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var query =
                from work in db.Workers
                where work.firstName == nameworker.Text
                select work;
            foreach (Workers work in query)
            {

                work.firstName = nameworker.Text;
                work.lastName = famWorker.Text;
                work.patronymic = otchWorker.Text;
                work.birthday = dateTimePicker.Value;
                work.salary = Convert.ToDecimal(Salary.Text);
                work.telephone = telbox.Text;
                work.experience = expbox.Text;
                work.position = posBox.Text;
                work.address = addressbx.Text;
                
                db.SubmitChanges();
            }
            dataGridView1.DataSource = from n in db.Workers select n;
            nameworker.Clear();
            famWorker.Clear();
            otchWorker.Clear();
            Salary.Clear();
            telbox.Clear();
            expbox.Clear();
            posBox.Clear();
            addressbx.Clear();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            nameworker.Text = (string)dataGridView1.Rows[index].Cells[1].Value;
            famWorker.Text = (string)dataGridView1.Rows[index].Cells[2].Value;
            otchWorker.Text = (string)dataGridView1.Rows[index].Cells[3].Value;
            dateTimePicker.Value = (System.DateTime)dataGridView1.Rows[index].Cells[4].Value;
            Salary.Text = (Convert.ToString(dataGridView1.Rows[index].Cells[5].Value));
            telbox.Text = (string)dataGridView1.Rows[index].Cells[6].Value;
            expbox.Text = (string)dataGridView1.Rows[index].Cells[7].Value;
            posBox.Text = (string)dataGridView1.Rows[index].Cells[8].Value;
            addressbx.Text = (string)dataGridView1.Rows[index].Cells[9].Value;

            SaveBtn.Visible = false;
            UpBtn.Visible = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            nameworker.Clear();
            famWorker.Clear();
            otchWorker.Clear();
            Salary.Clear();
            telbox.Clear();
            expbox.Clear();
            posBox.Clear();
            addressbx.Clear();
            dataGridView1.DataSource = from n in db.Workers select n;
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
                    ids.Add((int)row.Cells["id_worker"].Value);
                }
                var query = from n in db.Workers
                            where ids.Contains(n.id_worker)
                            select n;
                foreach (var q in query)
                {
                    db.Workers.DeleteOnSubmit(q);
                }
                db.SubmitChanges();
                dataGridView1.DataSource = from n in db.Workers select n;
            }
        }
    }
}
