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
        FormLibraryController flc;

        public FormLibrary()
        {
            InitializeComponent();
        }

        private void FormLibrary_Load(object sender, EventArgs e)
        {
            flc = new FormLibraryController(this);
        }

        private void buttonSelectReaders_Click(object sender, EventArgs e)
        {
            flc.SelectReaders();
        }

        private void buttonInsertReader_Click(object sender, EventArgs e)
        {
            flc.InsertReader();
        }

        private void dataGridViewReaders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flc.FillReaderFields();
        }

        private void buttonUpdateReader_Click(object sender, EventArgs e)
        {
            flc.UpdateReader();
        }

        private void buttonDeleteReader_Click(object sender, EventArgs e)
        {
            flc.DeleteReader();
        }
    }
}
