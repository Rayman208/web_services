using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Library
{
    class BooksAdapter
    {
        private List<Book> books;
        private MySqlConnection connection;
        private MySqlCommand command;

        public BooksAdapter(List<Book> b, MySqlConnection c)
        {
            books = b;
            connection = c;

            command = new MySqlCommand();
            command.Connection = c;
        }

        public bool SelectAll()
        {
            try
            {
                command.CommandText = "SELECT * FROM books";
                MySqlDataReader sqlReader = command.ExecuteReader();

                List<Book> tempBooks = new List<Book>();

                while (sqlReader.Read())
                {
                    tempBooks.Add(new Book(
                        sqlReader.GetInt64("id"),
                        sqlReader.GetString("name"),
                        sqlReader.GetString("author"),
                        sqlReader.GetInt64("id_reader")
                        ));
                }
                sqlReader.Close();

                books.Clear();
                books.AddRange(tempBooks);

                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool DeleteById(long id)
        {
            try
            {
                command.CommandText = String.Format("DELETE FROM books WHERE id={0}",id);
                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    books.RemoveAll(r => r.Id == id);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateBookSettingsById(Book book)
        {
            try
            {
                command.CommandText = String.Format("UPDATE books SET name='{0}', author='{1}' WHERE id={2}", book.Name, book.Author, book.Id);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    int index = books.FindIndex(r => r.Id == book.Id);
                    books[index] = book;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Insert(Book book)
        {
            try
            {
                command.CommandText = String.Format("INSERT INTO books(name,author,id_reader) VALUE('{0}','{1}',{2})", book.Name, book.Author, book.IdReader);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    book.Id = command.LastInsertedId;
                    books.Add(book);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}

