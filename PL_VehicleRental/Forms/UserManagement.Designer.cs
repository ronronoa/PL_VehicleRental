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
            this.BackgroundPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.UserManagementPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.userManagementTabControl = new System.Windows.Forms.TabControl();
            this.userManagementTab = new System.Windows.Forms.TabPage();
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.statusCmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.roleCmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.addressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lastNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.firstNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.rolesPermissionTab = new System.Windows.Forms.TabPage();
            this.userPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.totalUserLabel = new System.Windows.Forms.Label();
            this.totalUserData = new System.Windows.Forms.Label();
            this.statCard = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.activeUserData = new System.Windows.Forms.Label();
            this.activeUserLabel = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.InactiveUserData = new System.Windows.Forms.Label();
            this.inActiveUserLabel = new System.Windows.Forms.Label();
            this.BackgroundPanel.SuspendLayout();
            this.UserManagementPanel.SuspendLayout();
            this.userManagementTabControl.SuspendLayout();
            this.userManagementTab.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.statCard.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
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
            this.userManagementTab.Padding = new System.Windows.Forms.Padding(3);
            this.userManagementTab.Size = new System.Drawing.Size(1292, 699);
            this.userManagementTab.TabIndex = 0;
            this.userManagementTab.Text = "User Management";
            this.userManagementTab.Click += new System.EventHandler(this.userManagementTab_Click);
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
            this.clearBtn.Location = new System.Drawing.Point(241, 290);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(180, 45);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear All";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
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
            this.addBtn.Location = new System.Drawing.Point(55, 290);
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
            this.statusCmb.Location = new System.Drawing.Point(170, 226);
            this.statusCmb.Name = "statusCmb";
            this.statusCmb.Size = new System.Drawing.Size(235, 36);
            this.statusCmb.StartIndex = 0;
            this.statusCmb.TabIndex = 9;
            this.statusCmb.SelectedIndexChanged += new System.EventHandler(this.statusCmb_SelectedIndexChanged);
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
            this.roleCmb.Location = new System.Drawing.Point(170, 173);
            this.roleCmb.Name = "roleCmb";
            this.roleCmb.Size = new System.Drawing.Size(235, 36);
            this.roleCmb.StartIndex = 0;
            this.roleCmb.TabIndex = 8;
            this.roleCmb.SelectedIndexChanged += new System.EventHandler(this.roleCmb_SelectedIndexChanged);
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
            this.addressTextBox.Location = new System.Drawing.Point(170, 136);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PlaceholderText = "";
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.Size = new System.Drawing.Size(376, 30);
            this.addressTextBox.TabIndex = 7;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTextBox.DefaultText = "";
            this.lastNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.lastNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.Location = new System.Drawing.Point(170, 98);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PlaceholderText = "";
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.Size = new System.Drawing.Size(376, 30);
            this.lastNameTextBox.TabIndex = 6;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTextBox.DefaultText = "";
            this.firstNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.firstNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.Location = new System.Drawing.Point(170, 60);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PlaceholderText = "";
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.Size = new System.Drawing.Size(376, 30);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(50, 231);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(61, 23);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status:";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // roleLabel
            // 
            this.roleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(50, 180);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(48, 23);
            this.roleLabel.TabIndex = 3;
            this.roleLabel.Text = "Role:";
            this.roleLabel.Click += new System.EventHandler(this.roleLabel_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(50, 136);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(74, 23);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address:";
            this.addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(50, 97);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(95, 23);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.Click += new System.EventHandler(this.lastNameLabel_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(50, 60);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 23);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // rolesPermissionTab
            // 
            this.rolesPermissionTab.BackColor = System.Drawing.Color.Transparent;
            this.rolesPermissionTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rolesPermissionTab.Location = new System.Drawing.Point(4, 39);
            this.rolesPermissionTab.Name = "rolesPermissionTab";
            this.rolesPermissionTab.Padding = new System.Windows.Forms.Padding(3);
            this.rolesPermissionTab.Size = new System.Drawing.Size(1292, 704);
            this.rolesPermissionTab.TabIndex = 1;
            this.rolesPermissionTab.Text = "Roles & Permission";
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.roleCmb);
            this.userPanel.Controls.Add(this.clearBtn);
            this.userPanel.Controls.Add(this.firstNameLabel);
            this.userPanel.Controls.Add(this.addBtn);
            this.userPanel.Controls.Add(this.lastNameLabel);
            this.userPanel.Controls.Add(this.statusCmb);
            this.userPanel.Controls.Add(this.addressLabel);
            this.userPanel.Controls.Add(this.roleLabel);
            this.userPanel.Controls.Add(this.addressTextBox);
            this.userPanel.Controls.Add(this.statusLabel);
            this.userPanel.Controls.Add(this.lastNameTextBox);
            this.userPanel.Controls.Add(this.firstNameTextBox);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.userPanel.Location = new System.Drawing.Point(3, 3);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(616, 691);
            this.userPanel.TabIndex = 13;
            this.userPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.userPanel_Paint);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Panel5);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Controls.Add(this.statCard);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(619, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(668, 691);
            this.guna2Panel2.TabIndex = 14;
            // 
            // totalUserLabel
            // 
            this.totalUserLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalUserLabel.AutoSize = true;
            this.totalUserLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUserLabel.Location = new System.Drawing.Point(270, 84);
            this.totalUserLabel.Name = "totalUserLabel";
            this.totalUserLabel.Size = new System.Drawing.Size(121, 31);
            this.totalUserLabel.TabIndex = 0;
            this.totalUserLabel.Text = "Total User";
            this.totalUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalUserLabel.Click += new System.EventHandler(this.totalUserLabel_Click);
            // 
            // totalUserData
            // 
            this.totalUserData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalUserData.AutoSize = true;
            this.totalUserData.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUserData.Location = new System.Drawing.Point(309, 18);
            this.totalUserData.Name = "totalUserData";
            this.totalUserData.Size = new System.Drawing.Size(43, 50);
            this.totalUserData.TabIndex = 3;
            this.totalUserData.Text = "0";
            this.totalUserData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalUserData.Click += new System.EventHandler(this.totalUserData_Click);
            // 
            // statCard
            // 
            this.statCard.Controls.Add(this.totalUserData);
            this.statCard.Controls.Add(this.totalUserLabel);
            this.statCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.statCard.Location = new System.Drawing.Point(0, 0);
            this.statCard.Name = "statCard";
            this.statCard.Size = new System.Drawing.Size(668, 142);
            this.statCard.TabIndex = 6;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.guna2Panel4);
            this.guna2Panel3.Controls.Add(this.activeUserData);
            this.guna2Panel3.Controls.Add(this.activeUserLabel);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 142);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(668, 142);
            this.guna2Panel3.TabIndex = 7;
            // 
            // activeUserData
            // 
            this.activeUserData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.activeUserData.AutoSize = true;
            this.activeUserData.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUserData.Location = new System.Drawing.Point(309, 18);
            this.activeUserData.Name = "activeUserData";
            this.activeUserData.Size = new System.Drawing.Size(43, 50);
            this.activeUserData.TabIndex = 3;
            this.activeUserData.Text = "0";
            this.activeUserData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.activeUserData.Click += new System.EventHandler(this.activeUserData_Click_1);
            // 
            // activeUserLabel
            // 
            this.activeUserLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.activeUserLabel.AutoSize = true;
            this.activeUserLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUserLabel.Location = new System.Drawing.Point(270, 84);
            this.activeUserLabel.Name = "activeUserLabel";
            this.activeUserLabel.Size = new System.Drawing.Size(135, 31);
            this.activeUserLabel.TabIndex = 0;
            this.activeUserLabel.Text = "Active User";
            this.activeUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.activeUserLabel.Click += new System.EventHandler(this.activeUserLabel_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.label1);
            this.guna2Panel4.Controls.Add(this.label2);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(668, 142);
            this.guna2Panel4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Active User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.InactiveUserData);
            this.guna2Panel5.Controls.Add(this.inActiveUserLabel);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.Location = new System.Drawing.Point(0, 284);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(668, 142);
            this.guna2Panel5.TabIndex = 8;
            // 
            // InactiveUserData
            // 
            this.InactiveUserData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InactiveUserData.AutoSize = true;
            this.InactiveUserData.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InactiveUserData.Location = new System.Drawing.Point(309, 18);
            this.InactiveUserData.Name = "InactiveUserData";
            this.InactiveUserData.Size = new System.Drawing.Size(43, 50);
            this.InactiveUserData.TabIndex = 3;
            this.InactiveUserData.Text = "0";
            this.InactiveUserData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inActiveUserLabel
            // 
            this.inActiveUserLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inActiveUserLabel.AutoSize = true;
            this.inActiveUserLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inActiveUserLabel.Location = new System.Drawing.Point(270, 89);
            this.inActiveUserLabel.Name = "inActiveUserLabel";
            this.inActiveUserLabel.Size = new System.Drawing.Size(152, 31);
            this.inActiveUserLabel.TabIndex = 0;
            this.inActiveUserLabel.Text = "Inactive User";
            this.inActiveUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 802);
            this.Controls.Add(this.BackgroundPanel);
            this.Name = "UserManagementForm";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.UserManagementPanel.ResumeLayout(false);
            this.userManagementTabControl.ResumeLayout(false);
            this.userManagementTab.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.statCard.ResumeLayout(false);
            this.statCard.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel BackgroundPanel;
        private Guna.UI2.WinForms.Guna2Panel UserManagementPanel;
        private System.Windows.Forms.TabControl userManagementTabControl;
        private System.Windows.Forms.TabPage userManagementTab;
        private System.Windows.Forms.TabPage rolesPermissionTab;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label statusLabel;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox lastNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox addressTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox roleCmb;
        private Guna.UI2.WinForms.Guna2ComboBox statusCmb;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private Guna.UI2.WinForms.Guna2Panel userPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label totalUserLabel;
        private System.Windows.Forms.Label totalUserData;
        private Guna.UI2.WinForms.Guna2Panel statCard;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label activeUserData;
        private System.Windows.Forms.Label activeUserLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label InactiveUserData;
        private System.Windows.Forms.Label inActiveUserLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}