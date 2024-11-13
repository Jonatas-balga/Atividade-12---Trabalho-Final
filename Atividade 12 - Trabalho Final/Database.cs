using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_12___Trabalho_Final
{
    internal class Database
    {
        private MySqlConnection connection;
        
        public Database() {

            string connectionString = "server=localhost;database=Crud;user=root;password=1234;";

            connection = new MySqlConnection(connectionString);

        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
