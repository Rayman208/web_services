using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Library
{
    class DbModel
    {
        private string connectionString = "server=localhost;user=root;database=library;port=3306;password=1234;";
        private MySqlConnection connection;

        private ReadersAdapter readersAdapter;
        private BooksAdapter booksAdapter;
        private RecordsAdapter recordsAdapter;

        public List<Reader> readers { private set; get; }
        public List<Book> books { private set; get; }
        public List<Record> records { private set; get; }

        private static DbModel instance = null;
        public static DbModel GetInstance()
        {
            if (instance == null) { instance = new DbModel(); }
            return instance;
        }
        private DbModel()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            readers = new List<Reader>();
            books = new List<Book>();
            records = new List<Record>();

            readersAdapter = new ReadersAdapter(readers, connection);
            booksAdapter = new BooksAdapter(books, connection);
            recordsAdapter = new RecordsAdapter(records, connection);
        }

        #region READERS
        public bool Readers_SelectAll()
        {
            return readersAdapter.SelectAll();
        }

        public bool Readers_Insert(Reader reader)
        {
            return readersAdapter.Insert(reader);
        }

        public bool Readers_Delete(long id)
        {
            return readersAdapter.DeleteById(id);
        }

        public bool Readers_Update(Reader reader)
        {
            return readersAdapter.UpdateById(reader);
        }
        #endregion

        #region BOOKS
        public bool Books_SelectAll()
        {
            return booksAdapter.SelectAll();
        }

        public bool Books_Insert(Book book)
        {
            return booksAdapter.Insert(book);
        }

        public bool Books_Delete(long id)
        {
            return booksAdapter.DeleteById(id);
        }

        public bool Books_UpdateSettings(Book book)
        {
            return booksAdapter.UpdateBookSettingsById(book);
        }

        public bool Books_UpdateReader(Book book)
        {
            return booksAdapter.UpdateIdReaderById(book);
        }
        #endregion

        #region RECORDS
        public bool Records_SelectAll()
        {
            return recordsAdapter.SelectAll();
        }

        public bool Records_Insert(Record record)
        {
            return recordsAdapter.Insert(record);
        }
        #endregion

    }
}
