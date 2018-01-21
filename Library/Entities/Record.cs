using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Record
    {
        public long Id { set; get; }
        public int Date { set; get; }
        public long IdBook { set; get; }
        public long IdReader { set; get; }
        public int Action { set; get; }

        public Record(long id, int date, long idBook, long idReader, int action)
        {
            Id = id;
            Date = date;
            IdBook = idBook;
            IdReader = idReader;
            Action = action;
        }
    }
}
