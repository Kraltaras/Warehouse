namespace Warehouse
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableGrid = new System.Windows.Forms.DataGridView();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonWared = new System.Windows.Forms.Button();
            this.buttonSold = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableGrid
            // 
            this.tableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ware,
            this.Status,
            this.Date});
            this.tableGrid.Location = new System.Drawing.Point(12, 12);
            this.tableGrid.Name = "tableGrid";
            this.tableGrid.Size = new System.Drawing.Size(600, 350);
            this.tableGrid.TabIndex = 0;
            this.tableGrid.Visible = false;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(12, 12);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(200, 100);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "Просмотр принятых товаров, добавление новых и отправка на склад";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonWared
            // 
            this.buttonWared.Location = new System.Drawing.Point(12, 118);
            this.buttonWared.Name = "buttonWared";
            this.buttonWared.Size = new System.Drawing.Size(200, 100);
            this.buttonWared.TabIndex = 2;
            this.buttonWared.Text = "Просмотр товаров на складе и их продажа";
            this.buttonWared.UseVisualStyleBackColor = true;
            this.buttonWared.Click += new System.EventHandler(this.buttonWared_Click);
            // 
            // buttonSold
            // 
            this.buttonSold.Location = new System.Drawing.Point(12, 224);
            this.buttonSold.Name = "buttonSold";
            this.buttonSold.Size = new System.Drawing.Size(200, 100);
            this.buttonSold.TabIndex = 3;
            this.buttonSold.Text = "Просмотр проданных товаров";
            this.buttonSold.UseVisualStyleBackColor = true;
            this.buttonSold.Click += new System.EventHandler(this.buttonSold_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(12, 330);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(200, 100);
            this.buttonReport.TabIndex = 4;
            this.buttonReport.Text = "Отчет по товарам по их статусу и дате изменения статуса";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Ware
            // 
            this.Ware.HeaderText = "Товар";
            this.Ware.Name = "Ware";
            this.Ware.ReadOnly = true;
            this.Ware.Width = 300;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата изменения статуса";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 442);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonSold);
            this.Controls.Add(this.buttonWared);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.tableGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableGrid;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonWared;
        private System.Windows.Forms.Button buttonSold;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ware;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}

