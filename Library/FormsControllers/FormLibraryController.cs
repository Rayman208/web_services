using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Library
{
    class FormLibraryController
    {
        private FormLibrary form;
        private DbModel dbModel;

        public FormLibraryController(FormLibrary f)
        {
            form = f;
            dbModel = DbModel.GetInstance();
        }

        #region READERS
        private void ShowReaders()
        {
            form.dataGridViewReaders.Rows.Clear();
            foreach (Reader reader in dbModel.readers)
            {
                form.dataGridViewReaders.Rows.Add(
                    reader.Id,
                    reader.Name,
                    reader.Description
                    );
            }
        }

        public void FillReaderFields()
        {
            int rowIndex = form.dataGridViewReaders.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = form.dataGridViewReaders.Rows[rowIndex];

            form.textBoxReaderId.Text = selectedRow.Cells[0].Value.ToString();

            form.textBoxReaderName.Text = selectedRow.Cells[1].Value.ToString();

            form.textBoxReaderDescription.Text = selectedRow.Cells[2].Value.ToString();
        }

        public void SelectReaders()
        {
            if (dbModel.Readers_SelectAll() == true)
            {
                ShowReaders();
            }
            else
            {
                MessageBox.Show("Ошибка загрузки читателей");
            }
        }

        public void InsertReader()
        {
            if (
               form.textBoxReaderName.Text == String.Empty ||
               form.textBoxReaderDescription.Text == String.Empty)
            {
                MessageBox.Show("Данные не заполнены");
                return;
            }

            Reader reader = new Reader
                (0,
                form.textBoxReaderName.Text,
                form.textBoxReaderDescription.Text);

            if (dbModel.Readers_Insert(reader) == true)
            {
                ShowReaders();
                form.textBoxReaderName.Clear();
                form.textBoxReaderDescription.Clear();
            }
            else
            {
                MessageBox.Show("Ошибка вставки читателя");
            }
        }

        public void UpdateReader()
        {
            if (form.textBoxReaderId.Text == String.Empty ||
                form.textBoxReaderName.Text == String.Empty ||
                form.textBoxReaderDescription.Text == String.Empty)
            {
                MessageBox.Show("Данные не заполнены");
                return;
            }

            Reader reader = new Reader
                (long.Parse(form.textBoxReaderId.Text),
                form.textBoxReaderName.Text,
                form.textBoxReaderDescription.Text);

            if (dbModel.Readers_Update(reader) == true)
            {
                ShowReaders();
            }
            else
            {
                MessageBox.Show("Ошибка обновления читателя");
            }
        }

        public void DeleteReader()
        {
            if (form.textBoxReaderId.Text == String.Empty)
            {
                MessageBox.Show("Данные не заполнены");
                return;
            }

            long id = long.Parse(form.textBoxReaderId.Text);

            if (dbModel.Readers_Delete(id) == true)
            {
                ShowReaders();
            }
            else
            {
                MessageBox.Show("Ошибка удаления читателя");
            }
        }
        #endregion

        #region BOOKS
        private void ShowBooks()
        {
            form.dataGridViewBooks.Rows.Clear();
            foreach (Book book in dbModel.books)
            {
                form.dataGridViewBooks.Rows.Add(
                    book.Id,
                    book.Name,
                    book.Author,
                    book.IdReader == 0 ? "книга в библиотеке" : dbModel.readers.Find((r) => r.Id == book.IdReader).Name
                    );
            }
        }

        public void FillBooksFields()
        {
            int rowIndex = form.dataGridViewBooks.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = form.dataGridViewBooks.Rows[rowIndex];

            form.textBoxBookId.Text = selectedRow.Cells[0].Value.ToString();

            form.textBoxBookName.Text = selectedRow.Cells[1].Value.ToString();

            form.textBoxBookAuthor.Text = selectedRow.Cells[2].Value.ToString();

            form.textBoxBookReader.Text = selectedRow.Cells[3].Value.ToString();
        }

        public void SelectBooks()
        {
            if (dbModel.Books_SelectAll() == true)
            {
                ShowBooks();
            }
            else
            {
                MessageBox.Show("Ошибка загрузки книг");
            }
        }

        public void InsertBook()
        {
            if (
               form.textBoxBookName.Text == String.Empty ||
               form.textBoxBookAuthor.Text == String.Empty)
            {
                MessageBox.Show("Данные не заполнены");
                return;
            }

            Book book = new Book
                (0,
                form.textBoxBookName.Text,
                form.textBoxBookAuthor.Text,
                0);

            if (dbModel.Books_Insert(book) == true)
            {
                ShowBooks();
                form.textBoxBookName.Clear();
                form.textBoxBookAuthor.Clear();
            }
            else
            {
                MessageBox.Show("Ошибка вставки книги");
            }
        }

        public void UpdateBook()
        {
            if (form.textBoxBookId.Text == String.Empty ||
                form.textBoxBookName.Text == String.Empty ||
                form.textBoxBookAuthor.Text == String.Empty)
            {
                MessageBox.Show("Данные не заполнены");
                return;
            }

            Book book = new Book
                (long.Parse(form.textBoxBookId.Text),
                form.textBoxBookName.Text,
                form.textBoxBookAuthor.Text, 0);

            if (dbModel.Books_UpdateSettings(book) == true)
            {
                ShowBooks();
            }
            else
            {
                MessageBox.Show("Ошибка обновления читателя");
            }
        }

        public void DeleteBook()
        {
            if (form.textBoxBookId.Text == String.Empty)
            {
                MessageBox.Show("Данные не заполнены");
                return;
            }

            long id = long.Parse(form.textBoxBookId.Text);

            if (dbModel.Books_Delete(id) == true)
            {
                ShowBooks();
            }
            else
            {
                MessageBox.Show("Ошибка удаления книги");
            }
        }
        #endregion

        #region RECORDS

        private void ShowRecords()
        {
            form.dataGridViewRecords.Rows.Clear();
            foreach (Record record in dbModel.records)
            {
                string date = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(record.Date).ToString();

                Book b = dbModel.books.Find(t => t.Id == record.IdBook);
                string book = "\"" + b.Name + "\" : " + b.Author;

                Reader r = dbModel.readers.Find(t => t.Id == record.IdReader);
                string reader = r.Name + " - " + r.Description;

                string action = record.Action == 1 ? "Взял" : "Сдал";

                form.dataGridViewRecords.Rows.Add(
                    record.Id,
                    date,
                    book,
                    reader,
                    action
                    );
            }
        }

        public void SelectRecords()
        {
            if (dbModel.Records_SelectAll() == true)
            {
                ShowRecords();
            }
            else
            {
                MessageBox.Show("Ошибка загрузки записей");
            }
        }

        #endregion

    }
}
