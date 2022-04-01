
namespace K1.Forms
{
    partial class NotesForm
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
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersDataSet = new K1.OrderDataSet();
            this.ordersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRead.Location = new System.Drawing.Point(522, 391);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(93, 38);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Читать";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDel.Location = new System.Drawing.Point(669, 391);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(93, 38);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(279, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 38);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(147, 391);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(93, 38);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Заголовок:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(82, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Текст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(518, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Список заметок";
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleBox.Location = new System.Drawing.Point(147, 44);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(240, 31);
            this.titleBox.TabIndex = 7;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(147, 93);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(240, 276);
            this.textBox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(522, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 276);
            this.dataGridView1.TabIndex = 9;
            // 
            // ordersDataSet
            // 
            this.ordersDataSet.DataSetName = "OrdersDataSet";
            this.ordersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersDataSetBindingSource
            // 
            this.ordersDataSetBindingSource.DataSource = this.ordersDataSet;
            this.ordersDataSetBindingSource.Position = 0;
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnRead);
            this.Name = "NotesForm";
            this.Text = "NotesForm";
            this.Load += new System.EventHandler(this.NotesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OrderDataSet ordersDataSet;
        private System.Windows.Forms.BindingSource ordersDataSetBindingSource;
    }
}