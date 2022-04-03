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
            updateBtn.BackColor = Color.FromArgb(254, 128, 0);
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {            
            var db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.Notes;
            
            dataGridView1.Columns["Текст"].Visible = false;
            dataGridView1.Columns["Заголовок"].Width = 197;
            btnSave.Visible = true;
            updateBtn.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {            
            var db = new DataClasses1DataContext();
            titleBox.Clear();
            textBox.Clear();
            dataGridView1.DataSource = from n in db.Notes select n;
            btnSave.Visible = true;
            updateBtn.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            
            if (titleBox.Text != "")
            {
                var n = new Notes();
                n.Заголовок = titleBox.Text;
                n.Текст = textBox.Text;
                db.Notes.InsertOnSubmit(n);
                
            }
            else if (titleBox.Text == "")
            {
                MessageBox.Show("Ошибка!");
            }
            db.SubmitChanges();
            dataGridView1.DataSource = from n in db.Notes select n;
            titleBox.Clear();
            textBox.Clear();
            
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            titleBox.Text = (string)dataGridView1.Rows[index].Cells[0].Value;
            textBox.Text = (string)dataGridView1.Rows[index].Cells[1].Value;
            btnSave.Visible = false;
            updateBtn.Visible = true;
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
             var query =
                 from note in db.Notes
                where note.Заголовок == titleBox.Text
                select note;
            foreach (Notes note in query)
            {
                
                note.Текст = textBox.Text;
                db.SubmitChanges();
                dataGridView1.DataSource = from n in db.Notes select n;

            }           
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();

            var query =
                 from note in db.Notes
                 where note.Заголовок == titleBox.Text
                 select note;

            dataGridView1.DataSource = query;

        }
    }
}
