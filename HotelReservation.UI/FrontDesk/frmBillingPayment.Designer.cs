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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillingPayment));
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
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPaymentReceived).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservationList).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(238, 36);
            label1.TabIndex = 43;
            label1.Text = "Billing Payment";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 100, 100);
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(35, 973);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(263, 43);
            btnLogout.TabIndex = 51;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBilling
            // 
            btnBilling.BackColor = Color.FromArgb(48, 91, 171);
            btnBilling.FlatStyle = FlatStyle.Popup;
            btnBilling.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnBilling.ForeColor = SystemColors.ButtonHighlight;
            btnBilling.Location = new Point(35, 521);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(263, 43);
            btnBilling.TabIndex = 50;
            btnBilling.Text = "BILLING PAYMENTS";
            btnBilling.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.FromArgb(48, 91, 171);
            btnCheckOut.FlatStyle = FlatStyle.Popup;
            btnCheckOut.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnCheckOut.ForeColor = SystemColors.ButtonHighlight;
            btnCheckOut.Location = new Point(35, 463);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(263, 43);
            btnCheckOut.TabIndex = 49;
            btnCheckOut.Text = "CHECK OUT";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.BackColor = Color.FromArgb(48, 91, 171);
            btnCheckIn.FlatStyle = FlatStyle.Popup;
            btnCheckIn.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnCheckIn.ForeColor = SystemColors.ButtonHighlight;
            btnCheckIn.Location = new Point(35, 405);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(263, 43);
            btnCheckIn.TabIndex = 48;
            btnCheckIn.Text = "CHECK IN";
            btnCheckIn.UseVisualStyleBackColor = false;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnReservation
            // 
            btnReservation.BackColor = Color.FromArgb(48, 91, 171);
            btnReservation.FlatStyle = FlatStyle.Popup;
            btnReservation.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnReservation.ForeColor = SystemColors.ButtonHighlight;
            btnReservation.Location = new Point(35, 348);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(263, 43);
            btnReservation.TabIndex = 47;
            btnReservation.Text = "RESERVATION";
            btnReservation.UseVisualStyleBackColor = false;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnGuestManagement
            // 
            btnGuestManagement.BackColor = Color.FromArgb(48, 91, 171);
            btnGuestManagement.FlatStyle = FlatStyle.Popup;
            btnGuestManagement.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnGuestManagement.ForeColor = SystemColors.ButtonHighlight;
            btnGuestManagement.Location = new Point(35, 293);
            btnGuestManagement.Name = "btnGuestManagement";
            btnGuestManagement.Size = new Size(263, 43);
            btnGuestManagement.TabIndex = 46;
            btnGuestManagement.Text = "GUEST";
            btnGuestManagement.UseVisualStyleBackColor = false;
            btnGuestManagement.Click += btnGuestManagement_Click;
            // 
            // btnRoom
            // 
            btnRoom.BackColor = Color.FromArgb(48, 91, 171);
            btnRoom.FlatStyle = FlatStyle.Popup;
            btnRoom.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnRoom.ForeColor = SystemColors.ButtonHighlight;
            btnRoom.Location = new Point(35, 237);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(263, 43);
            btnRoom.TabIndex = 45;
            btnRoom.Text = "ROOM";
            btnRoom.UseVisualStyleBackColor = false;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(48, 91, 171);
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnDashboard.ForeColor = SystemColors.ButtonHighlight;
            btnDashboard.Location = new Point(35, 181);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(263, 43);
            btnDashboard.TabIndex = 44;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18F);
            txtSearch.Location = new Point(27, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(854, 39);
            txtSearch.TabIndex = 52;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Constantia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(17, 14);
            label13.Name = "label13";
            label13.Size = new Size(242, 36);
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
            panel1.Location = new Point(1282, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 892);
            panel1.TabIndex = 66;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Crimson;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(457, 833);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 36);
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
            panel3.Location = new Point(17, 351);
            panel3.Name = "panel3";
            panel3.Size = new Size(569, 169);
            panel3.TabIndex = 67;
            // 
            // lblSTotalCharge
            // 
            lblSTotalCharge.AutoSize = true;
            lblSTotalCharge.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblSTotalCharge.ForeColor = Color.OliveDrab;
            lblSTotalCharge.Location = new Point(166, 58);
            lblSTotalCharge.Name = "lblSTotalCharge";
            lblSTotalCharge.Size = new Size(16, 23);
            lblSTotalCharge.TabIndex = 48;
            lblSTotalCharge.Text = "-";
            // 
            // lblSTotalPaid
            // 
            lblSTotalPaid.AutoSize = true;
            lblSTotalPaid.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblSTotalPaid.ForeColor = Color.IndianRed;
            lblSTotalPaid.Location = new Point(166, 116);
            lblSTotalPaid.Name = "lblSTotalPaid";
            lblSTotalPaid.Size = new Size(16, 23);
            lblSTotalPaid.TabIndex = 47;
            lblSTotalPaid.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label4.Location = new Point(53, 116);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 46;
            label4.Text = "Total Paid:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label3.Location = new Point(24, 58);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 45;
            label3.Text = "Total Charges:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label2.Location = new Point(17, 13);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 44;
            label2.Text = "Summary";
            // 
            // btnDpProcess
            // 
            btnDpProcess.BackColor = Color.OliveDrab;
            btnDpProcess.FlatStyle = FlatStyle.Flat;
            btnDpProcess.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            btnDpProcess.ForeColor = SystemColors.ButtonFace;
            btnDpProcess.Location = new Point(311, 833);
            btnDpProcess.Name = "btnDpProcess";
            btnDpProcess.Size = new Size(129, 36);
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
            panel2.Location = new Point(17, 542);
            panel2.Name = "panel2";
            panel2.Size = new Size(569, 51);
            panel2.TabIndex = 49;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblBalance.ForeColor = SystemColors.ButtonFace;
            lblBalance.Location = new Point(236, 14);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(16, 23);
            lblBalance.TabIndex = 48;
            lblBalance.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(62, 14);
            label7.Name = "label7";
            label7.Size = new Size(77, 23);
            label7.TabIndex = 47;
            label7.Text = "Balance:";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblChange.ForeColor = Color.ForestGreen;
            lblChange.Location = new Point(215, 755);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(16, 23);
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
            panel8.Location = new Point(17, 135);
            panel8.Name = "panel8";
            panel8.Size = new Size(569, 192);
            panel8.TabIndex = 57;
            // 
            // lblPdTotalNights
            // 
            lblPdTotalNights.AutoSize = true;
            lblPdTotalNights.BackColor = SystemColors.ControlLight;
            lblPdTotalNights.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblPdTotalNights.Location = new Point(166, 132);
            lblPdTotalNights.Name = "lblPdTotalNights";
            lblPdTotalNights.Size = new Size(16, 23);
            lblPdTotalNights.TabIndex = 38;
            lblPdTotalNights.Text = "-";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = SystemColors.ControlLight;
            label22.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label22.Location = new Point(22, 132);
            label22.Name = "label22";
            label22.Size = new Size(116, 23);
            label22.TabIndex = 37;
            label22.Text = "Total Night(s)";
            // 
            // lblPdRate
            // 
            lblPdRate.AutoSize = true;
            lblPdRate.BackColor = SystemColors.ControlLight;
            lblPdRate.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblPdRate.Location = new Point(166, 75);
            lblPdRate.Name = "lblPdRate";
            lblPdRate.Size = new Size(16, 23);
            lblPdRate.TabIndex = 36;
            lblPdRate.Text = "-";
            // 
            // lblPdRoomType
            // 
            lblPdRoomType.AutoSize = true;
            lblPdRoomType.BackColor = SystemColors.ControlLight;
            lblPdRoomType.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblPdRoomType.Location = new Point(166, 20);
            lblPdRoomType.Name = "lblPdRoomType";
            lblPdRoomType.Size = new Size(16, 23);
            lblPdRoomType.TabIndex = 35;
            lblPdRoomType.Text = "-";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = SystemColors.ControlLight;
            label26.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label26.Location = new Point(91, 75);
            label26.Name = "label26";
            label26.Size = new Size(47, 23);
            label26.TabIndex = 34;
            label26.Text = "Rate";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = SystemColors.ControlLight;
            label27.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label27.Location = new Point(41, 20);
            label27.Name = "label27";
            label27.Size = new Size(97, 23);
            label27.TabIndex = 33;
            label27.Text = "Room Type";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label42.Location = new Point(102, 755);
            label42.Name = "label42";
            label42.Size = new Size(73, 23);
            label42.TabIndex = 74;
            label42.Text = "Change:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(17, 88);
            label18.Name = "label18";
            label18.Size = new Size(101, 23);
            label18.TabIndex = 55;
            label18.Text = "Paying for";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label44.Location = new Point(24, 700);
            label44.Name = "label44";
            label44.Size = new Size(151, 23);
            label44.TabIndex = 73;
            label44.Text = "Payment method:";
            // 
            // numPaymentReceived
            // 
            numPaymentReceived.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            numPaymentReceived.Location = new Point(183, 636);
            numPaymentReceived.Name = "numPaymentReceived";
            numPaymentReceived.Size = new Size(403, 31);
            numPaymentReceived.TabIndex = 71;
            numPaymentReceived.ValueChanged += numPaymentReceived_ValueChanged;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label43.Location = new Point(17, 638);
            label43.Name = "label43";
            label43.Size = new Size(158, 23);
            label43.TabIndex = 70;
            label43.Text = "Payment received:";
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            cboPaymentMethod.FormattingEnabled = true;
            cboPaymentMethod.Location = new Point(183, 697);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(403, 31);
            cboPaymentMethod.TabIndex = 72;
            // 
            // lblCheckOutDate
            // 
            lblCheckOutDate.AutoSize = true;
            lblCheckOutDate.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblCheckOutDate.Location = new Point(225, 299);
            lblCheckOutDate.Name = "lblCheckOutDate";
            lblCheckOutDate.Size = new Size(16, 23);
            lblCheckOutDate.TabIndex = 54;
            lblCheckOutDate.Text = "-";
            // 
            // lblCheckInDate
            // 
            lblCheckInDate.AutoSize = true;
            lblCheckInDate.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblCheckInDate.Location = new Point(225, 234);
            lblCheckInDate.Name = "lblCheckInDate";
            lblCheckInDate.Size = new Size(16, 23);
            lblCheckInDate.TabIndex = 53;
            lblCheckInDate.Text = "-";
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblRoomNo.Location = new Point(225, 169);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(16, 23);
            lblRoomNo.TabIndex = 52;
            lblRoomNo.Text = "-";
            // 
            // lblGuest
            // 
            lblGuest.AutoSize = true;
            lblGuest.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblGuest.Location = new Point(225, 108);
            lblGuest.Name = "lblGuest";
            lblGuest.Size = new Size(16, 23);
            lblGuest.TabIndex = 51;
            lblGuest.Text = "-";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label14.Location = new Point(48, 299);
            label14.Name = "label14";
            label14.Size = new Size(139, 23);
            label14.TabIndex = 49;
            label14.Text = "Check-Out Date:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label12.Location = new Point(63, 234);
            label12.Name = "label12";
            label12.Size = new Size(124, 23);
            label12.TabIndex = 48;
            label12.Text = "Check-In Date:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label11.Location = new Point(57, 169);
            label11.Name = "label11";
            label11.Size = new Size(130, 23);
            label11.TabIndex = 47;
            label11.Text = "Room Number:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label10.Location = new Point(74, 108);
            label10.Name = "label10";
            label10.Size = new Size(113, 23);
            label10.TabIndex = 46;
            label10.Text = "Guest Name:";
            // 
            // dgvReservationList
            // 
            dgvReservationList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservationList.BackgroundColor = SystemColors.ActiveCaption;
            dgvReservationList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservationList.Location = new Point(27, 88);
            dgvReservationList.Name = "dgvReservationList";
            dgvReservationList.Size = new Size(854, 412);
            dgvReservationList.TabIndex = 68;
            dgvReservationList.CellFormatting += dgvGuestsList_CellFormatting;
            dgvReservationList.SelectionChanged += dgvReservationList_SelectionChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(lblGuest);
            panel4.Controls.Add(lblCheckOutDate);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(lblRoomNo);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(lblCheckInDate);
            panel4.Location = new Point(27, 513);
            panel4.Name = "panel4";
            panel4.Size = new Size(854, 356);
            panel4.TabIndex = 69;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Constantia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(39, 29);
            label20.Name = "label20";
            label20.Size = new Size(235, 29);
            label20.TabIndex = 55;
            label20.Text = "Reservation Details";
            // 
            // btnBRecords
            // 
            btnBRecords.BackColor = Color.FromArgb(48, 91, 171);
            btnBRecords.FlatStyle = FlatStyle.Popup;
            btnBRecords.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnBRecords.ForeColor = SystemColors.ButtonHighlight;
            btnBRecords.Location = new Point(35, 579);
            btnBRecords.Name = "btnBRecords";
            btnBRecords.Size = new Size(263, 43);
            btnBRecords.TabIndex = 70;
            btnBRecords.Text = "BOOKED RECORDS";
            btnBRecords.UseVisualStyleBackColor = false;
            btnBRecords.Click += btnRecords_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(19, 52, 113);
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(btnDashboard);
            panel5.Controls.Add(btnBRecords);
            panel5.Controls.Add(btnRoom);
            panel5.Controls.Add(btnGuestManagement);
            panel5.Controls.Add(btnReservation);
            panel5.Controls.Add(btnCheckIn);
            panel5.Controls.Add(btnCheckOut);
            panel5.Controls.Add(btnLogout);
            panel5.Controls.Add(btnBilling);
            panel5.Location = new Point(0, -1);
            panel5.Name = "panel5";
            panel5.Size = new Size(336, 1044);
            panel5.TabIndex = 71;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(215, 218, 224);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(35, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 72;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(101, 138, 208);
            label5.Location = new Point(27, 160);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 71;
            label5.Text = "NAVIGATIONS";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(7, 31, 77);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(334, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(1572, 108);
            panel6.TabIndex = 72;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(48, 91, 171);
            panel7.Controls.Add(dgvReservationList);
            panel7.Controls.Add(txtSearch);
            panel7.Controls.Add(panel4);
            panel7.Location = new Point(358, 129);
            panel7.Name = "panel7";
            panel7.Size = new Size(909, 892);
            panel7.TabIndex = 73;
            // 
            // frmBillingPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel1);
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
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel5;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel6;
        private Panel panel7;
    }
}