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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            // 254, 219, 0 желтый
            // 254, 128, 0 оранжевый
            
            btnRelog.BackColor = Color.FromArgb(254, 128, 0);
            btnDEL.BackColor = Color.FromArgb(254, 128, 0);
            label7.ForeColor = Color.FromArgb(254, 128, 0);
            delPanel.BackColor = Color.FromArgb(255, 228, 64);

            delPanel.Visible = false;
        }

        

        

        private void btnRelog_Click(object sender, EventArgs e)
        {
            

            if (MessageBox.Show("Вы уверены?", "Attantion", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Form1.ActiveForm.Hide();  //Скрываем первую форму
                LogForm MyForm2 = new LogForm(); //Инициализируем 2 форму
                MyForm2.ShowDialog();             // Отображает форму как модальное окно
                Close();                
            }
            
        }
        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Attantion", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                delPanel.Visible = true;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void acceptbtn_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();

            var query = from c in db.Users
                        where (c.login == textBox1.Text && c.password == LOGBox.Text)
                        select c;

            if (query.Count() == 1)
            {                
                var q = new Users();
                q.login = textBox1.Text;
                q.password = LOGBox.Text;
                
                                                
                foreach (Users user in query)
                {

                    user.password = PASSBox.Text;
                    db.SubmitChanges();
                    
                }

                Form1.ActiveForm.Hide();  //Скрываем первую форму
                LogForm MyForm2 = new LogForm(); //Инициализируем 2 форму
                MyForm2.ShowDialog();             // Отображает форму как модальное окно
                Close();


            }
            else
            {
                MessageBox.Show("Ошибка!!!");
            }
            db.SubmitChanges();
        }
    }
}
