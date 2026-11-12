namespace HotelReservation.UI.Admin
{
    partial class frmAdminReserved
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnReserved = new Button();
            btnRecords = new Button();
            btnLogout = new Button();
            btnGuest = new Button();
            btnRoom = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSearch = new TextBox();
            lblTotalGuest = new Label();
            dgvGuestsList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGuestsList).BeginInit();
            SuspendLayout();
            // 
            // btnReserved
            // 
            btnReserved.Location = new Point(12, 202);
            btnReserved.Name = "btnReserved";
            btnReserved.Size = new Size(108, 34);
            btnReserved.TabIndex = 57;
            btnReserved.Text = "Booked";
            btnReserved.UseVisualStyleBackColor = true;
            // 
            // btnRecords
            // 
            btnRecords.Location = new Point(12, 242);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(108, 34);
            btnRecords.TabIndex = 56;
            btnRecords.Text = "Invoiced";
            btnRecords.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 391);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 34);
            btnLogout.TabIndex = 55;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnGuest
            // 
            btnGuest.Location = new Point(12, 162);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(108, 34);
            btnGuest.TabIndex = 54;
            btnGuest.Text = "Guest";
            btnGuest.UseVisualStyleBackColor = true;
            // 
            // btnRoom
            // 
            btnRoom.Location = new Point(12, 122);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(108, 34);
            btnRoom.TabIndex = 53;
            btnRoom.Text = "Rooms";
            btnRoom.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(12, 82);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(108, 34);
            btnDashboard.TabIndex = 52;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 15);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 62;
            label2.Text = "Booked Records";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 48);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 61;
            label1.Text = "Total Reserved:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(127, 69);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(661, 23);
            txtSearch.TabIndex = 60;
            // 
            // lblTotalGuest
            // 
            lblTotalGuest.AutoSize = true;
            lblTotalGuest.Location = new Point(213, 48);
            lblTotalGuest.Name = "lblTotalGuest";
            lblTotalGuest.Size = new Size(13, 15);
            lblTotalGuest.TabIndex = 59;
            lblTotalGuest.Text = "0";
            // 
            // dgvGuestsList
            // 
            dgvGuestsList.AllowUserToAddRows = false;
            dgvGuestsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuestsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuestsList.Location = new Point(127, 98);
            dgvGuestsList.Name = "dgvGuestsList";
            dgvGuestsList.Size = new Size(661, 340);
            dgvGuestsList.TabIndex = 58;
            // 
            // frmAdminReserved
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(lblTotalGuest);
            Controls.Add(dgvGuestsList);
            Controls.Add(btnReserved);
            Controls.Add(btnRecords);
            Controls.Add(btnLogout);
            Controls.Add(btnGuest);
            Controls.Add(btnRoom);
            Controls.Add(btnDashboard);
            Name = "frmAdminReserved";
            Text = "frmAdminReserved";
            ((System.ComponentModel.ISupportInitialize)dgvGuestsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReserved;
        private Button btnRecords;
        private Button btnLogout;
        private Button btnGuest;
        private Button btnRoom;
        private Button btnDashboard;
        private Label label2;
        private Label label1;
        private TextBox txtSearch;
        private Label lblTotalGuest;
        private DataGridView dgvGuestsList;
    }
}