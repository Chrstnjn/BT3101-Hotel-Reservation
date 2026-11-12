using HotelReservation.Businesslogic.Repository;

namespace HotelReservation.UI.Admin
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
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

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            LoadTotalRooms();
            LoadTotalGuests();
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

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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
