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

                using (var changePassForm = new frmChangePassword(user.UserName))
                {
                    changePassForm.ShowDialog();
                }

                usernameTxt.Clear();
                passwordTxt.Clear();
                usernameTxt.Focus();

                MessageBox.Show(
                    "Password changed successfully. Please log in again using your new password.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
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
