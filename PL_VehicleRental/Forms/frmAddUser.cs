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
using PL_VehicleRental.Validation;

namespace PL_VehicleRental.Forms
{
    public partial class frmAddUser : Form
    {
        public event EventHandler UserAdded;
        private Validator _validator;
        private CancellationTokenSource _usernameCts;
        private bool _isUsernameAvailable = false;
        private bool _isSubmitting = false;
        public frmAddUser()
        {
            InitializeComponent();
            _validator = new Validator(errorProvider1);
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
            await AddUsersAsync();
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

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _usernameCts?.Cancel();
            _usernameCts = new CancellationTokenSource();
            var token = _usernameCts.Token;

            string username = userNameTextBox.Text.Trim();

            if(string.IsNullOrWhiteSpace(username))
            {
                errorProvider1.SetError(userNameTextBox, "Username is required");
            }
        }
    }
}