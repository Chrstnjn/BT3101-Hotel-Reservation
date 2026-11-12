using HotelReservation.Businesslogic.Controller;
using System.Data;

namespace HotelReservation.UI.FrontDesk
{
    public partial class frmCheckOut : Form
    {
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private const string DateTimeFormat = "MM/dd/yyyy hh:mm tt";
        private const string PesoFormat = "₱#,##0.00";

        private DataTable checkOuts;

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            LoadCheckOuts();
        }

        private void LoadCheckOuts()
        {
            ReservationController controller = new ReservationController();
            checkOuts = controller.GetCheckOuts();

            // The guests who leave first are shown first
            dgvCheckOut.DataSource = checkOuts.DefaultView;

            // Read-only grid
            dgvCheckOut.ReadOnly = true;
            dgvCheckOut.AllowUserToAddRows = false;
            dgvCheckOut.AllowUserToDeleteRows = false;
            dgvCheckOut.AllowUserToResizeRows = false;
            dgvCheckOut.MultiSelect = false;
            dgvCheckOut.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Hidden columns (the data is still there for the menu)
            dgvCheckOut.Columns["ReservationID"].Visible = false;
            dgvCheckOut.Columns["TotalPrice"].Visible = false;
            dgvCheckOut.Columns["CheckedInAt"].Visible = false;

            dgvCheckOut.Columns["ReservationNumber"].HeaderText = "Reservation Number";
            dgvCheckOut.Columns["GuestName"].HeaderText = "Guest Name";
            dgvCheckOut.Columns["PhoneNumber"].HeaderText = "Phone Number";
            dgvCheckOut.Columns["RoomNumber"].HeaderText = "Room Number";
            dgvCheckOut.Columns["RoomTypeName"].HeaderText = "Room Type";
            dgvCheckOut.Columns["CheckInDate"].HeaderText = "Check-In Date";
            dgvCheckOut.Columns["CheckOutDate"].HeaderText = "Check-Out Date";
            dgvCheckOut.Columns["TotalNights"].HeaderText = "Total Night(s)";
            dgvCheckOut.Columns["Paid"].HeaderText = "Paid";
            dgvCheckOut.Columns["Balance"].HeaderText = "Balance";
            dgvCheckOut.Columns["Status"].HeaderText = "Status";

            dgvCheckOut.Columns["CheckInDate"].DefaultCellStyle.Format = DateTimeFormat;
            dgvCheckOut.Columns["CheckOutDate"].DefaultCellStyle.Format = DateTimeFormat;
            dgvCheckOut.Columns["Paid"].DefaultCellStyle.Format = PesoFormat;
            dgvCheckOut.Columns["Balance"].DefaultCellStyle.Format = PesoFormat;

            ApplyCheckOutFilter();
        }

        private void ApplyCheckOutFilter()
        {
            if (checkOuts == null)
                return;

            string search = EscapeFilter(txtSearch.Text);

            checkOuts.DefaultView.RowFilter = search.Length == 0
                ? ""
                : $"ReservationNumber LIKE '%{search}%' OR " +
                  $"GuestName LIKE '%{search}%' OR " +
                  $"PhoneNumber LIKE '%{search}%' OR " +
                  $"Convert(RoomNumber, 'System.String') LIKE '%{search}%' OR " +
                  $"RoomTypeName LIKE '%{search}%'";

            // Count of all guests who are still checked in
            lblPendingCheckOut.Text = checkOuts.Rows.Count.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyCheckOutFilter();
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
        private void dgvCheckOut_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.RowIndex < 0)
                return;

            dgvCheckOut.ClearSelection();
            dgvCheckOut.Rows[e.RowIndex].Selected = true;

            if (e.ColumnIndex >= 0)
                dgvCheckOut.CurrentCell = dgvCheckOut.Rows[e.RowIndex].Cells[e.ColumnIndex];

            contextMenuStrip1.Show(Cursor.Position);
        }

        // =====================================================
        //  PROCESS CHECK-OUT
        // =====================================================
        private void processCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCheckOut.CurrentRow == null)
                return;

            DataGridViewRow row = dgvCheckOut.CurrentRow;

            int reservationId = Convert.ToInt32(row.Cells["ReservationID"].Value);
            string number = row.Cells["ReservationNumber"].Value.ToString();
            string guest = row.Cells["GuestName"].Value.ToString();
            string room = row.Cells["RoomNumber"].Value.ToString();
            decimal balance = Convert.ToDecimal(row.Cells["Balance"].Value);


            if (balance > 0)
            {
                MessageBox.Show(
                    $"{guest} still has a balance of {balance.ToString(PesoFormat)}.\n\n" +
                    "Please process the billing first.",
                    "Balance Not Paid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Check out {guest}?\n\nReservation: {number}\nRoom: {room}",
                "Confirm Check-Out",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            // Copy the data NOW, because the guest leaves the grid after check-out
            int nights = Convert.ToInt32(row.Cells["TotalNights"].Value);
            decimal totalCharges = Convert.ToDecimal(row.Cells["TotalPrice"].Value);

            ReceiptData receiptData = new ReceiptData
            {
                ReservationNumber = number,
                GuestName = guest,
                PhoneNumber = row.Cells["PhoneNumber"].Value.ToString(),
                RoomNumber = room,
                RoomType = row.Cells["RoomTypeName"].Value.ToString(),
                CheckIn = Convert.ToDateTime(row.Cells["CheckInDate"].Value),
                CheckOut = Convert.ToDateTime(row.Cells["CheckOutDate"].Value),
                Nights = nights,
                Rate = nights > 0 ? totalCharges / nights : 0,
                TotalCharges = totalCharges,
                Paid = Convert.ToDecimal(row.Cells["Paid"].Value),
                Balance = balance,
                CheckedInAt = Convert.ToDateTime(row.Cells["CheckedInAt"].Value),
                CheckedOutAt = DateTime.Now

            };

            try
            {
                ReservationController controller = new ReservationController();
                controller.CheckOutReservation(reservationId);

                MessageBox.Show($"{guest} is now checked out of room {room}.", "Check-Out Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ReceiptPrinter.Show(this, receiptData);

                LoadCheckOuts();            // the guest leaves this list
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Phone number format
        private void dgvCheckIn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCheckOut.Columns[e.ColumnIndex].Name == "PhoneNumber"
                && e.Value != null)
            {
                e.Value = "(+63) " + e.Value.ToString();
                e.FormattingApplied = true;
            }
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

        private void btnBilling_Click(object sender, EventArgs e)
        {
            frmBillingPayment formBillingPayment = new frmBillingPayment();
            formBillingPayment.Show();
            this.Hide();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            frmFrontBillingRecord formFrontBillingRecord = new frmFrontBillingRecord();
            formFrontBillingRecord.Show();
            this.Hide();
        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            frmCheckIn frontCheckIn = new frmCheckIn();
            frontCheckIn.Show();
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
    }
}
