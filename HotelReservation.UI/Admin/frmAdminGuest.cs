using HotelReservation.Businesslogic.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelReservation.UI.Admin
{
    public partial class frmAdminGuest : Form
    {
        public frmAdminGuest()
        {
            InitializeComponent();
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard adminDashboard = new frmAdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmRoomManagement adminRoom = new frmRoomManagement();
            adminRoom.Show();
            this.Hide();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            frmAdminBillingRecords adminBillingRecords = new frmAdminBillingRecords();
            adminBillingRecords.Show();
            this.Hide();
        }

        private void btnReserved_Click(object sender, EventArgs e)
        {
            frmAdminReserved adminReserved = new frmAdminReserved();
            adminReserved.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvGuestsList.DataSource;

            if (dt == null)
                return;

            string searchText = txtSearch.Text.Trim();

            // Show all records when textbox is empty
            if (string.IsNullOrWhiteSpace(searchText) ||
                searchText == "Search for...")
            {
                dt.DefaultView.RowFilter = "";
                return;
            }

            dt.DefaultView.RowFilter =
           $"FirstName LIKE '%{searchText}%' OR " +
           $"LastName LIKE '%{searchText}%' OR " +
           $"PhoneNumber LIKE '%{searchText}%' OR " +
           $"StreetAddress LIKE '%{searchText}%' OR " +
           $"City LIKE '%{searchText}%' OR " +
           $"Province LIKE '%{searchText}%' OR " +
           $"Gender = '{searchText}'";
        }

        private void dgvGuestsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvGuestsList.Columns[e.ColumnIndex].Name == "PhoneNumber"
                && e.Value != null)
            {
                e.Value = "(+63) " + e.Value.ToString();
                e.FormattingApplied = true;
            }

            if (dgvGuestsList.Columns[e.ColumnIndex].Name == "EmergencyContactNumber"
            && e.Value != null)
            {
                e.Value = "(+63) " + e.Value.ToString();
                e.FormattingApplied = true;
            }
        }

        private void frmAdminGuest_Load(object sender, EventArgs e)
        {
            LoadGuests();
            RefreshGuest();
        }
        private void RefreshGuest()
        {
            GuestController guestController = new GuestController();
            dgvGuestsList.DataSource = guestController.GetGuests();
        }
        private void LoadGuests()
        {
            GuestController controller = new GuestController();

            dgvGuestsList.DataSource = controller.GetGuests();

            dgvGuestsList.Columns["GuestID"].Visible = false;

            lblTotalGuest.Text = "" + dgvGuestsList.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);

        }
    }
}
