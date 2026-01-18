namespace PL_VehicleRental
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnFullWindow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.userBtn = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pageLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(1220, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(52, 43);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnFullWindow
            // 
            this.btnFullWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullWindow.Location = new System.Drawing.Point(1278, 11);
            this.btnFullWindow.Name = "btnFullWindow";
            this.btnFullWindow.Size = new System.Drawing.Size(52, 43);
            this.btnFullWindow.TabIndex = 1;
            this.btnFullWindow.Text = "❐";
            this.btnFullWindow.UseVisualStyleBackColor = true;
            this.btnFullWindow.Click += new System.EventHandler(this.btnFullWindow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1336, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 43);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.userBtn);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 114);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(267, 658);
            this.guna2Panel1.TabIndex = 3;
            // 
            // userBtn
            // 
            this.userBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.White;
            this.userBtn.Image = ((System.Drawing.Image)(resources.GetObject("userBtn.Image")));
            this.userBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.userBtn.Location = new System.Drawing.Point(3, 6);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(261, 73);
            this.userBtn.TabIndex = 4;
            this.userBtn.Text = "Users";
            this.userBtn.Click += new System.EventHandler(this.Test1Btn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BorderColor = System.Drawing.Color.Gray;
            this.mainPanel.Location = new System.Drawing.Point(273, 87);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1117, 685);
            this.mainPanel.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.pageLabel);
            this.guna2Panel2.Controls.Add(this.btnMinimize);
            this.guna2Panel2.Controls.Add(this.btnFullWindow);
            this.guna2Panel2.Controls.Add(this.btnExit);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1391, 80);
            this.guna2Panel2.TabIndex = 5;
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageLabel.Location = new System.Drawing.Point(267, 9);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(79, 31);
            this.pageLabel.TabIndex = 3;
            this.pageLabel.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 115);
            this.panel1.TabIndex = 6;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(3, 85);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(261, 73);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Add User";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 772);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnFullWindow;
        private System.Windows.Forms.Button btnExit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button userBtn;
        private Guna.UI2.WinForms.Guna2GradientPanel mainPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

