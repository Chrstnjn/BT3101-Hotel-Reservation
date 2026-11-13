using HotelReservation.Businesslogic.Controller;
using HotelReservation.Businesslogic.Repository;
using System.Data;

namespace HotelReservation.UI.Admin
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }
        private const string PesoFormat = "₱#,##0.00";
        private const string DateTimeFormat = "MM/dd/yyyy hh:mm tt";

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            LoadCards();
            LoadAvailableRooms();
            LoadRecentBooked();
            LoadTotalRooms();
            LoadTotalGuests();
        }

        // =====================================================
        //  CARDS: Total Rooms, Total Guest, Total Booked, Total Billed
        // =====================================================
        private void LoadCards()
        {
            RoomRepository roomRepo = new RoomRepository();
            GuestRepository guestRepo = new GuestRepository();
            ReservationController controller = new ReservationController();

            lblAvailable.Text = roomRepo.GetRooms().Rows.Count.ToString();
            lblTotalGuest.Text = guestRepo.GetGuests().Rows.Count.ToString();

            //booked
            DataTable reservations = controller.GetReservations();
            int CReserved = Convert.ToInt32(reservations.Select("Status = 'Reserved'").Length.ToString());
            int CCheckIn = Convert.ToInt32(reservations.Select("Status = 'Checked-In'").Length.ToString());
            int totalBooked = CReserved + CCheckIn;
            lblTotalReservation.Text = totalBooked.ToString();

            // Total checked-out guests
            DataTable billing = controller.GetBillingRecords();
            lblTotalRecords.Text = billing.Rows.Count.ToString();
        }

        // =====================================================
        //  AVAILABLE (rooms that are free today)
        // =====================================================
        private void LoadAvailableRooms()
        {
            ReservationController controller = new ReservationController();
            DataTable dt = controller.GetAvailableRooms(DateTime.Today);

            dgvAvailable.DataSource = dt;

            dgvAvailable.ReadOnly = true;
            dgvAvailable.AllowUserToAddRows = false;
            dgvAvailable.AllowUserToDeleteRows = false;
            dgvAvailable.AllowUserToResizeRows = false;
            dgvAvailable.MultiSelect = false;
            dgvAvailable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAvailable.Columns["RoomID"].Visible = false;

            dgvAvailable.Columns["RoomNumber"].HeaderText = "Room No.";
            dgvAvailable.Columns["RoomTypeName"].HeaderText = "Room Type";
            dgvAvailable.Columns["NumberOfBeds"].HeaderText = "Beds";
            dgvAvailable.Columns["NumberOfPersons"].HeaderText = "Max Guests";
            dgvAvailable.Columns["PricePerNight"].HeaderText = "Price/Night";

            dgvAvailable.Columns["PricePerNight"].DefaultCellStyle.Format = PesoFormat;

            dgvAvailable.ClearSelection();

            lblAvailable.Text = dt.Rows.Count.ToString();
        }

        // =====================================================
        //  RECENTLY BOOKED (Reserved, Checked-In, Checked-Out)
        // =====================================================
        private void LoadRecentBooked()
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

            dgvRecentBooked.DataSource = recent10;

            dgvRecentBooked.ReadOnly = true;
            dgvRecentBooked.AllowUserToAddRows = false;
            dgvRecentBooked.AllowUserToDeleteRows = false;
            dgvRecentBooked.AllowUserToResizeRows = false;
            dgvRecentBooked.MultiSelect = false;
            dgvRecentBooked.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentBooked.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvRecentBooked.Columns["ReservationID"].Visible = false;

            dgvRecentBooked.Columns["GuestName"].HeaderText = "Guest Name";
            dgvRecentBooked.Columns["RoomNumber"].HeaderText = "Room No.";
            dgvRecentBooked.Columns["RoomTypeName"].HeaderText = "Room Type";
            dgvRecentBooked.Columns["Status"].HeaderText = "Status";
            dgvRecentBooked.Columns["ActivityDate"].HeaderText = "Date & Time";

            dgvRecentBooked.Columns["ActivityDate"].DefaultCellStyle.Format = DateTimeFormat;

            foreach (DataGridViewRow row in dgvRecentBooked.Rows)
            {
                string status = row.Cells["Status"].Value?.ToString();

                row.Cells["Status"].Style.ForeColor = status switch
                {
                    "Reserved" => Color.DarkOrange,
                    "Checked-In" => Color.Green,
                    "Checked-Out" => Color.SteelBlue,
                    _ => Color.Black
                };
            }

            dgvRecentBooked.ClearSelection();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmRoomManagement adminRoom = new frmRoomManagement();
            adminRoom.Show();
            this.Hide();
        }

        private void LoadTotalRooms()
        {
            RoomRepository repo = new RoomRepository();

            lblTotalRoom.Text = repo.GetTotalRooms().Rows.Count.ToString();
        }

        private void LoadTotalGuests()
        {
            GuestRepository guestrepos = new GuestRepository();
            lblTotalGuest.Text = guestrepos.GetGuests().Rows.Count.ToString();
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

        private void btnReserved_Click(object sender, EventArgs e)
        {
            frmAdminReserved adminReserved = new frmAdminReserved();
            adminReserved.Show();
            this.Hide();
        }
    }
}
