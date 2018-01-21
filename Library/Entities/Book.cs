using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public string Author { set; get; }
        public long IdReader { set; get; }

        public Book(long id, string name, string author, long idReader)
        {
            Id = id;
            Name = name;
            Author = author;
            IdReader = idReader;
        }
    }
    
}
