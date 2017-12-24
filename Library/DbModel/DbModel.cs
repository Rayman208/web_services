﻿using System;
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

        public List<Reader> readers { private set; get; }

        public DbModel()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            readers = new List<Reader>();

            readersAdapter = new ReadersAdapter(readers, connection);
        }
    }
}