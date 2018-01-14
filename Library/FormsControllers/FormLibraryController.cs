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

    }
}
