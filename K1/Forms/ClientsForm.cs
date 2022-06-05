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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
            UpBtn.BackColor = Color.FromArgb(254, 128, 0);
            SaveBtn.BackColor = Color.FromArgb(254, 128, 0);
            closeBtn.BackColor = Color.FromArgb(254, 128, 0);
            ViewBtn.BackColor = Color.FromArgb(254, 128, 0);
            delBtn.BackColor = Color.FromArgb(254, 128, 0);

        }
        
        private void ClientsForm_Load(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.Clients; 
            SaveBtn.Visible = true;
            UpBtn.Visible = false;
            dataGridView1.Columns["id_client"].HeaderText = "код клиента";
            dataGridView1.Columns["firstName"].HeaderText = "Имя";
            dataGridView1.Columns["lastName"].HeaderText = "Фамилия";
            dataGridView1.Columns["patronymic"].HeaderText = "Отчество";
            dataGridView1.Columns["telephone"].HeaderText = "Телефон";
            dataGridView1.Columns["address"].HeaderText = "Адрес";

        }

        private void delBtn_Click(object sender, EventArgs e)
        {

            var db = new DataClasses1DataContext();
            var ids = new List<int>();
            var selected = dataGridView1.SelectedRows;
            foreach (DataGridViewRow row in selected)
            {
                ids.Add((int)row.Cells["id_client"].Value);
            }
            var query = from n in db.Clients
                        where ids.Contains(n.id_client)
                        select n;
            foreach (var q in query)
            {
                db.Clients.DeleteOnSubmit(q);

            }
            db.SubmitChanges();

            dataGridView1.DataSource = from n in db.Clients select n;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            Nameclient.Clear();
            famClient.Clear();
            otchClient.Clear();
            telClient.Clear();
            addressClient.Clear();
            dataGridView1.DataSource = from n in db.Clients select n;
            SaveBtn.Visible = true;
            UpBtn.Visible = false;
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            Nameclient.Text = (string)dataGridView1.Rows[index].Cells[1].Value;
            famClient.Text = (string)dataGridView1.Rows[index].Cells[2].Value;
            otchClient.Text = (string)dataGridView1.Rows[index].Cells[3].Value;
            telClient.Text = (string)dataGridView1.Rows[index].Cells[4].Value;
            addressClient.Text = (string)dataGridView1.Rows[index].Cells[5].Value;
            SaveBtn.Visible = false;
            UpBtn.Visible = true;
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var query =
                from client in db.Clients
                where client.firstName == Nameclient.Text
                select client;
            foreach (Clients client in query)
            {

                client.firstName = Nameclient.Text;
                client.lastName = famClient.Text;
                client.patronymic = otchClient.Text;
                client.telephone = telClient.Text;
                client.address = addressClient.Text;
                db.SubmitChanges();
                dataGridView1.DataSource = from n in db.Clients select n;

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();

            if (Nameclient.Text != "" && famClient.Text != "" && otchClient.Text != "" && telClient.Text != "" && addressClient.Text != "")
            {
                var n = new Clients();
                n.firstName = Nameclient.Text;
                n.lastName = famClient.Text;
                n.patronymic = otchClient.Text;
                n.telephone = telClient.Text;
                n.address = addressClient.Text;
                db.Clients.InsertOnSubmit(n);

            }
            else if (Nameclient.Text == "" && famClient.Text == "" && otchClient.Text == "" && telClient.Text == "" && addressClient.Text == "")
            {
                MessageBox.Show("Ошибка!");
            }
            db.SubmitChanges();
            dataGridView1.DataSource = from n in db.Clients select n;
            Nameclient.Clear();
            famClient.Clear();
            otchClient.Clear();
            telClient.Clear();
            addressClient.Clear();
        }
    }
}
