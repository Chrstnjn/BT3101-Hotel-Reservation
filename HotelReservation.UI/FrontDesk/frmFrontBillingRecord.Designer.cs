namespace HotelReservation.UI.FrontDesk
{
    partial class frmFrontBillingRecord
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
            btnRecords = new Button();
            btnLogout = new Button();
            btnBilling = new Button();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            btnReservation = new Button();
            btnGuestManagement = new Button();
            btnRoom = new Button();
            btnDashboard = new Button();
            dgvCheckOut = new DataGridView();
            txtSearch = new TextBox();
            lblTotalCheckOut = new Label();
            label3 = new Label();
            label1 = new Label();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).BeginInit();
            SuspendLayout();
            // 
            // btnRecords
            // 
            btnRecords.Location = new Point(20, 339);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(108, 34);
            btnRecords.TabIndex = 80;
            btnRecords.Text = "Billing Records";
            btnRecords.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(20, 401);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 34);
            btnLogout.TabIndex = 78;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBilling
            // 
            btnBilling.Location = new Point(20, 293);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(108, 34);
            btnBilling.TabIndex = 77;
            btnBilling.Text = "Billing Payment";
            btnBilling.UseVisualStyleBackColor = true;
            btnBilling.Click += btnBilling_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(20, 253);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(108, 34);
            btnCheckOut.TabIndex = 76;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(21, 213);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(108, 34);
            btnCheckIn.TabIndex = 75;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnReservation
            // 
            btnReservation.Location = new Point(21, 173);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(108, 34);
            btnReservation.TabIndex = 74;
            btnReservation.Text = "Reservation";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnGuestManagement
            // 
            btnGuestManagement.Location = new Point(21, 133);
            btnGuestManagement.Name = "btnGuestManagement";
            btnGuestManagement.Size = new Size(108, 34);
            btnGuestManagement.TabIndex = 73;
            btnGuestManagement.Text = "Guest";
            btnGuestManagement.UseVisualStyleBackColor = true;
            btnGuestManagement.Click += btnGuestManagement_Click;
            // 
            // btnRoom
            // 
            btnRoom.Location = new Point(21, 93);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(108, 34);
            btnRoom.TabIndex = 72;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(21, 53);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(108, 34);
            btnDashboard.TabIndex = 71;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // dgvCheckOut
            // 
            dgvCheckOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckOut.BackgroundColor = SystemColors.ActiveCaption;
            dgvCheckOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckOut.GridColor = SystemColors.InactiveCaption;
            dgvCheckOut.Location = new Point(144, 110);
            dgvCheckOut.Name = "dgvCheckOut";
            dgvCheckOut.Size = new Size(633, 321);
            dgvCheckOut.TabIndex = 86;
            dgvCheckOut.CellFormatting += dgvGuestsList_CellFormatting;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(154, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(623, 23);
            txtSearch.TabIndex = 84;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTotalCheckOut
            // 
            lblTotalCheckOut.AutoSize = true;
            lblTotalCheckOut.Location = new Point(277, 54);
            lblTotalCheckOut.Name = "lblTotalCheckOut";
            lblTotalCheckOut.Size = new Size(12, 15);
            lblTotalCheckOut.TabIndex = 83;
            lblTotalCheckOut.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 54);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 82;
            label3.Text = "Total Check-Outs";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 21);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 81;
            label1.Text = "Billing Records";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(702, 50);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 87;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // frmFrontBillingRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrint);
            Controls.Add(dgvCheckOut);
            Controls.Add(txtSearch);
            Controls.Add(lblTotalCheckOut);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnRecords);
            Controls.Add(btnLogout);
            Controls.Add(btnBilling);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(btnReservation);
            Controls.Add(btnGuestManagement);
            Controls.Add(btnRoom);
            Controls.Add(btnDashboard);
            Name = "frmFrontBillingRecord";
            Text = "frmFrontBillingRecord";
            Load += frmFrontBillingRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRecords;
        private Button btnLogout;
        private Button btnBilling;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private Button btnReservation;
        private Button btnGuestManagement;
        private Button btnRoom;
        private Button btnDashboard;
        private DataGridView dgvCheckOut;
        private TextBox txtSearch;
        private Label lblTotalCheckOut;
        private Label label3;
        private Label label1;
        private Button btnPrint;
    }
}