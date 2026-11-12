using HotelReservation.Businesslogic.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;

namespace HotelReservation.UI.Admin
{
    public partial class frmAdminReserved : Form
    {
        private const string DateTimeFormat = "MM/dd/yyyy hh:mm tt";
        public frmAdminReserved()
        {
            InitializeComponent();
        }
        //  RECENTLY BOOKED (Reserved, Checked-In, Checked-Out)
        // =====================================================
        private void LoadRecentBooked()
        {
            ReservationController controller = new ReservationController();
            DataTable dt = controller.GetRecentActivity();

            dt.DefaultView.RowFilter = "Status IN ('Reserved', 'Checked-In')";
            dgvBooked.DataSource = dt.DefaultView;

            dgvBooked.ReadOnly = true;
            dgvBooked.AllowUserToAddRows = false;
            dgvBooked.AllowUserToDeleteRows = false;
            dgvBooked.AllowUserToResizeRows = false;
            dgvBooked.MultiSelect = false;
            dgvBooked.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooked.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvBooked.Columns["ReservationID"].Visible = false;

            dgvBooked.Columns["GuestName"].HeaderText = "Guest Name";
            dgvBooked.Columns["RoomNumber"].HeaderText = "Room No.";
            dgvBooked.Columns["RoomTypeName"].HeaderText = "Room Type";
            dgvBooked.Columns["Status"].HeaderText = "Status";
            dgvBooked.Columns["ActivityDate"].HeaderText = "Date & Time";

            dgvBooked.Columns["ActivityDate"].DefaultCellStyle.Format = DateTimeFormat;

            // Orange for Reserved, green for Checked-In, blue for Checked-Out
            foreach (DataGridViewRow row in dgvBooked.Rows)
            {
                string status = row.Cells["Status"].Value?.ToString();

                row.Cells["Status"].Style.ForeColor = status switch
                {
                    "Reserved" => Color.DarkOrange,
                    "Checked-In" => Color.Green
                };
            }

            dgvBooked.ClearSelection();
        }

        private void frmAdminReserved_Load(object sender, EventArgs e)
        {
            LoadRecentBooked();
            LoadTotal();
        }
        private void LoadTotal()
        {
            ReservationController controller = new ReservationController();

            //booked
            DataTable reservations = controller.GetReservations();
            int CReserved = Convert.ToInt32(reservations.Select("Status = 'Reserved'").Length.ToString());
            int CCheckIn = Convert.ToInt32(reservations.Select("Status = 'Checked-In'").Length.ToString());
            int totalBooked = CReserved + CCheckIn;
            lblTotalBooked.Text = totalBooked.ToString();
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

        private void btnGuest_Click(object sender, EventArgs e)
        {
            frmAdminGuest adminGuest = new frmAdminGuest();
            adminGuest.Show();
            this.Hide();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            frmAdminBillingRecords adminBillingRecords = new frmAdminBillingRecords();
            adminBillingRecords.Show();
            this.Hide();
        }
    }
}
