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
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUserForm = new Guna.UI2.WinForms.Guna2Button();
            this.rolesTablePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvRolesPermission = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BackgroundPanel.SuspendLayout();
            this.UserManagementPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.rolesTablePanel.SuspendLayout();
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
            this.UserManagementPanel.Controls.Add(this.rolesTablePanel);
            this.UserManagementPanel.Controls.Add(this.headerPanel);
            this.UserManagementPanel.Location = new System.Drawing.Point(14, 15);
            this.UserManagementPanel.Name = "UserManagementPanel";
            this.UserManagementPanel.Padding = new System.Windows.Forms.Padding(10);
            this.UserManagementPanel.Size = new System.Drawing.Size(1300, 747);
            this.UserManagementPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BorderColor = System.Drawing.Color.Silver;
            this.headerPanel.BorderRadius = 10;
            this.headerPanel.BorderThickness = 2;
            this.headerPanel.Controls.Add(this.btnUserForm);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(10, 10);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1280, 91);
            this.headerPanel.TabIndex = 0;
            // 
            // btnUserForm
            // 
            this.btnUserForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserForm.BorderColor = System.Drawing.Color.Silver;
            this.btnUserForm.BorderRadius = 10;
            this.btnUserForm.BorderThickness = 2;
            this.btnUserForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUserForm.ForeColor = System.Drawing.Color.White;
            this.btnUserForm.Location = new System.Drawing.Point(1051, 23);
            this.btnUserForm.Name = "btnUserForm";
            this.btnUserForm.Size = new System.Drawing.Size(202, 45);
            this.btnUserForm.TabIndex = 0;
            this.btnUserForm.Text = "+ Add User";
            this.btnUserForm.Click += new System.EventHandler(this.btnUserForm_Click);
            // 
            // rolesTablePanel
            // 
            this.rolesTablePanel.Controls.Add(this.dgvRolesPermission);
            this.rolesTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesTablePanel.Location = new System.Drawing.Point(10, 101);
            this.rolesTablePanel.Name = "rolesTablePanel";
            this.rolesTablePanel.Size = new System.Drawing.Size(1280, 636);
            this.rolesTablePanel.TabIndex = 1;
            // 
            // dgvRolesPermission
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvRolesPermission.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRolesPermission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvRolesPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRolesPermission.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvRolesPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRolesPermission.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRolesPermission.Location = new System.Drawing.Point(0, 0);
            this.dgvRolesPermission.Name = "dgvRolesPermission";
            this.dgvRolesPermission.RowHeadersVisible = false;
            this.dgvRolesPermission.RowHeadersWidth = 51;
            this.dgvRolesPermission.RowTemplate.Height = 24;
            this.dgvRolesPermission.Size = new System.Drawing.Size(1280, 636);
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
            this.dgvRolesPermission.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRolesPermission.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRolesPermission.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolesPermission.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvRolesPermission.ThemeStyle.ReadOnly = false;
            this.dgvRolesPermission.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRolesPermission.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRolesPermission.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRolesPermission.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRolesPermission.ThemeStyle.RowsStyle.Height = 24;
            this.dgvRolesPermission.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRolesPermission.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.headerPanel.ResumeLayout(false);
            this.rolesTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesPermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel BackgroundPanel;
        private Guna.UI2.WinForms.Guna2Panel UserManagementPanel;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2Button btnUserForm;
        private Guna.UI2.WinForms.Guna2Panel rolesTablePanel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRolesPermission;
    }
}