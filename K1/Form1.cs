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
    public partial class Form1 : Form
    {
        private Form activeForm;
        private Button currentButton;
        

        public Form1()
        {
            InitializeComponent();
            
            panel1.BackColor = Color.FromArgb(73, 101, 214);
            panelLogo.BackColor = Color.FromArgb(21, 51, 173);
            panelTitle.BackColor = Color.FromArgb(44, 61, 130);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            btnClose.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
            
        }
        private void ActivateButton(object btnSender)
        {
            if(btnSender!=null)
            {
                if(currentButton!=(Button) btnSender)
                {
                    disableButton();
                    btnClose.Visible = true;
                }
                
            }

        }
        private void disableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if ( previousBtn.GetType() == typeof(Button))
                {

                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.servicesForm(), sender);
            lbTitle.Text = "Услуги";
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.WorkersForm(), sender);
            lbTitle.Text = "Работники";
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.OrdersForm(), sender);
            lbTitle.Text = "Заказы";
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ClientsForm(), sender);
            lbTitle.Text = "Клиенты";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ReportForm(), sender);
            lbTitle.Text = "Отчеты";
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.NotesForm(), sender);
            lbTitle.Text = "Заметки";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SettingsForm(), sender);
            lbTitle.Text = "Настройки";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            disableButton();
            lbTitle.Text = "ГЛАВНАЯ";
            currentButton = null;
            btnClose.Visible = false;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            

            
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void btnhide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
