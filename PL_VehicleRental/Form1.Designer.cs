namespace PL_VehicleRental
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sideBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.userBtn = new Guna.UI2.WinForms.Guna2Button();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.pageLabel = new System.Windows.Forms.Label();
            this.userLabelsHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblloggedInUser = new System.Windows.Forms.Label();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.sideBarPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.userLabelsHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.Lavender;
            this.sideBarPanel.BorderColor = System.Drawing.Color.Gray;
            this.sideBarPanel.Controls.Add(this.guna2Button1);
            this.sideBarPanel.Controls.Add(this.userBtn);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 80);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(267, 692);
            this.sideBarPanel.TabIndex = 3;
            this.sideBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBarPanel_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(21, 151);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(221, 59);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Logout";
            // 
            // userBtn
            // 
            this.userBtn.BackColor = System.Drawing.Color.Transparent;
            this.userBtn.BorderRadius = 2;
            this.userBtn.BorderThickness = 1;
            this.userBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userBtn.FillColor = System.Drawing.Color.Transparent;
            this.userBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.Black;
            this.userBtn.Image = ((System.Drawing.Image)(resources.GetObject("userBtn.Image")));
            this.userBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.userBtn.Location = new System.Drawing.Point(21, 86);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(221, 59);
            this.userBtn.TabIndex = 4;
            this.userBtn.Text = "Users";
            this.userBtn.Click += new System.EventHandler(this.Test1Btn_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Lavender;
            this.headerPanel.BorderColor = System.Drawing.Color.Gray;
            this.headerPanel.Controls.Add(this.guna2VSeparator1);
            this.headerPanel.Controls.Add(this.pageLabel);
            this.headerPanel.Controls.Add(this.userLabelsHeader);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.headerPanel.Size = new System.Drawing.Size(1391, 80);
            this.headerPanel.TabIndex = 5;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Gray;
            this.guna2VSeparator1.FillThickness = 2;
            this.guna2VSeparator1.Location = new System.Drawing.Point(258, 9);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 71);
            this.guna2VSeparator1.TabIndex = 0;
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageLabel.Location = new System.Drawing.Point(284, 22);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(191, 45);
            this.pageLabel.TabIndex = 3;
            this.pageLabel.Text = "Form Label";
            // 
            // userLabelsHeader
            // 
            this.userLabelsHeader.Controls.Add(this.guna2Shapes1);
            this.userLabelsHeader.Controls.Add(this.lblRole);
            this.userLabelsHeader.Controls.Add(this.lblloggedInUser);
            this.userLabelsHeader.Dock = System.Windows.Forms.DockStyle.Right;
            this.userLabelsHeader.Location = new System.Drawing.Point(1181, 0);
            this.userLabelsHeader.Name = "userLabelsHeader";
            this.userLabelsHeader.Size = new System.Drawing.Size(200, 80);
            this.userLabelsHeader.TabIndex = 6;
            this.userLabelsHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.userLabelsHeader_Paint);
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.LineEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2Shapes1.LineStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2Shapes1.Location = new System.Drawing.Point(115, 5);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSides = 100;
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Size = new System.Drawing.Size(73, 62);
            this.guna2Shapes1.TabIndex = 0;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(27, 50);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(49, 17);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Admin";
            // 
            // lblloggedInUser
            // 
            this.lblloggedInUser.AutoSize = true;
            this.lblloggedInUser.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloggedInUser.Location = new System.Drawing.Point(27, 33);
            this.lblloggedInUser.Name = "lblloggedInUser";
            this.lblloggedInUser.Size = new System.Drawing.Size(67, 17);
            this.lblloggedInUser.TabIndex = 4;
            this.lblloggedInUser.Text = "John Doe";
            // 
            // mainPanel
            // 
            this.mainPanel.BorderColor = System.Drawing.Color.Black;
            this.mainPanel.BorderRadius = 2;
            this.mainPanel.BorderThickness = 2;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(267, 80);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1124, 692);
            this.mainPanel.TabIndex = 6;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 772);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sideBarPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideBarPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.userLabelsHeader.ResumeLayout(false);
            this.userLabelsHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel sideBarPanel;
        private Guna.UI2.WinForms.Guna2Button userBtn;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private System.Windows.Forms.Label pageLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Label lblloggedInUser;
        private System.Windows.Forms.Label lblRole;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2Panel userLabelsHeader;
    }
}

