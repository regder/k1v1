﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace K1.Forms
{
    public partial class OrdersForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlCommand wrk;
        SqlCommand wr;
        public OrdersForm()
        {
            InitializeComponent();
            UpBtn.BackColor = Color.FromArgb(73, 101, 214);
            SaveBtn.BackColor = Color.FromArgb(73, 101, 214);
            closeBtn.BackColor = Color.FromArgb(73, 101, 214);
            ViewBtn.BackColor = Color.FromArgb(73, 101, 214);
            delBtn.BackColor = Color.FromArgb(73, 101, 214);
            Searchbtn.BackColor = Color.FromArgb(255, 160, 64);
            connection = new SqlConnection("Server=DESKTOP-8847191\\SQL321;Database=OrdersK;Trusted_Connection=True;");


        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            idbx.Visible = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ordersKDataSet.Services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.ordersKDataSet.Services);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ordersKDataSet.Orderi". При необходимости она может быть перемещена или удалена.
            this.orderiTableAdapter.Fill(this.ordersKDataSet.Orderi);

            var db = new DataClasses1DataContext();

            servbx.DataSource = db.Services;
            servbx.ValueMember = "id_service";
            servbx.DisplayMember = "title";
                        
            command = new SqlCommand("Select  id_client, (convert(varchar(10),id_client)+' | ' + firstName + ' ' + lastName +' '+ patronymic) as FIO  from Clients", connection);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            
            try
            {
                sda.Fill(ds);
                clientbox.DataSource = ds.Tables[0];
                clientbox.ValueMember = "id_client";
                clientbox.DisplayMember = "FIO";
            }
            finally
            {
                connection.Close();
            }

            wrk = new SqlCommand("Select id_worker, (convert(varchar(10),id_worker)+' | ' + firstName + ' ' + lastName +' '+ patronymic) as FioWorker  from Workers", connection);
            connection.Open();
            SqlDataAdapter wrke = new SqlDataAdapter(wrk);
            DataSet wke = new DataSet();
            try
            {
                wrke.Fill(wke);
                workerbx.DataSource = wke.Tables[0];
                workerbx.ValueMember = "id_worker";
                workerbx.DisplayMember = "FioWorker";                               

            }
            finally
            {
                connection.Close();
            }
            wr = new SqlCommand ("SELECT dbo.Orderi.id_order AS Код_заказа, dbo.Services.title AS Услуга, dbo.Orderi.StartTime AS Дата_начала, dbo.Orderi.EndTime AS Дата_окончания, dbo.Clients.firstName AS Клиент, dbo.Status.name AS Статус, dbo.Workers.firstName AS Сотрудник, dbo.Orderi.Discription AS Описание, (convert(varchar(10), id_worker) + ' | ' + dbo.Workers.firstName + ' ' + dbo.Workers.lastName + ' ' + dbo.Workers.patronymic) as FioOfWorker, (convert(varchar(10), id_client) + ' | ' + dbo.Clients.firstName + ' ' + dbo.Clients.lastName + ' ' + dbo.Clients.patronymic) as FIO FROM dbo.Clients INNER JOIN dbo.Orderi ON dbo.Clients.id_client = dbo.Orderi.Client INNER JOIN dbo.Services ON dbo.Orderi.service = dbo.Services.id_service INNER JOIN dbo.Status ON dbo.Orderi.Status = dbo.Status.id_status INNER JOIN dbo.Workers ON dbo.Orderi.Worker = dbo.Workers.id_worker", connection);
            connection.Open();
            SqlDataAdapter wre = new SqlDataAdapter(wr);
            DataSet wrek = new DataSet();
            wre.Fill(wrek);
                

            
            statusbx.DataSource = db.Status;
            statusbx.ValueMember = "id_status";
            statusbx.DisplayMember = "name";

            dataGridView1.DataSource = wrek.Tables[0];
            SaveBtn.Visible = true;
            UpBtn.Visible = false;
            
            dataGridView1.Columns["Код_заказа"].HeaderText = "Код заказа";
            dataGridView1.Columns["Услуга"].HeaderText = "Название услуги";
            dataGridView1.Columns["Дата_начала"].HeaderText = "Дата начала";
            dataGridView1.Columns["Дата_окончания"].HeaderText = "Дата Окончания";
            dataGridView1.Columns["Клиент"].Visible = false;
            dataGridView1.Columns["Статус"].HeaderText = "Статус заказа";
            dataGridView1.Columns["Сотрудник"].Visible = false;
            dataGridView1.Columns["Описание"].HeaderText = "Описание";
            dataGridView1.Columns["FioOfWorker"].HeaderText = "ФИО сотрудника";
            dataGridView1.Columns["FIO"].HeaderText = "ФИО клиента";


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
                MessageBox.Show("=Данные успешно удалены!=");
                dataGridView1.DataSource = from n in db.ord select n;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            servbx.Text = "";
            
            workerbx.Text = "";
            statusbx.Text = "";
            clientbox.Text = "";
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
            startPicker.Value = (System.DateTime)dataGridView1.Rows[index].Cells[2].Value;
            discbx.Text = (string)dataGridView1.Rows[index].Cells[7].Value;
            endPicker.Value = (System.DateTime)dataGridView1.Rows[index].Cells[3].Value;
            
            workerbx.Text = (Convert.ToString(dataGridView1.Rows[index].Cells[8].Value));

            clientbox.Text = (Convert.ToString(dataGridView1.Rows[index].Cells[9].Value));

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
                work.Status = Convert.ToInt32(servbx.GetItemText(statusbx.SelectedValue));
                work.Worker = Convert.ToInt32(servbx.GetItemText(workerbx.SelectedValue));
                work.Discription = discbx.Text;

                work.Client = Convert.ToInt32(clientbox.SelectedValue);

                db.SubmitChanges();
                MessageBox.Show("=Данные успешно обновлены!=");
            }
            dataGridView1.DataSource = from n in db.ord select n;
            servbx.Text = "";
            workerbx.Text = "";
            statusbx.Text = "";
            clientbox.Text = "";
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
                n.Status = Convert.ToInt32(servbx.GetItemText(statusbx.SelectedValue));
                n.Worker = Convert.ToInt32(servbx.GetItemText(workerbx.SelectedValue));
                n.Discription = discbx.Text;

                n.Client = Convert.ToInt32(clientbox.SelectedValue);


                db.Orderi.InsertOnSubmit(n);

            }
            else if (servbx.Text == "")
            {
                MessageBox.Show("Ошибка!");
            }
            db.SubmitChanges();
            MessageBox.Show("=Данные успешно сохранены!=");
            dataGridView1.DataSource = from n in db.ord select n;
            servbx.Text = "";
            workerbx.Text = "";
            statusbx.Text = "";
            clientbox.Text = "";
            discbx.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();

            var query =
                 from n in db.ord
                 where n.Статус == statusbx.Text
                 select n;

            dataGridView1.DataSource = query;
        }
    }
}
