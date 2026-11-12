using HotelReservation.Businesslogic.Controller;
using HotelReservation.Businesslogic.Repository;
using System.Data;

namespace HotelReservation.UI.FrontDesk
{
    public partial class frmFrontDashboard : Form
    {
        private const string PesoFormat = "₱#,##0.00";
        private const string DateTimeFormat = "MM/dd/yyyy hh:mm tt";

        public frmFrontDashboard()
        {
            InitializeComponent();
        }

        private void frmFrontDashboard_Load(object sender, EventArgs e)
        {
            LoadTotalGuests();
            LoadReservationCounts();
            LoadRecentActivity();

            // Available rooms start with today
            pnlDateAvailable.Visible = false;
            txtDateDisplay.Text = DateTime.Today.ToString("MM/dd/yyyy");
            LoadAvailableRooms(DateTime.Today);
        }

        // =====================================================
        //  CARDS
        // =====================================================
        private void LoadTotalGuests()
        {
            GuestRepository repo = new GuestRepository();

            lblTotalGuest.Text = repo.GetGuests().Rows.Count.ToString();
        }

        // Cards: Reservation, Check In, Check Out
        private void LoadReservationCounts()
        {
            ReservationController controller = new ReservationController();
            DataTable dt = controller.GetReservations();

            // Reservation = paid reservations that are waiting to check in
            lblTotalReservation.Text = dt.Select("Status = 'Reserved'").Length.ToString();
            lblTotalCheckIn.Text = dt.Select("Status = 'Checked-In'").Length.ToString();
            lblTotalCheckOut.Text = dt.Select("Status = 'Checked-Out'").Length.ToString();
        }

        // =====================================================
        //  RECENTLY RESERVE PANEL (only Checked-In and Checked-Out)
        // =====================================================
        private void LoadRecentActivity()
        {
            ReservationController controller = new ReservationController();
            DataTable dt = controller.GetRecentActivity();

            // Show only Reserved, Checked-In, Checked-Out
            DataView view = dt.DefaultView;
            view.RowFilter = "Status IN ('Reserved', 'Checked-In', 'Checked-Out')";

            // Get only latest 10 records
            DataTable recent10 = view.ToTable();

            if (recent10.Rows.Count > 10)
            {
                recent10 = recent10.AsEnumerable()
                                   .OrderByDescending(r => r.Field<DateTime>("ActivityDate"))
                                   .Take(10)
                                   .CopyToDataTable();
            }

            dgvRecentReserve.DataSource = recent10;

            dgvRecentReserve.ReadOnly = true;
            dgvRecentReserve.AllowUserToAddRows = false;
            dgvRecentReserve.AllowUserToDeleteRows = false;
            dgvRecentReserve.AllowUserToResizeRows = false;
            dgvRecentReserve.MultiSelect = false;
            dgvRecentReserve.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentReserve.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvRecentReserve.Columns["ReservationID"].Visible = false;

            dgvRecentReserve.Columns["GuestName"].HeaderText = "Guest Name";
            dgvRecentReserve.Columns["RoomNumber"].HeaderText = "Room No.";
            dgvRecentReserve.Columns["RoomTypeName"].HeaderText = "Room Type";
            dgvRecentReserve.Columns["Status"].HeaderText = "Status";
            dgvRecentReserve.Columns["ActivityDate"].HeaderText = "Date & Time";

            dgvRecentReserve.Columns["ActivityDate"].DefaultCellStyle.Format = DateTimeFormat;

            // Orange for Awaiting Check-In, green for Checked-In, blue for Checked-Out
            foreach (DataGridViewRow row in dgvRecentReserve.Rows)
            {
                string status = row.Cells["Status"].Value?.ToString();

                row.Cells["Status"].Style.ForeColor = status switch
                {
                    "Reserved" => Color.DarkOrange,
                    "Checked-In" => Color.Green,
                    "Checked-Out" => Color.IndianRed
                };
            }

            dgvRecentReserve.ClearSelection();
        }

        // =====================================================
        //  AVAILABLE ROOMS (for the chosen date)
        // =====================================================
        private void LoadAvailableRooms(DateTime date)
        {
            ReservationController controller = new ReservationController();
            DataTable dt = controller.GetAvailableRooms(date);

            dgvAvailableRoom.DataSource = dt;

            dgvAvailableRoom.ReadOnly = true;
            dgvAvailableRoom.AllowUserToAddRows = false;
            dgvAvailableRoom.AllowUserToDeleteRows = false;
            dgvAvailableRoom.AllowUserToResizeRows = false;
            dgvAvailableRoom.MultiSelect = false;
            dgvAvailableRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvAvailableRoom.Columns["RoomID"].Visible = false;

            dgvAvailableRoom.Columns["RoomNumber"].HeaderText = "Room No.";
            dgvAvailableRoom.Columns["RoomTypeName"].HeaderText = "Room Type";
            dgvAvailableRoom.Columns["NumberOfBeds"].HeaderText = "No. of Beds";
            dgvAvailableRoom.Columns["NumberOfPersons"].HeaderText = "Max Guests";
            dgvAvailableRoom.Columns["PricePerNight"].HeaderText = "Price/Night";

            dgvAvailableRoom.Columns["PricePerNight"].DefaultCellStyle.Format = PesoFormat;

            lblAvailRoom.Text = dt.Rows.Count.ToString();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            pnlDateAvailable.Visible = !pnlDateAvailable.Visible;

            if (pnlDateAvailable.Visible)
                pnlDateAvailable.BringToFront();   // so the grid does not cover it
        }

        // The user picks a date in the calendar
        private void monthCalendarDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDateDisplay.Text = e.Start.ToString("MM/dd/yyyy");
            pnlDateAvailable.Visible = false;

            LoadAvailableRooms(e.Start.Date);
        }

        // =====================================================
        //  NAVIGATION
        // =====================================================
        private void btnGuestManagement_Click(object sender, EventArgs e)
        {
            frmGuestManagement frontDashboard = new frmGuestManagement();
            frontDashboard.Show();
            this.Hide();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmRooms frontRoom = new frmRooms();
            frontRoom.Show();
            this.Hide();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            frmReservation frontReservation = new frmReservation();
            frontReservation.Show();
            this.Hide();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            frmCheckIn frontCheckIn = new frmCheckIn();
            frontCheckIn.Show();
            this.Hide();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            frmCheckOut frontCheckOut = new frmCheckOut();
            frontCheckOut.Show();
            this.Hide();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            frmBillingPayment frontBillingPayment = new frmBillingPayment();
            frontBillingPayment.Show();
            this.Hide();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            frmFrontBillingRecord frontBillingRecord = new frmFrontBillingRecord();
            frontBillingRecord.Show();
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