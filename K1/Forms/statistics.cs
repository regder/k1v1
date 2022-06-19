﻿using Elasticsearch.Net;
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
            ShowTable("SELECT TOP(5) Название_услуги, count(*) as topcount FROM ReportOrder group by Название_услуги order by topcount DESC");
            // int index = dataGridView1.CurrentCell.RowIndex; 

            //   int[] yValues =  { Convert.ToInt32(dataGridView1.Rows[index].Cells[].Value) };
            //  string[] xValues = { Convert.ToString(dataGridView1.Rows[index].Cells[].Value) };
            //  popServ.Series["Series1"].Points.DataBindXY( xValues, yValues);      
            popServ.Series["Series1"].XValueMember = "Название_услуги";
            popServ.Series["Series1"].YValueMembers = "topcount";
            popServ.Series["Series1"]["PieLabelStyle"] = "Disabled";
            popServ.DataSource = dataGridView1.DataSource;
            popServ.DataBind();
        }
    }
}