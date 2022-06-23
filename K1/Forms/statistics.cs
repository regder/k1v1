using Elasticsearch.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace K1.Forms
{
    public partial class statistics : Form
    {

        SqlConnection connection;
        SqlCommand command;
        SqlCommand serv;
        SqlDataAdapter adapter;
        DataTable table;
        public statistics()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=DESKTOP-8847191\\SQL321;Database=OrdersK;Trusted_Connection=True;");
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            button1.BackColor = Color.FromArgb(73, 101, 214);
            button2.BackColor = Color.FromArgb(73, 101, 214);
            button3.BackColor = Color.FromArgb(73, 101, 214);
            button4.BackColor = Color.FromArgb(73, 101, 214);
            
            button4.ForeColor = Color.FromArgb(255,255,255);
            button3.ForeColor = Color.FromArgb(255, 255, 255);
            button2.ForeColor = Color.FromArgb(255, 255, 255);
            button1.ForeColor = Color.FromArgb(255, 255, 255);


        }
        private void ShowTable(string text)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            command.CommandText = text;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void statistics_Load(object sender, EventArgs e)
        {

            var db = new DataClasses1DataContext();

            int count = db.Clients.Count();
            TotalClients.Text = Convert.ToString(count);

            int total = db.Services.Count();
            TotalServices.Text = Convert.ToString(total);

            int orders = db.Orderi.Count();
            TotalOrders.Text = Convert.ToString(orders);

            decimal profit = (from n in db.ReportOrder select n.Цена).Sum();
            Totalprofit.Text = Convert.ToString(profit);

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            ShowTable("SELECT TOP(5) Название_услуги, count(*) as topcount FROM ReportOrder group by Название_услуги order by topcount DESC");
               
            popServ.Series["Series1"].XValueMember = "Название_услуги";
            popServ.Series["Series1"].YValueMembers = "topcount";
            popServ.Series["Series1"]["PieLabelStyle"] = "Disabled";
            popServ.DataSource = dataGridView1.DataSource;
            popServ.DataBind();
            panel7.Visible = false;
            button5.Visible = false;            
            serv = new SqlCommand("Select Дата_начала, count(Услуга) as ser from ord group by Дата_начала order by ser", connection);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(serv);
            DataSet ds = new DataSet();
            try
            {
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                StatDate.Series["Series1"].XValueMember= "Дата_начала";
                StatDate.Series["Series1"].YValueMembers= "ser";
                StatDate.Series["Series1"]["PieLabelStyle"] = "Disabled";
                StatDate.DataSource = dataGridView2.DataSource;
                StatDate.DataBind();
                                
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //select* from ReportOrder Where Дата_начала >= GETDATE() - 7
            serv = new SqlCommand("Select Дата_начала, count(Услуга) as ser  from ord where Дата_начала >= GETDATE() - 7 group by Дата_начала order by ser ", connection);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(serv);
            DataSet ds = new DataSet();
            try
            {
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                StatDate.Series["Series1"].XValueMember = "Дата_начала";
                StatDate.Series["Series1"].YValueMembers = "ser";
                StatDate.Series["Series1"]["PieLabelStyle"] = "Disabled";
                StatDate.DataSource = dataGridView2.DataSource;
                StatDate.DataBind();
                
                ShowTable("SELECT TOP(5) Название_услуги, count(*) as topcount FROM ReportOrder where Дата_начала >= GETDATE() - 7 group by Название_услуги order by topcount DESC");

                popServ.Series["Series1"].XValueMember = "Название_услуги";
                popServ.Series["Series1"].YValueMembers = "topcount";
                popServ.Series["Series1"]["PieLabelStyle"] = "Disabled";
                popServ.DataSource = dataGridView1.DataSource;
                popServ.DataBind();
            }
            finally
            {
                connection.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //select* from ReportOrder Where Дата_начала >= GETDATE() - 30
            serv = new SqlCommand("Select Дата_начала, count(Услуга) as ser  from ord where Дата_начала >= GETDATE() - 30 group by Дата_начала order by ser", connection);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(serv);
            DataSet ds = new DataSet();
            try
            {
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                StatDate.Series["Series1"].XValueMember = "Дата_начала";
                StatDate.Series["Series1"].YValueMembers = "ser";
                StatDate.Series["Series1"]["PieLabelStyle"] = "Disabled";
                StatDate.DataSource = dataGridView2.DataSource;
                StatDate.DataBind();

                ShowTable("SELECT TOP(5) Название_услуги, count(*) as topcount FROM ReportOrder where Дата_начала >= GETDATE() - 30 group by Название_услуги order by topcount DESC");

                popServ.Series["Series1"].XValueMember = "Название_услуги";
                popServ.Series["Series1"].YValueMembers = "topcount";
                popServ.Series["Series1"]["PieLabelStyle"] = "Disabled";
                popServ.DataSource = dataGridView1.DataSource;
                popServ.DataBind();
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //select* from ReportOrder Where Дата_начала >= GETDATE() - 0
            serv = new SqlCommand("Select Дата_начала, count(Услуга) as ser  from ord where Дата_начала >= GETDATE() - 1 group by Дата_начала order by ser", connection);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(serv);
            DataSet ds = new DataSet();
            try
            {
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                StatDate.Series["Series1"].XValueMember = "Дата_начала";
                StatDate.Series["Series1"].YValueMembers = "ser";
                StatDate.Series["Series1"]["PieLabelStyle"] = "Disabled";
                StatDate.DataSource = dataGridView2.DataSource;
                StatDate.DataBind();

                ShowTable("SELECT TOP(5) Название_услуги, count(*) as topcount FROM ReportOrder where Дата_начала >= GETDATE() - 1 group by Название_услуги order by topcount DESC");

                popServ.Series["Series1"].XValueMember = "Название_услуги";
                popServ.Series["Series1"].YValueMembers = "topcount";
                popServ.Series["Series1"]["PieLabelStyle"] = "Disabled";
                popServ.DataSource = dataGridView1.DataSource;
                popServ.DataBind();
            }
            finally
            {
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //select* from ReportOrder
            serv = new SqlCommand("Select Дата_начала, count(Услуга) as ser from ord group by Дата_начала order by ser", connection);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(serv);
            DataSet ds = new DataSet();
            try
            {
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                StatDate.Series["Series1"].XValueMember = "Дата_начала";
                StatDate.Series["Series1"].YValueMembers = "ser";
                StatDate.Series["Series1"]["PieLabelStyle"] = "Disabled";
                StatDate.DataSource = dataGridView2.DataSource;
                StatDate.DataBind();

                ShowTable("SELECT TOP(5) Название_услуги, count(*) as topcount FROM ReportOrder group by Название_услуги order by topcount DESC");

                popServ.Series["Series1"].XValueMember = "Название_услуги";
                popServ.Series["Series1"].YValueMembers = "topcount";
                popServ.Series["Series1"]["PieLabelStyle"] = "Disabled";
                popServ.DataSource = dataGridView1.DataSource;
                popServ.DataBind();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
