using HotelReservation.Businesslogic.Controller;
using HotelReservation.UI.FrontDesk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelReservation.UI.Admin
{
    public partial class frmAdminBillingRecords : Form
    {
        public frmAdminBillingRecords()
        {
            InitializeComponent();
        }
        private const string DateTimeFormat = "MM/dd/yyyy hh:mm tt";
        private const string StatusCheckedOut = "Checked-Out";

        private DataTable records;

        private void frmFrontBillingRecord_Load(object sender, EventArgs e)
        {
            LoadBillingRecords();
        }

        private void LoadBillingRecords()
        {
            ReservationController controller = new ReservationController();
            records = controller.GetBillingRecords();

            // The most recent check-outs are shown first
            records.DefaultView.Sort = "CheckedOutAt DESC";
            dgvCheckOut.DataSource = records.DefaultView;

            // Read-only grid
            dgvCheckOut.ReadOnly = true;
            dgvCheckOut.AllowUserToAddRows = false;
            dgvCheckOut.AllowUserToDeleteRows = false;
            dgvCheckOut.AllowUserToResizeRows = false;
            dgvCheckOut.MultiSelect = false;
            dgvCheckOut.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCheckOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Only these 4 columns are shown. The others stay in the data for later.
            string[] shown = { "GuestName", "PhoneNumber", "CheckInDate", "CheckOutDate" };

            foreach (DataGridViewColumn column in dgvCheckOut.Columns)
                column.Visible = shown.Contains(column.Name);

            dgvCheckOut.Columns["GuestName"].HeaderText = "Guest Name";
            dgvCheckOut.Columns["PhoneNumber"].HeaderText = "Phone Number";
            dgvCheckOut.Columns["CheckInDate"].HeaderText = "Check-In Date";
            dgvCheckOut.Columns["CheckOutDate"].HeaderText = "Check-Out Date";

            dgvCheckOut.Columns["CheckInDate"].DefaultCellStyle.Format = DateTimeFormat;
            dgvCheckOut.Columns["CheckOutDate"].DefaultCellStyle.Format = DateTimeFormat;

            ApplyRecordFilter();
        }

        // Shows only Checked-Out, and also applies the search text
        private void ApplyRecordFilter()
        {
            if (records == null)
                return;

            string filter = $"Status = '{StatusCheckedOut}'";

            string search = EscapeFilter(txtSearch.Text);

            if (search.Length > 0)
            {
                filter += " AND (" +
                          $"GuestName LIKE '%{search}%' OR " +
                          $"PhoneNumber LIKE '%{search}%' OR " +
                          $"ReservationNumber LIKE '%{search}%')";
            }

            records.DefaultView.RowFilter = filter;

            // Count of all the guests who checked out
            lblTotalCheckOut.Text = records.Select($"Status = '{StatusCheckedOut}'").Length.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyRecordFilter();
        }

        // Makes the search text safe for DataView.RowFilter
        private static string EscapeFilter(string text)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach (char c in text.Trim())
            {
                switch (c)
                {
                    case '\'':
                        sb.Append("''");
                        break;
                    case '[':
                    case ']':
                    case '%':
                    case '*':
                        sb.Append('[').Append(c).Append(']');
                        break;
                    default:
                        sb.Append(c);
                        break;
                }
            }

            return sb.ToString();
        }

        // =====================================================
        //  PRINT RECEIPT
        // =====================================================
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvCheckOut.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a guest first.", "Guest Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvCheckOut.SelectedRows[0];

            string guest = row.Cells["GuestName"].Value.ToString();
            string number = row.Cells["ReservationNumber"].Value.ToString();

            // Confirmation first
            DialogResult confirm = MessageBox.Show(
                $"Print the receipt of {guest}?\n\nReservation: {number}",
                "Print Receipt",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            int nights = Convert.ToInt32(row.Cells["TotalNights"].Value);
            decimal totalCharges = Convert.ToDecimal(row.Cells["TotalPrice"].Value);

            ReceiptData data = new ReceiptData
            {
                ReservationNumber = number,
                GuestName = guest,
                PhoneNumber = row.Cells["PhoneNumber"].Value.ToString(),
                RoomNumber = row.Cells["RoomNumber"].Value.ToString(),
                RoomType = row.Cells["RoomTypeName"].Value.ToString(),
                CheckIn = Convert.ToDateTime(row.Cells["CheckInDate"].Value),
                CheckOut = Convert.ToDateTime(row.Cells["CheckOutDate"].Value),
                CheckedInAt = Convert.ToDateTime(row.Cells["CheckedInAt"].Value),
                CheckedOutAt = Convert.ToDateTime(row.Cells["CheckedOutAt"].Value),
                Nights = nights,
                Rate = nights > 0 ? totalCharges / nights : 0,
                TotalCharges = totalCharges,
                Paid = Convert.ToDecimal(row.Cells["Paid"].Value),
                Balance = Convert.ToDecimal(row.Cells["Balance"].Value)
            };

            try
            {
                ReceiptPrinter.Show(this, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvGuestsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCheckOut.Columns[e.ColumnIndex].Name == "PhoneNumber"
                && e.Value != null)
            {
                e.Value = "(+63) " + e.Value.ToString();
                e.FormattingApplied = true;
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            frmAdminGuest adminGuest = new frmAdminGuest();
            adminGuest.Show();
            this.Hide();
        }
        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmRoomManagement adminRoom = new frmRoomManagement();
            adminRoom.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard adminDashboard = new frmAdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to log out?",
            "Log Out",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void btnReserved_Click(object sender, EventArgs e)
        {
            frmAdminReserved adminReserved = new frmAdminReserved();
            adminReserved.Show();
            this.Hide();
        }
    }
}
