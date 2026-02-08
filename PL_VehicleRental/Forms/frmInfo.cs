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
    public partial class frmInfo : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        private readonly int _userId;

        public frmInfo(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadUserInfo()
        {
            string query = @"SELECT id, userName, fullName, address, role, status FROM users WHERE id = @id";

            using (var conn = new MySqlConnection(connString))
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", _userId);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show("User not found.");
                        Close();
                        return;
                    }

                    txtUserName.Text = reader["userName"].ToString();
                    txtFullName.Text = reader["fullName"].ToString();
                    txtAddress.Text = reader["address"].ToString();
                }
            }
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
            txtUserName.ReadOnly = true;
        }
    }
}
