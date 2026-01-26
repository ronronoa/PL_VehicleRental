namespace PL_VehicleRental.Forms
{
    partial class UserManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BackgroundPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.UserManagementPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.userManagementTabControl = new System.Windows.Forms.TabControl();
            this.userManagementTab = new System.Windows.Forms.TabPage();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSuspendedUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblInactiveUsers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblActiveUsers = new System.Windows.Forms.Label();
            this.ActiveUserDataLabel = new System.Windows.Forms.Label();
            this.statCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.totalUserLabel = new System.Windows.Forms.Label();
            this.userPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.headerLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roleCmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.statusCmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.fullNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.rolesPermissionTab = new System.Windows.Forms.TabPage();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgvRolesPermission = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BackgroundPanel.SuspendLayout();
            this.UserManagementPanel.SuspendLayout();
            this.userManagementTabControl.SuspendLayout();
            this.userManagementTab.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.statCard.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.rolesPermissionTab.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesPermission)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundPanel.BorderColor = System.Drawing.Color.Gray;
            this.BackgroundPanel.BorderRadius = 5;
            this.BackgroundPanel.BorderThickness = 1;
            this.BackgroundPanel.Controls.Add(this.UserManagementPanel);
            this.BackgroundPanel.Location = new System.Drawing.Point(12, 12);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(1329, 778);
            this.BackgroundPanel.TabIndex = 0;
            this.BackgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // UserManagementPanel
            // 
            this.UserManagementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserManagementPanel.BorderColor = System.Drawing.Color.Transparent;
            this.UserManagementPanel.Controls.Add(this.userManagementTabControl);
            this.UserManagementPanel.Location = new System.Drawing.Point(14, 15);
            this.UserManagementPanel.Name = "UserManagementPanel";
            this.UserManagementPanel.Size = new System.Drawing.Size(1300, 747);
            this.UserManagementPanel.TabIndex = 0;
            // 
            // userManagementTabControl
            // 
            this.userManagementTabControl.Controls.Add(this.userManagementTab);
            this.userManagementTabControl.Controls.Add(this.rolesPermissionTab);
            this.userManagementTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userManagementTabControl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagementTabControl.ItemSize = new System.Drawing.Size(120, 40);
            this.userManagementTabControl.Location = new System.Drawing.Point(0, 0);
            this.userManagementTabControl.Name = "userManagementTabControl";
            this.userManagementTabControl.Padding = new System.Drawing.Point(10, 10);
            this.userManagementTabControl.SelectedIndex = 0;
            this.userManagementTabControl.Size = new System.Drawing.Size(1300, 747);
            this.userManagementTabControl.TabIndex = 9;
            // 
            // userManagementTab
            // 
            this.userManagementTab.BackColor = System.Drawing.Color.Transparent;
            this.userManagementTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userManagementTab.Controls.Add(this.guna2Panel2);
            this.userManagementTab.Controls.Add(this.userPanel);
            this.userManagementTab.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagementTab.Location = new System.Drawing.Point(4, 44);
            this.userManagementTab.Name = "userManagementTab";
            this.userManagementTab.Padding = new System.Windows.Forms.Padding(10);
            this.userManagementTab.Size = new System.Drawing.Size(1292, 699);
            this.userManagementTab.TabIndex = 0;
            this.userManagementTab.Text = "User Management";
            this.userManagementTab.Click += new System.EventHandler(this.userManagementTab_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Panel6);
            this.guna2Panel2.Controls.Add(this.guna2Panel5);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Controls.Add(this.statCard);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(626, 10);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(20);
            this.guna2Panel2.Size = new System.Drawing.Size(654, 677);
            this.guna2Panel2.TabIndex = 14;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel6.BorderRadius = 10;
            this.guna2Panel6.BorderThickness = 1;
            this.guna2Panel6.Controls.Add(this.lblSuspendedUser);
            this.guna2Panel6.Controls.Add(this.label5);
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel6.Location = new System.Drawing.Point(20, 446);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(614, 142);
            this.guna2Panel6.TabIndex = 10;
            // 
            // lblSuspendedUser
            // 
            this.lblSuspendedUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSuspendedUser.AutoSize = true;
            this.lblSuspendedUser.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuspendedUser.Location = new System.Drawing.Point(282, 18);
            this.lblSuspendedUser.Name = "lblSuspendedUser";
            this.lblSuspendedUser.Size = new System.Drawing.Size(43, 50);
            this.lblSuspendedUser.TabIndex = 3;
            this.lblSuspendedUser.Text = "0";
            this.lblSuspendedUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Suspended User";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.guna2Panel1);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.Location = new System.Drawing.Point(20, 304);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(614, 142);
            this.guna2Panel5.TabIndex = 8;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lblInactiveUsers);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(614, 142);
            this.guna2Panel1.TabIndex = 9;
            // 
            // lblInactiveUsers
            // 
            this.lblInactiveUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInactiveUsers.AutoSize = true;
            this.lblInactiveUsers.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactiveUsers.Location = new System.Drawing.Point(282, 18);
            this.lblInactiveUsers.Name = "lblInactiveUsers";
            this.lblInactiveUsers.Size = new System.Drawing.Size(43, 50);
            this.lblInactiveUsers.TabIndex = 3;
            this.lblInactiveUsers.Text = "0";
            this.lblInactiveUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inactive User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.guna2Panel4);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(20, 162);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(614, 142);
            this.guna2Panel3.TabIndex = 7;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.lblActiveUsers);
            this.guna2Panel4.Controls.Add(this.ActiveUserDataLabel);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(614, 142);
            this.guna2Panel4.TabIndex = 8;
            // 
            // lblActiveUsers
            // 
            this.lblActiveUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblActiveUsers.AutoSize = true;
            this.lblActiveUsers.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUsers.Location = new System.Drawing.Point(282, 18);
            this.lblActiveUsers.Name = "lblActiveUsers";
            this.lblActiveUsers.Size = new System.Drawing.Size(43, 50);
            this.lblActiveUsers.TabIndex = 3;
            this.lblActiveUsers.Text = "0";
            this.lblActiveUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActiveUserDataLabel
            // 
            this.ActiveUserDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActiveUserDataLabel.AutoSize = true;
            this.ActiveUserDataLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveUserDataLabel.Location = new System.Drawing.Point(243, 84);
            this.ActiveUserDataLabel.Name = "ActiveUserDataLabel";
            this.ActiveUserDataLabel.Size = new System.Drawing.Size(135, 31);
            this.ActiveUserDataLabel.TabIndex = 0;
            this.ActiveUserDataLabel.Text = "Active User";
            this.ActiveUserDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statCard
            // 
            this.statCard.BorderColor = System.Drawing.Color.Black;
            this.statCard.BorderRadius = 10;
            this.statCard.BorderThickness = 1;
            this.statCard.Controls.Add(this.lblTotalUsers);
            this.statCard.Controls.Add(this.totalUserLabel);
            this.statCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.statCard.FillColor = System.Drawing.Color.Transparent;
            this.statCard.Location = new System.Drawing.Point(20, 20);
            this.statCard.Name = "statCard";
            this.statCard.Size = new System.Drawing.Size(614, 142);
            this.statCard.TabIndex = 6;
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsers.Location = new System.Drawing.Point(282, 18);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(43, 50);
            this.lblTotalUsers.TabIndex = 3;
            this.lblTotalUsers.Text = "0";
            this.lblTotalUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalUsers.Click += new System.EventHandler(this.totalUserData_Click);
            // 
            // totalUserLabel
            // 
            this.totalUserLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalUserLabel.AutoSize = true;
            this.totalUserLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUserLabel.Location = new System.Drawing.Point(243, 84);
            this.totalUserLabel.Name = "totalUserLabel";
            this.totalUserLabel.Size = new System.Drawing.Size(121, 31);
            this.totalUserLabel.TabIndex = 0;
            this.totalUserLabel.Text = "Total User";
            this.totalUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalUserLabel.Click += new System.EventHandler(this.totalUserLabel_Click);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.guna2Separator1);
            this.userPanel.Controls.Add(this.headerLabel);
            this.userPanel.Controls.Add(this.userNameTextBox);
            this.userPanel.Controls.Add(this.label3);
            this.userPanel.Controls.Add(this.roleCmb);
            this.userPanel.Controls.Add(this.clearBtn);
            this.userPanel.Controls.Add(this.fullNameLabel);
            this.userPanel.Controls.Add(this.addBtn);
            this.userPanel.Controls.Add(this.statusCmb);
            this.userPanel.Controls.Add(this.addressLabel);
            this.userPanel.Controls.Add(this.roleLabel);
            this.userPanel.Controls.Add(this.addressTextBox);
            this.userPanel.Controls.Add(this.statusLabel);
            this.userPanel.Controls.Add(this.fullNameTxt);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.userPanel.Location = new System.Drawing.Point(10, 10);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(616, 677);
            this.userPanel.TabIndex = 13;
            this.userPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.userPanel_Paint);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(54, 49);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(492, 10);
            this.guna2Separator1.TabIndex = 15;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(48, 18);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(209, 31);
            this.headerLabel.TabIndex = 14;
            this.headerLabel.Text = "Register New User";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTextBox.DefaultText = "";
            this.userNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.userNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTextBox.Location = new System.Drawing.Point(170, 117);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PlaceholderText = "";
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.Size = new System.Drawing.Size(376, 30);
            this.userNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username:";
            // 
            // roleCmb
            // 
            this.roleCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roleCmb.BackColor = System.Drawing.Color.Transparent;
            this.roleCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCmb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleCmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleCmb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roleCmb.ForeColor = System.Drawing.Color.Black;
            this.roleCmb.ItemHeight = 30;
            this.roleCmb.Items.AddRange(new object[] {
            "Admin",
            "Staff",
            "Customer"});
            this.roleCmb.Location = new System.Drawing.Point(170, 231);
            this.roleCmb.Name = "roleCmb";
            this.roleCmb.Size = new System.Drawing.Size(235, 36);
            this.roleCmb.StartIndex = 0;
            this.roleCmb.TabIndex = 8;
            this.roleCmb.SelectedIndexChanged += new System.EventHandler(this.roleCmb_SelectedIndexChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.BorderColor = System.Drawing.Color.Transparent;
            this.clearBtn.BorderRadius = 10;
            this.clearBtn.BorderThickness = 1;
            this.clearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(89)))), ((int)(((byte)(124)))));
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(276, 379);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(180, 45);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear All";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(50, 156);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(92, 23);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "Full Name:";
            this.fullNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BorderColor = System.Drawing.Color.Transparent;
            this.addBtn.BorderRadius = 10;
            this.addBtn.BorderThickness = 1;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(89)))), ((int)(((byte)(124)))));
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(54, 379);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(180, 45);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add User";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // statusCmb
            // 
            this.statusCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusCmb.BackColor = System.Drawing.Color.Transparent;
            this.statusCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCmb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusCmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusCmb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusCmb.ForeColor = System.Drawing.Color.Black;
            this.statusCmb.ItemHeight = 30;
            this.statusCmb.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusCmb.Location = new System.Drawing.Point(170, 284);
            this.statusCmb.Name = "statusCmb";
            this.statusCmb.Size = new System.Drawing.Size(235, 36);
            this.statusCmb.StartIndex = 0;
            this.statusCmb.TabIndex = 9;
            this.statusCmb.SelectedIndexChanged += new System.EventHandler(this.statusCmb_SelectedIndexChanged);
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(50, 194);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(74, 23);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address:";
            this.addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // roleLabel
            // 
            this.roleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(50, 238);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(48, 23);
            this.roleLabel.TabIndex = 3;
            this.roleLabel.Text = "Role:";
            this.roleLabel.Click += new System.EventHandler(this.roleLabel_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTextBox.DefaultText = "";
            this.addressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addressTextBox.ForeColor = System.Drawing.Color.Black;
            this.addressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTextBox.Location = new System.Drawing.Point(170, 194);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PlaceholderText = "";
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.Size = new System.Drawing.Size(376, 30);
            this.addressTextBox.TabIndex = 7;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(50, 289);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(61, 23);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status:";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullNameTxt.DefaultText = "";
            this.fullNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullNameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fullNameTxt.ForeColor = System.Drawing.Color.Black;
            this.fullNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullNameTxt.Location = new System.Drawing.Point(170, 156);
            this.fullNameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.PlaceholderText = "";
            this.fullNameTxt.SelectedText = "";
            this.fullNameTxt.Size = new System.Drawing.Size(376, 30);
            this.fullNameTxt.TabIndex = 6;
            this.fullNameTxt.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // rolesPermissionTab
            // 
            this.rolesPermissionTab.BackColor = System.Drawing.Color.Transparent;
            this.rolesPermissionTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rolesPermissionTab.Controls.Add(this.guna2ShadowPanel1);
            this.rolesPermissionTab.Location = new System.Drawing.Point(4, 44);
            this.rolesPermissionTab.Name = "rolesPermissionTab";
            this.rolesPermissionTab.Padding = new System.Windows.Forms.Padding(3);
            this.rolesPermissionTab.Size = new System.Drawing.Size(1292, 699);
            this.rolesPermissionTab.TabIndex = 1;
            this.rolesPermissionTab.Text = "Roles & Permission";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.dgvRolesPermission);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1284, 691);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // dgvRolesPermission
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvRolesPermission.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRolesPermission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvRolesPermission.ColumnHeadersHeight = 4;
            this.dgvRolesPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRolesPermission.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvRolesPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRolesPermission.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRolesPermission.Location = new System.Drawing.Point(20, 20);
            this.dgvRolesPermission.Name = "dgvRolesPermission";
            this.dgvRolesPermission.RowHeadersVisible = false;
            this.dgvRolesPermission.RowHeadersWidth = 51;
            this.dgvRolesPermission.RowTemplate.Height = 24;
            this.dgvRolesPermission.Size = new System.Drawing.Size(1244, 651);
            this.dgvRolesPermission.TabIndex = 0;
            this.dgvRolesPermission.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRolesPermission.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRolesPermission.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRolesPermission.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRolesPermission.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRolesPermission.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRolesPermission.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRolesPermission.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvRolesPermission.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRolesPermission.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRolesPermission.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRolesPermission.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRolesPermission.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvRolesPermission.ThemeStyle.ReadOnly = false;
            this.dgvRolesPermission.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRolesPermission.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRolesPermission.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRolesPermission.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRolesPermission.ThemeStyle.RowsStyle.Height = 24;
            this.dgvRolesPermission.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRolesPermission.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRolesPermission.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRolesPermission_CellClick);
            this.dgvRolesPermission.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRolesPermission_CellContentClick_1);
            this.dgvRolesPermission.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvRolesPermission_CellPainting);
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 802);
            this.Controls.Add(this.BackgroundPanel);
            this.Name = "UserManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.UserManagementPanel.ResumeLayout(false);
            this.userManagementTabControl.ResumeLayout(false);
            this.userManagementTab.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.statCard.ResumeLayout(false);
            this.statCard.PerformLayout();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.rolesPermissionTab.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesPermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel BackgroundPanel;
        private Guna.UI2.WinForms.Guna2Panel UserManagementPanel;
        private System.Windows.Forms.TabControl userManagementTabControl;
        private System.Windows.Forms.TabPage userManagementTab;
        private System.Windows.Forms.TabPage rolesPermissionTab;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label statusLabel;
        private Guna.UI2.WinForms.Guna2TextBox fullNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox addressTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox roleCmb;
        private Guna.UI2.WinForms.Guna2ComboBox statusCmb;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private Guna.UI2.WinForms.Guna2Panel userPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label totalUserLabel;
        private System.Windows.Forms.Label lblTotalUsers;
        private Guna.UI2.WinForms.Guna2Panel statCard;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label lblActiveUsers;
        private System.Windows.Forms.Label ActiveUserDataLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2TextBox userNameTextBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label headerLabel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRolesPermission;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label lblSuspendedUser;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblInactiveUsers;
        private System.Windows.Forms.Label label2;
    }
}