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
using System.Windows.Forms.VisualStyles;
using Guna.UI2.WinForms;

namespace PL_VehicleRental.Forms
{
    public partial class UserManagementForm : Form
    {
        //string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        public UserManagementForm()
        {
            InitializeComponent();

            dgvRolesPermission.CellPainting -= dgvRolesPermission_CellPainting;
            dgvRolesPermission.CellPainting += dgvRolesPermission_CellPainting;
            dgvRolesPermission.CellClick -= dgvRolesPermission_CellClick;
            dgvRolesPermission.CellClick += dgvRolesPermission_CellClick;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadUsersData();
            SetupActionsButtons();
            CenterGridHeaders();
            //addBtn.BackColor = UITheme.PrimaryColor;
            statCard.Dock = DockStyle.Top;
            statCard.Height = 120;
            this.DoubleBuffered = true;

            //DataGridViewStyle.ApplyStandard(dgvRolesPermission);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            fullNameTxt.Clear();
            userNameTextBox.Clear();
            addressTextBox.Clear();
            roleCmb.StartIndex = 0;
            statusCmb.StartIndex = 0;
        }

        private void LoadUsersData()
        {
            //string query = @"
            //                 SELECT
            //                    COUNT(*) AS Total,
            //                    SUM(CASE WHEN status ='Active' THEN 1 ELSE 0 END) AS Active,
            //                    SUM(CASE WHEN status ='Inactive' THEN 1 ELSE 0 END) AS Inactive
            //                 FROM users";

            //using (MySqlConnection conn = new MySqlConnection(connString))
            //{
            //    conn.Open();
            //    MySqlCommand cmd = new MySqlCommand(query, conn);
            //    using (MySqlDataReader reader = cmd.ExecuteReader())
            //    {
            //        if (reader.Read())
            //        {
            //            lblTotalUsers.Text = reader["Total"].ToString();
            //            lblActiveUsers.Text = reader["Active"].ToString();
            //            lblInactiveUsers.Text = reader["Inactive"].ToString();
            //        }
            //    }
            //}
        }

        private void LoadUsers()
        {
            //DataTable dt = new DataTable();

            //using (MySqlConnection conn = new MySqlConnection(connString))
            //{
            //    conn.Open();

            //    string query = @"SELECT id AS ID, 
            //                            userName AS Username, 
            //                            fullName AS FullName,
            //                            address AS Address,
            //                            role As Role, 
            //                            status AS Status
            //                    FROM users";
            //    using (MySqlCommand cmd = new MySqlCommand(query, conn))
            //    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            //    {
            //        da.Fill(dt);
            //    }
            //}
            //dgvRolesPermission.DataSource = dt;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //string sql = "INSERT INTO users (userName, fullName, address, role, status) VALUES (@userName, @fullName, @address, @role, @status)";

            //using (MySqlConnection conn = new MySqlConnection(connString))
            //{
            //    try
            //    {
            //        conn.Open();

            //        string checkQuery = @"
            //                            SELECT COUNT(*) 
            //                            FROM users 
            //                            WHERE userName = @userName 
            //                            OR (fullName = @fullName AND userName = @userName)";

            //        MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
            //        checkCmd.Parameters.AddWithValue("@userName", userNameTextBox.Text.Trim());
            //        checkCmd.Parameters.AddWithValue("@fullName", fullNameTxt.Text.Trim());

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

            //        if (string.IsNullOrEmpty(fullNameTxt.Text) || string.IsNullOrEmpty(userNameTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text))
            //        {
            //            MessageBox.Show("All fields are required.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }

            //        MySqlCommand cmd = new MySqlCommand(sql, conn);
            //        cmd.Parameters.AddWithValue("@userName", userNameTextBox.Text);
            //        cmd.Parameters.AddWithValue("@fullName", fullNameTxt.Text);
            //        cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
            //        cmd.Parameters.AddWithValue("@role", roleCmb.Text);
            //        cmd.Parameters.AddWithValue("@status", statusCmb.Text);

            //        int result = cmd.ExecuteNonQuery();

            //        if (result > 0)
            //        {
            //            MessageBox.Show("User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            LoadUsers();
            //            LoadUsersData();
            //            userNameTextBox.Clear();
            //            fullNameTxt.Clear();
            //            addressTextBox.Clear();
            //            roleCmb.StartIndex = 0;
            //            statusCmb.StartIndex = 0;
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

        private void dgvRolesPermission_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRolesPermission.Columns[e.ColumnIndex].Name != "Status")
                return;

            if (e.Value == null)
                return;

            string status = e.Value.ToString();

            switch (status)
            {
                case "Active":
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font(dgvRolesPermission.Font, FontStyle.Bold);
                    break;

                case "Inactive":
                    e.CellStyle.ForeColor = Color.Red;
                    break;

                case "Suspended":
                    e.CellStyle.ForeColor = Color.DarkOrange;
                    break;
            }
        }

        private void CenterGridHeaders()
        {
            dgvRolesPermission.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvRolesPermission.EnableHeadersVisualStyles = false;
        }

        private void SetupActionsButtons()
        {
            if (dgvRolesPermission.Columns["Actions"] == null)
            {
                DataGridViewTextBoxColumn actionsCol = new DataGridViewTextBoxColumn();
                actionsCol.Name = "Actions";
                actionsCol.HeaderText = "Actions";
                actionsCol.ReadOnly = true;
                actionsCol.Width = 150;
                actionsCol.SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvRolesPermission.Columns.Add(actionsCol);
            }
        }

        private void dgvRolesPermission_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvRolesPermission.Columns[e.ColumnIndex].Name == "Actions")
            {
                var cell = dgvRolesPermission.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                int padding = 5;
                int buttonWidth = (cell.Width - 3 * padding) / 2;

                Point clickPoint = dgvRolesPermission.PointToClient(Cursor.Position);
                int relativeX = clickPoint.X - cell.Left;

                if (relativeX <= buttonWidth)
                {
                    MessageBox.Show($"Edit clicked for row {e.RowIndex}");
                }
                else
                {
                    MessageBox.Show($"Delete clicked for row {e.RowIndex}");
                }
            }
        }


        // for edit, delete button on datagrid
        private void dgvRolesPermission_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvRolesPermission.Columns[e.ColumnIndex].Name == "Actions")
            {
                e.PaintBackground(e.ClipBounds, true);

                int padding = 5;
                int buttonWidth = (e.CellBounds.Width - 3 * padding) / 2;
                int buttonHeight = e.CellBounds.Height - 2 * padding;

                // editIcon, deleteIcon as button
                Rectangle editButton = new Rectangle(e.CellBounds.Left + padding, e.CellBounds.Top + padding, buttonWidth, buttonHeight);
                Rectangle deleteButton = new Rectangle(e.CellBounds.Left + buttonWidth + 2 * padding, e.CellBounds.Top + padding, buttonWidth, buttonHeight);

                Color editColor = Color.FromArgb(94, 148, 255);
                Color deleteColor = Color.FromArgb(255, 77, 79);

                using (SolidBrush editBrush = new SolidBrush(editColor))
                    e.Graphics.FillRectangle(editBrush, editButton);

                using (SolidBrush deleteBrush = new SolidBrush(deleteColor))
                    e.Graphics.FillRectangle(deleteBrush, deleteButton);

                // icons
                //Image editIcon = Properties.Resources.editIcon;
                //int ex = editButton.Left + (editButton.Width - editIcon.Width) / 2;
                //int ey = editButton.Top + (editButton.Height - editIcon.Height) / 2;
                //e.Graphics.DrawImage(editIcon, new Rectangle(ex, ey, editIcon.Width, editIcon.Height));

                //Image deleteIcon = Properties.Resources.deleteIcon;
                //int dx = deleteButton.Left + (deleteButton.Width - deleteIcon.Width) / 2;
                //int dy = deleteButton.Top + (deleteButton.Height - deleteIcon.Height) / 2;
                //e.Graphics.DrawImage(deleteIcon, new Rectangle(dx, dy, deleteIcon.Width, deleteIcon.Height));

                e.Handled = true;
            }
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

        private void dgvRolesPermission_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRolesPermission_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
