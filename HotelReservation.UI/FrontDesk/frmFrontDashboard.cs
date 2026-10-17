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
    }
}
