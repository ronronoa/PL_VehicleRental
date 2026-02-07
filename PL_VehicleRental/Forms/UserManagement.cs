using MySql.Data.MySqlClient;
using PL_VehicleRental.Classes;
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
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        enum ActionButton
        {
            Info,
            Edit,
            Delete
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

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            rolesTablePanel.BackColor = SystemColors.Control;
            rolesTablePanel.ForeColor = SystemColors.ControlText;

            DataGridViewStyle.ApplyStandard(dgvRolesPermission);

            dgvRolesPermission.BackColor = Color.White;
            dgvRolesPermission.ForeColor = Color.Black;
            dgvRolesPermission.Font = new Font("Segoe UI Semibold", 10.5f);

            RefreshUserData();
        }

        public void RefreshUserData()
        {
            DataTable users = LoadUsers();
            dgvRolesPermission.DataSource = users;
            SetupActionsButtons();
            CenterGridHeaders();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            
        }

        public DataTable LoadUsers()
        {
            DataTable dt = new DataTable();
            
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string query = @"SELECT id AS ID, 
                                        userName AS Username, 
                                        fullName AS FullName,
                                        address AS Address,
                                        role As Role, 
                                        status AS Status
                                FROM users";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvRolesPermission_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private ActionButton? GetActionButton(DataGridView dgv, int row, int col)
        {
            return null;
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

            if (dgvRolesPermission.Columns[e.ColumnIndex].Name == "Actions")
            {
                var cell = dgvRolesPermission.GetCellDisplayRectangle(
                    e.ColumnIndex, e.RowIndex, false);

                int padding = 5;
                int buttonCount = 3;

                int totalPadding = padding * (buttonCount + 1);
                int buttonWidth = (cell.Width - totalPadding) / buttonCount;

                Point clickPoint = dgvRolesPermission.PointToClient(Cursor.Position);
                int relativeX = clickPoint.X - cell.Left;

                int infoStart = padding;
                int editStart = infoStart + buttonWidth + padding;
                int deleteStart = editStart + buttonWidth + padding;

                if (relativeX >= infoStart && relativeX < infoStart + buttonWidth)
                {
                    MessageBox.Show($"Info clicked for row {e.RowIndex}");
                }
                else if (relativeX >= editStart && relativeX < editStart + buttonWidth)
                {
                    MessageBox.Show($"Edit clicked for row {e.RowIndex}");
                }
                else if (relativeX >= deleteStart && relativeX < deleteStart + buttonWidth)
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
 
        private void OpenAddUserForm()
        {
            frmAddUser form = new frmAddUser();

            form.UserAdded += (sender, e) =>
            {
                this.RefreshUserData();
            };
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
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

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void dgvRolesPermission_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
