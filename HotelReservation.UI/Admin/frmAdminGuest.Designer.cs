namespace HotelReservation.UI.Admin
{
    partial class frmAdminGuest
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
            txtSearch = new TextBox();
            lblTotalGuest = new Label();
            dgvGuestsList = new DataGridView();
            btnRecords = new Button();
            btnLogout = new Button();
            btnGuest = new Button();
            btnRoom = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            btnReserved = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGuestsList).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(127, 73);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(661, 23);
            txtSearch.TabIndex = 21;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTotalGuest
            // 
            lblTotalGuest.AutoSize = true;
            lblTotalGuest.Location = new Point(206, 52);
            lblTotalGuest.Name = "lblTotalGuest";
            lblTotalGuest.Size = new Size(13, 15);
            lblTotalGuest.TabIndex = 20;
            lblTotalGuest.Text = "0";
            // 
            // dgvGuestsList
            // 
            dgvGuestsList.AllowUserToAddRows = false;
            dgvGuestsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuestsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuestsList.Location = new Point(127, 102);
            dgvGuestsList.Name = "dgvGuestsList";
            dgvGuestsList.Size = new Size(661, 340);
            dgvGuestsList.TabIndex = 19;
            dgvGuestsList.CellFormatting += dgvGuestsList_CellFormatting;
            // 
            // btnRecords
            // 
            btnRecords.Location = new Point(7, 252);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(108, 34);
            btnRecords.TabIndex = 49;
            btnRecords.Text = "Invoiced";
            btnRecords.UseVisualStyleBackColor = true;
            btnRecords.Click += btnRecords_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(7, 401);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 34);
            btnLogout.TabIndex = 48;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnGuest
            // 
            btnGuest.Location = new Point(7, 172);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(108, 34);
            btnGuest.TabIndex = 47;
            btnGuest.Text = "Guest";
            btnGuest.UseVisualStyleBackColor = true;
            // 
            // btnRoom
            // 
            btnRoom.Location = new Point(7, 132);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(108, 34);
            btnRoom.TabIndex = 46;
            btnRoom.Text = "Rooms";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(7, 92);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(108, 34);
            btnDashboard.TabIndex = 45;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 52);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 50;
            label1.Text = "Total Guests:";
            // 
            // btnReserved
            // 
            btnReserved.Location = new Point(7, 212);
            btnReserved.Name = "btnReserved";
            btnReserved.Size = new Size(108, 34);
            btnReserved.TabIndex = 51;
            btnReserved.Text = "Booked";
            btnReserved.UseVisualStyleBackColor = true;
            btnReserved.Click += btnReserved_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 19);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 52;
            label2.Text = "Guest's Record";
            // 
            // frmAdminGuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnReserved);
            Controls.Add(label1);
            Controls.Add(btnRecords);
            Controls.Add(btnLogout);
            Controls.Add(btnGuest);
            Controls.Add(btnRoom);
            Controls.Add(btnDashboard);
            Controls.Add(txtSearch);
            Controls.Add(lblTotalGuest);
            Controls.Add(dgvGuestsList);
            Name = "frmAdminGuest";
            Text = "frmAdminGuest";
            Load += frmAdminGuest_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGuestsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label lblTotalGuest;
        private DataGridView dgvGuestsList;
        private Button btnRecords;
        private Button btnLogout;
        private Button btnGuest;
        private Button btnRoom;
        private Button btnDashboard;
        private Label label1;
        private Button btnReserved;
        private Label label2;
    }
}