using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelReservation.UI.Admin
{
    public partial class frmAdminBillingRecords : Form
    {
        public frmAdminBillingRecords()
        {
            InitializeComponent();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            frmAdminGuest adminGuest = new frmAdminGuest();
            adminGuest.Show();
            this.Hide();
        }
        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmRoomManagement adminRoom = new frmRoomManagement();
            adminRoom.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard adminDashboard = new frmAdminDashboard();
            adminDashboard.Show();
            this.Hide();
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

        private void btnReserved_Click(object sender, EventArgs e)
        {
            frmAdminReserved adminReserved = new frmAdminReserved();
            adminReserved.Show();
            this.Hide();
        }
    }
}
