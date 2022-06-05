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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ordersDataSet.ReportOrder". При необходимости она может быть перемещена или удалена.
            this.reportOrderTableAdapter.Fill(this.ordersDataSet.ReportOrder);
            
            this.reportViewer1.RefreshReport();
            
        }
    }
}
