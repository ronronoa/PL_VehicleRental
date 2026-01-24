using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PL_VehicleRental.Classes
{
    internal class DataGridViewStyle
    {
        public static void ApplyStandard(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = true;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.Dock = DockStyle.Fill;

            dgv.ColumnHeadersHeight = 40;
            dgv.RowTemplate.Height = 35;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(63, 92, 136);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 235, 245);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.LightGray;
        }
    }
}
