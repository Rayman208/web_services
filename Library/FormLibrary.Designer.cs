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
            this.buttonReturnSelectedBook = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewBooksForReader = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSelectReadersForRecords = new System.Windows.Forms.Button();
            this.dataGridViewReadersForRecords = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSelectRecords = new System.Windows.Forms.Button();
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageReaders = new System.Windows.Forms.TabPage();
            this.buttonDeleteReader = new System.Windows.Forms.Button();
            this.buttonUpdateReader = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReaderId = new System.Windows.Forms.TextBox();
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
            this.textBoxBookReader = new System.Windows.Forms.TextBox();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonUpdateBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBookId = new System.Windows.Forms.TextBox();
            this.buttonInsertBook = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBookAuthor = new System.Windows.Forms.TextBox();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.buttonSelectBooks = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBooksWithoutReader = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonGiveSelectedBook = new System.Windows.Forms.Button();
            this.tabControlLibrary.SuspendLayout();
            this.tabPageRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksForReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReadersForRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
            this.tabPageReaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).BeginInit();
            this.tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksWithoutReader)).BeginInit();
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
            this.tabControlLibrary.Size = new System.Drawing.Size(582, 672);
            this.tabControlLibrary.TabIndex = 0;
            // 
            // tabPageRecords
            // 
            this.tabPageRecords.Controls.Add(this.buttonGiveSelectedBook);
            this.tabPageRecords.Controls.Add(this.label10);
            this.tabPageRecords.Controls.Add(this.dataGridViewBooksWithoutReader);
            this.tabPageRecords.Controls.Add(this.buttonReturnSelectedBook);
            this.tabPageRecords.Controls.Add(this.label9);
            this.tabPageRecords.Controls.Add(this.label8);
            this.tabPageRecords.Controls.Add(this.dataGridViewBooksForReader);
            this.tabPageRecords.Controls.Add(this.buttonSelectReadersForRecords);
            this.tabPageRecords.Controls.Add(this.dataGridViewReadersForRecords);
            this.tabPageRecords.Controls.Add(this.buttonSelectRecords);
            this.tabPageRecords.Controls.Add(this.dataGridViewRecords);
            this.tabPageRecords.Location = new System.Drawing.Point(4, 25);
            this.tabPageRecords.Name = "tabPageRecords";
            this.tabPageRecords.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecords.Size = new System.Drawing.Size(574, 643);
            this.tabPageRecords.TabIndex = 0;
            this.tabPageRecords.Text = "Записи";
            this.tabPageRecords.UseVisualStyleBackColor = true;
            // 
            // buttonReturnSelectedBook
            // 
            this.buttonReturnSelectedBook.Location = new System.Drawing.Point(301, 393);
            this.buttonReturnSelectedBook.Name = "buttonReturnSelectedBook";
            this.buttonReturnSelectedBook.Size = new System.Drawing.Size(261, 27);
            this.buttonReturnSelectedBook.TabIndex = 15;
            this.buttonReturnSelectedBook.Text = "Сдать выбранную книгу";
            this.buttonReturnSelectedBook.UseVisualStyleBackColor = true;
            this.buttonReturnSelectedBook.Click += new System.EventHandler(this.buttonReturnSelectedBook_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Читатели";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Книги читателя";
            // 
            // dataGridViewBooksForReader
            // 
            this.dataGridViewBooksForReader.AllowUserToAddRows = false;
            this.dataGridViewBooksForReader.AllowUserToDeleteRows = false;
            this.dataGridViewBooksForReader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooksForReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooksForReader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridViewBooksForReader.Location = new System.Drawing.Point(298, 232);
            this.dataGridViewBooksForReader.MultiSelect = false;
            this.dataGridViewBooksForReader.Name = "dataGridViewBooksForReader";
            this.dataGridViewBooksForReader.ReadOnly = true;
            this.dataGridViewBooksForReader.RowTemplate.Height = 24;
            this.dataGridViewBooksForReader.Size = new System.Drawing.Size(264, 155);
            this.dataGridViewBooksForReader.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "author";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // buttonSelectReadersForRecords
            // 
            this.buttonSelectReadersForRecords.Location = new System.Drawing.Point(8, 393);
            this.buttonSelectReadersForRecords.Name = "buttonSelectReadersForRecords";
            this.buttonSelectReadersForRecords.Size = new System.Drawing.Size(284, 27);
            this.buttonSelectReadersForRecords.TabIndex = 4;
            this.buttonSelectReadersForRecords.Text = "Заполнить таблицу";
            this.buttonSelectReadersForRecords.UseVisualStyleBackColor = true;
            this.buttonSelectReadersForRecords.Click += new System.EventHandler(this.buttonSelectReadersForRecords_Click);
            // 
            // dataGridViewReadersForRecords
            // 
            this.dataGridViewReadersForRecords.AllowUserToAddRows = false;
            this.dataGridViewReadersForRecords.AllowUserToDeleteRows = false;
            this.dataGridViewReadersForRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReadersForRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReadersForRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewReadersForRecords.Location = new System.Drawing.Point(8, 232);
            this.dataGridViewReadersForRecords.MultiSelect = false;
            this.dataGridViewReadersForRecords.Name = "dataGridViewReadersForRecords";
            this.dataGridViewReadersForRecords.ReadOnly = true;
            this.dataGridViewReadersForRecords.RowTemplate.Height = 24;
            this.dataGridViewReadersForRecords.Size = new System.Drawing.Size(284, 155);
            this.dataGridViewReadersForRecords.TabIndex = 3;
            this.dataGridViewReadersForRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReadersForRecords_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // buttonSelectRecords
            // 
            this.buttonSelectRecords.Location = new System.Drawing.Point(372, 173);
            this.buttonSelectRecords.Name = "buttonSelectRecords";
            this.buttonSelectRecords.Size = new System.Drawing.Size(190, 27);
            this.buttonSelectRecords.TabIndex = 2;
            this.buttonSelectRecords.Text = "Заполнить таблицу";
            this.buttonSelectRecords.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToAddRows = false;
            this.dataGridViewRecords.AllowUserToDeleteRows = false;
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridViewRecords.Location = new System.Drawing.Point(8, 6);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.ReadOnly = true;
            this.dataGridViewRecords.RowTemplate.Height = 24;
            this.dataGridViewRecords.Size = new System.Drawing.Size(554, 161);
            this.dataGridViewRecords.TabIndex = 0;
            this.dataGridViewRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecords_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Book";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Reader";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Action";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
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
            this.tabPageReaders.Size = new System.Drawing.Size(574, 643);
            this.tabPageReaders.TabIndex = 1;
            this.tabPageReaders.Text = "Читатели";
            this.tabPageReaders.UseVisualStyleBackColor = true;
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
            this.tabPageBooks.Controls.Add(this.textBoxBookReader);
            this.tabPageBooks.Controls.Add(this.buttonDeleteBook);
            this.tabPageBooks.Controls.Add(this.buttonUpdateBook);
            this.tabPageBooks.Controls.Add(this.label4);
            this.tabPageBooks.Controls.Add(this.textBoxBookId);
            this.tabPageBooks.Controls.Add(this.buttonInsertBook);
            this.tabPageBooks.Controls.Add(this.label7);
            this.tabPageBooks.Controls.Add(this.label5);
            this.tabPageBooks.Controls.Add(this.label6);
            this.tabPageBooks.Controls.Add(this.textBoxBookAuthor);
            this.tabPageBooks.Controls.Add(this.textBoxBookName);
            this.tabPageBooks.Controls.Add(this.buttonSelectBooks);
            this.tabPageBooks.Controls.Add(this.dataGridViewBooks);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 25);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(574, 643);
            this.tabPageBooks.TabIndex = 2;
            this.tabPageBooks.Text = "Книги";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // textBoxBookReader
            // 
            this.textBoxBookReader.Location = new System.Drawing.Point(222, 289);
            this.textBoxBookReader.Name = "textBoxBookReader";
            this.textBoxBookReader.ReadOnly = true;
            this.textBoxBookReader.Size = new System.Drawing.Size(271, 22);
            this.textBoxBookReader.TabIndex = 22;
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(255, 383);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(238, 27);
            this.buttonDeleteBook.TabIndex = 21;
            this.buttonDeleteBook.Text = "Удалить книгу";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonUpdateBook
            // 
            this.buttonUpdateBook.Location = new System.Drawing.Point(4, 384);
            this.buttonUpdateBook.Name = "buttonUpdateBook";
            this.buttonUpdateBook.Size = new System.Drawing.Size(245, 26);
            this.buttonUpdateBook.TabIndex = 20;
            this.buttonUpdateBook.Text = "Обновить книгу";
            this.buttonUpdateBook.UseVisualStyleBackColor = true;
            this.buttonUpdateBook.Click += new System.EventHandler(this.buttonUpdateBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "id";
            // 
            // textBoxBookId
            // 
            this.textBoxBookId.Location = new System.Drawing.Point(4, 342);
            this.textBoxBookId.Name = "textBoxBookId";
            this.textBoxBookId.ReadOnly = true;
            this.textBoxBookId.Size = new System.Drawing.Size(183, 22);
            this.textBoxBookId.TabIndex = 18;
            // 
            // buttonInsertBook
            // 
            this.buttonInsertBook.Location = new System.Drawing.Point(303, 317);
            this.buttonInsertBook.Name = "buttonInsertBook";
            this.buttonInsertBook.Size = new System.Drawing.Size(190, 28);
            this.buttonInsertBook.TabIndex = 17;
            this.buttonInsertBook.Text = "Вставить книгу";
            this.buttonInsertBook.UseVisualStyleBackColor = true;
            this.buttonInsertBook.Click += new System.EventHandler(this.buttonInsertBook_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "reader";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "name";
            // 
            // textBoxBookAuthor
            // 
            this.textBoxBookAuthor.Location = new System.Drawing.Point(115, 289);
            this.textBoxBookAuthor.Name = "textBoxBookAuthor";
            this.textBoxBookAuthor.Size = new System.Drawing.Size(101, 22);
            this.textBoxBookAuthor.TabIndex = 14;
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(6, 289);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(103, 22);
            this.textBoxBookName.TabIndex = 13;
            // 
            // buttonSelectBooks
            // 
            this.buttonSelectBooks.Location = new System.Drawing.Point(303, 231);
            this.buttonSelectBooks.Name = "buttonSelectBooks";
            this.buttonSelectBooks.Size = new System.Drawing.Size(190, 27);
            this.buttonSelectBooks.TabIndex = 12;
            this.buttonSelectBooks.Text = "Заполнить таблицу";
            this.buttonSelectBooks.UseVisualStyleBackColor = true;
            this.buttonSelectBooks.Click += new System.EventHandler(this.buttonSelectBooks_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column4});
            this.dataGridViewBooks.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewBooks.MultiSelect = false;
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(487, 218);
            this.dataGridViewBooks.TabIndex = 11;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "reader";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridViewBooksWithoutReader
            // 
            this.dataGridViewBooksWithoutReader.AllowUserToAddRows = false;
            this.dataGridViewBooksWithoutReader.AllowUserToDeleteRows = false;
            this.dataGridViewBooksWithoutReader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooksWithoutReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooksWithoutReader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridViewBooksWithoutReader.Location = new System.Drawing.Point(8, 452);
            this.dataGridViewBooksWithoutReader.MultiSelect = false;
            this.dataGridViewBooksWithoutReader.Name = "dataGridViewBooksWithoutReader";
            this.dataGridViewBooksWithoutReader.ReadOnly = true;
            this.dataGridViewBooksWithoutReader.RowTemplate.Height = 24;
            this.dataGridViewBooksWithoutReader.Size = new System.Drawing.Size(281, 155);
            this.dataGridViewBooksWithoutReader.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "author";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Книги в наличии";
            // 
            // buttonGiveSelectedBook
            // 
            this.buttonGiveSelectedBook.Location = new System.Drawing.Point(6, 610);
            this.buttonGiveSelectedBook.Name = "buttonGiveSelectedBook";
            this.buttonGiveSelectedBook.Size = new System.Drawing.Size(283, 25);
            this.buttonGiveSelectedBook.TabIndex = 18;
            this.buttonGiveSelectedBook.Text = "Выдать выбранную книгу";
            this.buttonGiveSelectedBook.UseVisualStyleBackColor = true;
            this.buttonGiveSelectedBook.Click += new System.EventHandler(this.buttonGiveSelectedBook_Click);
            // 
            // FormLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 672);
            this.Controls.Add(this.tabControlLibrary);
            this.Name = "FormLibrary";
            this.Text = "Библиотекарь v 2.0";
            this.Load += new System.EventHandler(this.FormLibrary_Load);
            this.tabControlLibrary.ResumeLayout(false);
            this.tabPageRecords.ResumeLayout(false);
            this.tabPageRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksForReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReadersForRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            this.tabPageReaders.ResumeLayout(false);
            this.tabPageReaders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).EndInit();
            this.tabPageBooks.ResumeLayout(false);
            this.tabPageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksWithoutReader)).EndInit();
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
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonUpdateBook;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxBookId;
        private System.Windows.Forms.Button buttonInsertBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxBookAuthor;
        public System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Button buttonSelectBooks;
        public System.Windows.Forms.DataGridView dataGridViewBooks;
        public System.Windows.Forms.TextBox textBoxBookReader;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button buttonSelectRecords;
        public System.Windows.Forms.DataGridView dataGridViewRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView dataGridViewBooksForReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button buttonSelectReadersForRecords;
        public System.Windows.Forms.DataGridView dataGridViewReadersForRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button buttonReturnSelectedBook;
        private System.Windows.Forms.Button buttonGiveSelectedBook;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DataGridView dataGridViewBooksWithoutReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}

