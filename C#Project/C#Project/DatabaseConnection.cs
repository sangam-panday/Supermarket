using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project
{
    class DatabaseConnection
    {
        private MySqlConnection connection;
        public DatabaseConnection()
        {
            string connectionString = "Server = 127.0.0.1;Database=marketdb;Uid=root;pwd=qwert!@345;";
            connection = new MySqlConnection(connectionString);

        }
        public MySqlConnection GetConnection()
        {
            return connection; 
        }
    }
}
