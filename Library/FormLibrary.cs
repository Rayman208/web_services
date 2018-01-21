using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormLibrary : Form
    {
        FormLibraryController fLibraryConroller;

        public FormLibrary()
        {
            InitializeComponent();
        }

        private void FormLibrary_Load(object sender, EventArgs e)
        {
            fLibraryConroller = new FormLibraryController(this);
            fLibraryConroller.SelectReaders();
            fLibraryConroller.SelectBooks();
        }

        private void buttonSelectReaders_Click(object sender, EventArgs e)
        {
            fLibraryConroller.SelectReaders();
        }

        private void buttonInsertReader_Click(object sender, EventArgs e)
        {
            fLibraryConroller.InsertReader();
        }

        private void dataGridViewReaders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fLibraryConroller.FillReaderFields();
        }

        private void buttonUpdateReader_Click(object sender, EventArgs e)
        {
            fLibraryConroller.UpdateReader();
        }

        private void buttonDeleteReader_Click(object sender, EventArgs e)
        {
            fLibraryConroller.DeleteReader();
        }

        private void buttonSelectBooks_Click(object sender, EventArgs e)
        {
            fLibraryConroller.SelectBooks();
        }

        private void buttonInsertBook_Click(object sender, EventArgs e)
        {
            fLibraryConroller.InsertBook();
        }

        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            fLibraryConroller.UpdateBook();
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            fLibraryConroller.DeleteBook();
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fLibraryConroller.FillBooksFields();
        }
    }
}
