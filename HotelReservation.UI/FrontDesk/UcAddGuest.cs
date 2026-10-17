using HotelReservation.Businesslogic.Controller;
using HotelReservation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelReservation.UI.FrontDesk
{
    public partial class UcAddGuest : UserControl
    {
        public UcAddGuest()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
            controller.AddGuest(guest);

            MessageBox.Show(
                "Guest added successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void UcAddGuest_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Clear();

            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");

            cmbGender.SelectedIndex = 0;

            dtpBirthDate.MaxDate = DateTime.Today.AddYears(-18);
        }
    }
}
