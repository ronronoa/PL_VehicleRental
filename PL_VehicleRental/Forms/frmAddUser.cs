using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using PL_VehicleRental.Data;

namespace PL_VehicleRental.Forms
{
    public partial class frmAddUser : Form
    {
        public event EventHandler UserAdded;
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void AddUsers()
        {
            string sql = "INSERT INTO users (userName, fullName, email, address, role, status) VALUES (@userName, @fullName, @email, @address, @role, @status)";

            using (MySqlConnection conn = MySQLConnectionContext.Create())
            {
                try
                {
                    conn.Open();

                    string checkQuery = @"
                                        SELECT COUNT(*) 
                                        FROM users 
                                        WHERE userName = @userName 
                                        OR (fullName = @fullName AND userName = @userName AND email = @email)";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@userName", userNameTextBox.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@fullName", fullNameTxt.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@email", fullNameTxt.Text.Trim());

                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

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

                    if (string.IsNullOrEmpty(fullNameTxt.Text) || string.IsNullOrEmpty(userNameTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text))
                    {
                        MessageBox.Show("All fields are required.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@userName", userNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@fullName", fullNameTxt.Text);
                    cmd.Parameters.AddWithValue("@email", emaiTxt.Text);
                    cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                    cmd.Parameters.AddWithValue("@role", roleCmb.Text);
                    cmd.Parameters.AddWithValue("@status", statusCmb.Text);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userNameTextBox.Clear();
                        fullNameTxt.Clear();
                        addressTextBox.Clear();
                        roleCmb.StartIndex = 0;
                        statusCmb.StartIndex = 0;

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

        private void addBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            fullNameTxt.Clear();
            userNameTextBox.Clear();
            addressTextBox.Clear();
            roleCmb.StartIndex = 0;
            statusCmb.StartIndex = 0;
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            AddUsers();
        }

        protected virtual void OnUserAdded()
        {
            UserAdded?.Invoke(this, EventArgs.Empty);
        }

        // Double buffer
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
    }
}