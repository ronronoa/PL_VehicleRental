using PL_VehicleRental.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using VehicleManagementSystem.Dto;
using System.Security.Cryptography;
using Org.BouncyCastle.Bcpg;

namespace PL_VehicleRental.DAL.Repositories
{
    public class userRepository
    {
        public static class PasswordHelper
        {
            private const string DefaultPassword = "userpass";

            public static string HashPassword(string password)
                => BCrypt.Net.BCrypt.HashPassword(password);

            public static string GetDefaultPasswordHash()
                => BCrypt.Net.BCrypt.HashPassword(DefaultPassword);

            public static bool Verify(string inputPassword, string storedHash)
                => BCrypt.Net.BCrypt.Verify(inputPassword, storedHash);
        }

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

                const string sql = @"INSERT INTO users (userName, fullName, email, address, role, status, passwordHash, isDefaultPassword)
                                     VALUES (@userName, @fullName, @email, @address, @role, @status, @passwordHash, 1)";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", dto.UserName);
                    cmd.Parameters.AddWithValue("@fullName", dto.FullName);
                    cmd.Parameters.AddWithValue("@email", dto.Email);
                    cmd.Parameters.AddWithValue("@address", dto.Address);
                    cmd.Parameters.AddWithValue("@role", dto.Role);
                    cmd.Parameters.AddWithValue("@status", dto.Status);
                    cmd.Parameters.AddWithValue("@passwordHash", PasswordHelper.GetDefaultPasswordHash());

                    return await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
        }

        public async Task<UserInfoDto> ValidateLoginAsync(string usernameOrEmail, string password)
        {
            using (var conn = MySQLConnectionContext.Create())
            {
                await conn.OpenAsync();

                const string sql = @"SELECT userName, fullName, email, address, role, status, passwordHash, isDefaultPassword
                                     FROM users WHERE (userName = @input OR email = @input) AND status = 'Active'";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@input", usernameOrEmail);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (!await reader.ReadAsync()) return null;

                        var storedHash = reader.GetString("passwordHash");
                        if (!PasswordHelper.Verify(password, storedHash)) return null;

                        return new UserInfoDto
                        {
                            UserName = reader.GetString("userName"),
                            FullName = reader.GetString("fullName"),
                            Email = reader.GetString("email"),
                            Address = reader.GetString("address"),
                            Role = reader.GetString("role"),
                            Status = reader.GetString("status"),
                            isDefaultPassword = reader.GetBoolean("isDefaultPassword")
                        };
                    }
                }
                    
            }
        }

        public async Task<bool> ChangePasswordAsync(string username, string newPassword)
        {
            using (var conn = MySQLConnectionContext.Create())
            {
                await conn.OpenAsync();

                const string sql = @"UPDATE users SET passwordHash = @hash, isDefaultPassword = 0 
                                     WHERE userName = @userName";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@hash", PasswordHelper.HashPassword(newPassword));
                    cmd.Parameters.AddWithValue("@userName", username);

                    return await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
        }

        public async Task<(List<UserInfoDto> Users, int TotalCount)> GetPagedUsersAsync(string search, int pageNumber, int pageSize)
        {
            var users = new List<UserInfoDto>();
            int totalCount = 0;

            using (MySqlConnection conn = MySQLConnectionContext.Create())
            {
                await conn.OpenAsync();

                string searchParam = $"%{search}%";

                string countQuery = @"
                                    SELECT COUNT(*) 
                                    FROM users WHERE userName LIKE @Search
                                      OR fullName LIKE @Search
                                      OR email LIKE @Search
                                      OR address LIKE @Search";

                using (var countCmd = new MySqlCommand(countQuery, conn))
                {
                    countCmd.Parameters.AddWithValue("@Search", searchParam);
                    totalCount = Convert.ToInt32(await countCmd.ExecuteScalarAsync());
                }

                string dataQuery = @"
                SELECT id, userName, fullName, email, address, role, status 
                FROM users 
                WHERE userName LIKE @Search
                   OR fullName LIKE @Search
                   OR email LIKE @Search
                   OR address LIKE @Search
                ORDER BY created_at DESC LIMIT @PageSize OFFSET @Offset";

                using (var cmd = new MySqlCommand(dataQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Search", searchParam);
                    cmd.Parameters.AddWithValue("PageSize", pageSize);
                    cmd.Parameters.AddWithValue("Offset", (pageNumber - 1) * pageSize);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            users.Add(new UserInfoDto
                            {
                                Id = reader.GetInt32("id"),
                                UserName = reader.GetString("userName"),
                                FullName = reader.GetString("fullName"),
                                Email = reader.GetString("email"),
                                Address = reader.GetString("address"),
                                Role = reader.GetString("role"),
                                Status = reader.GetString("status")
                            });
                        }
                    }
                }
            }

            return (users, totalCount);
        }
    }
}
