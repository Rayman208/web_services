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
        FormLibraryController formLibraryController;

        public FormLibrary()
        {
            InitializeComponent();
        }

        private void FormLibrary_Load(object sender, EventArgs e)
        {
            formLibraryController = new FormLibraryController(this);
            formLibraryController.SelectReaders();
            formLibraryController.SelectBooks();
            formLibraryController.SelectRecords();
            formLibraryController.SelectReadersForRecords();
            formLibraryController.ShowBooksWithoutReader();
        }

        private void buttonSelectReaders_Click(object sender, EventArgs e)
        {
            formLibraryController.SelectReaders();
        }

        private void buttonInsertReader_Click(object sender, EventArgs e)
        {
            formLibraryController.InsertReader();
        }

        private void dataGridViewReaders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formLibraryController.FillReaderFields();
        }

        private void buttonUpdateReader_Click(object sender, EventArgs e)
        {
            formLibraryController.UpdateReader();
        }

        private void buttonDeleteReader_Click(object sender, EventArgs e)
        {
            formLibraryController.DeleteReader();
        }

        private void buttonSelectBooks_Click(object sender, EventArgs e)
        {
            formLibraryController.SelectBooks();
        }

        private void buttonInsertBook_Click(object sender, EventArgs e)
        {
            formLibraryController.InsertBook();
        }

        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            formLibraryController.UpdateBook();
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            formLibraryController.DeleteBook();
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formLibraryController.FillBooksFields();
        }

        private void dataGridViewRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSelectReadersForRecords_Click(object sender, EventArgs e)
        {
            formLibraryController.SelectReadersForRecords();
        }

        private void dataGridViewReadersForRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formLibraryController.FillReaderBooks();
        }

        private void buttonReturnSelectedBook_Click(object sender, EventArgs e)
        {
            formLibraryController.ReturnSelectedBook();
            formLibraryController.FillReaderBooks();
            formLibraryController.ShowRecords();
            formLibraryController.ShowBooksWithoutReader();
        }

        private void buttonGiveSelectedBook_Click(object sender, EventArgs e)
        {
            formLibraryController.GiveSelectedBook();
            formLibraryController.ShowBooksWithoutReader();
            formLibraryController.FillReaderBooks();
            formLibraryController.ShowRecords();
        }
    }
}
