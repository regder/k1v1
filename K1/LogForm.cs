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
    public partial class LogForm : Form
    {

        public LogForm()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(73, 101, 214);
            btnEnter.BackColor = Color.FromArgb(73, 101, 214);
            btnReg.BackColor = Color.FromArgb(73, 101, 214);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnReg_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();

            var form = new RegForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var p = new Users();
                p.login = form.logBoxReg.Text;
                p.password = form.PassBoxReg.Text;
                p.role = 2;

                db.Users.InsertOnSubmit(p);
                db.SubmitChanges();
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();

            var query = from c in db.Users
                        where (c.login == logBox.Text && c.password == passBox.Text)
                        select c;

            if (query.Count() == 1 && logBox.Text == "admin" && passBox.Text == "123")
            {

                Form1 A = new Form1();
                A.Show();
                this.Hide();

            }
            else if (query.Count() == 1 && logBox.Text != "admin" && passBox.Text != "123")
            { 
                Form1 u = new Form1();
                u.Show();
                this.Hide();
            }
            else if (query.Count() == 1 && logBox.Text != "admin" && passBox.Text == "123")
            {
                Form1 u = new Form1();
                u.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации");
            }
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
