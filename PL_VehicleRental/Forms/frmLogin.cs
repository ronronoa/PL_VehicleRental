using PL_VehicleRental.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_VehicleRental.Forms
{
    public partial class frmLogin : Form
    {
        private readonly userRepository _repository;
        public frmLogin()
        {
            InitializeComponent();
            _repository = new userRepository();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = usernameTxt.Text.Trim();
            var password = passwordTxt.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.", "Validation", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = await _repository.ValidateLoginAsync(username, password);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if(user.isDefaultPassword)
            {
                MessageBox.Show("You are using a default password. Please change it before continuing.",
                                "Security Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var changePassForm = new frmChangePassword(user.UserName);
                changePassForm.ShowDialog();

                var updatedUser = await _repository.ValidateLoginAsync(username, passwordTxt.Text);
                if(updatedUser == null || updatedUser.isDefaultPassword)
                {
                    MessageBox.Show("Password was not changed. Please try again.", "Cancelled",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                user = updatedUser;
            }

            var mainForm = new UserManagementForm();
            mainForm.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
