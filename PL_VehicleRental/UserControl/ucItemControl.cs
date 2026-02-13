using Guna.UI2.WinForms;
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

        private Panel actionPanel;

        public ucItemControl(UserInfoDto user)
        {
            InitializeComponent();
            UserId = user.Id;

            lblUserID.Text = Convert.ToString(user.Id);
            lblUsername.Text = user.UserName;
            lblAddress.Text = user.Address;
            lblFullName.Text = user.FullName;
            lblEmail.Text = user.email;
            lblRole.Text = user.Role;
            setStatus(user.Status);

            InitializeActionButtons();
        }

        private void InitializeActionButtons()
        {
            actionPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
            };

            var btnInfo = CreateIconButton(
                Properties.Resources.infoIcon, "View Info", (_, __) => InfoClicked?.Invoke(this, EventArgs.Empty)
                );

            var btnEdit = CreateIconButton(
                Properties.Resources.editIcon, "Edit User", (_, __) => EditClicked?.Invoke(this, EventArgs.Empty)
                );

            var btnDelete = CreateIconButton(
                Properties.Resources.deleteIcon, "Delete User", (_, __) => DeleteClicked?.Invoke(this, EventArgs.Empty)
                );

            var toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btnInfo, "View Details");
            toolTip.SetToolTip(btnEdit, "Edit User");
            toolTip.SetToolTip(btnDelete, "Delete User");

            var flowLayout = new FlowLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                BackColor = Color.Transparent,
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                Anchor = AnchorStyles.None
            };

            actionPanel.Resize += (s, e) =>
            {
                flowLayout.Left = (actionPanel.Width - flowLayout.Width) / 2;
                flowLayout.Top = (actionPanel.Height - flowLayout.Height) / 2;
            };

            flowLayout.Controls.Add(btnInfo);
            flowLayout.Controls.Add(btnEdit);
            flowLayout.Controls.Add(btnDelete);

            actionPanel.Controls.Add(flowLayout);
        }

        private Guna2Button CreateIconButton(
            Image icon,
            string tooltip,
            EventHandler onClick,
            bool isDanger = false)
        {
            var btn = new Guna2Button
            {
                Size = new Size(32, 32),
                BorderRadius = 6,
                Image = icon,
                ImageSize = new Size(18, 18),
                FillColor = Color.Transparent,
                HoverState =
                {
                    FillColor = isDanger
                ? Color.FromArgb(255, 235, 235)
                : Color.FromArgb(235, 240, 255)
                },

                PressedColor = Color.Transparent,
                Cursor = Cursors.Hand
            };

            btn.Click += onClick;

            new System.Windows.Forms.ToolTip().SetToolTip(btn, tooltip);

            return btn;
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void setStatus(string status)
        {
            lblStatus.Text = status;

            switch (status)
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
                ColumnCount = 8,
                RowCount = 1,
                Padding = new Padding(2),
                BackColor = Color.White,
                Margin = new Padding(0, 1, 0, 1),
                
            };

            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.IdWidth));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.UsernameWidth));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.FullnameWidth));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.EmailWidth));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.RoleWidth));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.StatusWidth));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, UserTableLayout.ActionWidth));

            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));

            AddCell(layout, lblUserID, 0);
            AddCell(layout, lblUsername, 1);
            AddCell(layout, lblFullName, 2);
            AddCell(layout, lblEmail, 3);
            AddCell(layout, lblAddress, 4);
            AddCell(layout, lblRole, 5);
            AddCell(layout, lblStatus, 6);
            AddCell(layout, actionPanel, 7);

            MakeRounded(lblStatus);

            Controls.Clear();
            Controls.Add(layout);

            this.MouseEnter += (s, e) => { this.BackColor = Color.FromArgb(250, 250, 250); };
            this.MouseLeave += (s, e) => { this.BackColor = Color.White; };
        }

        private void AddCell(TableLayoutPanel layout, Control control, int column)
        {
            control.Dock = DockStyle.Fill;
            control.Margin = Padding.Empty;

            if (column == 8)
            {
                control.Dock = DockStyle.None;
                control.Anchor = AnchorStyles.None;
            }
            else
            {
                control.Dock = DockStyle.Fill;
            }

            if (control is Label label)
            {
                label.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);

                switch (column)
                {
                    case 0:
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        break;
                    case 1:
                    case 2:
                    case 3:
                        label.TextAlign = ContentAlignment.MiddleLeft;
                        break;
                    case 4:
                    case 5:
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        break;
                    default:
                        label.TextAlign = ContentAlignment.MiddleLeft;
                        break;
                }
            }

            layout.Controls.Add(control, column, 0);
        }

        private void MakeRounded(Label label)
        {
            label.AutoSize = false;
            label.Height = 28;
            label.Padding = new Padding(10, 4, 10, 4);
            label.TextAlign = ContentAlignment.MiddleCenter;

            label.Paint += (s, e) =>
            {
                var rect = label.ClientRectangle;
                rect.Inflate(-1, -1);

                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radius = 12;
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    label.Region = new Region(path);
                }
            };
        }

        private void ucItemControl_Load(object sender, EventArgs e)
        {
            BuildLayout();
        }

        public void UpdateWidth(int width)
        {
            this.Width = width;
            if (this.Controls.Count > 0 && this.Controls[0] is TableLayoutPanel layout)
            {
                layout.Width = width;
            }
        }
    }
}