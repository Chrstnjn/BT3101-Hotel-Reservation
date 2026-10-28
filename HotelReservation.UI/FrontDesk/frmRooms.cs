namespace HotelReservation.UI.FrontDesk
{
    public partial class frmRooms : Form
    {
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
    }
}
