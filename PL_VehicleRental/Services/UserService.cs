using MySql.Data.MySqlClient;
using PL_VehicleRental.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Dto;

namespace PL_VehicleRental.Services
{
    public class UserService
    {
        private readonly userRepository _repository;

        public UserService()
        {
            _repository = new userRepository();
        }

        public async Task<(bool Success, string Message)> CreateUserAsync(UserInfoDto dto)
        {
            if (await _repository.UsernameExistsAsync(dto.UserName))
                return (false, "Username already exists.");

            bool inserted = await _repository.InsertAsync(dto);

            if (!inserted)
                return (false, "Failed to insert user.");

            return (true, "User created successfully.");
        }

        public async Task<bool> UsernameExistsAsync(string username)
        {
            return await _repository.UsernameExistsAsync(username);
        }
    }
}
