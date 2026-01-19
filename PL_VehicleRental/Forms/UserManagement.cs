using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_VehicleRental.Forms
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            headerSeparator.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            headerSeparator.FillThickness = 2;
        }
    }
}
