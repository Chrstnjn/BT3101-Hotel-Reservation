using HotelReservation.Businesslogic.Controller;
using HotelReservation.Model;
using System.Data;


namespace HotelReservation.UI.Admin
{
    public partial class frmRoomManagement : Form
    {
        public frmRoomManagement()
        {
            InitializeComponent();
        }
        private void LoadRoomTypes()
        {
            RoomTypeController controller =
                new RoomTypeController();

            dgvRoomTypeList.DataSource =
                controller.GetRoomTypes();

            dgvRoomTypeList.Columns["RoomTypeID"].Visible = false;

            // Hide CreatedDate
            dgvRoomTypeList.Columns["CreatedDate"].Visible = false;

            dgvRoomTypeList.Columns["PricePerNight"]
                .DefaultCellStyle.Format = "₱#,##0.00";

            // Remove empty row
            dgvRoomTypeList.AllowUserToAddRows = false;

            lblTotalRType.Text =
                dgvRoomTypeList.Rows.Cast<DataGridViewRow>()
                .Count(r => !r.IsNewRow)
                .ToString();

            dgvRoomTypeList.Columns["RoomTypeName"].HeaderText = "Room Type";
            dgvRoomTypeList.Columns["NumberOfBeds"].HeaderText = "Beds";
            dgvRoomTypeList.Columns["NumberOfPersons"].HeaderText = "Persons";
            dgvRoomTypeList.Columns["PricePerNight"].HeaderText = "Price Per Night";
        }
        private void btnAddRoomType_Click(object sender, EventArgs e)
        {
            pnlRoomType.Visible = true;

            txtRoomType.Clear();
            txtNumberofBed.Value = 0;
            txtNumberofPerson.Value = 0;
            txtPricePerNight.Clear();

            txtRoomType.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlRoomType.Visible = false;
        }
        private void txtPricePerNight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private RoomTypeController roomTypeController =
    new RoomTypeController();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomType.Text))
            {
                MessageBox.Show("Enter Room Type");
                return;
            }

            RoomTypeModel roomType = new RoomTypeModel()
            {
                RoomTypeName = txtRoomType.Text.Trim(),
                NumberOfBeds = (int)txtNumberofBed.Value,
                NumberOfPersons = (int)txtNumberofPerson.Value,
                PricePerNight = Convert.ToDecimal(txtPricePerNight.Text)
            };

            bool result = roomTypeController.Save(roomType);

            if (result)
            {
                MessageBox.Show("Room Type Added Successfully!");

                LoadRoomTypes();

                pnlRoomType.Visible = false;
            }

        }

        private void frmRoomManagement_Load(object sender, EventArgs e)
        {
            pnlRoom.Visible = false;

            LoadRoomTypes();
            LoadRoomTypesToCombo();
            LoadRooms();

            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Under Maintenance");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard adminDashboard = new frmAdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }



        private void LoadRooms()
        {
            RoomController controller = new RoomController();

            dgvRoomList.DataSource = controller.GetRooms();

            dgvRoomList.AllowUserToAddRows = false;

            dgvRoomList.Columns["RoomID"].Visible = false;

            dgvRoomList.Columns["RoomNumber"].HeaderText = "Room Number";
            dgvRoomList.Columns["RoomTypeName"].HeaderText = "Room Type";
            dgvRoomList.Columns["NumberOfBeds"].HeaderText = "Beds";
            dgvRoomList.Columns["NumberOfPersons"].HeaderText = "Maximum Person";
            dgvRoomList.Columns["PricePerNight"].HeaderText = "Rate";
            dgvRoomList.Columns["Status"].HeaderText = "Status";

            dgvRoomList.Columns["PricePerNight"]
                .DefaultCellStyle.Format = "₱#,##0.00";

            UpdateRoomCounters();
        }

        private void UpdateRoomCounters()
        {
            int totalRoom = 0;
            int totalAvailable = 0;
            int totalMaintenance = 0;

            foreach (DataGridViewRow row in dgvRoomList.Rows)
            {
                if (row.IsNewRow)
                    continue;

                totalRoom++;

                string status =
                    row.Cells["Status"].Value.ToString();

                if (status == "Available")
                    totalAvailable++;

                if (status == "Under Maintenance")
                    totalMaintenance++;
            }

            lblTotalRoom.Text = totalRoom.ToString();
            lblTotalAvailable.Text = totalAvailable.ToString();
            lblTotalMaintenance.Text = totalMaintenance.ToString();
        }

        private void LoadRoomTypesToCombo()
        {
            RoomTypeController controller =
                new RoomTypeController();

            DataTable dt = controller.GetRoomTypes();

            cmbRoomType.DataSource = dt;
            cmbRoomType.DisplayMember = "RoomTypeName";
            cmbRoomType.ValueMember = "RoomTypeID";
        }

        private void btnRoomAdd_Click(object sender, EventArgs e)
        {
            RoomController controller = new RoomController();

            if (controller.RoomNumberExists(txtRoomNumber.Text.Trim()))
            {
                MessageBox.Show("Room Number already exists!",
                    "Duplicate Room",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtRoomNumber.Focus();
                return;
            }

            RoomModel room = new RoomModel()
            {
                RoomNumber = txtRoomNumber.Text.Trim(),
                RoomTypeID = Convert.ToInt32(cmbRoomType.SelectedValue),
                Status = cmbStatus.Text
            };

            bool result = controller.SaveRoom(room);

            if (result)
            {
                MessageBox.Show("Room Added Successfully!");
                LoadRooms();
                pnlRoom.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlRoom.Visible = false;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            pnlRoom.Visible = true;

            txtRoomNumber.Clear();

            cmbRoomType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
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

        private void txtRoomType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
