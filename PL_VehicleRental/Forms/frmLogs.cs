using PL_VehicleRental.Services;
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
    public partial class frmLogs : Form
    {
        public frmLogs()
        {
            InitializeComponent();
        }

        private void dgvLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async Task LoadLogs()
        {
            var service = new AuditService();
            var logs = await service.GetAuditLogsAsync();

            dgvLogs.DataSource = logs;
        }

        private async void frmLogs_Load(object sender, EventArgs e)
        {
            await LoadLogs();
        }
    }
}
