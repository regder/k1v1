using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            
        }

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

        }
    }
}
