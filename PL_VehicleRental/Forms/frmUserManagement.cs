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
using MySqlConnector;
using PL_VehicleRental.Classes;
using PL_VehicleRental.Data;
using PL_VehicleRental.UI.Layout;
using PL_VehicleRental.UserControl;
using VehicleManagementSystem.Dto;

namespace PL_VehicleRental.Forms
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
            flowUsers.Resize += flowUsers_Resize;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void UserManagementForm_Load(object sender, EventArgs e)
        {
            TableHeader();
            FixHeaderScrollbarAlignment();
            await RefreshUserDataAsync();

        }
        private async void UserManagementForm_Shown(object sender, EventArgs e)
        {
            
        }

        public async Task RefreshUserDataAsync()
        {
            flowUsers.Controls.Clear();

            var users = await GetUserAsync();

            foreach (var user in users)
            {
                var item = new ucItemControl(user);

                flowUsers.Controls.Add(item);
                item.Width = flowUsers.ClientSize.Width;

                flowUsers.WrapContents = false;
                flowUsers.FlowDirection = FlowDirection.TopDown;
                flowUsers.AutoScroll = true;
                flowUsers.Padding = Padding.Empty;
                flowUsers.Margin = Padding.Empty;
            }
        }

        private async Task<List<UserInfoDto>> GetUserAsync()
        {
            const string query = @"
                                   SELECT id,
                                   userName,
                                   fullName,
                                   address,
                                   role,
                                   status
                                   FROM users";
            var users = new List<UserInfoDto>();

            using(var conn = MySQLConnectionContext.Create())
                using (var cmd = new MySqlCommand(query, conn))
            {
                await conn.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        users.Add(new UserInfoDto
                        {
                            Id = reader.GetInt32("id"),
                            UserName = reader.GetString("userName"),
                            FullName = reader.GetString("fullName"),
                            Address = reader.GetString("address"),
                            Role = reader.GetString("role"),
                            Status = reader.GetString("status"),
                        });

                    }
                }
            }

            return users;
        }

        private void TableHeader()
        {
            TableHeaderPanel.SuspendLayout();
            TableHeaderPanel.Controls.Clear();

            TableHeaderPanel.Height = 45;
            TableHeaderPanel.Dock = DockStyle.Top;
            TableHeaderPanel.BackColor = Color.White;

            TableLayoutPanel headerLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 6,
                RowCount = 1
            };

            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.IdWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.UsernameWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.FullnameWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.RoleWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.StatusWidth));

            Label CreateHeader(string text)
            {
                return new Label
                {
                    Text = text,
                    Dock = DockStyle.Fill,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(90, 90, 90),
                    Padding = new Padding(10, 0, 0, 0)
                };
            }

            headerLayout.Controls.Add(CreateHeader("ID"), 0, 0);
            headerLayout.Controls.Add(CreateHeader("USERNAME"), 1, 0);
            headerLayout.Controls.Add(CreateHeader("FULLNAME"), 2, 0);
            headerLayout.Controls.Add(CreateHeader("ADDRESS"), 3, 0);
            headerLayout.Controls.Add(CreateHeader("ROLE"), 4, 0);
            headerLayout.Controls.Add(CreateHeader("STATUS"), 5, 0);

            TableHeaderPanel.Controls.Add(headerLayout);
            TableHeaderPanel.ResumeLayout();
        }

        private void FixHeaderScrollbarAlignment()
        {
            int scrollBarWidth = SystemInformation.VerticalScrollBarWidth;
            TableHeaderPanel.Padding = new Padding(0, 0, scrollBarWidth, 0);
        }


        //private void OpenInfo()
        //{
        //    using (frmInfo frm = new frmInfo(userId))
        //    {
        //        frm.ShowDialog(this);
        //    }
        //}

        private void addBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvRolesPermission_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void CenterGridHeaders()
        {
        }

        private void SetupActionsButtons()
        {
            
        }

        private void dgvRolesPermission_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void dgvRolesPermission_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }
        private void DrawCenteredIcon(Graphics g, Image icon, Rectangle button)
        {
            
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

        private void btnUserForm_Click(object sender, EventArgs e)
        {
            frmAddUser form = new frmAddUser();

            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void OpenAddUserForm()
        {
            using (frmAddUser form = new frmAddUser())
            {
                form.UserAdded += async (sender, e) =>
                {
                    await RefreshUserDataAsync();
                };

                form.FormBorderStyle = FormBorderStyle.None;
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }

        private void btnUserForm_Click_1(object sender, EventArgs e)
        {
            OpenAddUserForm();
        }


        // Double buffer
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void flowUsers_Resize(object sender, EventArgs e)
        {
            foreach (Control c in flowUsers.Controls)
                c.Width = flowUsers.ClientSize.Width;
        }
    }
}
