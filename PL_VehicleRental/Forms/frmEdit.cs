using PL_VehicleRental.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Dto;
using MySqlConnector;
using PL_VehicleRental.DAL.Repositories;

namespace PL_VehicleRental.Forms
{
    public partial class frmEdit : Form
    {
        private readonly int _userId;
        private UserStatus _userStatus;
        public event EventHandler UserUpdated;

        private readonly userRepository _repository;
        public enum UserStatus
        {
            Active,
            Inactive,
            Suspended
        }
        public frmEdit(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _repository = new userRepository();
        }

        private void ToggleLoading(bool isLoading)
        {
            progressBar.Visible = isLoading;

            pnlMain.Enabled = !isLoading;
        }

        private async Task LoadUserInfoAsync()
        {
            ToggleLoading(true);
            UserInfoDto user = await GetUserByIdAsync(_userId);

            if (user == null)
            {
                MessageBox.Show("User not found.");
                Close();
                return;
            }

            BindUser(user);
            ToggleLoading(false);
            pnlProgress.Visible = false;
        }

        private async Task<UserInfoDto> GetUserByIdAsync(int userId)
        {
            const string query = @"
                                SELECT id, userName, fullName, address, role, status
                                FROM users
                                WHERE id = @id";

            using (var conn = MySQLConnectionContext.Create())
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", userId);
                await conn.OpenAsync();

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (!await reader.ReadAsync())
                        return null;

                    string dbStatus = reader.GetString("status");
                    _userStatus = ParseStatus(dbStatus);

                    return new UserInfoDto
                    {
                        Id = reader.GetInt32("id"),
                        UserName = reader.GetString("userName"),
                        FullName = reader.GetString("fullName"),
                        Address = reader.GetString("address"),
                        Status = dbStatus,
                        Role = reader.GetString("role")
                    };
                }
            }
        }

        private void BindUser(UserInfoDto user)
        {
            roleCmb.Items.Clear();

            roleCmb.Items.AddRange(new object[]
            {
                "Superadmin",
                "Admin",
                "Staff",
                "Mechanic"
            });

            statusCmb.Items.Clear();

            statusCmb.Items.AddRange(new object[]
            {
                "Active",
                "Inactive",
                "Suspended"
            });

            txtUserName.Text = user.UserName;
            txtFullName.Text = user.FullName;
            txtEmail.Text = user.Email;
            txtAddress.Text = user.Address;
            roleCmb.SelectedItem = user.Role;
            statusCmb.SelectedItem = user.Status;
        }

        private Color GetStatusColor(UserStatus status)
        {
            switch (status)
            {
                case UserStatus.Active:
                    return Color.Green;

                case UserStatus.Inactive:
                    return Color.Goldenrod;

                case UserStatus.Suspended:
                    return Color.Red;

                default:
                    return Color.Black;
            }
        }

        private UserStatus ParseStatus(string dbStatus)
        {
            return Enum.TryParse(dbStatus, true, out UserStatus status) ? status : UserStatus.Inactive;
        }
        
        protected virtual void OnUserUpdated()
        {
            UserUpdated?.Invoke(this, EventArgs.Empty);
        }

        private async void frmEdit_Shown(object sender, EventArgs e)
        {
            await LoadUserInfoAsync();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ToggleLoading(true);
                var user = new UserInfoDto
                {
                    Id = _userId,
                    UserName = txtUserName.Text,
                    FullName = txtFullName.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    Role = roleCmb.SelectedItem.ToString(),
                    Status = statusCmb.SelectedItem.ToString()
                };

                bool success = await _repository.UpdateUserAsync(user);

                if (success)
                {
                    MessageBox.Show(
                        "User updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    OnUserUpdated();
                    Close();
                } else
                {
                    MessageBox.Show("No changes were made.",
                            "Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user:\n" + ex.Message, 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            } finally
            {
                ToggleLoading(false);
            }
        }
    }
}
