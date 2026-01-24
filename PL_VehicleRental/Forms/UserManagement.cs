using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace PL_VehicleRental.Forms
{
    public partial class UserManagementForm : Form
    {
         
        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {

            //addBtn.BackColor = UITheme.PrimaryColor;
            statCard.Dock = DockStyle.Top;
            statCard.Height = 120;
            this.DoubleBuffered = true;

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            addressTextBox.Clear();
            roleCmb.StartIndex = 0;
            statusCmb.StartIndex = 0;
        }

        private void addUser()
        {
           
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //string sql = "INSERT INTO registeredUser (firstName, lastName, address, role, status) VALUES (@firstName, @lastName, @address, @role, @status)";

            //using (MySqlConnection conn = new MySqlConnection(connString))
            //{
            //    try
            //    {
            //        conn.Open();

            //        string checkQuery = @"
            //                            SELECT COUNT(*) 
            //                            FROM registeredUser 
            //                            WHERE firstName = @firstName 
            //                            OR (firstName = @firstName AND lastName = @lastName)";

            //        MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
            //        checkCmd.Parameters.AddWithValue("@firstName", firstNameTextBox.Text.Trim());
            //        checkCmd.Parameters.AddWithValue("@lastName", lastNameTextBox.Text.Trim());

            //        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

            //        if (exists > 0)
            //        {
            //            MessageBox.Show(
            //                "Username or full name already exists.",
            //                "Duplicate Entry",
            //                MessageBoxButtons.OK,
            //                MessageBoxIcon.Warning
            //            );
            //            return;
            //        }

            //        MySqlCommand cmd = new MySqlCommand(sql, conn);
            //        cmd.Parameters.AddWithValue("@firstName", firstNameTextBox.Text);
            //        cmd.Parameters.AddWithValue("@lastName", lastNameTextBox.Text);
            //        cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
            //        cmd.Parameters.AddWithValue("@role", roleCmb.Text);
            //        cmd.Parameters.AddWithValue("@status", statusCmb.Text);

            //        int result = cmd.ExecuteNonQuery();

            //        if (result > 0)
            //        {
            //            MessageBox.Show("User Added Successfully");
            //            //firstNameTextBox.Clear();
            //            //lastNameTextBox.Clear();
            //            //addressTextBox.Clear();
            //            //roleCmb.StartIndex = 0;
            //            //statusCmb.StartIndex = 0;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Failed to add user.");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error:", ex.Message);
            //    }
            //}
        }


        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void roleLabel_Click(object sender, EventArgs e)
        {

        }

        private void roleCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void statusCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void userManagementTab_Click(object sender, EventArgs e)
        {

        }

        private void totalUserData_Click(object sender, EventArgs e)
        {

        }

        private void totalUserLabel_Click(object sender, EventArgs e)
        {

        }

        private void activeUserData_Click(object sender, EventArgs e)
        {

        }

        private void activeUserData_Click_1(object sender, EventArgs e)
        {

        }

        private void activeUserLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
