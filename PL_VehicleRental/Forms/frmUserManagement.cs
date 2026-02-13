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
            flowUsers.WrapContents = false;
            flowUsers.FlowDirection = FlowDirection.TopDown;
            flowUsers.AutoScroll = true;
            flowUsers.Padding = Padding.Empty;
            flowUsers.Margin = Padding.Empty;

            var users = await GetUserAsync();

            foreach (var user in users)
            {
                var item = new ucItemControl(user);

                flowUsers.Controls.Add(item);
                item.Width = flowUsers.ClientSize.Width;

                item.InfoClicked += (_, __) => OpenInfo(user.Id);
                item.EditClicked += (_, __) => OpenEditForm(user.Id);
                item.DeleteClicked += (_, __) => DeleteUser(user.Id, user.UserName);
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

            using (var conn = MySQLConnectionContext.Create())
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
                        Status = reader.GetString("status")
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
            TableHeaderPanel.Padding = new Padding(0, 5, 0, 5);

            TableLayoutPanel headerLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 7,
                RowCount = 1,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                Margin = Padding.Empty
            };

            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.IdWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.UsernameWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.FullnameWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.RoleWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.StatusWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.ActionWidth));

            Label CreateHeader(string text)
            {
                return new Label
                {
                    Text = text,
                    Dock = DockStyle.Fill,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                    Padding = new Padding(5, 0, 5, 0),
                    Margin = new Padding(0)
                };
            }

            headerLayout.Controls.Add(CreateHeader("ID"), 0, 0);
            headerLayout.Controls.Add(CreateHeader("USERNAME"), 1, 0);
            headerLayout.Controls.Add(CreateHeader("FULLNAME"), 2, 0);
            headerLayout.Controls.Add(CreateHeader("ADDRESS"), 3, 0);
            headerLayout.Controls.Add(CreateHeader("ROLE"), 4, 0);
            headerLayout.Controls.Add(CreateHeader("STATUS"), 5, 0);
            headerLayout.Controls.Add(CreateHeader("ACTION"), 6, 0);

            headerLayout.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, headerLayout.ClientRectangle,
                    Color.Transparent, 0, ButtonBorderStyle.None,
                    Color.Transparent, 0, ButtonBorderStyle.None,
                    Color.Transparent, 0, ButtonBorderStyle.None,
                    Color.FromArgb(230, 230, 230), 1, ButtonBorderStyle.Solid);
            };

            TableHeaderPanel.Controls.Add(headerLayout);
            TableHeaderPanel.ResumeLayout();
        }

        private void FixHeaderScrollbarAlignment()
        {
            int scrollBarWidth = SystemInformation.VerticalScrollBarWidth;
            TableHeaderPanel.Padding = new Padding(0, 0, scrollBarWidth, 0);
        }

        public void OpenInfo(int userId)
        {
            using (frmInfo frm = new frmInfo(userId))
            {
                frm.ShowDialog(this);
            }
        }

        private void OpenEditForm(int userId)
        {
            MessageBox.Show($"Edit user with ID: {userId}", "Edit User",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // using (frmEditUser form = new frmEditUser(userId))
            // {
            //     form.UserUpdated += async (sender, e) =>
            //     {
            //         await RefreshUserDataAsync();
            //     };
            //     form.ShowDialog(this);
            // }
        }

        private async void DeleteUser(int userId, string userName)
        {
            var result = MessageBox.Show($"Are you sure you want to delete user '{userName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // await DeleteUserFromDatabase(userId);

                    MessageBox.Show($"User '{userName}' has been deleted.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await RefreshUserDataAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUserForm_Click(object sender, EventArgs e)
        {
            OpenAddUserForm();
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
            {
                if (c is ucItemControl itemControl)
                {
                    itemControl.Width = flowUsers.ClientSize.Width;
                    itemControl.UpdateWidth(flowUsers.ClientSize.Width);
                }
                else
                {
                    c.Width = flowUsers.ClientSize.Width;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}