using System.Drawing;
using System.Windows.Forms;

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
            this.pnlOverlay = new Guna.UI2.WinForms.Guna2Panel();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.flowUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.TableHeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.headerPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUserForm = new Guna.UI2.WinForms.Guna2Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.BackgroundPanel.SuspendLayout();
            this.UserManagementPanel.SuspendLayout();
            this.rolesTablePanel.SuspendLayout();
            this.pnlOverlay.SuspendLayout();
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
            this.BackgroundPanel.Location = new System.Drawing.Point(12, 12);
            this.BackgroundPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.UserManagementPanel.Controls.Add(this.rolesTablePanel);
            this.UserManagementPanel.Controls.Add(this.headerPanel);
            this.UserManagementPanel.Location = new System.Drawing.Point(13, 15);
            this.UserManagementPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserManagementPanel.Name = "UserManagementPanel";
            this.UserManagementPanel.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.UserManagementPanel.Size = new System.Drawing.Size(1300, 747);
            this.UserManagementPanel.TabIndex = 0;
            // 
            // rolesTablePanel
            // 
            this.rolesTablePanel.Controls.Add(this.pnlOverlay);
            this.rolesTablePanel.Controls.Add(this.flowUsers);
            this.rolesTablePanel.Controls.Add(this.TableHeaderPanel);
            this.rolesTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesTablePanel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolesTablePanel.Location = new System.Drawing.Point(11, 110);
            this.rolesTablePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rolesTablePanel.Name = "rolesTablePanel";
            this.rolesTablePanel.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.rolesTablePanel.Size = new System.Drawing.Size(1278, 627);
            this.rolesTablePanel.TabIndex = 1;
            // 
            // pnlOverlay
            // 
            this.pnlOverlay.Controls.Add(this.progressBar);
            this.pnlOverlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOverlay.Location = new System.Drawing.Point(11, 110);
            this.pnlOverlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOverlay.Name = "pnlOverlay";
            this.pnlOverlay.Size = new System.Drawing.Size(1256, 507);
            this.pnlOverlay.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BorderRadius = 5;
            this.progressBar.BorderThickness = 1;
            this.progressBar.Location = new System.Drawing.Point(276, 208);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(699, 14);
            this.progressBar.TabIndex = 0;
            this.progressBar.Text = "guna2ProgressBar1";
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progressBar.ValueChanged += new System.EventHandler(this.progressBar_ValueChanged);
            // 
            // flowUsers
            // 
            this.flowUsers.AutoScroll = true;
            this.flowUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowUsers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowUsers.Location = new System.Drawing.Point(11, 110);
            this.flowUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowUsers.Name = "flowUsers";
            this.flowUsers.Size = new System.Drawing.Size(1256, 507);
            this.flowUsers.TabIndex = 1;
            this.flowUsers.WrapContents = false;
            this.flowUsers.Resize += new System.EventHandler(this.flowUsers_Resize);
            // 
            // TableHeaderPanel
            // 
            this.TableHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableHeaderPanel.Location = new System.Drawing.Point(11, 10);
            this.TableHeaderPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableHeaderPanel.Name = "TableHeaderPanel";
            this.TableHeaderPanel.Size = new System.Drawing.Size(1256, 100);
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
            this.headerPanel.Location = new System.Drawing.Point(11, 10);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1278, 100);
            this.headerPanel.TabIndex = 1;
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
            this.txtSearch.Location = new System.Drawing.Point(735, 30);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search user...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(267, 44);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.btnUserForm.Location = new System.Drawing.Point(1047, 28);
            this.btnUserForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserForm.Name = "btnUserForm";
            this.btnUserForm.Size = new System.Drawing.Size(203, 46);
            this.btnUserForm.TabIndex = 2;
            this.btnUserForm.Text = "Add User";
            this.btnUserForm.Click += new System.EventHandler(this.btnUserForm_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(29, 28);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(250, 32);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "User Management";
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 802);
            this.Controls.Add(this.BackgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            this.Shown += new System.EventHandler(this.UserManagementForm_Shown);
            this.BackgroundPanel.ResumeLayout(false);
            this.UserManagementPanel.ResumeLayout(false);
            this.rolesTablePanel.ResumeLayout(false);
            this.pnlOverlay.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2Panel pnlOverlay;
    }
}