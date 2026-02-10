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
        public ucItemControl(UserInfoDto user)
        {
            InitializeComponent();
            UserId = user.Id;

            lblUsername.Text = user.UserName;
            lblFullName.Text = user.FullName;
            lblRole.Text = user.Role;
            setStatus(user.Status);
        }

        private void setStatus(string status)
        {
            lblStatus.Text = status;

            switch(status)
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

        private void ucItemControl_Load(object sender, EventArgs e)
        {

        }
    }
}
