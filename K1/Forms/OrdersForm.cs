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
            UpBtn.BackColor = Color.FromArgb(254, 128, 0);
            SaveBtn.BackColor = Color.FromArgb(254, 128, 0);
            closeBtn.BackColor = Color.FromArgb(254, 128, 0);
            ViewBtn.BackColor = Color.FromArgb(254, 128, 0);
            delBtn.BackColor = Color.FromArgb(254, 128, 0);
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ordersKDataSet.Services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.ordersKDataSet.Services);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ordersKDataSet.Orderi". При необходимости она может быть перемещена или удалена.
            this.orderiTableAdapter.Fill(this.ordersKDataSet.Orderi);


            var db = new DataClasses1DataContext();
            

            servbx.DataSource = db.Services;
            servbx.ValueMember = "id_service";
            servbx.DisplayMember = "title";
        //    servbx.Items.Add(db.Services["id_service"].ToString() + " | " + db.Services[1].ToString());


            clientbx.DataSource = db.Clients;
            clientbx.ValueMember = "id_client";
            clientbx.DisplayMember = "firstName";
            
            workerbx.DataSource = db.Workers;
            workerbx.ValueMember = "id_worker";
            workerbx.DisplayMember = "firstName";
            
            statusbx.DataSource = db.Status;
            statusbx.ValueMember = "id_status";
            statusbx.DisplayMember = "name";

            dataGridView1.DataSource = from n in db.ord select n;
            SaveBtn.Visible = true;
            UpBtn.Visible = false;
            //   dataGridView1.Columns["Имя_клиента"].HeaderText = "Имя клиента";
            //   dataGridView1.Columns["Фамилия_клиента"].HeaderText = "Фамилия клиента";
            //   dataGridView1.Columns["Название_услуги"].HeaderText = "Название услуги";
            //  dataGridView1.Columns["Дата_начала"].HeaderText = "Дата начала";
            //  dataGridView1.Columns["Дата_окончания"].HeaderText = "Дата окончания";
            //    dataGridView1.Columns["Цена"].HeaderText = "Цена";
            //   dataGridView1.Columns["Статус_заказа"].HeaderText = "Статус заказа";
            //   dataGridView1.Columns["Телефон_клиента"].HeaderText = "Телефон клиента";
            //    dataGridView1.Columns["Адрес"].HeaderText = "Адрес";
            //   dataGridView1.Columns["Имя_сотрудника"].HeaderText = "Имя сотрудника";
            //   dataGridView1.Columns["Фамилия_сотрудника"].HeaderText = "Фамилия сотрудника";
            //   dataGridView1.Columns["Описание_заказа"].HeaderText = "Описание";
            dataGridView1.Columns["Код_заказа"].HeaderText = "Код заказа";
            dataGridView1.Columns["Услуга"].HeaderText = "Название услуги";
            dataGridView1.Columns["Дата_начала"].HeaderText = "Дата начала";
            dataGridView1.Columns["Дата_окончания"].HeaderText = "Дата Окончания";
            dataGridView1.Columns["Клиент"].HeaderText = "Клиент";
            dataGridView1.Columns["Статус"].HeaderText = "Статус заказа";
            dataGridView1.Columns["Сотрудник"].HeaderText = "Сотрудник";
            dataGridView1.Columns["Описание"].HeaderText = "Описание";

            
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
                dataGridView1.DataSource = from n in db.ord select n;
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
            dataGridView1.DataSource = from n in db.ord select n;
            SaveBtn.Visible = true;
            UpBtn.Visible = false;
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            var db = new DataClasses1DataContext();
            
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
                work.service = Convert.ToInt32(servbx.GetItemText(servbx.SelectedValue));
                work.StartTime = startPicker.Value;
                work.EndTime = endPicker.Value;
                work.Client = Convert.ToInt32(servbx.GetItemText(clientbx.SelectedValue));
                work.Status = Convert.ToInt32(servbx.GetItemText(statusbx.SelectedValue));
                work.Worker = Convert.ToInt32(servbx.GetItemText(workerbx.SelectedValue));
                work.Discription = discbx.Text;

                db.SubmitChanges();
            }
            dataGridView1.DataSource = from n in db.ord select n;
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
                n.service = Convert.ToInt32(servbx.GetItemText(servbx.SelectedValue));
                n.StartTime = startPicker.Value;
                n.EndTime = endPicker.Value;
                n.Client = Convert.ToInt32(servbx.GetItemText(clientbx.SelectedValue));
                n.Status = Convert.ToInt32(servbx.GetItemText(statusbx.SelectedValue));
                n.Worker = Convert.ToInt32(servbx.GetItemText(workerbx.SelectedValue));
                n.Discription = discbx.Text;
                
                db.Orderi.InsertOnSubmit(n);

            }
            else if (servbx.Text == "")
            {
                MessageBox.Show("Ошибка!");
            }
            db.SubmitChanges();
            dataGridView1.DataSource = from n in db.ord select n;
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
