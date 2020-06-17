using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using DierenasielTongelreDAL.DTO;

namespace DierenasielTongelreDAL.Queries
{
    public class AccountQueries
    {
        public string ConnectionString { get; set; }

        public AccountQueries(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<AccountDTO> GetAllAccounts()
        {//query precies opvragen wat je precies nodig hebt
            string query = "Select * FROM account;";
            List<AccountDTO> accounts = new List<AccountDTO>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    accounts.Add(new AccountDTO()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        MiddleName = reader.GetString(2),
                        LastName = reader.GetString(3),
                        Username = reader.GetString(4),
                        Password = reader.GetString(5),
                        Sex = reader.GetString(6),
                        Age = reader.GetDateTime(7),
                        Role = reader.GetString(8)

                    });
                }
            }

            return accounts;
        }
    }

}
