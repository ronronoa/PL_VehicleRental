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
        private List<UserInfoDto> _allUsers = new List<UserInfoDto>();
        private System.Windows.Forms.Timer _searchTimer;
        public UserManagementForm()
        {
            InitializeComponent();
            InitializeSearchDebounce();
            flowUsers.Resize += flowUsers_Resize;

            pnlOverlay.Dock = DockStyle.Fill;
            pnlOverlay.BackColor = Color.FromArgb(120, Color.White);
            pnlOverlay.Visible = false;

            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Dock = DockStyle.None;
            progressBar.Location = new Point((pnlOverlay.Width - progressBar.Width) / 2,
                                             (pnlOverlay.Height - progressBar.Height) / 2);
            pnlOverlay.Controls.Add(progressBar);
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

        private void ToggleLoading(bool isLoading)
        {
            pnlOverlay.Visible = isLoading;
            if (isLoading) pnlOverlay.BringToFront();
        }

        public async Task RefreshUserDataAsync()
        {
            ToggleLoading(true);
            flowUsers.Controls.Clear();
            ConfigureFlowLayout();
            _allUsers = await GetUserAsync();

            RenderUsers(_allUsers);
            ToggleLoading(false);
        }

        private void RenderUsers(List<UserInfoDto> users)
        {
            flowUsers.Controls.Clear();

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

        private void ConfigureFlowLayout()
        {
            flowUsers.WrapContents = false;
            flowUsers.FlowDirection = FlowDirection.TopDown;
            flowUsers.AutoScroll = true;
            flowUsers.Padding = Padding.Empty;
            flowUsers.Margin = Padding.Empty;
        }

        private async Task<List<UserInfoDto>> GetUserAsync()
        {
            const string query = @"
        SELECT id,
               userName,
               fullName,
               email,
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
                        email = reader.GetString("email"),
                        Address = reader.GetString("address"),
                        Role = reader.GetString("role"),
                        Status = reader.GetString("status")
                        });
                    }
                }
            }

            return users;
        }
        
        private void InitializeSearchDebounce()
        {
            _searchTimer = new System.Windows.Forms.Timer();
            _searchTimer.Interval = 400;
            _searchTimer.Tick += SearchTimer_Tick;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            _searchTimer.Stop();

            string keyword = txtSearch.Text.ToLower();

            var filtered = _allUsers
                .Where(u =>
                    (!string.IsNullOrEmpty(u.UserName) && u.UserName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (!string.IsNullOrEmpty(u.FullName) && u.FullName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (!string.IsNullOrEmpty(u.Address) && u.Address.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (!string.IsNullOrEmpty(u.email) && u.email.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0))
                .ToList();

            RenderUsers(filtered);
        }

        private void TableHeader()
        {
            TableHeaderPanel.SuspendLayout();
            TableHeaderPanel.Controls.Clear();

            TableHeaderPanel.Height = 45;
            TableHeaderPanel.Dock = DockStyle.Top;
            TableHeaderPanel.BackColor = Color.FromArgb(42, 132, 191);
            TableHeaderPanel.Padding = new Padding(0, 10, 0, 10);

            TableLayoutPanel headerLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 8,
                RowCount = 1,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                Margin = Padding.Empty,
            };

            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.IdWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.UsernameWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.FullnameWidth));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.EmailWidth));
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
                    Margin = new Padding(0),
                    ForeColor = Color.White
                };
            }

            headerLayout.Controls.Add(CreateHeader("ID"), 0, 0);
            headerLayout.Controls.Add(CreateHeader("USERNAME"), 1, 0);
            headerLayout.Controls.Add(CreateHeader("FULLNAME"), 2, 0);
            headerLayout.Controls.Add(CreateHeader("EMAIL"), 3, 0);
            headerLayout.Controls.Add(CreateHeader("ADDRESS"), 4, 0);
            headerLayout.Controls.Add(CreateHeader("ROLE"), 5, 0);
            headerLayout.Controls.Add(CreateHeader("STATUS"), 6, 0);
            headerLayout.Controls.Add(CreateHeader("ACTION"), 7, 0);

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

        private void progressBar_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}