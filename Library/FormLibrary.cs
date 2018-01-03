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
    }
}
