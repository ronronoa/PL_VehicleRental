using PL_VehicleRental.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using VehicleManagementSystem.Dto;

namespace PL_VehicleRental.DAL.Repositories
{
    public class userRepository
    {
        public async Task<bool> UsernameExistsAsync(string username)
        {
            using (var conn = MySQLConnectionContext.Create())
            {
                await conn.OpenAsync();

                const string query = @"SELECT COUNT(*) FROM users WHERE userName = @userName";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", username);

                   int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    return count > 0;
                }
            }
        }

        public async Task<bool> InsertAsync(UserInfoDto dto)
        {
            using (var conn = MySQLConnectionContext.Create())
            {
                await conn.OpenAsync();
                const string sql = @"INSERT INTO users (userName, fullName, email, address, role, status)
                                     VALUES (@userName, @fullName, @email, @address, @role, @status)";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", dto.UserName);
                    cmd.Parameters.AddWithValue("@fullName", dto.FullName);
                    cmd.Parameters.AddWithValue("@email", dto.Email);
                    cmd.Parameters.AddWithValue("@address", dto.Address);
                    cmd.Parameters.AddWithValue("@role", dto.Role);
                    cmd.Parameters.AddWithValue("@status", dto.Status);

                    return await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
        }
    }
}
