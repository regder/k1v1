using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(255, 160, 64);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            // 111, 131, 214
            // 255, 228, 64
            Relogbtn.BackColor = Color.FromArgb(255, 185, 115);
            btnde.BackColor = Color.FromArgb(255, 185, 115);
            btnview.BackColor = Color.FromArgb(255, 185, 115);
            btnCl.BackColor = Color.FromArgb(255, 185, 115);
            lightBtn.BackColor = Color.FromArgb(255, 185, 115);
            Savebtn.BackColor = Color.FromArgb(255, 185, 115);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void AdminForm_Load(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.Users;
            dataGridView1.Columns["role"].Visible = false;
            dataGridView1.Columns["Roles"].Visible = false;
            dataGridView1.Columns["Name"].Width = 197;
            string usr = Convert.ToString(Program.AppData.CurrentUser);
            var query = from c in db.Users where c.login == usr select c.Name;
            label9.Text = "Добро пожаловать, " + query.First() + "!";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnde_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            var ids = new List<string>();
            var selected = dataGridView1.SelectedRows;
            foreach (DataGridViewRow row in selected)
            {
                ids.Add((string)row.Cells["login"].Value);
            }
            var query = from n in db.Users
                        where ids.Contains(n.login)
                        select n;
            foreach (var q in query)
            {
                db.Users.DeleteOnSubmit(q);

            }
            db.SubmitChanges();

            dataGridView1.DataSource = from n in db.Users select n;
        }

        private void btnCl_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            logbox.Clear();
            passbox.Clear();
            namebox.Clear();
            dataGridView1.DataSource = from n in db.Users select n;
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            logbox.Text = (string)dataGridView1.Rows[index].Cells[1].Value;
            passbox.Text = (string)dataGridView1.Rows[index].Cells[2].Value;
            namebox.Text = (string)dataGridView1.Rows[index].Cells[3].Value;
        }

        private void Relogbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Attantion", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                AdminForm.ActiveForm.Hide();  //Скрываем первую форму
                LogForm MyForm2 = new LogForm(); //Инициализируем 2 форму
                MyForm2.ShowDialog();             // Отображает форму как модальное окно
                Close();
            }
        }
        int i = 0;
        private void lightBtn_Click(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
            {
                panel1.BackColor = Color.FromArgb(44, 61, 130);
                this.BackColor = Color.FromArgb(111, 131, 214);
                label1.ForeColor = Color.FromArgb(255, 255, 255);
                label2.ForeColor = Color.FromArgb(255, 255, 255);
                label3.ForeColor = Color.FromArgb(255, 255, 255);
                label4.ForeColor = Color.FromArgb(255, 255, 255);
                label5.ForeColor = Color.FromArgb(255, 255, 255);
                label6.ForeColor = Color.FromArgb(255, 255, 255);
                label7.ForeColor = Color.FromArgb(255, 255, 255);
                label8.ForeColor = Color.FromArgb(255, 255, 255);
                label9.ForeColor = Color.FromArgb(255, 255, 255);

                btnCl.ForeColor = Color.FromArgb(255, 255, 255);
                btnClose.ForeColor = Color.FromArgb(255, 255, 255);
                btnde.ForeColor = Color.FromArgb(255, 255, 255);
                btnview.ForeColor = Color.FromArgb(255, 255, 255);
                btnHide.ForeColor = Color.FromArgb(255, 255, 255);
                btnFill.ForeColor = Color.FromArgb(255, 255, 255);
                Relogbtn.ForeColor = Color.FromArgb(255, 255, 255);
                lightBtn.ForeColor = Color.FromArgb(255, 255, 255);
                Savebtn.ForeColor = Color.FromArgb(255, 255, 255);

                Relogbtn.BackColor = Color.FromArgb(73, 101, 214);
                btnCl.BackColor = Color.FromArgb(73, 101, 214);
                btnde.BackColor = Color.FromArgb(73, 101, 214);
                btnview.BackColor = Color.FromArgb(73, 101, 214);
                lightBtn.BackColor = Color.FromArgb(73, 101, 214);
                Savebtn.BackColor = Color.FromArgb(73, 101, 214);
            }
            else if (i >= 1)
            {
                i = 0;
                panel1.BackColor = Color.FromArgb(255, 160, 64);
                //   255, 255, 255
                label1.ForeColor = Color.FromArgb(0, 0, 0);
                label2.ForeColor = Color.FromArgb(0, 0, 0);
                label3.ForeColor = Color.FromArgb(0, 0, 0);
                label4.ForeColor = Color.FromArgb(0, 0, 0);
                label5.ForeColor = Color.FromArgb(0, 0, 0);
                label6.ForeColor = Color.FromArgb(0, 0, 0);
                label7.ForeColor = Color.FromArgb(0, 0, 0);
                label8.ForeColor = Color.FromArgb(0, 0, 0);
                label9.ForeColor = Color.FromArgb(0, 0, 0);

                this.BackColor = Color.FromArgb(255, 255, 255);
                btnCl.ForeColor = Color.FromArgb(0, 0, 0);
                btnClose.ForeColor = Color.FromArgb(0, 0, 0);
                btnde.ForeColor = Color.FromArgb(0, 0, 0);
                btnview.ForeColor = Color.FromArgb(0, 0, 0);
                btnHide.ForeColor = Color.FromArgb(0, 0, 0);
                btnFill.ForeColor = Color.FromArgb(0, 0, 0);
                Relogbtn.ForeColor = Color.FromArgb(0, 0, 0);
                lightBtn.ForeColor = Color.FromArgb(0, 0, 0);
                Savebtn.ForeColor = Color.FromArgb(0, 0, 0);

                Relogbtn.BackColor = Color.FromArgb(255, 185, 115);
                btnde.BackColor = Color.FromArgb(255, 185, 115);
                btnview.BackColor = Color.FromArgb(255, 185, 115);
                btnCl.BackColor = Color.FromArgb(255, 185, 115);
                lightBtn.BackColor = Color.FromArgb(255, 185, 115);
                Savebtn.BackColor = Color.FromArgb(255, 185, 115);
            }
            
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            
            var db = new DataClasses1DataContext();
            var query =
                from user in db.Users
                where user.login == logbox.Text
                select user;
            foreach (Users user in query)
            {

                user.login = logbox.Text;
                user.password = passbox.Text;
                user.Name = namebox.Text;
                db.SubmitChanges();
                dataGridView1.DataSource = from n in db.Users select n;
                
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
