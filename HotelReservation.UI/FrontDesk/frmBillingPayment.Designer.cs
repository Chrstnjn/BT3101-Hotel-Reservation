namespace HotelReservation.UI.FrontDesk
{
    partial class frmBillingPayment
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
            label1 = new Label();
            btnLogout = new Button();
            btnBilling = new Button();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            btnReservation = new Button();
            btnGuestManagement = new Button();
            btnRoom = new Button();
            btnDashboard = new Button();
            txtSearch = new TextBox();
            label13 = new Label();
            panel1 = new Panel();
            btnCancel = new Button();
            panel3 = new Panel();
            lblSTotalCharge = new Label();
            lblSTotalPaid = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnDpProcess = new Button();
            panel2 = new Panel();
            lblBalance = new Label();
            label7 = new Label();
            lblChange = new Label();
            panel8 = new Panel();
            lblPdTotalNights = new Label();
            label22 = new Label();
            lblPdRate = new Label();
            lblPdRoomType = new Label();
            label26 = new Label();
            label27 = new Label();
            label42 = new Label();
            label18 = new Label();
            label44 = new Label();
            numPaymentReceived = new NumericUpDown();
            label43 = new Label();
            cboPaymentMethod = new ComboBox();
            lblCheckOutDate = new Label();
            lblCheckInDate = new Label();
            lblRoomNo = new Label();
            lblGuest = new Label();
            label14 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            dgvReservationList = new DataGridView();
            panel4 = new Panel();
            label20 = new Label();
            btnBRecords = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPaymentReceived).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservationList).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 25);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 43;
            label1.Text = "Billing Payment";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 460);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 34);
            btnLogout.TabIndex = 51;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnBilling
            // 
            btnBilling.Location = new Point(12, 352);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(108, 34);
            btnBilling.TabIndex = 50;
            btnBilling.Text = "Billing Payment";
            btnBilling.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(12, 312);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(108, 34);
            btnCheckOut.TabIndex = 49;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(13, 272);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(108, 34);
            btnCheckIn.TabIndex = 48;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnReservation
            // 
            btnReservation.Location = new Point(13, 232);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(108, 34);
            btnReservation.TabIndex = 47;
            btnReservation.Text = "Reservation";
            btnReservation.UseVisualStyleBackColor = true;
            // 
            // btnGuestManagement
            // 
            btnGuestManagement.Location = new Point(13, 192);
            btnGuestManagement.Name = "btnGuestManagement";
            btnGuestManagement.Size = new Size(108, 34);
            btnGuestManagement.TabIndex = 46;
            btnGuestManagement.Text = "Guest";
            btnGuestManagement.UseVisualStyleBackColor = true;
            // 
            // btnRoom
            // 
            btnRoom.Location = new Point(13, 152);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(108, 34);
            btnRoom.TabIndex = 45;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(13, 112);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(108, 34);
            btnDashboard.TabIndex = 44;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(148, 57);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(684, 23);
            txtSearch.TabIndex = 52;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(10, 15);
            label13.Name = "label13";
            label13.Size = new Size(123, 20);
            label13.TabIndex = 44;
            label13.Text = "Payment Details";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnDpProcess);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblChange);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(label42);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label44);
            panel1.Controls.Add(numPaymentReceived);
            panel1.Controls.Add(label43);
            panel1.Controls.Add(cboPaymentMethod);
            panel1.Location = new Point(847, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 491);
            panel1.TabIndex = 66;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Crimson;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(169, 446);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 28);
            btnCancel.TabIndex = 77;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(lblSTotalCharge);
            panel3.Controls.Add(lblSTotalPaid);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(11, 193);
            panel3.Name = "panel3";
            panel3.Size = new Size(341, 96);
            panel3.TabIndex = 67;
            // 
            // lblSTotalCharge
            // 
            lblSTotalCharge.AutoSize = true;
            lblSTotalCharge.Location = new Point(144, 41);
            lblSTotalCharge.Name = "lblSTotalCharge";
            lblSTotalCharge.Size = new Size(12, 15);
            lblSTotalCharge.TabIndex = 48;
            lblSTotalCharge.Text = "-";
            // 
            // lblSTotalPaid
            // 
            lblSTotalPaid.AutoSize = true;
            lblSTotalPaid.Location = new Point(144, 71);
            lblSTotalPaid.Name = "lblSTotalPaid";
            lblSTotalPaid.Size = new Size(12, 15);
            lblSTotalPaid.TabIndex = 47;
            lblSTotalPaid.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 71);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 46;
            label4.Text = "Total Paid:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 41);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 45;
            label3.Text = "Total Charges:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 44;
            label2.Text = "Summary";
            // 
            // btnDpProcess
            // 
            btnDpProcess.BackColor = Color.Olive;
            btnDpProcess.FlatStyle = FlatStyle.Flat;
            btnDpProcess.ForeColor = SystemColors.ButtonFace;
            btnDpProcess.Location = new Point(264, 446);
            btnDpProcess.Name = "btnDpProcess";
            btnDpProcess.Size = new Size(75, 28);
            btnDpProcess.TabIndex = 76;
            btnDpProcess.Text = "Process";
            btnDpProcess.UseVisualStyleBackColor = false;
            btnDpProcess.Click += btnDpProcess_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OliveDrab;
            panel2.Controls.Add(lblBalance);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(11, 292);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 34);
            panel2.TabIndex = 49;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = SystemColors.ButtonFace;
            lblBalance.Location = new Point(269, 5);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(16, 21);
            lblBalance.TabIndex = 48;
            lblBalance.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(32, 7);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 47;
            label7.Text = "Balance:";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.ForestGreen;
            lblChange.Location = new Point(131, 409);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(12, 15);
            lblChange.TabIndex = 75;
            lblChange.Text = "-";
            lblChange.TextChanged += lblChange_TextChanged;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ControlLight;
            panel8.Controls.Add(lblPdTotalNights);
            panel8.Controls.Add(label22);
            panel8.Controls.Add(lblPdRate);
            panel8.Controls.Add(lblPdRoomType);
            panel8.Controls.Add(label26);
            panel8.Controls.Add(label27);
            panel8.Location = new Point(11, 73);
            panel8.Name = "panel8";
            panel8.Size = new Size(341, 117);
            panel8.TabIndex = 57;
            // 
            // lblPdTotalNights
            // 
            lblPdTotalNights.AutoSize = true;
            lblPdTotalNights.BackColor = SystemColors.ControlLight;
            lblPdTotalNights.Location = new Point(110, 79);
            lblPdTotalNights.Name = "lblPdTotalNights";
            lblPdTotalNights.Size = new Size(12, 15);
            lblPdTotalNights.TabIndex = 38;
            lblPdTotalNights.Text = "-";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = SystemColors.ControlLight;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(16, 79);
            label22.Name = "label22";
            label22.Size = new Size(81, 15);
            label22.TabIndex = 37;
            label22.Text = "Total Night(s)";
            // 
            // lblPdRate
            // 
            lblPdRate.AutoSize = true;
            lblPdRate.BackColor = SystemColors.ControlLight;
            lblPdRate.Location = new Point(110, 48);
            lblPdRate.Name = "lblPdRate";
            lblPdRate.Size = new Size(12, 15);
            lblPdRate.TabIndex = 36;
            lblPdRate.Text = "-";
            // 
            // lblPdRoomType
            // 
            lblPdRoomType.AutoSize = true;
            lblPdRoomType.BackColor = SystemColors.ControlLight;
            lblPdRoomType.Location = new Point(110, 17);
            lblPdRoomType.Name = "lblPdRoomType";
            lblPdRoomType.Size = new Size(12, 15);
            lblPdRoomType.TabIndex = 35;
            lblPdRoomType.Text = "-";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = SystemColors.ControlLight;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(65, 49);
            label26.Name = "label26";
            label26.Size = new Size(33, 15);
            label26.TabIndex = 34;
            label26.Text = "Rate";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = SystemColors.ControlLight;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(28, 17);
            label27.Name = "label27";
            label27.Size = new Size(69, 15);
            label27.TabIndex = 33;
            label27.Text = "Room Type";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label42.Location = new Point(76, 409);
            label42.Name = "label42";
            label42.Size = new Size(51, 15);
            label42.TabIndex = 74;
            label42.Text = "Change:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(11, 53);
            label18.Name = "label18";
            label18.Size = new Size(61, 15);
            label18.TabIndex = 55;
            label18.Text = "Paying for";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label44.Location = new Point(20, 368);
            label44.Name = "label44";
            label44.Size = new Size(106, 15);
            label44.TabIndex = 73;
            label44.Text = "Payment method:";
            // 
            // numPaymentReceived
            // 
            numPaymentReceived.Location = new Point(132, 334);
            numPaymentReceived.Name = "numPaymentReceived";
            numPaymentReceived.Size = new Size(195, 23);
            numPaymentReceived.TabIndex = 71;
            numPaymentReceived.ValueChanged += numPaymentReceived_ValueChanged;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label43.Location = new Point(15, 339);
            label43.Name = "label43";
            label43.Size = new Size(111, 15);
            label43.TabIndex = 70;
            label43.Text = "Payment received:";
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.FormattingEnabled = true;
            cboPaymentMethod.Location = new Point(132, 364);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(195, 23);
            cboPaymentMethod.TabIndex = 72;
            // 
            // lblCheckOutDate
            // 
            lblCheckOutDate.AutoSize = true;
            lblCheckOutDate.Location = new Point(150, 140);
            lblCheckOutDate.Name = "lblCheckOutDate";
            lblCheckOutDate.Size = new Size(12, 15);
            lblCheckOutDate.TabIndex = 54;
            lblCheckOutDate.Text = "-";
            // 
            // lblCheckInDate
            // 
            lblCheckInDate.AutoSize = true;
            lblCheckInDate.Location = new Point(150, 109);
            lblCheckInDate.Name = "lblCheckInDate";
            lblCheckInDate.Size = new Size(12, 15);
            lblCheckInDate.TabIndex = 53;
            lblCheckInDate.Text = "-";
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.Location = new Point(150, 81);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(12, 15);
            lblRoomNo.TabIndex = 52;
            lblRoomNo.Text = "-";
            // 
            // lblGuest
            // 
            lblGuest.AutoSize = true;
            lblGuest.Location = new Point(150, 52);
            lblGuest.Name = "lblGuest";
            lblGuest.Size = new Size(12, 15);
            lblGuest.TabIndex = 51;
            lblGuest.Text = "-";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(46, 140);
            label14.Name = "label14";
            label14.Size = new Size(95, 15);
            label14.TabIndex = 49;
            label14.Text = "Check-Out Date:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(56, 109);
            label12.Name = "label12";
            label12.Size = new Size(85, 15);
            label12.TabIndex = 48;
            label12.Text = "Check-In Date:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(55, 81);
            label11.Name = "label11";
            label11.Size = new Size(89, 15);
            label11.TabIndex = 47;
            label11.Text = "Room Number:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(69, 52);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 46;
            label10.Text = "Guest Name:";
            // 
            // dgvReservationList
            // 
            dgvReservationList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservationList.BackgroundColor = SystemColors.ActiveCaption;
            dgvReservationList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservationList.Location = new Point(148, 88);
            dgvReservationList.Name = "dgvReservationList";
            dgvReservationList.Size = new Size(684, 190);
            dgvReservationList.TabIndex = 68;
            dgvReservationList.SelectionChanged += dgvReservationList_SelectionChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(lblGuest);
            panel4.Controls.Add(lblCheckOutDate);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(lblRoomNo);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(lblCheckInDate);
            panel4.Location = new Point(148, 288);
            panel4.Name = "panel4";
            panel4.Size = new Size(684, 214);
            panel4.TabIndex = 69;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(14, 15);
            label20.Name = "label20";
            label20.Size = new Size(145, 20);
            label20.TabIndex = 55;
            label20.Text = "Reservation Details";
            // 
            // btnBRecords
            // 
            btnBRecords.Location = new Point(12, 398);
            btnBRecords.Name = "btnBRecords";
            btnBRecords.Size = new Size(108, 34);
            btnBRecords.TabIndex = 70;
            btnBRecords.Text = "Billing Records";
            btnBRecords.UseVisualStyleBackColor = true;
            // 
            // frmBillingPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 543);
            Controls.Add(btnBRecords);
            Controls.Add(panel4);
            Controls.Add(dgvReservationList);
            Controls.Add(panel1);
            Controls.Add(txtSearch);
            Controls.Add(btnLogout);
            Controls.Add(btnBilling);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(btnReservation);
            Controls.Add(btnGuestManagement);
            Controls.Add(btnRoom);
            Controls.Add(btnDashboard);
            Controls.Add(label1);
            Name = "frmBillingPayment";
            Text = "frmBillingPayment";
            Load += frmBillingPayment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPaymentReceived).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservationList).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnLogout;
        private Button btnBilling;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private Button btnReservation;
        private Button btnGuestManagement;
        private Button btnRoom;
        private Button btnDashboard;
        private TextBox txtSearch;
        private Label label13;
        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private Label lblSTotalCharge;
        private Label lblSTotalPaid;
        private Label label4;
        private Label label3;
        private DataGridView dgvReservationList;
        private Panel panel2;
        private Label label7;
        private Label lblBalance;
        private Label lblGuest;
        private Label label14;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label lblRoomNo;
        private Label label18;
        private Label lblCheckOutDate;
        private Label lblCheckInDate;
        private Panel panel4;
        private Label label20;
        private Panel panel8;
        private Label lblPdTotalNights;
        private Label label22;
        private Label lblPdRate;
        private Label lblPdRoomType;
        private Label label26;
        private Label label27;
        private Button btnCancel;
        private Button btnDpProcess;
        private Label lblChange;
        private Label label42;
        private Label label44;
        private NumericUpDown numPaymentReceived;
        private Label label43;
        private ComboBox cboPaymentMethod;
        private Button btnBRecords;
    }
}