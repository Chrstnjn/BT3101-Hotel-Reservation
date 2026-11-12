using HotelReservation.Businesslogic.Controller;
using HotelReservation.Businesslogic.Repository;
using System.Data;

namespace HotelReservation.UI.FrontDesk
{
    public partial class frmFrontDashboard : Form
    {
        public frmFrontDashboard()
        {
            InitializeComponent();
        }

        private void btnGuestManagement_Click(object sender, EventArgs e)
        {
            frmGuestManagement frontDashboard = new frmGuestManagement();
            frontDashboard.Show();
            this.Hide();
        }

        private void frmFrontDashboard_Load(object sender, EventArgs e)
        {
            LoadTotalGuests();
        }

        private void LoadTotalGuests()
        {
            GuestRepository repo = new GuestRepository();

            lblTotalGuest.Text = repo.GetGuests().Rows.Count.ToString();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmRooms frontRoom = new frmRooms();
            frontRoom.Show();
            this.Hide();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            frmReservation frontReservation = new frmReservation();
            frontReservation.Show();
            this.Hide();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            frmCheckIn frontCheckIn = new frmCheckIn();
            frontCheckIn.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
            this.Hide();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            frmCheckOut frontCheckOut = new frmCheckOut();
            frontCheckOut.Show();
            this.Hide();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            frmBillingPayment frontBillingPayment = new frmBillingPayment();
            frontBillingPayment.Show();
            this.Hide();
        }
    }
}
