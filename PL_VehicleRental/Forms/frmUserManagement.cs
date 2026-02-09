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
using VehicleManagementSystem.Dto;

namespace PL_VehicleRental.Forms
{
    public partial class UserManagementForm : Form
    {

        enum ActionButton
        {
            Info,
            Edit,
            Delete,
        }

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

        private async void UserManagementForm_Load(object sender, EventArgs e)
        {

            DataGridViewStyle.ApplyStandard(dgvRolesPermission);
            await RefreshUserDataAsync();

        }
        private async void UserManagementForm_Shown(object sender, EventArgs e)
        {
            
        }

        public async Task RefreshUserDataAsync()
        {
            DataTable users = await GetUserAsync();
            dgvRolesPermission.DataSource = users;
            SetupActionsButtons();
            CenterGridHeaders();

        }

        private async Task<DataTable> GetUserAsync()
        {
            const string query = @"
                                   SELECT id AS ID,
                                   userName AS USERNAME,
                                   fullName AS FULLNAME,
                                   address AS ADDRESS,
                                   role AS ROLE,
                                   status AS STATUS
                                   FROM users";

            DataTable dt = new DataTable();
            using (var conn = MySQLConnectionContext.Create())
                using (var cmd = new MySqlCommand(query, conn))
            {
                await conn.OpenAsync();

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
        }

        private ActionButton? GetActionButton(DataGridView dgv, int row, int col)
        {
            var cell = dgv.GetCellDisplayRectangle(col, row, false);

            int padding = 5;
            int buttonCount = 3;
            int totalPadding = padding * (buttonCount + 1);
            int buttonWidth = (cell.Width - totalPadding) / buttonCount;

            Point click = dgv.PointToClient(Cursor.Position);
            int x = click.X - cell.Left;

            int infoStart = padding;
            int editStart = infoStart + buttonWidth + padding;
            int deleteStart = editStart + buttonWidth + padding;

            if (x >= infoStart && x < infoStart + buttonWidth) return ActionButton.Info;
            if (x >= editStart && x < editStart + buttonWidth) return ActionButton.Edit;
            if (x >= deleteStart && x < deleteStart + buttonWidth) return ActionButton.Delete;

            return null;
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
            dgvRolesPermission.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

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
            if (dgvRolesPermission.Columns[e.ColumnIndex].Name != "Actions") return;

            var action = GetActionButton(dgvRolesPermission, e.RowIndex, e.ColumnIndex);
            if (action == null) return;

            int userId = Convert.ToInt32(dgvRolesPermission.Rows[e.RowIndex].Cells["id"].Value);

            switch (action)
            {
                case ActionButton.Info:
                    using (var form = new frmInfo(userId))
                    {
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.StartPosition = FormStartPosition.CenterParent;
                        form.ShowDialog();
                    }
                    break;
            }
        }


        private void dgvRolesPermission_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvRolesPermission.Columns[e.ColumnIndex].Name == "Actions")
            {
                e.PaintBackground(e.ClipBounds, true);

                int padding = 5;
                int buttonCount = 3;

                int totalPadding = padding * (buttonCount + 1);
                int buttonWidth = (e.CellBounds.Width - totalPadding) / buttonCount;
                int buttonHeight = e.CellBounds.Height - (padding * 2);

                Rectangle infoButton = new Rectangle(
                    e.CellBounds.Left + padding,
                    e.CellBounds.Top + padding,
                    buttonWidth,
                    buttonHeight
                );

                Rectangle editButton = new Rectangle(
                    infoButton.Right + padding,
                    e.CellBounds.Top + padding,
                    buttonWidth,
                    buttonHeight
                );

                Rectangle deleteButton = new Rectangle(
                    editButton.Right + padding,
                    e.CellBounds.Top + padding,
                    buttonWidth,
                    buttonHeight
                );

                using (SolidBrush infoBrush = new SolidBrush(Color.FromArgb(250, 250, 250)))
                    e.Graphics.FillRectangle(infoBrush, infoButton);

                using (SolidBrush editBrush = new SolidBrush(Color.FromArgb(94, 148, 255)))
                    e.Graphics.FillRectangle(editBrush, editButton);

                using (SolidBrush deleteBrush = new SolidBrush(Color.FromArgb(255, 77, 79)))
                    e.Graphics.FillRectangle(deleteBrush, deleteButton);

                DrawCenteredIcon(e.Graphics, Properties.Resources.infoIcon, infoButton);
                DrawCenteredIcon(e.Graphics, Properties.Resources.editIcon, editButton);
                DrawCenteredIcon(e.Graphics, Properties.Resources.deleteIcon, deleteButton);

                e.Handled = true;
            }
        }
        private void DrawCenteredIcon(Graphics g, Image icon, Rectangle button)
        {
            int x = button.Left + (button.Width - icon.Width) / 2;
            int y = button.Top + (button.Height - icon.Height) / 2;
            g.DrawImage(icon, x, y, icon.Width, icon.Height);
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

    }
}
