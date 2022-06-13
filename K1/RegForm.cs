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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(73, 101, 214);
            btnSave.BackColor = Color.FromArgb(73, 101, 214);
            btnSave.ForeColor = Color.FromArgb(255, 255, 255);
            btnHide.ForeColor = Color.FromArgb(255, 255, 255);
            btnClose.ForeColor = Color.FromArgb(255, 255, 255);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {            
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Namebox.Text != "" && logBoxReg.Text != "" && PassBoxReg.Text != "")
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show("Новая учетная запись успешно создана!");

            }
            else
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Ошибка регистрации!!!");
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
