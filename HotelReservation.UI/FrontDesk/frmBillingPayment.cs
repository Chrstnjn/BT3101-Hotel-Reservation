using HotelReservation.Businesslogic.Controller;
using System.Data;

namespace HotelReservation.UI.FrontDesk
{
    public partial class frmBillingPayment : Form
    {
        public frmBillingPayment()
        {
            InitializeComponent();
        }
        private const string DateTimeFormat = "MM/dd/yyyy hh:mm tt";
        private const string PesoFormat = "₱#,##0.00";

        private DataTable billings;
        private decimal currentBalance;

        private void frmBillingPayment_Load(object sender, EventArgs e)
        {
            SetupPaymentControls();
            LoadBillings();
        }

        private void SetupPaymentControls()
        {
            cboPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaymentMethod.Items.Clear();
            cboPaymentMethod.Items.AddRange(new object[]
            {
        "Cash", "GCash", "Maya", "Credit/Debit Card", "Bank Transfer"
            });

            // The default maximum of a NumericUpDown is 100, which is too small for money
            numPaymentReceived.DecimalPlaces = 2;
            numPaymentReceived.Minimum = 0;
            numPaymentReceived.Maximum = 10000000;
        }

        // =====================================================
        //  RESERVATION LIST (Checked-In guests)
        // =====================================================
        private void LoadBillings()
        {
            ReservationController controller = new ReservationController();
            billings = controller.GetCheckOuts();   // only Checked-In reservations

            dgvReservationList.DataSource = billings.DefaultView;

            dgvReservationList.ReadOnly = true;
            dgvReservationList.AllowUserToAddRows = false;
            dgvReservationList.AllowUserToDeleteRows = false;
            dgvReservationList.AllowUserToResizeRows = false;
            dgvReservationList.MultiSelect = false;
            dgvReservationList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // The grid shows only: Guest Name, Phone Number, Room No, Check-In, Check-Out.
            // The other columns stay in the data for the details on the right.
            string[] hiddenColumns =
            {
       "ReservationID", "ReservationNumber", "RoomTypeName", "TotalNights",
        "TotalPrice", "Paid", "Balance", "Status", "CheckedInAt"
    };

            foreach (string column in hiddenColumns)
                dgvReservationList.Columns[column].Visible = false;

            dgvReservationList.Columns["GuestName"].HeaderText = "Guest Name";
            dgvReservationList.Columns["PhoneNumber"].HeaderText = "Phone Number";
            dgvReservationList.Columns["RoomNumber"].HeaderText = "Room No.";
            dgvReservationList.Columns["CheckInDate"].HeaderText = "Check-In";
            dgvReservationList.Columns["CheckOutDate"].HeaderText = "Check-Out";

            dgvReservationList.Columns["CheckInDate"].DefaultCellStyle.Format = DateTimeFormat;
            dgvReservationList.Columns["CheckOutDate"].DefaultCellStyle.Format = DateTimeFormat;

            ApplyBillingFilter();

            // Nothing is chosen until the user clicks a row
            dgvReservationList.ClearSelection();
            dgvReservationList.CurrentCell = null;
            ClearDetails();
        }

        private void ApplyBillingFilter()
        {
            if (billings == null)
                return;

            string search = EscapeFilter(txtSearch.Text);

            billings.DefaultView.RowFilter = search.Length == 0
                ? ""
                : $"ReservationNumber LIKE '%{search}%' OR " +
                  $"GuestName LIKE '%{search}%' OR " +
                  $"PhoneNumber LIKE '%{search}%' OR " +
                  $"Convert(RoomNumber, 'System.String') LIKE '%{search}%'";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyBillingFilter();
        }
        private void dgvGuestsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvReservationList.Columns[e.ColumnIndex].Name == "PhoneNumber"
                && e.Value != null)
            {
                e.Value = "(+63) " + e.Value.ToString();
                e.FormattingApplied = true;
            }
        }

        // =====================================================
        //  CLICK A RESERVATION -> FILL THE DETAILS
        // =====================================================
        private void dgvReservationList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservationList.SelectedRows.Count == 0)
            {
                ClearDetails();
                return;
            }

            DataGridViewRow row = dgvReservationList.SelectedRows[0];

            int nights = Convert.ToInt32(row.Cells["TotalNights"].Value);
            decimal totalCharges = Convert.ToDecimal(row.Cells["TotalPrice"].Value);
            decimal totalPaid = Convert.ToDecimal(row.Cells["Paid"].Value);
            decimal rate = nights > 0 ? totalCharges / nights : 0;

            currentBalance = totalCharges - totalPaid;

            // Reservation Details
            lblGuest.Text = row.Cells["GuestName"].Value.ToString();
            lblRoomNo.Text = row.Cells["RoomNumber"].Value.ToString();
            lblCheckInDate.Text = Convert.ToDateTime(row.Cells["CheckInDate"].Value).ToString(DateTimeFormat);
            lblCheckOutDate.Text = Convert.ToDateTime(row.Cells["CheckOutDate"].Value).ToString(DateTimeFormat);

            // Payment Details
            lblPdRoomType.Text = row.Cells["RoomTypeName"].Value.ToString();
            lblPdRate.Text = rate.ToString(PesoFormat);
            lblPdTotalNights.Text = nights.ToString();

            // Summary
            lblSTotalCharge.Text = totalCharges.ToString(PesoFormat);
            lblSTotalPaid.Text = totalPaid.ToString(PesoFormat);
            lblBalance.Text = currentBalance.ToString(PesoFormat);

            // Start a new payment
            numPaymentReceived.Value = 0;
            cboPaymentMethod.SelectedIndex = -1;
            lblChange.Text = "-";
        }

        private void ClearDetails()
        {
            currentBalance = 0;

            lblGuest.Text = "-";
            lblRoomNo.Text = "-";
            lblCheckInDate.Text = "-";
            lblCheckOutDate.Text = "-";

            lblPdRoomType.Text = "-";
            lblPdRate.Text = "-";
            lblPdTotalNights.Text = "-";

            lblSTotalCharge.Text = "-";
            lblSTotalPaid.Text = "-";
            lblBalance.Text = "-";

            numPaymentReceived.Value = 0;
            cboPaymentMethod.SelectedIndex = -1;
            lblChange.Text = "-";
            ResetPaymentInput();
        }

        // Reads the text, because the Value is not updated until the user leaves the box
        private decimal GetPaymentReceived()
        {
            return decimal.TryParse(numPaymentReceived.Text, out decimal value) ? value : 0;
        }

        private void UpdateChange()
        {
            decimal received = GetPaymentReceived();

            if (currentBalance <= 0 || received <= 0)
            {
                lblChange.Text = "-";
                return;
            }

            if (received < currentBalance)
            {
                lblChange.Text = "Insufficient";
                lblChange.ForeColor = Color.Crimson;
                return;
            }

            lblChange.Text = (received - currentBalance).ToString(PesoFormat);
            lblChange.ForeColor = Color.Green;
        }

        private void numPaymentReceived_ValueChanged(object sender, EventArgs e)
        {
            UpdateChange();
        }

        private void lblChange_TextChanged(object sender, EventArgs e)
        {
            UpdateChange();
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

        private void btnDpProcess_Click(object sender, EventArgs e)
        {
            // =====================================================
            //  PROCESS BILLING
            // =====================================================
            if (dgvReservationList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation first.", "Reservation Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reservationId = Convert.ToInt32(dgvReservationList.SelectedRows[0].Cells["ReservationID"].Value);

            // Nothing to pay: the guest can go straight to check-out
            if (currentBalance <= 0)
            {
                MessageBox.Show("This reservation has no balance. You can check out the guest.", "No Balance",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoToCheckOut();
                return;
            }

            if (cboPaymentMethod.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a payment method.", "Payment Method Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal received = GetPaymentReceived();

            // Insufficient payment
            if (received < currentBalance)
            {
                MessageBox.Show(
                    $"The payment is not enough.\n\n" +
                    $"Balance: {currentBalance.ToString(PesoFormat)}\n" +
                    $"Received: {received.ToString(PesoFormat)}\n" +
                    $"Short by: {(currentBalance - received).ToString(PesoFormat)}",
                    "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ReservationController controller = new ReservationController();
                controller.ProcessBilling(reservationId, received, cboPaymentMethod.Text);

                MessageBox.Show(
                    $"Payment successful.\n\n" +
                    $"Paid: {currentBalance.ToString(PesoFormat)}\n" +
                    $"Change: {(received - currentBalance).ToString(PesoFormat)}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GoToCheckOut();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvReservationList.ClearSelection();
            ClearDetails();
        }

        private void GoToCheckOut()
        {
            new frmCheckOut().Show();
            Hide();
        }
        // Clears the payment input (amount, method and change)
        private void ResetPaymentInput()
        {
            numPaymentReceived.Value = 0;
            numPaymentReceived.Text = "0.00";   // also clears an amount that was typed but not confirmed yet

            cboPaymentMethod.SelectedIndex = -1;

            lblChange.Text = "-";
            lblChange.ForeColor = Color.Green;
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            dgvReservationList.ClearSelection();
            ClearDetails();
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
        private void btnRecords_Click(object sender, EventArgs e)
        {
            frmFrontBillingRecord formFrontBillingRecord = new frmFrontBillingRecord();
            formFrontBillingRecord.Show();
            this.Hide();
        }

    }
}
