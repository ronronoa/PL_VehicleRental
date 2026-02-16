using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using PL_VehicleRental.Data;
using PL_VehicleRental.Services;
using PL_VehicleRental.Validation;
using VehicleManagementSystem.Dto;

namespace PL_VehicleRental.Forms
{
    public partial class frmAddUser : Form
    {
        public event EventHandler UserAdded;
        private Validator _validator;
        private UserService _userService;
        private CancellationTokenSource _usernameCts;
        private bool _isUsernameAvailable = false;
        private bool _isSubmitting = false;
        public frmAddUser()
        {
            InitializeComponent();
            _validator = new Validator(errorProvider1);
            _userService = new UserService();
            userNameTextBox.TextChanged += userNameTextBox_TextChanged;
        }

        private async Task AddUsersAsync()
        {
            

            string sql = "INSERT INTO users (userName, fullName, email, address, role, status) VALUES (@userName, @fullName, @email, @address, @role, @status)";

            using (MySqlConnection conn = MySQLConnectionContext.Create())
            {
                try
                {
                   await conn.OpenAsync();

                    string checkQuery = @"
                                        SELECT COUNT(*) 
                                        FROM users 
                                        WHERE userName = @userName 
                                        OR (fullName = @fullName AND userName = @userName AND email = @email)";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@userName", userNameTextBox.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@fullName", fullNameTxt.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@email", fullNameTxt.Text.Trim());

                    int exists = Convert.ToInt32(await checkCmd.ExecuteScalarAsync());

                    if (exists > 0)
                    {
                        MessageBox.Show(
                            "Username or full name already exists.",
                            "Duplicate Entry",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@userName", userNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@fullName", fullNameTxt.Text);
                    cmd.Parameters.AddWithValue("@email", emaiTxt.Text);
                    cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                    cmd.Parameters.AddWithValue("@role", roleCmb.Text);
                    cmd.Parameters.AddWithValue("@status", statusCmb.Text);

                    int result = await cmd.ExecuteNonQueryAsync();

                    if (result > 0)
                    {
                        MessageBox.Show("User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userNameTextBox.Clear();
                        fullNameTxt.Clear();
                        addressTextBox.Clear();
                        roleCmb.StartIndex = 0;
                        statusCmb.StartIndex = 0;

                        ClearFields();
                        OnUserAdded();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add user.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:", ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            fullNameTxt.Clear();
            userNameTextBox.Clear();
            addressTextBox.Clear();
            roleCmb.StartIndex = 0;
            statusCmb.StartIndex = 0;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void addBtn_Click_1(object sender, EventArgs e)
        {
            if (_isSubmitting) return;

            _isSubmitting = true;
            addBtn.Enabled = false;

           try
            {
                _validator.Clear();

                _validator.Required(userNameTextBox, "Username is required");
                _validator.Required(fullNameTxt, "Full name is required");
                _validator.Required(addressTextBox, "Address is required");
                _validator.IsEmail(emaiTxt, "Invalid email format");

                if (!_validator.Validate() || !_isUsernameAvailable) return;

                var dto = new UserInfoDto
                {
                    UserName = userNameTextBox.Text.Trim(),
                    FullName = fullNameTxt.Text.Trim(),
                    Email = emaiTxt.Text.Trim(),
                    Address = addressTextBox.Text.Trim(),
                    Role = roleCmb.Text,
                    Status = statusCmb.Text
                };

                var result = await _userService.CreateUserAsync(dto);

                if (!result.Success)
                {
                    MessageBox.Show(result.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show(result.Message, "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                OnUserAdded();
                Close();
            } finally
            {
                _isSubmitting = false;
                UpdateAddButtonState();
            }
        }

        protected virtual void OnUserAdded()
        {
            UserAdded?.Invoke(this, EventArgs.Empty);
        }
        protected override CreateParams CreateParams
        {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            fullNameTxt.Clear();
            userNameTextBox.Clear();
            addressTextBox.Clear();
            roleCmb.StartIndex = 0;
            statusCmb.StartIndex = 0;
        }

        private void UpdateAddButtonState()
        {
            bool basicValid =
                !string.IsNullOrWhiteSpace(userNameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(fullNameTxt.Text) &&
                !string.IsNullOrWhiteSpace(emaiTxt.Text) &&
                !string.IsNullOrWhiteSpace(addressTextBox.Text) &&
                roleCmb.SelectedIndex != -1 &&
                statusCmb.SelectedIndex != -1;

            addBtn.Enabled = basicValid && _isUsernameAvailable;
        }

        private async void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _usernameCts?.Cancel();
            _usernameCts = new CancellationTokenSource();
            var token = _usernameCts.Token;

            string username = userNameTextBox.Text.Trim();

            if(string.IsNullOrWhiteSpace(username))
            {
                errorProvider1.SetError(userNameTextBox, "Username is required");
                _isUsernameAvailable = false;
                return;
            }

            try
            {
                await Task.Delay(500, token);

                bool exists = await _userService.UsernameExistsAsync(username);

                if(exists)
                {
                    errorProvider1.SetError(userNameTextBox, "Username already taken.");
                    _isUsernameAvailable = false;
                } else
                {
                    errorProvider1.SetError(userNameTextBox, "");
                   _isUsernameAvailable = true;
                }

            } catch (TaskCanceledException)
            {
                return;
            }

            UpdateAddButtonState();
        }

        private void fullNameTxt_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }

        private void emaiTxt_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }

        private void roleCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }

        private void statusCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAddButtonState();
        }
    }
}