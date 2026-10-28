using HotelReservation.Businesslogic.Controller;
using HotelReservation.Model;
using System.Data;

namespace HotelReservation.UI.FrontDesk
{
    public partial class frmGuestManagement : Form
    {
        public frmGuestManagement()
        {
            InitializeComponent();
        }

        private void LoadGuests()
        {
            GuestController controller = new GuestController();

            dgvGuestsList.DataSource = controller.GetGuests();

            dgvGuestsList.Columns["GuestID"].Visible = false;

            lblTotalGuest.Text = "Total Guest : " +
      dgvGuestsList.Rows.Cast<DataGridViewRow>()
                    .Count(r => !r.IsNewRow);

        }
        private void frmGuestManagement_Load(object sender, EventArgs e)
        {
            dgvGuestsList.ContextMenuStrip = cMenuGuest;
            dgvGuestsList.SelectionMode =
       DataGridViewSelectionMode.FullRowSelect;

            LoadGuests();

            cmbGender.Items.Clear();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");

            dtpBirthDate.MaxDate = DateTime.Today.AddYears(-18);

            txtSearch.Text = "";
            txtSearch.PlaceholderText = "Search for...";

            pnlAddGuest.Visible = false;

            RefreshGuest();
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

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search for...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search for...";
                txtSearch.ForeColor = Color.Gray;
            }
        }
        private void dgvGuestsList_CellFormatting(object sender,
    DataGridViewCellFormattingEventArgs e)
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
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void ucAddGuest1_Load(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtEmergencyName.Clear();
            txtEmergencyNumber.Clear();

            cmbGender.SelectedIndex = -1;

            selectedGuestId = 0;
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            pnlAddGuest.Visible = true;

            ClearFields();
            cmbGender.SelectedIndex = 0;

            btnSave.Text = "Save";

            selectedGuestId = 0;

            RefreshGuest();
        }

        private void pnlAddGuest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Phone validation
            if (!txtPhone.MaskCompleted)
            {
                MessageBox.Show(
                    "Please enter a valid phone number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPhone.Focus();
                return;
            }

            // Emergency Contact validation
            if (!txtEmergencyNumber.MaskCompleted)
            {
                MessageBox.Show(
                    "Please enter a valid emergency contact number.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmergencyNumber.Focus();
                return;
            }

            // Age validation
            if (dtpBirthDate.Value > DateTime.Today.AddYears(-18))
            {
                MessageBox.Show(
                    "Guest must be at least 18 years old.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            GuestModel guest = new GuestModel()
            {
                GuestID = selectedGuestId,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                DateOfBirth = dtpBirthDate.Value,
                Gender = cmbGender.Text,
                PhoneNumber = txtPhone.Text,
                StreetAddress = txtStreet.Text.Trim(),
                City = txtCity.Text.Trim(),
                Province = txtProvince.Text.Trim(),
                EmergencyContactName = txtEmergencyName.Text.Trim(),
                EmergencyContactNumber = txtEmergencyNumber.Text
            };

            GuestController controller = new GuestController();

            if (selectedGuestId > 0)
            {
                controller.UpdateGuest(guest);

                MessageBox.Show("Guest updated successfully!");

                selectedGuestId = 0;
                btnSave.Text = "Save";
            }
            else
            {
                controller.AddGuest(guest);

                MessageBox.Show("Guest added successfully!");
            }

            LoadGuests();
            pnlAddGuest.Visible = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddGuest.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGuest();
        }
        private void RefreshGuest()
        {
            GuestController guestController = new GuestController();
            dgvGuestsList.DataSource = guestController.GetGuests();
        }
        private void dgvGuestsList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                dgvGuestsList.ClearSelection();
                dgvGuestsList.Rows[e.RowIndex].Selected = true;

                cMenuGuest.Show(Cursor.Position);
            }
        }
        private int selectedGuestId = 0;
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGuestsList.SelectedRows.Count == 0)
                return;

            pnlAddGuest.Visible = true;

            DataGridViewRow row = dgvGuestsList.SelectedRows[0];

            selectedGuestId = Convert.ToInt32(row.Cells["GuestID"].Value);

            txtFirstName.Text =
                row.Cells["FirstName"].Value?.ToString();

            txtLastName.Text =
                row.Cells["LastName"].Value?.ToString();

            dtpBirthDate.Value =
                Convert.ToDateTime(row.Cells["DateOfBirth"].Value);

            cmbGender.Text =
                row.Cells["Gender"].Value?.ToString();

            txtPhone.Text =
                row.Cells["PhoneNumber"].Value?.ToString();

            txtStreet.Text =
                row.Cells["StreetAddress"].Value?.ToString();

            txtCity.Text =
                row.Cells["City"].Value?.ToString();

            txtProvince.Text =
                row.Cells["Province"].Value?.ToString();

            txtEmergencyName.Text =
                row.Cells["EmergencyContactName"].Value?.ToString();

            txtEmergencyNumber.Text =
                row.Cells["EmergencyContactNumber"].Value?.ToString();

            btnSave.Text = "Update";

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGuestsList.SelectedRows.Count > 0)
            {
                int guestId = Convert.ToInt32(
                    dgvGuestsList.SelectedRows[0].Cells["GuestID"].Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this guest?",
                    "Delete Guest",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    GuestController controller = new GuestController();
                    controller.DeleteGuest(guestId);

                    LoadGuests(); // Refresh DataGridView

                    MessageBox.Show("Guest deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a guest first.");
            }

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmFrontDashboard frontDashboard = new frmFrontDashboard();
            frontDashboard.Show();
            this.Hide();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmRooms frontRoom = new frmRooms();
            frontRoom.Show();
            this.Hide();
        }
    }
}
