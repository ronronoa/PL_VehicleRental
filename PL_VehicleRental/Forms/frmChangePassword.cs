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
    public partial class frmChangePassword : Form
    {
        private readonly string _username;
        private readonly userRepository _repository;
        public frmChangePassword(string username)
        {
            InitializeComponent();
            _repository = new userRepository();
            _username = username;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            var newPass = newPassTxt.Text;
            var confirmPass = confirmPassTxt.Text;

            if(newPass.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Passwords do not match.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass == "userpass")
            {
               MessageBox.Show("New password cannot be the default password.", "Validation",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
            }

            var success = await _repository.ChangePasswordAsync(_username, newPass);

            if (success)
            {
                MessageBox.Show("Password changed successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            } else
            {
                MessageBox.Show("Failed to update password.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
