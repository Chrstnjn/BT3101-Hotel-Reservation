using HotelReservation.Businesslogic.Controller;
using HotelReservation.Model;
using HotelReservation.UI.Admin;
using HotelReservation.UI.FrontDesk;

namespace HotelReservation.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();

            UserModel user = controller.Login(
                txtUsername.Text.Trim(),
                txtPassword.Text.Trim());

            if (user != null)
            {
                MessageBox.Show(
                    "Welcome, " + user.FullName + "!",
                    "Login Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                if (user.Role == "Admin")
                {
                    frmAdminDashboard adminForm = new frmAdminDashboard();
                    adminForm.Show();
                }
                else if (user.Role == "FrontDesk")
                {
                    frmFrontDashboard recepForm = new frmFrontDashboard();
                    recepForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid credentials",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            txtPassword.UseSystemPasswordChar = true;
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkPassword.Checked;
        }
    }
}
