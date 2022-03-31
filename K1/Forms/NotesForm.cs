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
    public partial class NotesForm : Form
    {

        public NotesForm()
        {
            InitializeComponent();
            btnCreate.BackColor = Color.FromArgb(254, 128, 0);
            btnDel.BackColor = Color.FromArgb(254, 128, 0);
            btnRead.BackColor = Color.FromArgb(254, 128, 0);
            btnSave.BackColor = Color.FromArgb(254, 128, 0);
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {            
            var db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.Notes;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["Текст"].Visible = false;
            dataGridView1.Columns["Заголовок"].Width = 197;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {            
            var db = new DataClasses1DataContext();
            titleBox.Clear();
            textBox.Clear();
            dataGridView1.DataSource = from n in db.Notes select n;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {                        
            var db = new DataClasses1DataContext();
            if (btnSave.Enabled)
            {
                var n = new Notes();
                n.Заголовок = titleBox.Text;
                n.Текст = textBox.Text;
                db.Notes.InsertOnSubmit(n);
                db.SubmitChanges();
            }
            dataGridView1.DataSource = from n in db.Notes select n;

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            titleBox.Text = (string)dataGridView1.Rows[index].Cells[1].Value;
            textBox.Text = (string)dataGridView1.Rows[index].Cells[2].Value;


            //    int index = dataGridView1.CurrentCell.RowIndex;
            //   titleBox.Text = dataGridView1.Rows[index].Cells[0].ToString();
            //   textBox.Text = dataGridView1.Rows[index].Cells[1].ToString();


            //   int index = dataGridView1.CurrentCell.RowIndex;
            //       if (index > -1)
            //      {
            //          titleBox.Text = table.Rows[index].ItemArray[1].ToString();
            //          textBox.Text = table.Rows[index].ItemArray[2].ToString();
            //      }
            //   db.SubmitChanges();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {            
            var db = new DataClasses1DataContext();
            var ids = new List<string>();
            var selected = dataGridView1.SelectedRows;
            foreach (DataGridViewRow row in selected)
            {
                ids.Add((string)row.Cells["Заголовок"].Value);
            }
            var query = from n in db.Notes
                        where ids.Contains(n.Заголовок)
                        select n;
            foreach (var q in query)
            {
                db.Notes.DeleteOnSubmit(q);

            }
            db.SubmitChanges();
            
            dataGridView1.DataSource = from n in db.Notes select n;
        }
    }
}
