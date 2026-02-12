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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
            this.BackgroundPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.UserManagementPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.rolesTablePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.flowUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.TableHeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.headerPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUserForm = new Guna.UI2.WinForms.Guna2Button();
            this.BackgroundPanel.SuspendLayout();
            this.UserManagementPanel.SuspendLayout();
            this.rolesTablePanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
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
            this.BackgroundPanel.Location = new System.Drawing.Point(9, 10);
            this.BackgroundPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(997, 632);
            this.BackgroundPanel.TabIndex = 0;
            this.BackgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // UserManagementPanel
            // 
            this.UserManagementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserManagementPanel.BorderColor = System.Drawing.Color.Transparent;
            this.UserManagementPanel.Controls.Add(this.rolesTablePanel);
            this.UserManagementPanel.Controls.Add(this.headerPanel);
            this.UserManagementPanel.Location = new System.Drawing.Point(10, 12);
            this.UserManagementPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserManagementPanel.Name = "UserManagementPanel";
            this.UserManagementPanel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.UserManagementPanel.Size = new System.Drawing.Size(975, 607);
            this.UserManagementPanel.TabIndex = 0;
            // 
            // rolesTablePanel
            // 
            this.rolesTablePanel.Controls.Add(this.flowUsers);
            this.rolesTablePanel.Controls.Add(this.TableHeaderPanel);
            this.rolesTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesTablePanel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolesTablePanel.Location = new System.Drawing.Point(8, 89);
            this.rolesTablePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rolesTablePanel.Name = "rolesTablePanel";
            this.rolesTablePanel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rolesTablePanel.Size = new System.Drawing.Size(959, 510);
            this.rolesTablePanel.TabIndex = 1;
            // 
            // flowUsers
            // 
            this.flowUsers.AutoScroll = true;
            this.flowUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowUsers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowUsers.Location = new System.Drawing.Point(8, 89);
            this.flowUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowUsers.Name = "flowUsers";
            this.flowUsers.Size = new System.Drawing.Size(943, 413);
            this.flowUsers.TabIndex = 1;
            this.flowUsers.WrapContents = false;
            this.flowUsers.Resize += new System.EventHandler(this.flowUsers_Resize);
            // 
            // TableHeaderPanel
            // 
            this.TableHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableHeaderPanel.Location = new System.Drawing.Point(8, 8);
            this.TableHeaderPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TableHeaderPanel.Name = "TableHeaderPanel";
            this.TableHeaderPanel.Size = new System.Drawing.Size(943, 81);
            this.TableHeaderPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Transparent;
            this.headerPanel.BorderColor = System.Drawing.Color.Silver;
            this.headerPanel.BorderRadius = 10;
            this.headerPanel.BorderThickness = 2;
            this.headerPanel.Controls.Add(this.txtSearch);
            this.headerPanel.Controls.Add(this.btnUserForm);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.CustomizableEdges.BottomLeft = false;
            this.headerPanel.CustomizableEdges.BottomRight = false;
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.headerPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.headerPanel.Location = new System.Drawing.Point(8, 8);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(959, 81);
            this.headerPanel.TabIndex = 1;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(22, 23);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(250, 32);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "User Management";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::PL_VehicleRental.Properties.Resources.searchIcon;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.Location = new System.Drawing.Point(552, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search user...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(200, 36);
            this.txtSearch.TabIndex = 4;
            // 
            // btnUserForm
            // 
            this.btnUserForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserForm.BorderColor = System.Drawing.Color.Transparent;
            this.btnUserForm.BorderRadius = 5;
            this.btnUserForm.BorderThickness = 2;
            this.btnUserForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.btnUserForm.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnUserForm.ForeColor = System.Drawing.Color.White;
            this.btnUserForm.Image = ((System.Drawing.Image)(resources.GetObject("btnUserForm.Image")));
            this.btnUserForm.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUserForm.Location = new System.Drawing.Point(786, 23);
            this.btnUserForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserForm.Name = "btnUserForm";
            this.btnUserForm.Size = new System.Drawing.Size(152, 37);
            this.btnUserForm.TabIndex = 2;
            this.btnUserForm.Text = "Add User";
            this.btnUserForm.Click += new System.EventHandler(this.btnUserForm_Click);
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 652);
            this.Controls.Add(this.BackgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            this.Shown += new System.EventHandler(this.UserManagementForm_Shown);
            this.BackgroundPanel.ResumeLayout(false);
            this.UserManagementPanel.ResumeLayout(false);
            this.rolesTablePanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel BackgroundPanel;
        private Guna.UI2.WinForms.Guna2Panel UserManagementPanel;
        private Guna.UI2.WinForms.Guna2Panel rolesTablePanel;
        private Guna.UI2.WinForms.Guna2GradientPanel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private Guna.UI2.WinForms.Guna2Button btnUserForm;
        private System.Windows.Forms.FlowLayoutPanel flowUsers;
        private Guna.UI2.WinForms.Guna2Panel TableHeaderPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}