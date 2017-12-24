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

                readers.Clear();
                while (sqlReader.Read())
                {
                    readers.Add(new Reader(
                        sqlReader.GetInt64("id"),
                        sqlReader.GetString("name"),
                        sqlReader.GetString("description")
                        ));
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
