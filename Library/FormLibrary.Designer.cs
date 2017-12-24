namespace Library
{
    partial class FormLibrary
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
            this.tabControlLibrary = new System.Windows.Forms.TabControl();
            this.tabPageRecords = new System.Windows.Forms.TabPage();
            this.tabPageReaders = new System.Windows.Forms.TabPage();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.dataGridViewReaders = new System.Windows.Forms.DataGridView();
            this.buttonSelectReaders = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlLibrary.SuspendLayout();
            this.tabPageReaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlLibrary
            // 
            this.tabControlLibrary.Controls.Add(this.tabPageRecords);
            this.tabControlLibrary.Controls.Add(this.tabPageReaders);
            this.tabControlLibrary.Controls.Add(this.tabPageBooks);
            this.tabControlLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlLibrary.Location = new System.Drawing.Point(0, 0);
            this.tabControlLibrary.Name = "tabControlLibrary";
            this.tabControlLibrary.SelectedIndex = 0;
            this.tabControlLibrary.Size = new System.Drawing.Size(511, 515);
            this.tabControlLibrary.TabIndex = 0;
            // 
            // tabPageRecords
            // 
            this.tabPageRecords.Location = new System.Drawing.Point(4, 25);
            this.tabPageRecords.Name = "tabPageRecords";
            this.tabPageRecords.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecords.Size = new System.Drawing.Size(823, 477);
            this.tabPageRecords.TabIndex = 0;
            this.tabPageRecords.Text = "Записи";
            this.tabPageRecords.UseVisualStyleBackColor = true;
            // 
            // tabPageReaders
            // 
            this.tabPageReaders.Controls.Add(this.buttonSelectReaders);
            this.tabPageReaders.Controls.Add(this.dataGridViewReaders);
            this.tabPageReaders.Location = new System.Drawing.Point(4, 25);
            this.tabPageReaders.Name = "tabPageReaders";
            this.tabPageReaders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReaders.Size = new System.Drawing.Size(503, 486);
            this.tabPageReaders.TabIndex = 1;
            this.tabPageReaders.Text = "Читатели";
            this.tabPageReaders.UseVisualStyleBackColor = true;
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Location = new System.Drawing.Point(4, 25);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(1014, 489);
            this.tabPageBooks.TabIndex = 2;
            this.tabPageBooks.Text = "Книги";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReaders
            // 
            this.dataGridViewReaders.AllowUserToAddRows = false;
            this.dataGridViewReaders.AllowUserToDeleteRows = false;
            this.dataGridViewReaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewReaders.Location = new System.Drawing.Point(8, 6);
            this.dataGridViewReaders.Name = "dataGridViewReaders";
            this.dataGridViewReaders.ReadOnly = true;
            this.dataGridViewReaders.RowTemplate.Height = 24;
            this.dataGridViewReaders.Size = new System.Drawing.Size(487, 218);
            this.dataGridViewReaders.TabIndex = 0;
            // 
            // buttonSelectReaders
            // 
            this.buttonSelectReaders.Location = new System.Drawing.Point(305, 231);
            this.buttonSelectReaders.Name = "buttonSelectReaders";
            this.buttonSelectReaders.Size = new System.Drawing.Size(190, 27);
            this.buttonSelectReaders.TabIndex = 1;
            this.buttonSelectReaders.Text = "Заполнить таблицу";
            this.buttonSelectReaders.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 515);
            this.Controls.Add(this.tabControlLibrary);
            this.Name = "FormLibrary";
            this.Text = "Библиотекарь v 2.0";
            this.tabControlLibrary.ResumeLayout(false);
            this.tabPageReaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlLibrary;
        private System.Windows.Forms.TabPage tabPageRecords;
        private System.Windows.Forms.TabPage tabPageReaders;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.Button buttonSelectReaders;
        private System.Windows.Forms.DataGridView dataGridViewReaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

