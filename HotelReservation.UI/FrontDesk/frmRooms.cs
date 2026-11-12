using HotelReservation.Businesslogic.Repository;
using System.Data;

namespace HotelReservation.UI.FrontDesk
{
    public partial class frmRooms : Form
    {
        private DateTime selectedDate = DateTime.Today;
        public frmRooms()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmFrontDashboard frontDashboard = new frmFrontDashboard();
            frontDashboard.Show();
            this.Hide();
        }

        private void btnGuestManagement_Click(object sender, EventArgs e)
        {
            frmGuestManagement frontDashboard = new frmGuestManagement();
            frontDashboard.Show();
            this.Hide();
        }


        private void LoadTotalRoomType()
        {
            RoomTypeRepository repo = new RoomTypeRepository();

            lblTotalRType.Text = repo.GetRoomTypes().Rows.Count.ToString();
        }


        private void frmRooms_Load(object sender, EventArgs e)
        {
            LoadTotalRoomType();
            LoadRooms();
            LoadRoomTypes();

            monthCalendarDate.Visible = false;
            txtDateDisplay.Text = DateTime.Today.ToString("MM/dd/yyyy");
        }

        //datagrid view room
        private void LoadRooms()
        {
            RoomRepository repo = new RoomRepository();

            dgvRoomList.DataSource = repo.GetRoomsByDate(selectedDate);

            // Read-only
            dgvRoomList.ReadOnly = true;
            dgvRoomList.AllowUserToAddRows = false;
            dgvRoomList.AllowUserToDeleteRows = false;
            dgvRoomList.AllowUserToResizeRows = false;
            dgvRoomList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvRoomList.Columns["RoomID"].Visible = false;

            dgvRoomList.Columns["RoomNumber"].HeaderText = "Room Number";
            dgvRoomList.Columns["RoomTypeName"].HeaderText = "Room Type";
            dgvRoomList.Columns["NumberOfBeds"].HeaderText = "Beds";
            dgvRoomList.Columns["NumberOfPersons"].HeaderText = "Persons";
            dgvRoomList.Columns["PricePerNight"].HeaderText = "Rate";
            dgvRoomList.Columns["Status"].HeaderText = "Status";

            dgvRoomList.Columns["PricePerNight"].DefaultCellStyle.Format = "₱#,##0.00";

            UpdateRoomStatistics();
            SearchRooms(txtSearch.Text.Trim());
        }
        // =====================================================
        //  DATE (see the rooms on another day)
        // =====================================================
        private void btnDate_Click(object sender, EventArgs e)
        {
            monthCalendarDate.Visible = !monthCalendarDate.Visible; 
            pnlDateAvailable.Visible = !pnlDateAvailable.Visible;
        }

        private void monthCalendarDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = e.Start.Date;
            txtDateDisplay.Text = selectedDate.ToString("MM/dd/yyyy");
            pnlDateAvailable.Visible = false;
            monthCalendarDate.Visible = false;

            LoadRooms();   // the list and the cards use the new date
        }
        private void UpdateRoomStatistics()
        {
            int totalRooms = 0;
            int totalAvailable = 0;
            int totalMaintenance = 0;

            foreach (DataGridViewRow row in dgvRoomList.Rows)
            {
                if (row.IsNewRow)
                    continue;

                totalRooms++;

                string status = row.Cells["Status"].Value?.ToString();

                if (status == "Available")
                    totalAvailable++;

                if (status == "Under Maintenance")
                    totalMaintenance++;
            }

            lblTotalRoom.Text = totalRooms.ToString();
            lblTotalAvailable.Text = totalAvailable.ToString();
            lblTotalMaintenance.Text = totalMaintenance.ToString();
        }
        // datagrid view roomtype
        private void LoadRoomTypes()
        {
            RoomTypeRepository repo = new RoomTypeRepository();

            dgvRoomTypeList.DataSource = repo.GetRoomTypes();

            // Read-only
            dgvRoomTypeList.ReadOnly = true;
            dgvRoomTypeList.AllowUserToAddRows = false;
            dgvRoomTypeList.AllowUserToDeleteRows = false;
            dgvRoomTypeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Hide ID column
            dgvRoomTypeList.Columns["RoomTypeID"].Visible = false;

            // Optional: Hide CreatedDate if it exists
            if (dgvRoomTypeList.Columns.Contains("CreatedDate"))
                dgvRoomTypeList.Columns["CreatedDate"].Visible = false;

            dgvRoomTypeList.Columns["RoomTypeName"].HeaderText = "Room Type";
            dgvRoomTypeList.Columns["NumberOfBeds"].HeaderText = "Beds";
            dgvRoomTypeList.Columns["NumberOfPersons"].HeaderText = "Persons";
            dgvRoomTypeList.Columns["PricePerNight"].HeaderText = "Price Per Night";

            dgvRoomTypeList.Columns["PricePerNight"]
                .DefaultCellStyle.Format = "₱#,##0.00";

            // Auto size columns
            dgvRoomTypeList.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            frmReservation formReserve = new frmReservation();
            formReserve.Show();
            this.Hide();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchRooms(txtSearch.Text.Trim());
        }

        private void SearchRooms(string keyword)
        {
            DataTable dt = (DataTable)dgvRoomList.DataSource;

            if (dt != null)
            {
                dt.DefaultView.RowFilter =
                    $"Convert(RoomNumber, 'System.String') LIKE '%{keyword}%' OR " +
                    $"RoomTypeName LIKE '%{keyword}%' OR " +
                    $"Convert(NumberOfBeds, 'System.String') LIKE '%{keyword}%' OR " +
                    $"Convert(NumberOfPersons, 'System.String') LIKE '%{keyword}%' OR " +
                    $"Convert(PricePerNight, 'System.String') LIKE '%{keyword}%' OR " +
                    $"Status LIKE '%{keyword}%'";
            }
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

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            frmCheckIn formCheckIn = new frmCheckIn();
            formCheckIn.Show();
            this.Hide();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            frmCheckOut formCheckOut = new frmCheckOut();
            formCheckOut.Show();
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
    }
}
