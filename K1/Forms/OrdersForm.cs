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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            

            var db = new DataClasses1DataContext();
            servbx.DataSource = db.Services;
            servbx.ValueMember = "id_service";
            servbx.DisplayMember = "title";
            
            
            clientbx.DataSource = db.Clients;
            clientbx.ValueMember = "id_client";
            clientbx.DisplayMember = "firstName";
            
            workerbx.DataSource = db.Workers;
            workerbx.ValueMember = "id_worker";
            workerbx.DisplayMember = "firstName";
            
            statusbx.DataSource = db.Status;
            statusbx.ValueMember = "id_status";
            statusbx.DisplayMember = "name";

            dataGridView1.DataSource = from n in db.Orderi select n;
            SaveBtn.Visible = true;
            UpBtn.Visible = false;
            dataGridView1.Columns["id_order"].HeaderText = "код заказа";
            dataGridView1.Columns["service"].HeaderText = "Услуга";
            dataGridView1.Columns["StartTime"].HeaderText = "Дата начала";
            dataGridView1.Columns["EndTime"].HeaderText = "Дата окончания";
            dataGridView1.Columns["Client"].HeaderText = "Код клиента";
            dataGridView1.Columns["Status"].HeaderText = "Статус заказа";
            dataGridView1.Columns["Worker"].HeaderText = "Код сотрудника";
            dataGridView1.Columns["Discription"].HeaderText = "Описание";

            dataGridView1.Columns["services"].HeaderText = "Услуга";
            dataGridView1.Columns["Clients"].HeaderText = "Код клиента";
            dataGridView1.Columns["Status1"].HeaderText = "Статус заказа";
            dataGridView1.Columns["Workers"].HeaderText = "Код сотрудника";
                 dataGridView1.Columns["services"].Visible = false;
                 dataGridView1.Columns["Clients"].Visible = false;
                 dataGridView1.Columns["Status1"].Visible = false;
                 dataGridView1.Columns["Workers"].Visible = false;
            
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
                    ids.Add((int)row.Cells["id_order"].Value);
                }
                var query = from n in db.Orderi
                            where ids.Contains(n.id_order)
                            select n;
                foreach (var q in query)
                {
                    db.Orderi.DeleteOnSubmit(q);
                }
                db.SubmitChanges();
                dataGridView1.DataSource = from n in db.Orderi select n;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            servbx.Text = "";
            clientbx.Text = "";
            workerbx.Text = "";
            statusbx.Text = "";
            discbx.Clear();
            dataGridView1.DataSource = from n in db.Orderi select n;
            SaveBtn.Visible = true;
            UpBtn.Visible = false;
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            idbx.Text = (Convert.ToString(dataGridView1.Rows[index].Cells[0].Value));
            servbx.Text = (Convert.ToString(dataGridView1.Rows[index].Cells[1].Value));
            statusbx.Text = (Convert.ToString(dataGridView1.Rows[index].Cells[5].Value));
            clientbx.Text = (Convert.ToString(dataGridView1.Rows[index].Cells[4].Value));
            startPicker.Value = (System.DateTime)dataGridView1.Rows[index].Cells[2].Value;
            workerbx.Text = (Convert.ToString(dataGridView1.Rows[index].Cells[6].Value));
            discbx.Text = (string)dataGridView1.Rows[index].Cells[7].Value;
            endPicker.Value = (System.DateTime)dataGridView1.Rows[index].Cells[3].Value;


            SaveBtn.Visible = false;
            UpBtn.Visible = true;
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            
            var query =
                from work in db.Orderi
                where work.id_order == Convert.ToInt32(idbx.Text)
                select work;
            foreach (Orderi work in query)
            {
                work.service = Convert.ToInt32(servbx.SelectedItem);
                work.StartTime = startPicker.Value;
                work.EndTime = endPicker.Value;
                work.Client = Convert.ToInt32(clientbx.SelectedItem);
                work.Status = Convert.ToInt32(statusbx.SelectedItem);
                work.Worker = Convert.ToInt32(workerbx.SelectedItem);
                work.Discription = discbx.Text;

                db.SubmitChanges();
            }
            dataGridView1.DataSource = from n in db.Orderi select n;
            servbx.Text = "";
            clientbx.Text = "";
            workerbx.Text = "";
            statusbx.Text = "";
            discbx.Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();

            if (servbx.Text != "")
            {
                var n = new Orderi();
                n.service = servbx.SelectedIndex;
                n.StartTime = startPicker.Value;
                n.EndTime = endPicker.Value;
                n.Client = clientbx.SelectedIndex;
                n.Status = statusbx.SelectedIndex;
                n.Worker = workerbx.SelectedIndex;
                n.Discription = discbx.Text;

                db.Orderi.InsertOnSubmit(n);

            }
            else if (servbx.Text == "")
            {
                MessageBox.Show("Ошибка!");
            }
            db.SubmitChanges();
            dataGridView1.DataSource = from n in db.Orderi select n;
            servbx.Text = "";
            clientbx.Text = "";
            workerbx.Text = "";
            statusbx.Text = "";
            discbx.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
