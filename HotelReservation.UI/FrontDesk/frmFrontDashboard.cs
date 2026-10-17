using HotelReservation.Businesslogic.Controller;


namespace HotelReservation.UI.FrontDesk
{
    public partial class frmFrontDashboard : Form
    {
        public frmFrontDashboard()
        {
            InitializeComponent();
        }

        private void LoadTotalGuests()
        {
            GuestController guestController = new GuestController();

            lblTotalGuest.Text = guestController.GetGuests().Rows.Count.ToString();
        }
        private void frmFrontDashboard_Load(object sender, EventArgs e)
        {

            LoadTotalGuests();
        }

        private void btnGuestManagement_Click(object sender, EventArgs e)
        {
            frmGuestManagement guestForm = new frmGuestManagement();
            guestForm.Show();
            this.Hide();
        }
    }
}
