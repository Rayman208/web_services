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

        public void InsertReader()
        {
            Reader ir = new Reader
                (0,
                form.textBoxReaderName.Text,
                form.textBoxReaderDescription.Text);

            if (dbModel.Readers_Insert(ir) == true)
            {
                ShowReaders();
            }
            else
            {
                MessageBox.Show("Ошибка вставки читателя");
            }
        }
        #endregion

    }
}
