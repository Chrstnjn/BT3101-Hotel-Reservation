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
    }
}
