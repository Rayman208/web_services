using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Library
{
    class ReadersAdapter
    {
        private List<Reader> readers;
        private MySqlConnection connection;
        private MySqlCommand command;

        public ReadersAdapter(List<Reader> r, MySqlConnection c)
        {
            readers = r;
            connection = c;

            command = new MySqlCommand();
            command.Connection = c;
        }

        public bool SelectAll()
        {
            try
            {
                command.CommandText = "SELECT * FROM readers";
                MySqlDataReader sqlReader = command.ExecuteReader();

                List<Reader> tempReaders = new List<Reader>();

                while (sqlReader.Read())
                {
                    tempReaders.Add(new Reader(
                        sqlReader.GetInt64("id"),
                        sqlReader.GetString("name"),
                        sqlReader.GetString("description")
                        ));
                }
                sqlReader.Close();

                readers.Clear();
                readers.AddRange(tempReaders);

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
                command.CommandText = String.Format("DELETE FROM readers WHERE id={0}",id);
                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    readers.RemoveAll(r => r.Id == id);
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

        public bool UpdateById(Reader reader)
        {
            try
            {
                command.CommandText = String.Format("UPDATE readers SET name='{0}', description='{1}' WHERE id={2}", reader.Name, reader.Description, reader.Id);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    int index = readers.FindIndex(r => r.Id == reader.Id);
                    readers[index].Name = reader.Name;
                    readers[index].Description = reader.Description;
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

        public bool Insert(Reader reader)
        {
            try
            {
                command.CommandText = String.Format("INSERT INTO readers(name,description) VALUE('{0}','{1}')", reader.Name, reader.Description);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    reader.Id = command.LastInsertedId;
                    readers.Add(reader);
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

