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
            if (dgv == null) return;

            dgv.AutoGenerateColumns = true;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.Dock = DockStyle.Fill;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;

            dgv.ColumnHeadersHeight = 40;
            dgv.RowTemplate.Height = 35;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(63, 92, 136);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 235, 245);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.LightGray;

            dgv.CellFormatting += DataGridView_CellFormatting;

            dgv.DataBindingComplete += DataGridView_DataBindingComplete;
        }

        private static void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null || e.RowIndex < 0) return;

            if (dgv.Columns[e.ColumnIndex].HeaderText.Equals("Status", StringComparison.OrdinalIgnoreCase) ||
                dgv.Columns[e.ColumnIndex].Name.Equals("Status", StringComparison.OrdinalIgnoreCase))
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString().Trim();

                    if (status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.BackColor = Color.FromArgb(223, 240, 216); // Light green
                        e.CellStyle.ForeColor = Color.FromArgb(60, 118, 61);    // Dark green text
                        e.CellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
                        e.CellStyle.SelectionBackColor = Color.FromArgb(200, 220, 200); // Green selection
                        e.CellStyle.SelectionForeColor = Color.FromArgb(60, 118, 61);
                    }
                    else if (status.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.BackColor = Color.FromArgb(255, 243, 205); // Light yellow
                        e.CellStyle.ForeColor = Color.FromArgb(133, 100, 4);   // Dark yellow/brown text
                        e.CellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
                        e.CellStyle.SelectionBackColor = Color.FromArgb(255, 230, 180); // Yellow selection
                        e.CellStyle.SelectionForeColor = Color.FromArgb(133, 100, 4);
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.FromArgb(255, 0, 0); // Red
                        e.CellStyle.ForeColor = Color.FromArgb(255, 160, 122);   // Crimson
                        e.CellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
                        e.CellStyle.SelectionBackColor = Color.FromArgb(139, 0, 0); // Yellow selection
                        e.CellStyle.SelectionForeColor = Color.FromArgb(255, 160, 122);
                    }

                        e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }
        private static void DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null) return;

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.HeaderText.Equals("Status", StringComparison.OrdinalIgnoreCase) ||
                    column.Name.Equals("Status", StringComparison.OrdinalIgnoreCase))
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.Width = 100;
                    break;
                }
            }
        }

        public static void ApplyStatusColoring(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.CellFormatting -= DataGridView_CellFormatting;

            dgv.CellFormatting += DataGridView_CellFormatting;

            dgv.Invalidate();
        }
    }
}
