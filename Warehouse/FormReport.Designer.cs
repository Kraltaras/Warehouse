namespace Warehouse
{
    partial class FormReport
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
            this.tableGridReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonSold = new System.Windows.Forms.RadioButton();
            this.radioButtonWared = new System.Windows.Forms.RadioButton();
            this.radioButtonNew = new System.Windows.Forms.RadioButton();
            this.monthCalendarStart = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarEnd = new System.Windows.Forms.MonthCalendar();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableGridReport
            // 
            this.tableGridReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGridReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ware,
            this.Status,
            this.Date});
            this.tableGridReport.Location = new System.Drawing.Point(12, 12);
            this.tableGridReport.Name = "tableGridReport";
            this.tableGridReport.Size = new System.Drawing.Size(600, 500);
            this.tableGridReport.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAll);
            this.groupBox1.Controls.Add(this.radioButtonSold);
            this.groupBox1.Controls.Add(this.radioButtonWared);
            this.groupBox1.Controls.Add(this.radioButtonNew);
            this.groupBox1.Location = new System.Drawing.Point(618, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статус";
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(17, 19);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(44, 17);
            this.radioButtonAll.TabIndex = 3;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Все";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonSold
            // 
            this.radioButtonSold.AutoSize = true;
            this.radioButtonSold.Location = new System.Drawing.Point(15, 88);
            this.radioButtonSold.Name = "radioButtonSold";
            this.radioButtonSold.Size = new System.Drawing.Size(63, 17);
            this.radioButtonSold.TabIndex = 2;
            this.radioButtonSold.TabStop = true;
            this.radioButtonSold.Text = "Продан";
            this.radioButtonSold.UseVisualStyleBackColor = true;
            this.radioButtonSold.CheckedChanged += new System.EventHandler(this.radioButtonSold_CheckedChanged);
            // 
            // radioButtonWared
            // 
            this.radioButtonWared.AutoSize = true;
            this.radioButtonWared.Location = new System.Drawing.Point(16, 65);
            this.radioButtonWared.Name = "radioButtonWared";
            this.radioButtonWared.Size = new System.Drawing.Size(78, 17);
            this.radioButtonWared.TabIndex = 1;
            this.radioButtonWared.TabStop = true;
            this.radioButtonWared.Text = "На складе";
            this.radioButtonWared.UseVisualStyleBackColor = true;
            this.radioButtonWared.CheckedChanged += new System.EventHandler(this.radioButtonWared_CheckedChanged);
            // 
            // radioButtonNew
            // 
            this.radioButtonNew.AutoSize = true;
            this.radioButtonNew.Location = new System.Drawing.Point(16, 42);
            this.radioButtonNew.Name = "radioButtonNew";
            this.radioButtonNew.Size = new System.Drawing.Size(62, 17);
            this.radioButtonNew.TabIndex = 0;
            this.radioButtonNew.TabStop = true;
            this.radioButtonNew.Text = "Принят";
            this.radioButtonNew.UseVisualStyleBackColor = true;
            this.radioButtonNew.CheckedChanged += new System.EventHandler(this.radioButtonNew_CheckedChanged);
            // 
            // monthCalendarStart
            // 
            this.monthCalendarStart.Location = new System.Drawing.Point(618, 159);
            this.monthCalendarStart.MaxSelectionCount = 1;
            this.monthCalendarStart.Name = "monthCalendarStart";
            this.monthCalendarStart.ShowToday = false;
            this.monthCalendarStart.TabIndex = 3;
            this.monthCalendarStart.TodayDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.monthCalendarStart.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarStart_DateChanged);
            // 
            // monthCalendarEnd
            // 
            this.monthCalendarEnd.Location = new System.Drawing.Point(618, 352);
            this.monthCalendarEnd.MaxSelectionCount = 1;
            this.monthCalendarEnd.Name = "monthCalendarEnd";
            this.monthCalendarEnd.TabIndex = 4;
            this.monthCalendarEnd.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarEnd_DateChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ОТ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ДО";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 525);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendarEnd);
            this.Controls.Add(this.monthCalendarStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableGridReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет";
            ((System.ComponentModel.ISupportInitialize)(this.tableGridReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableGridReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSold;
        private System.Windows.Forms.RadioButton radioButtonWared;
        private System.Windows.Forms.RadioButton radioButtonNew;
        private System.Windows.Forms.MonthCalendar monthCalendarStart;
        private System.Windows.Forms.MonthCalendar monthCalendarEnd;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ware;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}