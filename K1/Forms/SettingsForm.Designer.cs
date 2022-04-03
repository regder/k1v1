
namespace K1.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRelog = new System.Windows.Forms.Button();
            this.btnLight = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDEL = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LOGBox = new System.Windows.Forms.TextBox();
            this.PASSBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.acceptbtn = new System.Windows.Forms.Button();
            this.delPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.delPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вкл/Откл темную тему:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выйти из учетной записи:";
            // 
            // btnRelog
            // 
            this.btnRelog.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRelog.Location = new System.Drawing.Point(264, 121);
            this.btnRelog.Name = "btnRelog";
            this.btnRelog.Size = new System.Drawing.Size(90, 34);
            this.btnRelog.TabIndex = 3;
            this.btnRelog.Text = "Выйти";
            this.btnRelog.UseVisualStyleBackColor = true;
            this.btnRelog.Click += new System.EventHandler(this.btnRelog_Click);
            // 
            // btnLight
            // 
            this.btnLight.Image = global::K1.Properties.Resources.imgonline_com_ua_Resize_dBCJ4MqitVy;
            this.btnLight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLight.Location = new System.Drawing.Point(264, 31);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(40, 40);
            this.btnLight.TabIndex = 4;
            this.btnLight.UseVisualStyleBackColor = true;
            this.btnLight.Click += new System.EventHandler(this.btnLight_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(425, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 450);
            this.panel1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(24, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Описание программы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сменить пароль:";
            // 
            // btnDEL
            // 
            this.btnDEL.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDEL.Location = new System.Drawing.Point(264, 195);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(90, 34);
            this.btnDEL.TabIndex = 6;
            this.btnDEL.Text = "Сменить";
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Старый пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Новый пароль:";
            // 
            // LOGBox
            // 
            this.LOGBox.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LOGBox.Location = new System.Drawing.Point(129, 74);
            this.LOGBox.Name = "LOGBox";
            this.LOGBox.Size = new System.Drawing.Size(134, 27);
            this.LOGBox.TabIndex = 2;
            // 
            // PASSBox
            // 
            this.PASSBox.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PASSBox.Location = new System.Drawing.Point(129, 110);
            this.PASSBox.Name = "PASSBox";
            this.PASSBox.Size = new System.Drawing.Size(134, 27);
            this.PASSBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(106, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Смена пароля";
            // 
            // acceptbtn
            // 
            this.acceptbtn.Location = new System.Drawing.Point(129, 149);
            this.acceptbtn.Name = "acceptbtn";
            this.acceptbtn.Size = new System.Drawing.Size(134, 33);
            this.acceptbtn.TabIndex = 5;
            this.acceptbtn.Text = "Подтвердить";
            this.acceptbtn.UseVisualStyleBackColor = true;
            this.acceptbtn.Click += new System.EventHandler(this.acceptbtn_Click);
            // 
            // delPanel
            // 
            this.delPanel.Controls.Add(this.textBox1);
            this.delPanel.Controls.Add(this.label8);
            this.delPanel.Controls.Add(this.acceptbtn);
            this.delPanel.Controls.Add(this.label6);
            this.delPanel.Controls.Add(this.PASSBox);
            this.delPanel.Controls.Add(this.LOGBox);
            this.delPanel.Controls.Add(this.label5);
            this.delPanel.Controls.Add(this.label4);
            this.delPanel.Location = new System.Drawing.Point(41, 253);
            this.delPanel.Name = "delPanel";
            this.delPanel.Size = new System.Drawing.Size(313, 185);
            this.delPanel.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(64, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Логин:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(129, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 27);
            this.textBox1.TabIndex = 7;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.delPanel);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLight);
            this.Controls.Add(this.btnRelog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.delPanel.ResumeLayout(false);
            this.delPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRelog;
        private System.Windows.Forms.Button btnLight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LOGBox;
        private System.Windows.Forms.TextBox PASSBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button acceptbtn;
        private System.Windows.Forms.Panel delPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}