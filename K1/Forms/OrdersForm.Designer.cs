﻿
namespace K1.Forms
{
    partial class OrdersForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.orderrr = new System.Windows.Forms.DataGridView();
            this.delBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.UpBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.discbx = new System.Windows.Forms.TextBox();
            this.startPicker = new System.Windows.Forms.DateTimePicker();
            this.endPicker = new System.Windows.Forms.DateTimePicker();
            this.workerbx = new System.Windows.Forms.ComboBox();
            this.statusbx = new System.Windows.Forms.ComboBox();
            this.servbx = new System.Windows.Forms.ComboBox();
            this.idbx = new System.Windows.Forms.TextBox();
            this.ordersKDataSet = new K1.OrdersKDataSet();
            this.orderiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderiTableAdapter = new K1.OrdersKDataSetTableAdapters.OrderiTableAdapter();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new K1.OrdersKDataSetTableAdapters.ServicesTableAdapter();
            this.clientbox = new System.Windows.Forms.ComboBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderrr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderrr
            // 
            this.orderrr.AllowUserToDeleteRows = false;
            this.orderrr.AllowUserToResizeColumns = false;
            this.orderrr.AllowUserToResizeRows = false;
            this.orderrr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderrr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.orderrr.BackgroundColor = System.Drawing.Color.White;
            this.orderrr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderrr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.orderrr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderrr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderrr.Location = new System.Drawing.Point(423, 23);
            this.orderrr.Name = "orderrr";
            this.orderrr.ReadOnly = true;
            this.orderrr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.orderrr.RowHeadersVisible = false;
            this.orderrr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderrr.Size = new System.Drawing.Size(365, 359);
            this.orderrr.TabIndex = 13;
            this.orderrr.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderrr_CellDoubleClick);
            this.orderrr.SelectionChanged += new System.EventHandler(this.orderrr_SelectionChanged);
            // 
            // delBtn
            // 
            this.delBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delBtn.ForeColor = System.Drawing.Color.White;
            this.delBtn.Location = new System.Drawing.Point(667, 400);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(93, 38);
            this.delBtn.TabIndex = 17;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(49, 400);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(106, 38);
            this.SaveBtn.TabIndex = 18;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(553, 400);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(93, 38);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // UpBtn
            // 
            this.UpBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpBtn.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpBtn.ForeColor = System.Drawing.Color.White;
            this.UpBtn.Location = new System.Drawing.Point(187, 400);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(108, 38);
            this.UpBtn.TabIndex = 14;
            this.UpBtn.Text = "Обновить";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBtn.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewBtn.ForeColor = System.Drawing.Color.White;
            this.ViewBtn.Location = new System.Drawing.Point(423, 400);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(111, 38);
            this.ViewBtn.TabIndex = 15;
            this.ViewBtn.Text = "Просмотр";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(21, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Статус заказа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Клиент:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Дата окончания:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Дата начала:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Услуга:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Данные:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(21, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Сотрудник";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(21, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Описание:";
            // 
            // discbx
            // 
            this.discbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discbx.Location = new System.Drawing.Point(139, 281);
            this.discbx.Multiline = true;
            this.discbx.Name = "discbx";
            this.discbx.Size = new System.Drawing.Size(247, 101);
            this.discbx.TabIndex = 27;
            this.discbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // startPicker
            // 
            this.startPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startPicker.Location = new System.Drawing.Point(139, 89);
            this.startPicker.Name = "startPicker";
            this.startPicker.Size = new System.Drawing.Size(247, 22);
            this.startPicker.TabIndex = 28;
            // 
            // endPicker
            // 
            this.endPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endPicker.Location = new System.Drawing.Point(139, 126);
            this.endPicker.Name = "endPicker";
            this.endPicker.Size = new System.Drawing.Size(247, 22);
            this.endPicker.TabIndex = 29;
            // 
            // workerbx
            // 
            this.workerbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workerbx.FormattingEnabled = true;
            this.workerbx.Location = new System.Drawing.Point(139, 236);
            this.workerbx.Name = "workerbx";
            this.workerbx.Size = new System.Drawing.Size(247, 24);
            this.workerbx.TabIndex = 31;
            // 
            // statusbx
            // 
            this.statusbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusbx.FormattingEnabled = true;
            this.statusbx.Location = new System.Drawing.Point(139, 199);
            this.statusbx.Name = "statusbx";
            this.statusbx.Size = new System.Drawing.Size(247, 24);
            this.statusbx.TabIndex = 32;
            // 
            // servbx
            // 
            this.servbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servbx.FormattingEnabled = true;
            this.servbx.Location = new System.Drawing.Point(139, 54);
            this.servbx.Name = "servbx";
            this.servbx.Size = new System.Drawing.Size(247, 24);
            this.servbx.TabIndex = 33;
            // 
            // idbx
            // 
            this.idbx.BackColor = System.Drawing.Color.White;
            this.idbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idbx.ForeColor = System.Drawing.Color.White;
            this.idbx.Location = new System.Drawing.Point(25, 328);
            this.idbx.Name = "idbx";
            this.idbx.ReadOnly = true;
            this.idbx.Size = new System.Drawing.Size(10, 13);
            this.idbx.TabIndex = 34;
            // 
            // ordersKDataSet
            // 
            this.ordersKDataSet.DataSetName = "OrdersKDataSet";
            this.ordersKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderiBindingSource
            // 
            this.orderiBindingSource.DataMember = "Orderi";
            this.orderiBindingSource.DataSource = this.ordersKDataSet;
            // 
            // orderiTableAdapter
            // 
            this.orderiTableAdapter.ClearBeforeFill = true;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.ordersKDataSet;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // clientbox
            // 
            this.clientbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientbox.FormattingEnabled = true;
            this.clientbox.Location = new System.Drawing.Point(139, 159);
            this.clientbox.Name = "clientbox";
            this.clientbox.Size = new System.Drawing.Size(247, 24);
            this.clientbox.TabIndex = 35;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbtn.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Searchbtn.Image = ((System.Drawing.Image)(resources.GetObject("Searchbtn.Image")));
            this.Searchbtn.Location = new System.Drawing.Point(392, 199);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(25, 24);
            this.Searchbtn.TabIndex = 36;
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.clientbox);
            this.Controls.Add(this.idbx);
            this.Controls.Add(this.servbx);
            this.Controls.Add(this.statusbx);
            this.Controls.Add(this.workerbx);
            this.Controls.Add(this.endPicker);
            this.Controls.Add(this.startPicker);
            this.Controls.Add(this.discbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.UpBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.orderrr);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderrr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox discbx;
        private System.Windows.Forms.DateTimePicker startPicker;
        private System.Windows.Forms.DateTimePicker endPicker;
        private System.Windows.Forms.ComboBox workerbx;
        private System.Windows.Forms.ComboBox statusbx;
        private System.Windows.Forms.ComboBox servbx;
        private System.Windows.Forms.TextBox idbx;
        private OrdersKDataSet ordersKDataSet;
        private System.Windows.Forms.BindingSource orderiBindingSource;
        private OrdersKDataSetTableAdapters.OrderiTableAdapter orderiTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private OrdersKDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.ComboBox clientbox;
        private System.Windows.Forms.Button Searchbtn;
        public System.Windows.Forms.DataGridView orderrr;
    }
}