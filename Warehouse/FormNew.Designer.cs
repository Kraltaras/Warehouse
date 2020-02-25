namespace Warehouse
{
    partial class FormNew
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
            this.tableGridNew = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonToWare = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableGridNew)).BeginInit();
            this.SuspendLayout();
            // 
            // tableGridNew
            // 
            this.tableGridNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGridNew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ware,
            this.Status,
            this.Date});
            this.tableGridNew.Location = new System.Drawing.Point(12, 12);
            this.tableGridNew.Name = "tableGridNew";
            this.tableGridNew.Size = new System.Drawing.Size(600, 350);
            this.tableGridNew.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(618, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 98);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить новую запись";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonToWare
            // 
            this.buttonToWare.Location = new System.Drawing.Point(618, 272);
            this.buttonToWare.Name = "buttonToWare";
            this.buttonToWare.Size = new System.Drawing.Size(75, 90);
            this.buttonToWare.TabIndex = 3;
            this.buttonToWare.Text = "На склад";
            this.buttonToWare.UseVisualStyleBackColor = true;
            this.buttonToWare.Click += new System.EventHandler(this.buttonToWare_Click);
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
            // FormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 377);
            this.Controls.Add(this.buttonToWare);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tableGridNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Принятые товары";
            ((System.ComponentModel.ISupportInitialize)(this.tableGridNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableGridNew;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonToWare;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ware;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}