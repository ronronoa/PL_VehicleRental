using MySql.Data.MySqlClient;
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

namespace PL_VehicleRental.Forms
{
    public partial class frmAddUser : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO users (userName, fullName, address, role, status) VALUES (@userName, @fullName, @address, @role, @status)";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string checkQuery = @"
                                        SELECT COUNT(*) 
                                        FROM users 
                                        WHERE userName = @userName 
                                        OR (fullName = @fullName AND userName = @userName)";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@userName", userNameTextBox.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@fullName", fullNameTxt.Text.Trim());

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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            fullNameTxt.Clear();
            userNameTextBox.Clear();
            addressTextBox.Clear();
            roleCmb.StartIndex = 0;
            statusCmb.StartIndex = 0;
        }
    }
}
