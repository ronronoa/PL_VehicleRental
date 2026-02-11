using PL_VehicleRental.UI.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Dto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PL_VehicleRental.UserControl
{
    public partial class ucItemControl : System.Windows.Forms.UserControl
    {
        public int UserId { get; }
        public event EventHandler InfoClicked;
        public event EventHandler EditClicked;
        public event EventHandler DeleteClicked;
        public ucItemControl(UserInfoDto user)
        {
            InitializeComponent();
            UserId = user.Id;

            lblUserID.Text = Convert.ToString(user.Id);
            lblUsername.Text = user.UserName;
            lblAddress.Text = user.Address;
            lblFullName.Text = user.FullName;
            lblRole.Text = user.Role;
            setStatus(user.Status);
        }

        private void setStatus(string status)
        {
            lblStatus.Text = status;

            switch(status)
            {
                case "Active":
                    lblStatus.BackColor = Color.FromArgb(230, 255, 240);
                    lblStatus.ForeColor = Color.Green;
                    break;

                case "Inactive":
                    lblStatus.BackColor = Color.FromArgb(255, 235, 235);
                    lblStatus.ForeColor = Color.Red;
                    break;

                case "Suspended":
                    lblStatus.BackColor = Color.FromArgb(255, 244, 230);
                    lblStatus.ForeColor = Color.DarkOrange;
                    break;
            }
        }

        private void BuildLayout()
        {
            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 6,
                RowCount = 1,
                BackColor = Color.White,
                Padding = new Padding(8)
            };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.IdWidth));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.UsernameWidth));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.FullnameWidth));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.RoleWidth));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.StatusWidth));

            AddCell(layout, lblUserID, 0);
            AddCell(layout, lblUsername, 1);
            AddCell(layout, lblFullName, 2);
            AddCell(layout, lblAddress, 3);
            AddCell(layout, lblRole, 4);
            AddCell(layout, lblStatus, 5);

            MakeRounded(lblStatus);

            Controls.Clear();
            Controls.Add(layout);
        }

        private void AddCell(TableLayoutPanel layout, Label label, int column)
        {
            label.Dock = DockStyle.Fill;
            label.Margin = new Padding(6, 0, 6, 0);
            label.TextAlign = ContentAlignment.MiddleLeft;

            layout.Controls.Add(label, column, 0);
        }

        private void MakeRounded(Label label)
        {
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;

            label.Paint += (s, e) =>
            {
                var rect = label.ClientRectangle;
                rect.Inflate(-1, -1);

                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.AddArc(rect.X, rect.Y, 12, 12, 180, 90);
                    path.AddArc(rect.Right - 12, rect.Y, 12, 12, 270, 90);
                    path.AddArc(rect.Right - 12, rect.Bottom - 12, 12, 12, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - 12, 12, 12, 90, 90);
                    path.CloseFigure();

                    label.Region = new Region(path);
                }
            };
        }

        private void ucItemControl_Load(object sender, EventArgs e)
        {
            BuildLayout();
        }
    }
}
