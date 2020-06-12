using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DierenasielTongelreDAL
{
    public class DatabaseConnection
    {
        public DatabaseConnection(string connectionString)
        {
            SqlConnection = new MySqlConnection(connectionString);
        }
        public MySqlConnection SqlConnection { get; set; }
    }
    
}
