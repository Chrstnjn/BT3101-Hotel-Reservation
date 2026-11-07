using HotelReservation.Businesslogic.Controller;
using HotelReservation.Businesslogic.Repository;
using HotelReservation.Model;
using System.Data;
using System.Text;

namespace HotelReservation.UI.FrontDesk
{
    public partial class frmReservation : Form
    {
        // ===== Constants =====
        private const int CheckInHour = 13;    // 1:00 PM
        private const int CheckOutHour = 12;   // 12:00 PM
        private const string DateTimeFormat = "MM/dd/yyyy hh:mm tt";
        private const string PesoFormat = "₱#,##0.00";

        // ===== Selected values =====
        private int? selectedGuestId;
        private int? selectedRoomId;
        private decimal selectedRoomPrice;
        private DateTime? checkInDate;
        private DateTime? checkOutDate;

        public frmReservation()
        {
            InitializeComponent();
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            LoadGuests();
            LoadRooms();
            LoadReservations();

            pnlReservationDetails.Visible = false;
            pnlGuestList.Visible = false;
            pnlRoomList.Visible = false;

            // Can only select today and future dates
            monthCalendarCheckIn.MinDate = DateTime.Today;
            monthCalendarCheckOut.MinDate = DateTime.Today.AddDays(1);

            // Number of guests cannot be 0
            numberOfGuest.Minimum = 1;
            numberOfGuest.Value = 1;
        }

        // =====================================================
        //  NAVIGATION
        // =====================================================
        private void btnGuestManagement_Click(object sender, EventArgs e)
        {
            new frmGuestManagement().Show();
            Hide();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            new frmRooms().Show();
            Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            Hide();
        }

        // =====================================================
        //  HELPERS
        // =====================================================
        private static void ShowWarning(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Makes the search text safe for DataView.RowFilter
        // (a name like O'Brien would crash the filter without this)
        private static string EscapeFilter(string text)
        {
            StringBuilder sb = new StringBuilder();

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

        private static void SetupReadOnlyGrid(DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private bool RequireGuest()
        {
            if (string.IsNullOrWhiteSpace(txtGuestName.Text))
            {
                ShowWarning("Please select a guest first.", "Guest Required");
                return false;
            }
            return true;
        }

        private bool RequireDates()
        {
            if (!checkInDate.HasValue)
            {
                ShowWarning("Please select a check-in date first.", "Check-In Required");
                return false;
            }

            if (!checkOutDate.HasValue)
            {
                ShowWarning("Please select a check-out date first.", "Check-Out Required");
                return false;
            }

            return true;
        }

        private int GetNights()
        {
            if (!checkInDate.HasValue || !checkOutDate.HasValue)
                return 0;

            // Use .Date so the check-in/check-out time does not change the count
            return (checkOutDate.Value.Date - checkInDate.Value.Date).Days;
        }

        // =====================================================
        //  LOAD DATA
        // =====================================================
        private void LoadGuests()
        {
            GuestController controller = new GuestController();
            dgvGuestList.DataSource = controller.GetGuests();

            string[] hiddenColumns =
            {
                "GuestID", "Gender", "StreetAddress", "City", "Province",
                "EmergencyContactName", "EmergencyContactNumber", "CreatedDate"
            };

            foreach (string column in hiddenColumns)
                dgvGuestList.Columns[column].Visible = false;
        }

        private void LoadRooms()
        {
            RoomRepository repo = new RoomRepository();
            dgvRoomList.DataSource = repo.GetRooms();

            SetupReadOnlyGrid(dgvRoomList);

            dgvRoomList.Columns["RoomID"].Visible = false;

            dgvRoomList.Columns["RoomNumber"].HeaderText = "Room Number";
            dgvRoomList.Columns["RoomTypeName"].HeaderText = "Room Type";
            dgvRoomList.Columns["NumberOfBeds"].HeaderText = "No. of Beds";
            dgvRoomList.Columns["NumberOfPersons"].HeaderText = "Maximum Guest";
            dgvRoomList.Columns["PricePerNight"].HeaderText = "Price/Night";
            dgvRoomList.Columns["Status"].HeaderText = "Status";

            dgvRoomList.Columns["PricePerNight"].DefaultCellStyle.Format = PesoFormat;
        }

        private void LoadReservations()
        {
            ReservationController controller = new ReservationController();
            DataTable dt = controller.GetReservations();

            dgvReservationList.DataSource = dt;
            UpdateCounters(dt);

            SetupReadOnlyGrid(dgvReservationList);

            dgvReservationList.Columns["ReservationID"].Visible = false;

            dgvReservationList.Columns["ReservationNumber"].HeaderText = "Reservation Number";
            dgvReservationList.Columns["GuestName"].HeaderText = "Guest Name";
            dgvReservationList.Columns["RoomNumber"].HeaderText = "Room Number";
            dgvReservationList.Columns["RoomTypeName"].HeaderText = "Room Type";
            dgvReservationList.Columns["CheckInDate"].HeaderText = "Check-In";
            dgvReservationList.Columns["CheckOutDate"].HeaderText = "Check-Out";
            dgvReservationList.Columns["NumberOfGuests"].HeaderText = "Number of Guest(s)";
            dgvReservationList.Columns["TotalNights"].HeaderText = "Total Night(s)";
            dgvReservationList.Columns["TotalPrice"].HeaderText = "Total Price";
            dgvReservationList.Columns["Status"].HeaderText = "Status";

            dgvReservationList.Columns["CheckInDate"].DefaultCellStyle.Format = DateTimeFormat;
            dgvReservationList.Columns["CheckOutDate"].DefaultCellStyle.Format = DateTimeFormat;
            dgvReservationList.Columns["TotalPrice"].DefaultCellStyle.Format = PesoFormat;

            ApplyReservationFilter();
        }

        private void UpdateCounters(DataTable dt)
        {
            lblTotalReservation.Text = dt.Rows.Count.ToString();
            lblTotalPending.Text = dt.Select("Status = 'Pending Downpayment'").Length.ToString();

            // For checkin at checkout mamaya
            // lblTotalAwaitingCheckIn.Text = dt.Select("Status = 'Awaiting Check-In'").Length.ToString();
            // lblTotalCheckIn.Text = dt.Select("Status = 'Checked-In'").Length.ToString();
        }

        // =====================================================
        //  GUEST
        // =====================================================
        private void btnReserveGuest_Click(object sender, EventArgs e)
        {
            pnlReservationDetails.Visible = true;
        }

        private void btnSelectG_Click(object sender, EventArgs e)
        {
            pnlGuestList.Visible = true;
        }

        private void txtSearchGuest_TextChanged(object sender, EventArgs e)
        {
            if (dgvGuestList.DataSource is not DataTable dt)
                return;

            string search = EscapeFilter(txtSearchGuest.Text);

            dt.DefaultView.RowFilter =
                $"FirstName LIKE '%{search}%' OR " +
                $"LastName LIKE '%{search}%' OR " +
                $"PhoneNumber LIKE '%{search}%'";
        }

        private void btnSelectGuest_Click(object sender, EventArgs e)
        {
            if (dgvGuestList.CurrentRow == null)
                return;

            DataGridViewRow row = dgvGuestList.CurrentRow;

            int guestId = Convert.ToInt32(row.Cells["GuestID"].Value);
            string firstName = row.Cells["FirstName"].Value.ToString();
            string lastName = row.Cells["LastName"].Value.ToString();

            // Start a new form only when a different guest is picked
            if (selectedGuestId != guestId)
            {
                ResetReservationDetails();
                selectedGuestId = guestId;
            }

            txtGuestName.Text = firstName + " " + lastName;
            pnlGuestList.Visible = false;
        }

        private void btnCancelGuest_Click(object sender, EventArgs e)
        {
            pnlGuestList.Visible = false;
        }

        // =====================================================
        //  DATES
        // =====================================================
        private void btnCheckInDate_Click(object sender, EventArgs e)
        {
            if (!RequireGuest())
                return;

            pnlCheckOutDate.Visible = false;
            pnlCheckInDate.Visible = !pnlCheckInDate.Visible;

            monthCalendarCheckIn.MinDate = DateTime.Today;
        }

        private void btnCheckOutDate_Click(object sender, EventArgs e)
        {
            if (!RequireGuest())
                return;

            if (!checkInDate.HasValue)
            {
                ShowWarning("Please select a check-in date first.", "Check-In Required");
                return;
            }

            pnlCheckInDate.Visible = false;
            pnlCheckOutDate.Visible = !pnlCheckOutDate.Visible;
        }

        private void monthCalendarCheckIn_DateSelected(object sender, DateRangeEventArgs e)
        {
            checkInDate = e.Start.Date.AddHours(CheckInHour);
            txtCheckInDate.Text = checkInDate.Value.ToString(DateTimeFormat);

            // Check-out must be after check-in
            monthCalendarCheckOut.MinDate = e.Start.Date.AddDays(1);

            // If the old check-out is not valid anymore, clear it
            if (checkOutDate.HasValue && checkOutDate.Value.Date <= e.Start.Date)
            {
                checkOutDate = null;
                txtCheckOutDate.Clear();
            }

            pnlCheckInDate.Visible = false;
            UpdateTotalNights();
        }

        private void monthCalendarCheckOut_DateSelected(object sender, DateRangeEventArgs e)
        {
            checkOutDate = e.Start.Date.AddHours(CheckOutHour);
            txtCheckOutDate.Text = checkOutDate.Value.ToString(DateTimeFormat);

            pnlCheckOutDate.Visible = false;
            UpdateTotalNights();
        }

        // =====================================================
        //  ROOM
        // =====================================================
        private void btnSelectR_Click(object sender, EventArgs e)
        {
            if (!RequireGuest() || !RequireDates())
                return;

            // Get the latest room status, then show only the rooms that fit
            LoadRooms();
            FilterRooms();

            if (dgvRoomList.Rows.Count == 0)
            {
                MessageBox.Show($"No available room for {numberOfGuest.Value} guest(s).", "No Room Available",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            pnlRoomList.Visible = true;
        }

        private void FilterRooms()
        {
            if (dgvRoomList.DataSource is not DataTable dt)
                return;

            int guestCount = (int)numberOfGuest.Value;
            string search = EscapeFilter(txtSearchRoom.Text);

            dt.DefaultView.RowFilter =
                $"NumberOfPersons >= {guestCount} " +
                $"AND Status = 'Available' " +
                $"AND (" +
                $"Convert(RoomNumber, 'System.String') LIKE '%{search}%' OR " +
                $"RoomTypeName LIKE '%{search}%')";
        }

        private void txtSearchRoom_TextChanged(object sender, EventArgs e)
        {
            FilterRooms();
        }

        private void numberOfGuest_ValueChanged(object sender, EventArgs e)
        {
            // The room was chosen for the old number of guests, so choose again
            FilterRooms();
            ClearRoomSelection();
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            if (dgvRoomList.CurrentRow == null)
            {
                ShowWarning("Please select a room first.", "Room Required");
                return;
            }

            DataGridViewRow row = dgvRoomList.CurrentRow;

            selectedRoomId = Convert.ToInt32(row.Cells["RoomID"].Value);
            selectedRoomPrice = Convert.ToDecimal(row.Cells["PricePerNight"].Value);

            txtRoomNumber.Text = row.Cells["RoomNumber"].Value.ToString();
            lblRoomType.Text = row.Cells["RoomTypeName"].Value.ToString();
            lblRate.Text = selectedRoomPrice.ToString(PesoFormat);

            UpdateTotalPrice();
            pnlRoomList.Visible = false;
        }

        private void btnCancelRoom_Click(object sender, EventArgs e)
        {
            pnlRoomList.Visible = false;
        }

        private void ClearRoomSelection()
        {
            selectedRoomId = null;
            selectedRoomPrice = 0;

            txtRoomNumber.Clear();
            lblRoomType.Text = "-";
            lblRate.Text = "-";

            UpdateTotalPrice();
        }

        // =====================================================
        //  SUMMARY (nights and total price)
        // =====================================================
        private void UpdateTotalNights()
        {
            int nights = GetNights();

            lblTotalNight.Text = nights > 0
                ? $"{nights} {(nights == 1 ? "night" : "nights")}"
                : "-";

            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            int nights = GetNights();

            lblTotalPrice.Text = nights > 0 && selectedRoomPrice > 0
                ? (nights * selectedRoomPrice).ToString(PesoFormat)
                : "-";
        }

        private void ResetReservationDetails()
        {
            // Dates
            checkInDate = null;
            checkOutDate = null;
            txtCheckInDate.Clear();
            txtCheckOutDate.Clear();
            pnlCheckInDate.Visible = false;
            pnlCheckOutDate.Visible = false;
            monthCalendarCheckIn.MinDate = DateTime.Today;
            monthCalendarCheckOut.MinDate = DateTime.Today.AddDays(1);

            // Guests and room
            numberOfGuest.Value = 1;
            ClearRoomSelection();

            // Summary
            UpdateTotalNights();
        }

        // =====================================================
        //  RESERVE
        // =====================================================
        private void btnReserve_Click(object sender, EventArgs e)
        {
            // 1. Everything must be filled in
            if (selectedGuestId == null || string.IsNullOrWhiteSpace(txtGuestName.Text))
            {
                ShowWarning("Please select a guest.", "Guest Required");
                return;
            }

            if (!RequireDates())
                return;

            if (selectedRoomId == null || string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                ShowWarning("Please select a room.", "Room Required");
                return;
            }

            // 2. Dates must be valid
            int nights = GetNights();

            if (nights <= 0)
            {
                ShowWarning("Check-out date must be after the check-in date.", "Invalid Dates");
                return;
            }

            // 3. Save
            ReservationModel reservation = new ReservationModel
            {
                GuestID = selectedGuestId.Value,
                RoomID = selectedRoomId.Value,
                CheckInDate = checkInDate.Value,
                CheckOutDate = checkOutDate.Value,
                NumberOfGuests = (int)numberOfGuest.Value,
                TotalNights = nights,
                RatePerNight = selectedRoomPrice,
                TotalPrice = nights * selectedRoomPrice
            };

            try
            {
                ReservationController controller = new ReservationController();
                controller.AddReservation(reservation);

                MessageBox.Show("Reservation saved. Proceed to downpayment.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form
                ResetReservationDetails();
                txtGuestName.Clear();
                selectedGuestId = null;
                pnlReservationDetails.Visible = false;

                // The room status does not change until the downpayment,
                // so only the reservation list needs to refresh
                LoadReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        //  SEARCH RESERVATIONS
        // =====================================================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyReservationFilter();
        }

        private void ApplyReservationFilter()
        {
            if (dgvReservationList.DataSource is not DataTable dt)
                return;

            string search = EscapeFilter(txtSearch.Text);

            dt.DefaultView.RowFilter =
                $"ReservationNumber LIKE '%{search}%' OR " +
                $"GuestName LIKE '%{search}%' OR " +
                $"Convert(RoomNumber, 'System.String') LIKE '%{search}%' OR " +
                $"RoomTypeName LIKE '%{search}%' OR " +
                $"Status LIKE '%{search}%'";
        }
    }
}