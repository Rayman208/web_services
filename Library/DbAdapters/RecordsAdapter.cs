using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Library
{
    class RecordsAdapter
    {
        private List<Record> records;
        private MySqlConnection connection;
        private MySqlCommand command;

        public RecordsAdapter(List<Record> r, MySqlConnection c)
        {
            records = r;
            connection = c;

            command = new MySqlCommand();
            command.Connection = c;
        }

        public bool SelectAll()
        {
            try
            {
                command.CommandText = "SELECT * FROM records";
                MySqlDataReader sqlReader = command.ExecuteReader();

                List<Record> tempRecords = new List<Record>();

                while (sqlReader.Read())
                {
                    tempRecords.Add(new Record(
                        sqlReader.GetInt64("id"),
                        sqlReader.GetInt32("date"),
                        sqlReader.GetInt64("id_book"),
                        sqlReader.GetInt64("id_reader"),
                        sqlReader.GetInt32("action")
                        ));
                }
                sqlReader.Close();

                records.Clear();
                records.AddRange(tempRecords);

                return true;
            }
            catch
            {
                return false;
            }
        }
                
        public bool Insert(Record record)
        {
            try
            {
                command.CommandText = String.Format("INSERT INTO records(date,id_book,id_reader,action) VALUE(UNIX_TIMESTAMP(NOW()),{0},{1},{2})", record.IdBook, record.IdReader, record.Action);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    record.Id = command.LastInsertedId;

                    command.CommandText = String.Format("SELECT * FROM records WHERE id={0}", command.LastInsertedId);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()==true)
                    {
                        record.Date = reader.GetInt32("date");
                    }
                    reader.Close();

                    records.Add(record);
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

