using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace FuelTrack.Database
{
    internal class Database
    {
        private string connectionString = "server=localhost;database=fueltrack_db;uid=root;pwd=;";
        public MySqlConnection GetConnection() 
        {
            return new MySqlConnection(connectionString);
        }
    }
}
