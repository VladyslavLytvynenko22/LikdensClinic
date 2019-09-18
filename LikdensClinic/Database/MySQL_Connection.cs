using MySql.Data.MySqlClient;
using System;

namespace LikdensClinic.Database
{
    class MySQL_Connection
    {
        public static MySqlConnection GetDBConnection(string host, int port, String database, String username, String password)
        {
            String connString = $"Server={host};Database={database};port={port};User Id={username};password={password};";
            MySqlConnection connection = new MySqlConnection(connString);

            return connection;
        }
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string sid = "Likdens_db";
            string user = "vlyt";
            string password = "1Q2w3e4r5t6y";

            return GetDBConnection(host, port, sid, user, password);
        }
    }
}
