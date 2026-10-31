using HotelReservation.Businesslogic.Controller;
using HotelReservation.Model;
using System.Data;


namespace HotelReservation.UI.Admin
{
    public partial class frmRoomManagement : Form
    {
        private int selectedRoomID = 0;
        private int selectedRoomTypeID = 0;
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
            selectedRoomTypeID = 0;
            btnAdd.Text = "Add";

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
                txtRoomType.Focus();
                return;
            }

            if (txtNumberofBed.Value <= 0)
            {
                MessageBox.Show("Number of Beds must be greater than 0");
                txtNumberofBed.Focus();
                return;
            }

            if (txtNumberofPerson.Value <= 0)
            {
                MessageBox.Show("Number of Persons must be greater than 0");
                txtNumberofPerson.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPricePerNight.Text))
            {
                MessageBox.Show("Enter Price Per Night");
                txtPricePerNight.Focus();
                return;
            }
            string name = txtRoomType.Text.Trim();

            // Duplicate check (ignores the current record when editing)
            if (roomTypeController.RoomTypeNameExists(name, selectedRoomTypeID))
            {
                MessageBox.Show("Room Type already exists!",
                    "Duplicate Room Type",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtRoomType.Focus();
                return;
            }
            RoomTypeModel roomType = new RoomTypeModel()
            {
                RoomTypeID = selectedRoomTypeID,
                RoomTypeName = name,
                NumberOfBeds = (int)txtNumberofBed.Value,
                NumberOfPersons = (int)txtNumberofPerson.Value,
                PricePerNight = Convert.ToDecimal(txtPricePerNight.Text)
            };

            bool result;

            if (selectedRoomTypeID == 0)
            {
                result = roomTypeController.Save(roomType);
                if (result) MessageBox.Show("Room Type Added Successfully!");
            }
            else
            {
                result = roomTypeController.Update(roomType);
                if (result) MessageBox.Show("Room Type Updated Successfully!");
            }

            if (result)
            {
                LoadRoomTypes();
                LoadRoomTypesToCombo();
                LoadRooms();            // Room List shows type name and price, so refresh it

                selectedRoomTypeID = 0;
                pnlRoomType.Visible = false;
            }
        }
        private void frmRoomManagement_Load(object sender, EventArgs e)
        {
            pnlRoom.Visible = false;

            LoadRoomTypes();
            LoadRoomTypesToCombo();
            LoadRooms();

            dgvRoomList.ContextMenuStrip = cMenuRoom;
            dgvRoomTypeList.ContextMenuStrip = cMenuRoomType;

            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Under Maintenance");

            dgvRoomList.Columns["RoomID"].Visible = false;

        }

        private void dgvRoomList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                e.Button == MouseButtons.Right)
            {
                dgvRoomList.ClearSelection();
                dgvRoomList.Rows[e.RowIndex].Selected = true;

                dgvRoomList.CurrentCell =
                    dgvRoomList.Rows[e.RowIndex].Cells["RoomNumber"];
            }
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

            cmbRoomType.SelectedIndex = -1;
        }

        private void btnRoomAdd_Click(object sender, EventArgs e)
        {
            RoomController controller = new RoomController();

            // VALIDATIONS
            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                MessageBox.Show("Please enter Room Number.");
                txtRoomNumber.Focus();
                return;
            }

            if (cmbRoomType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Room Type.");
                cmbRoomType.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                MessageBox.Show("Please select Status.");
                cmbStatus.Focus();
                return;
            }

            // ================= ADD =================
            if (selectedRoomID == 0)
            {
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

                    txtRoomNumber.Clear();
                    cmbRoomType.SelectedIndex = -1;
                    cmbStatus.SelectedIndex = -1;
                }
            }

            // ================= UPDATE =================
            else
            {
                DataTable dt = controller.GetRooms();

                bool duplicate = dt.AsEnumerable()
                    .Any(r =>
                        Convert.ToInt32(r["RoomID"]) != selectedRoomID &&
                        r["RoomNumber"].ToString() == txtRoomNumber.Text.Trim());

                if (duplicate)
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
                    RoomID = selectedRoomID,
                    RoomNumber = txtRoomNumber.Text.Trim(),
                    RoomTypeID = Convert.ToInt32(cmbRoomType.SelectedValue),
                    Status = cmbStatus.Text
                };

                bool result = controller.UpdateRoom(room);

                if (result)
                {
                    MessageBox.Show("Room Updated Successfully!");

                    LoadRooms();

                    pnlRoom.Visible = false;

                    txtRoomNumber.Clear();
                    cmbRoomType.SelectedIndex = -1;
                    cmbStatus.SelectedIndex = -1;

                    selectedRoomID = 0;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlRoom.Visible = false;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            selectedRoomID = 0;

            txtRoomNumber.Clear();

            cmbRoomType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            btnRoomAdd.Text = "Add";

            pnlRoom.Visible = true;
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
        private void txtRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // room list
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRoomList.SelectedRows.Count > 0)
            {
                selectedRoomID =
                    Convert.ToInt32(
                        dgvRoomList.SelectedRows[0]
                        .Cells["RoomID"].Value);

                txtRoomNumber.Text =
                    dgvRoomList.SelectedRows[0]
                    .Cells["RoomNumber"].Value.ToString();

                cmbStatus.Text =
                    dgvRoomList.SelectedRows[0]
                    .Cells["Status"].Value.ToString();

                cmbRoomType.Text =
                    dgvRoomList.SelectedRows[0]
                    .Cells["RoomTypeName"].Value.ToString();

                btnRoomAdd.Text = "Update";

                pnlRoom.Visible = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRoomList.SelectedRows.Count > 0)
            {
                int roomID = Convert.ToInt32(
                    dgvRoomList.SelectedRows[0]
                    .Cells["RoomID"].Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this room?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    RoomController controller = new RoomController();

                    bool deleted = controller.DeleteRoom(roomID);

                    if (deleted)
                    {
                        MessageBox.Show(
                            "Room deleted successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LoadRooms();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Failed to delete room.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        //room type
        private void dgvRoomTypeList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                dgvRoomTypeList.ClearSelection();
                dgvRoomTypeList.Rows[e.RowIndex].Selected = true;

                dgvRoomTypeList.CurrentCell =
                    dgvRoomTypeList.Rows[e.RowIndex].Cells["RoomTypeName"];
            }
        }

        private void editRoomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRoomTypeList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvRoomTypeList.SelectedRows[0];

                selectedRoomTypeID = Convert.ToInt32(row.Cells["RoomTypeID"].Value);

                txtRoomType.Text = row.Cells["RoomTypeName"].Value.ToString();
                txtNumberofBed.Value = Convert.ToInt32(row.Cells["NumberOfBeds"].Value);
                txtNumberofPerson.Value = Convert.ToInt32(row.Cells["NumberOfPersons"].Value);
                txtPricePerNight.Text =
                    Convert.ToDecimal(row.Cells["PricePerNight"].Value).ToString("0.##");

                btnAdd.Text = "Update";
                pnlRoomType.Visible = true;
            }
        }

        private void deleteRoomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRoomTypeList.SelectedRows.Count > 0)
            {
                int roomTypeID = Convert.ToInt32(
                    dgvRoomTypeList.SelectedRows[0].Cells["RoomTypeID"].Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this room type?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool deleted = roomTypeController.DeleteRoomType(roomTypeID);

                    if (deleted)
                    {
                        MessageBox.Show("Room type deleted successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LoadRoomTypes();
                        LoadRoomTypesToCombo();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Cannot delete this room type. It is still used by a room.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
