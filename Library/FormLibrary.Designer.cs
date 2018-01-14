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
            this.buttonInsertReader = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReaderDescription = new System.Windows.Forms.TextBox();
            this.textBoxReaderName = new System.Windows.Forms.TextBox();
            this.buttonSelectReaders = new System.Windows.Forms.Button();
            this.dataGridViewReaders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReaderId = new System.Windows.Forms.TextBox();
            this.buttonUpdateReader = new System.Windows.Forms.Button();
            this.buttonDeleteReader = new System.Windows.Forms.Button();
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
            this.tabPageRecords.Size = new System.Drawing.Size(503, 486);
            this.tabPageRecords.TabIndex = 0;
            this.tabPageRecords.Text = "Записи";
            this.tabPageRecords.UseVisualStyleBackColor = true;
            // 
            // tabPageReaders
            // 
            this.tabPageReaders.Controls.Add(this.buttonDeleteReader);
            this.tabPageReaders.Controls.Add(this.buttonUpdateReader);
            this.tabPageReaders.Controls.Add(this.label3);
            this.tabPageReaders.Controls.Add(this.textBoxReaderId);
            this.tabPageReaders.Controls.Add(this.buttonInsertReader);
            this.tabPageReaders.Controls.Add(this.label2);
            this.tabPageReaders.Controls.Add(this.label1);
            this.tabPageReaders.Controls.Add(this.textBoxReaderDescription);
            this.tabPageReaders.Controls.Add(this.textBoxReaderName);
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
            // buttonInsertReader
            // 
            this.buttonInsertReader.Location = new System.Drawing.Point(305, 317);
            this.buttonInsertReader.Name = "buttonInsertReader";
            this.buttonInsertReader.Size = new System.Drawing.Size(190, 28);
            this.buttonInsertReader.TabIndex = 6;
            this.buttonInsertReader.Text = "Вставить читателя";
            this.buttonInsertReader.UseVisualStyleBackColor = true;
            this.buttonInsertReader.Click += new System.EventHandler(this.buttonInsertReader_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "name";
            // 
            // textBoxReaderDescription
            // 
            this.textBoxReaderDescription.Location = new System.Drawing.Point(197, 289);
            this.textBoxReaderDescription.Name = "textBoxReaderDescription";
            this.textBoxReaderDescription.Size = new System.Drawing.Size(298, 22);
            this.textBoxReaderDescription.TabIndex = 3;
            // 
            // textBoxReaderName
            // 
            this.textBoxReaderName.Location = new System.Drawing.Point(8, 289);
            this.textBoxReaderName.Name = "textBoxReaderName";
            this.textBoxReaderName.Size = new System.Drawing.Size(183, 22);
            this.textBoxReaderName.TabIndex = 2;
            // 
            // buttonSelectReaders
            // 
            this.buttonSelectReaders.Location = new System.Drawing.Point(305, 231);
            this.buttonSelectReaders.Name = "buttonSelectReaders";
            this.buttonSelectReaders.Size = new System.Drawing.Size(190, 27);
            this.buttonSelectReaders.TabIndex = 1;
            this.buttonSelectReaders.Text = "Заполнить таблицу";
            this.buttonSelectReaders.UseVisualStyleBackColor = true;
            this.buttonSelectReaders.Click += new System.EventHandler(this.buttonSelectReaders_Click);
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
            this.dataGridViewReaders.MultiSelect = false;
            this.dataGridViewReaders.Name = "dataGridViewReaders";
            this.dataGridViewReaders.ReadOnly = true;
            this.dataGridViewReaders.RowTemplate.Height = 24;
            this.dataGridViewReaders.Size = new System.Drawing.Size(487, 218);
            this.dataGridViewReaders.TabIndex = 0;
            this.dataGridViewReaders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReaders_CellClick);
         
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
            // tabPageBooks
            // 
            this.tabPageBooks.Location = new System.Drawing.Point(4, 25);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(503, 486);
            this.tabPageBooks.TabIndex = 2;
            this.tabPageBooks.Text = "Книги";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "id";
            // 
            // textBoxReaderId
            // 
            this.textBoxReaderId.Location = new System.Drawing.Point(6, 342);
            this.textBoxReaderId.Name = "textBoxReaderId";
            this.textBoxReaderId.ReadOnly = true;
            this.textBoxReaderId.Size = new System.Drawing.Size(183, 22);
            this.textBoxReaderId.TabIndex = 7;
            // 
            // buttonUpdateReader
            // 
            this.buttonUpdateReader.Location = new System.Drawing.Point(6, 384);
            this.buttonUpdateReader.Name = "buttonUpdateReader";
            this.buttonUpdateReader.Size = new System.Drawing.Size(245, 26);
            this.buttonUpdateReader.TabIndex = 9;
            this.buttonUpdateReader.Text = "Обновить читателя";
            this.buttonUpdateReader.UseVisualStyleBackColor = true;
            this.buttonUpdateReader.Click += new System.EventHandler(this.buttonUpdateReader_Click);
            // 
            // buttonDeleteReader
            // 
            this.buttonDeleteReader.Location = new System.Drawing.Point(257, 383);
            this.buttonDeleteReader.Name = "buttonDeleteReader";
            this.buttonDeleteReader.Size = new System.Drawing.Size(238, 27);
            this.buttonDeleteReader.TabIndex = 10;
            this.buttonDeleteReader.Text = "Удалить читателя";
            this.buttonDeleteReader.UseVisualStyleBackColor = true;
            this.buttonDeleteReader.Click += new System.EventHandler(this.buttonDeleteReader_Click);
            // 
            // FormLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 515);
            this.Controls.Add(this.tabControlLibrary);
            this.Name = "FormLibrary";
            this.Text = "Библиотекарь v 2.0";
            this.Load += new System.EventHandler(this.FormLibrary_Load);
            this.tabControlLibrary.ResumeLayout(false);
            this.tabPageReaders.ResumeLayout(false);
            this.tabPageReaders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlLibrary;
        private System.Windows.Forms.TabPage tabPageRecords;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabPage tabPageReaders;
        private System.Windows.Forms.Button buttonSelectReaders;
        public System.Windows.Forms.DataGridView dataGridViewReaders;
        private System.Windows.Forms.Button buttonInsertReader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxReaderDescription;
        public System.Windows.Forms.TextBox textBoxReaderName;
        private System.Windows.Forms.Button buttonDeleteReader;
        private System.Windows.Forms.Button buttonUpdateReader;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxReaderId;
    }
}

