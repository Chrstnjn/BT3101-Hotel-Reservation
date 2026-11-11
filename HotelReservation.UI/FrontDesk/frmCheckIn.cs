using HotelReservation.Businesslogic.Controller;
using System.Data;

namespace HotelReservation.UI.FrontDesk
{
    public partial class frmCheckIn : Form
    {
        public frmCheckIn()
        {
            InitializeComponent();
        }
        private const string DateTimeFormat = "MM/dd/yyyy hh:mm tt";
        private const string StatusAwaiting = "Awaiting Check-In";

        private DataTable reservations;
        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            LoadAwaitingCheckIns();
        }

        private void LoadAwaitingCheckIns()
        {
            ReservationController controller = new ReservationController();
            reservations = controller.GetReservations();

            // The guests who arrive first are shown first
            reservations.DefaultView.Sort = "CheckInDate ASC";
            dgvCheckIn.DataSource = reservations.DefaultView;

            // Read-only grid
            dgvCheckIn.ReadOnly = true;
            dgvCheckIn.AllowUserToAddRows = false;
            dgvCheckIn.AllowUserToDeleteRows = false;
            dgvCheckIn.AllowUserToResizeRows = false;
            dgvCheckIn.MultiSelect = false;
            dgvCheckIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Hidden columns (the data is still there for later)
            dgvCheckIn.Columns["ReservationID"].Visible = false;
            dgvCheckIn.Columns["GuestID"].Visible = false;
            dgvCheckIn.Columns["RoomID"].Visible = false;
            dgvCheckIn.Columns["RatePerNight"].Visible = false;
            dgvCheckIn.Columns["Status"].Visible = false;
            dgvCheckIn.Columns["NumberOfGuests"].Visible = false;
            dgvCheckIn.Columns["TotalPrice"].Visible = false;

            dgvCheckIn.Columns["ReservationNumber"].HeaderText = "Reservation Number";
            dgvCheckIn.Columns["GuestName"].HeaderText = "Guest Name";
            dgvCheckIn.Columns["PhoneNumber"].HeaderText = "Phone Number";
            dgvCheckIn.Columns["PhoneNumber"].DisplayIndex = dgvCheckIn.Columns["GuestName"].DisplayIndex + 1;
            dgvCheckIn.Columns["RoomNumber"].HeaderText = "Room Number";
            dgvCheckIn.Columns["RoomTypeName"].HeaderText = "Room Type";
            dgvCheckIn.Columns["CheckInDate"].HeaderText = "Check-In Date";
            dgvCheckIn.Columns["CheckOutDate"].HeaderText = "Check-Out Date";
            dgvCheckIn.Columns["TotalNights"].HeaderText = "Total Night(s)";

            dgvCheckIn.Columns["CheckInDate"].DefaultCellStyle.Format = DateTimeFormat;
            dgvCheckIn.Columns["CheckOutDate"].DefaultCellStyle.Format = DateTimeFormat;

            ApplyCheckInFilter();
        }
        //Phone number format
        private void dgvCheckIn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCheckIn.Columns[e.ColumnIndex].Name == "PhoneNumber"
                && e.Value != null)
            {
                e.Value = "(+63) " + e.Value.ToString();
                e.FormattingApplied = true;
            }
        }

        // Shows only Awaiting Check-In, and also applies the search text
        private void ApplyCheckInFilter()
        {
            if (reservations == null)
                return;

            string filter = $"Status = '{StatusAwaiting}'";

            string search = EscapeFilter(txtSearch.Text);

            if (search.Length > 0)
            {
                filter += " AND (" +
                          $"ReservationNumber LIKE '%{search}%' OR " +
                          $"GuestName LIKE '%{search}%' OR " +
                          $"PhoneNumber LIKE '%{search}%' OR " +
                          $"Convert(RoomNumber, 'System.String') LIKE '%{search}%' OR " +
                          $"RoomTypeName LIKE '%{search}%')";
            }

            reservations.DefaultView.RowFilter = filter;

            // Count of all guests who are waiting to check in
            int total = reservations.Select($"Status = '{StatusAwaiting}'").Length;
            lblAwaitingCount.Text = total.ToString();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyCheckInFilter();
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
        //  RIGHT-CLICK MENU
        // =====================================================
        private void dgvCheckIn_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Only a right-click on a data row (not the header)
            if (e.Button != MouseButtons.Right || e.RowIndex < 0)
                return;

            // Select the row that was clicked
            dgvCheckIn.ClearSelection();
            dgvCheckIn.Rows[e.RowIndex].Selected = true;

            if (e.ColumnIndex >= 0)
                dgvCheckIn.CurrentCell = dgvCheckIn.Rows[e.RowIndex].Cells[e.ColumnIndex];

            contextMenuStrip1.Show(Cursor.Position);
        }

        // =====================================================
        //  PROCESS CHECK-IN
        // =====================================================
        private void processCheckInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCheckIn.CurrentRow == null)
                return;

            DataGridViewRow row = dgvCheckIn.CurrentRow;

            int reservationId = Convert.ToInt32(row.Cells["ReservationID"].Value);
            string number = row.Cells["ReservationNumber"].Value.ToString();
            string guest = row.Cells["GuestName"].Value.ToString();
            string room = row.Cells["RoomNumber"].Value.ToString();
            DateTime arrival = Convert.ToDateTime(row.Cells["CheckInDate"].Value);

            string message =
                $"Check in {guest}?\n\n" +
                $"Reservation: {number}\n" +
                $"Room: {room}\n" +
                $"Check-Out: {Convert.ToDateTime(row.Cells["CheckOutDate"].Value).ToString(DateTimeFormat)}";

            // The reservation is for another day
            if (arrival.Date > DateTime.Today)
                message += $"\n\nNote: the check-in date is {arrival:MM/dd/yyyy}, not today.";

            DialogResult confirm = MessageBox.Show(message, "Confirm Check-In",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                ReservationController controller = new ReservationController();
                controller.CheckInReservation(reservationId);

                MessageBox.Show($"{guest} is now checked in to room {room}.", "Check-In Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAwaitingCheckIns();   // the guest leaves this list
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        //  CANCEL RESERVATION
        // =====================================================
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCheckIn.CurrentRow == null)
                return;

            DataGridViewRow row = dgvCheckIn.CurrentRow;

            int reservationId = Convert.ToInt32(row.Cells["ReservationID"].Value);
            string number = row.Cells["ReservationNumber"].Value.ToString();
            string guest = row.Cells["GuestName"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Cancel reservation {number} of {guest}?\n\nThe room will be available again.",
                "Cancel Reservation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                ReservationController controller = new ReservationController();
                controller.CancelReservation(reservationId);

                MessageBox.Show("The reservation was cancelled.", "Cancelled",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAwaitingCheckIns();   // the guest leaves this list
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmFrontDashboard formFrontDashboard = new frmFrontDashboard();
            formFrontDashboard.Show();
            this.Hide();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmRooms formRooms = new frmRooms();
            formRooms.Show();
            this.Hide();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            frmReservation formReservation = new frmReservation();
            formReservation.Show();
            this.Hide();
        }

        private void btnGuestManagement_Click(object sender, EventArgs e)
        {
            frmGuestManagement formGuestManagement = new frmGuestManagement();
            formGuestManagement.Show();
            this.Hide();
        }
    }
}
