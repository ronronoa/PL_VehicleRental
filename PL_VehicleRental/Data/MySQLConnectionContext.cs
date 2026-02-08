using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_VehicleRental.Data
{
    public static class MySQLConnectionContext
    {

        public static MySqlConnection Create()
        {
            string host = ConfigurationManager.AppSettings["DB_HOST"];
            string port = ConfigurationManager.AppSettings["DB_PORT"];
            string db = ConfigurationManager.AppSettings["DB_NAME"];
            string user = ConfigurationManager.AppSettings["DB_USER"];
            string pass = ConfigurationManager.AppSettings["DB_PASSWORD"];

            string connStr = $"Server={host};Port={port};Database={db};User ID={user};Password={pass};SslMode=Required;";

            return new MySqlConnection(connStr);
        }

    }
}
