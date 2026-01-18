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

namespace PL_VehicleRental
{
    public partial class Form1 : Form
    {
        private Form ActiveForm;

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
        
        private void OpenForm(Form childForm)
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

        private void OpenForm()
        {
            
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnFullWindow.Text = "❐"; 
            }
            else
            {
                btnFullWindow.Text = "☐";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Test1Btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, FormPageTitles.Test);
            OpenForm(new Test1());
        }
    }
}
