using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_VehicleRental.Services
{
    internal class UserService
    {
        private string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public DataTable LoadUsers()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string query = @"SELECT id AS ID, 
                                    userName AS Username, 
                                    fullName AS FullName,
                                    address AS Address,
                                    role As Role, 
                                    status AS Status
                            FROM users";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}
