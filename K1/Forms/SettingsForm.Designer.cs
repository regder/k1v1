﻿
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnDEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Включить темную тему:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Удалить учетную запись:";
            // 
            // btnDEL
            // 
            this.btnDEL.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDEL.Location = new System.Drawing.Point(264, 195);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(90, 34);
            this.btnDEL.TabIndex = 6;
            this.btnDEL.Text = "Удалить";
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLight);
            this.Controls.Add(this.btnRelog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRelog;
        private System.Windows.Forms.Button btnLight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDEL;
    }
}