using PL_VehicleRental.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace PL_VehicleRental
{
    public partial class Form1 : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        private Form ActiveForm;

        private void Form1_Load(object sender, EventArgs e)
        {
            ActivateButton(sender, FormPageTitles.Test);
            LoadForm(new UserManagementForm());

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connected Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }

        }

        public static class Theme
        {
            public static readonly Color Primary = Color.FromArgb(71, 108, 255);
            public static readonly Color Secondary = Color.FromArgb(44, 44, 44);
            public static readonly Color SecondaryText = Color.Gray;
        }

        public static class FormPageTitles
        {
            public const string Test = "Users";
        }
        
        private void LoadForm(Form childForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            mainPanel.Controls.Clear();
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object senderBtn, string pageTitle)
        {
            if(senderBtn != null)
            {
                pageLabel.Text = pageTitle;

            }
        }


       
        public Form1()
        {
            InitializeComponent();
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFullWindow_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Test1Btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, FormPageTitles.Test);
            LoadForm(new UserManagementForm());
        }

        private void sideBarPanel_Paint(object sender, PaintEventArgs e)
        {
            int borderWidth = 2;
            Color borderColor = Color.Gray;

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                int x = sideBarPanel.Width - borderWidth;
                e.Graphics.DrawLine(pen, x, 0, x, sideBarPanel.Height);
            }
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {
            int borderHeight = 1;
            Color borderColor = Color.Gray;

            using (Pen pen = new Pen(borderColor, borderHeight))
            {
                int y = headerPanel.Height - borderHeight;
                e.Graphics.DrawLine(pen, 0, y, headerPanel.Width, y);
            }
        }
    }
}
