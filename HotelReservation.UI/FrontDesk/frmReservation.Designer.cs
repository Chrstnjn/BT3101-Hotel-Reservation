namespace HotelReservation.UI.FrontDesk
{
    partial class frmReservation
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
            components = new System.ComponentModel.Container();
            btnBilling = new Button();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            btnReservation = new Button();
            btnGuestManagement = new Button();
            btnRoom = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            lblTotalCheckIn = new Label();
            label6 = new Label();
            panel4 = new Panel();
            lblTotalPending = new Label();
            label8 = new Label();
            panel1 = new Panel();
            lblTotalReservation = new Label();
            label1 = new Label();
            txtSearch = new TextBox();
            btnReserveGuest = new Button();
            label2 = new Label();
            dgvReservationList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            EditToolStripMenuItem = new ToolStripMenuItem();
            processPaymentToolStripMenuItem = new ToolStripMenuItem();
            awaitCheckInToolStripMenuItem = new ToolStripMenuItem();
            cancelToolStripMenuItem = new ToolStripMenuItem();
            pnlReservationDetails = new Panel();
            btnReserveCancel = new Button();
            btnReserve = new Button();
            lblTotalNight = new Label();
            pnlCheckInDate = new Panel();
            monthCalendarCheckIn = new MonthCalendar();
            pnlCheckOutDate = new Panel();
            monthCalendarCheckOut = new MonthCalendar();
            label21 = new Label();
            btnSelectG = new Button();
            lblTotalPrice = new Label();
            label19 = new Label();
            txtRoomNumber = new TextBox();
            lblRate = new Label();
            lblRoomType = new Label();
            btnCheckOutDate = new Button();
            btnCheckInDate = new Button();
            txtCheckOutDate = new TextBox();
            txtCheckInDate = new TextBox();
            label16 = new Label();
            label15 = new Label();
            btnSelectR = new Button();
            label14 = new Label();
            numberOfGuest = new NumericUpDown();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            txtGuestName = new TextBox();
            label5 = new Label();
            panel7 = new Panel();
            panel5 = new Panel();
            txtSearchGuest = new TextBox();
            dgvGuestList = new DataGridView();
            label3 = new Label();
            btnLogout = new Button();
            pnlGuestList = new Panel();
            btnCancelGuest = new Button();
            btnSelectGuest = new Button();
            pnlRoomList = new Panel();
            btnCancelRoom = new Button();
            btnSelectRoom = new Button();
            txtSearchRoom = new TextBox();
            label23 = new Label();
            dgvRoomList = new DataGridView();
            panel2 = new Panel();
            lblTotalAwaiting = new Label();
            label13 = new Label();
            pnlDownpayment = new Panel();
            btnCancel = new Button();
            btnDpProcess = new Button();
            lblChange = new Label();
            label42 = new Label();
            label44 = new Label();
            cboPaymentMethod = new ComboBox();
            numPaymentReceived = new NumericUpDown();
            label43 = new Label();
            lblAmountToPay = new Label();
            label40 = new Label();
            panel9 = new Panel();
            panel10 = new Panel();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            textBox3 = new TextBox();
            label37 = new Label();
            textBox4 = new TextBox();
            label38 = new Label();
            label39 = new Label();
            panel8 = new Panel();
            lblDpTotalNights = new Label();
            lblDpSubtotal = new Label();
            label22 = new Label();
            label29 = new Label();
            lblDpRate = new Label();
            lblDpRoomType = new Label();
            label26 = new Label();
            label27 = new Label();
            label18 = new Label();
            txtDpFullName = new TextBox();
            label17 = new Label();
            txtDpReservationID = new TextBox();
            label4 = new Label();
            lbl1 = new Label();
            btnRecords = new Button();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservationList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            pnlReservationDetails.SuspendLayout();
            pnlCheckInDate.SuspendLayout();
            pnlCheckOutDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberOfGuest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGuestList).BeginInit();
            pnlGuestList.SuspendLayout();
            pnlRoomList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).BeginInit();
            panel2.SuspendLayout();
            pnlDownpayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPaymentReceived).BeginInit();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // btnBilling
            // 
            btnBilling.Location = new Point(13, 345);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(108, 34);
            btnBilling.TabIndex = 20;
            btnBilling.Text = "Billing Payment";
            btnBilling.UseVisualStyleBackColor = true;
            btnBilling.Click += btnBilling_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(13, 305);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(108, 34);
            btnCheckOut.TabIndex = 19;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(14, 265);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(108, 34);
            btnCheckIn.TabIndex = 18;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnReservation
            // 
            btnReservation.Location = new Point(13, 222);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(108, 34);
            btnReservation.TabIndex = 17;
            btnReservation.Text = "Reservation";
            btnReservation.UseVisualStyleBackColor = true;
            // 
            // btnGuestManagement
            // 
            btnGuestManagement.Location = new Point(13, 182);
            btnGuestManagement.Name = "btnGuestManagement";
            btnGuestManagement.Size = new Size(108, 34);
            btnGuestManagement.TabIndex = 16;
            btnGuestManagement.Text = "Guest";
            btnGuestManagement.UseVisualStyleBackColor = true;
            btnGuestManagement.Click += btnGuestManagement_Click;
            // 
            // btnRoom
            // 
            btnRoom.Location = new Point(13, 142);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(108, 34);
            btnRoom.TabIndex = 15;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(13, 102);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(108, 34);
            btnDashboard.TabIndex = 14;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(lblTotalCheckIn);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(569, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(120, 55);
            panel3.TabIndex = 28;
            // 
            // lblTotalCheckIn
            // 
            lblTotalCheckIn.AutoSize = true;
            lblTotalCheckIn.Location = new Point(50, 33);
            lblTotalCheckIn.Name = "lblTotalCheckIn";
            lblTotalCheckIn.Size = new Size(13, 15);
            lblTotalCheckIn.TabIndex = 1;
            lblTotalCheckIn.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 9);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 0;
            label6.Text = "Check-In";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(lblTotalPending);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(289, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(120, 55);
            panel4.TabIndex = 27;
            // 
            // lblTotalPending
            // 
            lblTotalPending.AutoSize = true;
            lblTotalPending.Location = new Point(50, 33);
            lblTotalPending.Name = "lblTotalPending";
            lblTotalPending.Size = new Size(13, 15);
            lblTotalPending.TabIndex = 1;
            lblTotalPending.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 9);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 0;
            label8.Text = "Pending";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblTotalReservation);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(146, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 55);
            panel1.TabIndex = 25;
            // 
            // lblTotalReservation
            // 
            lblTotalReservation.AutoSize = true;
            lblTotalReservation.Location = new Point(50, 33);
            lblTotalReservation.Name = "lblTotalReservation";
            lblTotalReservation.Size = new Size(13, 15);
            lblTotalReservation.TabIndex = 1;
            lblTotalReservation.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Total Reservation";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(146, 89);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(515, 23);
            txtSearch.TabIndex = 29;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnReserveGuest
            // 
            btnReserveGuest.Location = new Point(667, 89);
            btnReserveGuest.Name = "btnReserveGuest";
            btnReserveGuest.Size = new Size(103, 23);
            btnReserveGuest.TabIndex = 30;
            btnReserveGuest.Text = "Reserve Guest";
            btnReserveGuest.UseVisualStyleBackColor = true;
            btnReserveGuest.Click += btnReserveGuest_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 121);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 31;
            label2.Text = "Reservation List";
            // 
            // dgvReservationList
            // 
            dgvReservationList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservationList.BackgroundColor = SystemColors.ActiveCaption;
            dgvReservationList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservationList.Location = new Point(146, 146);
            dgvReservationList.Name = "dgvReservationList";
            dgvReservationList.Size = new Size(1200, 420);
            dgvReservationList.TabIndex = 32;
            dgvReservationList.CellMouseDown += dgvReservationList_CellMouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { EditToolStripMenuItem, processPaymentToolStripMenuItem, awaitCheckInToolStripMenuItem, cancelToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(173, 92);
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(172, 22);
            EditToolStripMenuItem.Text = "Edit";
            EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // processPaymentToolStripMenuItem
            // 
            processPaymentToolStripMenuItem.Name = "processPaymentToolStripMenuItem";
            processPaymentToolStripMenuItem.Size = new Size(172, 22);
            processPaymentToolStripMenuItem.Text = "Process payment";
            processPaymentToolStripMenuItem.Click += processPaymentToolStripMenuItem_Click;
            // 
            // awaitCheckInToolStripMenuItem
            // 
            awaitCheckInToolStripMenuItem.Name = "awaitCheckInToolStripMenuItem";
            awaitCheckInToolStripMenuItem.Size = new Size(172, 22);
            awaitCheckInToolStripMenuItem.Text = "Awaiting Check-In";
            awaitCheckInToolStripMenuItem.Click += awaitCheckInToolStripMenuItem_Click;
            // 
            // cancelToolStripMenuItem
            // 
            cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            cancelToolStripMenuItem.Size = new Size(172, 22);
            cancelToolStripMenuItem.Text = "Cancel";
            cancelToolStripMenuItem.Click += cancelToolStripMenuItem_Click;
            // 
            // pnlReservationDetails
            // 
            pnlReservationDetails.Controls.Add(btnReserveCancel);
            pnlReservationDetails.Controls.Add(btnReserve);
            pnlReservationDetails.Controls.Add(lblTotalNight);
            pnlReservationDetails.Controls.Add(pnlCheckInDate);
            pnlReservationDetails.Controls.Add(pnlCheckOutDate);
            pnlReservationDetails.Controls.Add(label21);
            pnlReservationDetails.Controls.Add(btnSelectG);
            pnlReservationDetails.Controls.Add(lblTotalPrice);
            pnlReservationDetails.Controls.Add(label19);
            pnlReservationDetails.Controls.Add(txtRoomNumber);
            pnlReservationDetails.Controls.Add(lblRate);
            pnlReservationDetails.Controls.Add(lblRoomType);
            pnlReservationDetails.Controls.Add(btnCheckOutDate);
            pnlReservationDetails.Controls.Add(btnCheckInDate);
            pnlReservationDetails.Controls.Add(txtCheckOutDate);
            pnlReservationDetails.Controls.Add(txtCheckInDate);
            pnlReservationDetails.Controls.Add(label16);
            pnlReservationDetails.Controls.Add(label15);
            pnlReservationDetails.Controls.Add(btnSelectR);
            pnlReservationDetails.Controls.Add(label14);
            pnlReservationDetails.Controls.Add(numberOfGuest);
            pnlReservationDetails.Controls.Add(label12);
            pnlReservationDetails.Controls.Add(label11);
            pnlReservationDetails.Controls.Add(label10);
            pnlReservationDetails.Controls.Add(label9);
            pnlReservationDetails.Controls.Add(label7);
            pnlReservationDetails.Controls.Add(txtGuestName);
            pnlReservationDetails.Controls.Add(label5);
            pnlReservationDetails.Controls.Add(panel7);
            pnlReservationDetails.Controls.Add(panel5);
            pnlReservationDetails.Location = new Point(145, 118);
            pnlReservationDetails.Name = "pnlReservationDetails";
            pnlReservationDetails.Size = new Size(638, 388);
            pnlReservationDetails.TabIndex = 34;
            // 
            // btnReserveCancel
            // 
            btnReserveCancel.Location = new Point(431, 345);
            btnReserveCancel.Name = "btnReserveCancel";
            btnReserveCancel.Size = new Size(95, 29);
            btnReserveCancel.TabIndex = 37;
            btnReserveCancel.Text = "Cancel";
            btnReserveCancel.UseVisualStyleBackColor = true;
            btnReserveCancel.Click += btnReserveCancel_Click;
            // 
            // btnReserve
            // 
            btnReserve.Location = new Point(532, 345);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(95, 29);
            btnReserve.TabIndex = 34;
            btnReserve.Text = "Reserve";
            btnReserve.UseVisualStyleBackColor = true;
            btnReserve.Click += btnReserve_Click;
            // 
            // lblTotalNight
            // 
            lblTotalNight.AutoSize = true;
            lblTotalNight.BackColor = SystemColors.ControlLight;
            lblTotalNight.Location = new Point(143, 276);
            lblTotalNight.Name = "lblTotalNight";
            lblTotalNight.Size = new Size(12, 15);
            lblTotalNight.TabIndex = 32;
            lblTotalNight.Text = "-";
            // 
            // pnlCheckInDate
            // 
            pnlCheckInDate.Controls.Add(monthCalendarCheckIn);
            pnlCheckInDate.Location = new Point(86, 95);
            pnlCheckInDate.Name = "pnlCheckInDate";
            pnlCheckInDate.Size = new Size(243, 178);
            pnlCheckInDate.TabIndex = 35;
            pnlCheckInDate.Visible = false;
            // 
            // monthCalendarCheckIn
            // 
            monthCalendarCheckIn.Location = new Point(9, 9);
            monthCalendarCheckIn.Name = "monthCalendarCheckIn";
            monthCalendarCheckIn.TabIndex = 0;
            monthCalendarCheckIn.DateSelected += monthCalendarCheckIn_DateSelected;
            // 
            // pnlCheckOutDate
            // 
            pnlCheckOutDate.Controls.Add(monthCalendarCheckOut);
            pnlCheckOutDate.Location = new Point(382, 94);
            pnlCheckOutDate.Name = "pnlCheckOutDate";
            pnlCheckOutDate.Size = new Size(243, 178);
            pnlCheckOutDate.TabIndex = 36;
            pnlCheckOutDate.Visible = false;
            // 
            // monthCalendarCheckOut
            // 
            monthCalendarCheckOut.Location = new Point(9, 9);
            monthCalendarCheckOut.Name = "monthCalendarCheckOut";
            monthCalendarCheckOut.TabIndex = 0;
            monthCalendarCheckOut.DateSelected += monthCalendarCheckOut_DateSelected;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = SystemColors.ControlLight;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(49, 276);
            label21.Name = "label21";
            label21.Size = new Size(81, 15);
            label21.TabIndex = 31;
            label21.Text = "Total Night(s)";
            // 
            // btnSelectG
            // 
            btnSelectG.Location = new Point(393, 40);
            btnSelectG.Name = "btnSelectG";
            btnSelectG.Size = new Size(95, 23);
            btnSelectG.TabIndex = 29;
            btnSelectG.Text = "Select Guest";
            btnSelectG.UseVisualStyleBackColor = true;
            btnSelectG.Click += btnSelectG_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.ForestGreen;
            lblTotalPrice.Location = new Point(137, 330);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(12, 15);
            lblTotalPrice.TabIndex = 28;
            lblTotalPrice.Text = "-";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(95, 330);
            label19.Name = "label19";
            label19.Size = new Size(37, 15);
            label19.TabIndex = 27;
            label19.Text = "Total:";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(134, 144);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.ReadOnly = true;
            txtRoomNumber.Size = new Size(258, 23);
            txtRoomNumber.TabIndex = 26;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.BackColor = SystemColors.ControlLight;
            lblRate.Location = new Point(143, 245);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(12, 15);
            lblRate.TabIndex = 25;
            lblRate.Text = "-";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.BackColor = SystemColors.ControlLight;
            lblRoomType.Location = new Point(143, 214);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(12, 15);
            lblRoomType.TabIndex = 24;
            lblRoomType.Text = "-";
            // 
            // btnCheckOutDate
            // 
            btnCheckOutDate.Location = new Point(593, 68);
            btnCheckOutDate.Name = "btnCheckOutDate";
            btnCheckOutDate.Size = new Size(31, 23);
            btnCheckOutDate.TabIndex = 23;
            btnCheckOutDate.Text = "v";
            btnCheckOutDate.UseVisualStyleBackColor = true;
            btnCheckOutDate.Click += btnCheckOutDate_Click;
            // 
            // btnCheckInDate
            // 
            btnCheckInDate.Location = new Point(301, 69);
            btnCheckInDate.Name = "btnCheckInDate";
            btnCheckInDate.Size = new Size(31, 23);
            btnCheckInDate.TabIndex = 22;
            btnCheckInDate.Text = "v";
            btnCheckInDate.UseVisualStyleBackColor = true;
            btnCheckInDate.Click += btnCheckInDate_Click;
            // 
            // txtCheckOutDate
            // 
            txtCheckOutDate.Location = new Point(433, 68);
            txtCheckOutDate.Name = "txtCheckOutDate";
            txtCheckOutDate.Size = new Size(164, 23);
            txtCheckOutDate.TabIndex = 21;
            // 
            // txtCheckInDate
            // 
            txtCheckInDate.Location = new Point(134, 69);
            txtCheckInDate.Name = "txtCheckInDate";
            txtCheckInDate.Size = new Size(178, 23);
            txtCheckInDate.TabIndex = 20;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.ControlLight;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(98, 246);
            label16.Name = "label16";
            label16.Size = new Size(33, 15);
            label16.TabIndex = 19;
            label16.Text = "Rate";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ControlLight;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(61, 214);
            label15.Name = "label15";
            label15.Size = new Size(69, 15);
            label15.TabIndex = 18;
            label15.Text = "Room Type";
            // 
            // btnSelectR
            // 
            btnSelectR.Location = new Point(399, 143);
            btnSelectR.Name = "btnSelectR";
            btnSelectR.Size = new Size(95, 23);
            btnSelectR.TabIndex = 17;
            btnSelectR.Text = "Select Room";
            btnSelectR.UseVisualStyleBackColor = true;
            btnSelectR.Click += btnSelectR_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(37, 149);
            label14.Name = "label14";
            label14.Size = new Size(86, 15);
            label14.TabIndex = 15;
            label14.Text = "Room Number";
            // 
            // numberOfGuest
            // 
            numberOfGuest.Location = new Point(135, 110);
            numberOfGuest.Name = "numberOfGuest";
            numberOfGuest.Size = new Size(194, 23);
            numberOfGuest.TabIndex = 12;
            numberOfGuest.ValueChanged += numberOfGuest_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(30, 112);
            label12.Name = "label12";
            label12.Size = new Size(98, 15);
            label12.TabIndex = 11;
            label12.Text = "Number of Guest";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(331, 74);
            label11.Name = "label11";
            label11.Size = new Size(10, 15);
            label11.TabIndex = 10;
            label11.Text = ":";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(339, 76);
            label10.Name = "label10";
            label10.Size = new Size(92, 15);
            label10.TabIndex = 7;
            label10.Text = "Check-Out Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 76);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 6;
            label9.Text = "Check-In Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 43);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 5;
            label7.Text = "Guest Name";
            // 
            // txtGuestName
            // 
            txtGuestName.Location = new Point(135, 40);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.ReadOnly = true;
            txtGuestName.Size = new Size(255, 23);
            txtGuestName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 18);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 3;
            label5.Text = "Reservation Details";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlDark;
            panel7.Location = new Point(0, 186);
            panel7.Name = "panel7";
            panel7.Size = new Size(638, 10);
            panel7.TabIndex = 30;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Location = new Point(37, 205);
            panel5.Name = "panel5";
            panel5.Size = new Size(275, 111);
            panel5.TabIndex = 33;
            // 
            // txtSearchGuest
            // 
            txtSearchGuest.Location = new Point(14, 22);
            txtSearchGuest.Name = "txtSearchGuest";
            txtSearchGuest.Size = new Size(543, 23);
            txtSearchGuest.TabIndex = 2;
            txtSearchGuest.TextChanged += txtSearchGuest_TextChanged;
            // 
            // dgvGuestList
            // 
            dgvGuestList.AllowUserToAddRows = false;
            dgvGuestList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuestList.BackgroundColor = SystemColors.ActiveCaption;
            dgvGuestList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuestList.Location = new Point(14, 54);
            dgvGuestList.Name = "dgvGuestList";
            dgvGuestList.Size = new Size(544, 154);
            dgvGuestList.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 4);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 0;
            label3.Text = "Guest List";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 543);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 34);
            btnLogout.TabIndex = 37;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlGuestList
            // 
            pnlGuestList.BackColor = SystemColors.AppWorkspace;
            pnlGuestList.Controls.Add(btnCancelGuest);
            pnlGuestList.Controls.Add(btnSelectGuest);
            pnlGuestList.Controls.Add(txtSearchGuest);
            pnlGuestList.Controls.Add(label3);
            pnlGuestList.Controls.Add(dgvGuestList);
            pnlGuestList.Location = new Point(789, 131);
            pnlGuestList.Name = "pnlGuestList";
            pnlGuestList.Size = new Size(568, 247);
            pnlGuestList.TabIndex = 38;
            // 
            // btnCancelGuest
            // 
            btnCancelGuest.Location = new Point(401, 213);
            btnCancelGuest.Name = "btnCancelGuest";
            btnCancelGuest.Size = new Size(75, 23);
            btnCancelGuest.TabIndex = 4;
            btnCancelGuest.Text = "Cancel";
            btnCancelGuest.UseVisualStyleBackColor = true;
            btnCancelGuest.Click += btnCancelGuest_Click;
            // 
            // btnSelectGuest
            // 
            btnSelectGuest.Location = new Point(482, 213);
            btnSelectGuest.Name = "btnSelectGuest";
            btnSelectGuest.Size = new Size(75, 23);
            btnSelectGuest.TabIndex = 3;
            btnSelectGuest.Text = "Select";
            btnSelectGuest.UseVisualStyleBackColor = true;
            btnSelectGuest.Click += btnSelectGuest_Click;
            // 
            // pnlRoomList
            // 
            pnlRoomList.BackColor = SystemColors.AppWorkspace;
            pnlRoomList.Controls.Add(btnCancelRoom);
            pnlRoomList.Controls.Add(btnSelectRoom);
            pnlRoomList.Controls.Add(txtSearchRoom);
            pnlRoomList.Controls.Add(label23);
            pnlRoomList.Controls.Add(dgvRoomList);
            pnlRoomList.Location = new Point(789, 385);
            pnlRoomList.Name = "pnlRoomList";
            pnlRoomList.Size = new Size(567, 243);
            pnlRoomList.TabIndex = 39;
            // 
            // btnCancelRoom
            // 
            btnCancelRoom.Location = new Point(401, 214);
            btnCancelRoom.Name = "btnCancelRoom";
            btnCancelRoom.Size = new Size(75, 23);
            btnCancelRoom.TabIndex = 6;
            btnCancelRoom.Text = "Cancel";
            btnCancelRoom.UseVisualStyleBackColor = true;
            btnCancelRoom.Click += btnCancelRoom_Click;
            // 
            // btnSelectRoom
            // 
            btnSelectRoom.Location = new Point(482, 214);
            btnSelectRoom.Name = "btnSelectRoom";
            btnSelectRoom.Size = new Size(75, 23);
            btnSelectRoom.TabIndex = 5;
            btnSelectRoom.Text = "Select";
            btnSelectRoom.UseVisualStyleBackColor = true;
            btnSelectRoom.Click += btnSelectRoom_Click;
            // 
            // txtSearchRoom
            // 
            txtSearchRoom.Location = new Point(14, 22);
            txtSearchRoom.Name = "txtSearchRoom";
            txtSearchRoom.Size = new Size(543, 23);
            txtSearchRoom.TabIndex = 2;
            txtSearchRoom.TextChanged += txtSearchRoom_TextChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(14, 4);
            label23.Name = "label23";
            label23.Size = new Size(60, 15);
            label23.TabIndex = 0;
            label23.Text = "Room List";
            // 
            // dgvRoomList
            // 
            dgvRoomList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomList.BackgroundColor = SystemColors.ActiveCaption;
            dgvRoomList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomList.Location = new Point(14, 54);
            dgvRoomList.Name = "dgvRoomList";
            dgvRoomList.Size = new Size(543, 154);
            dgvRoomList.TabIndex = 1;
            dgvRoomList.Tag = "";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lblTotalAwaiting);
            panel2.Controls.Add(label13);
            panel2.Location = new Point(428, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 55);
            panel2.TabIndex = 40;
            // 
            // lblTotalAwaiting
            // 
            lblTotalAwaiting.AutoSize = true;
            lblTotalAwaiting.Location = new Point(50, 33);
            lblTotalAwaiting.Name = "lblTotalAwaiting";
            lblTotalAwaiting.Size = new Size(13, 15);
            lblTotalAwaiting.TabIndex = 1;
            lblTotalAwaiting.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 9);
            label13.Name = "label13";
            label13.Size = new Size(105, 15);
            label13.TabIndex = 0;
            label13.Text = "Awaiting Check-In";
            // 
            // pnlDownpayment
            // 
            pnlDownpayment.BackColor = SystemColors.ButtonFace;
            pnlDownpayment.Controls.Add(btnCancel);
            pnlDownpayment.Controls.Add(btnDpProcess);
            pnlDownpayment.Controls.Add(lblChange);
            pnlDownpayment.Controls.Add(label42);
            pnlDownpayment.Controls.Add(label44);
            pnlDownpayment.Controls.Add(cboPaymentMethod);
            pnlDownpayment.Controls.Add(numPaymentReceived);
            pnlDownpayment.Controls.Add(label43);
            pnlDownpayment.Controls.Add(lblAmountToPay);
            pnlDownpayment.Controls.Add(label40);
            pnlDownpayment.Controls.Add(panel9);
            pnlDownpayment.Controls.Add(panel8);
            pnlDownpayment.Controls.Add(label18);
            pnlDownpayment.Controls.Add(txtDpFullName);
            pnlDownpayment.Controls.Add(label17);
            pnlDownpayment.Controls.Add(txtDpReservationID);
            pnlDownpayment.Controls.Add(label4);
            pnlDownpayment.Controls.Add(lbl1);
            pnlDownpayment.Location = new Point(1424, 102);
            pnlDownpayment.Name = "pnlDownpayment";
            pnlDownpayment.Size = new Size(370, 497);
            pnlDownpayment.TabIndex = 41;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Crimson;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(188, 447);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 28);
            btnCancel.TabIndex = 57;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnDpCancel_Click;
            // 
            // btnDpProcess
            // 
            btnDpProcess.BackColor = Color.Olive;
            btnDpProcess.FlatStyle = FlatStyle.Flat;
            btnDpProcess.ForeColor = SystemColors.ButtonFace;
            btnDpProcess.Location = new Point(281, 447);
            btnDpProcess.Name = "btnDpProcess";
            btnDpProcess.Size = new Size(75, 28);
            btnDpProcess.TabIndex = 56;
            btnDpProcess.Text = "Process";
            btnDpProcess.UseVisualStyleBackColor = false;
            btnDpProcess.Click += btnDpProcess_Click;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.ForestGreen;
            lblChange.Location = new Point(137, 420);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(12, 15);
            lblChange.TabIndex = 55;
            lblChange.Text = "-";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label42.Location = new Point(80, 420);
            label42.Name = "label42";
            label42.Size = new Size(51, 15);
            label42.TabIndex = 54;
            label42.Text = "Change:";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label44.Location = new Point(25, 376);
            label44.Name = "label44";
            label44.Size = new Size(106, 15);
            label44.TabIndex = 53;
            label44.Text = "Payment method:";
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.FormattingEnabled = true;
            cboPaymentMethod.Location = new Point(137, 372);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(195, 23);
            cboPaymentMethod.TabIndex = 52;
            // 
            // numPaymentReceived
            // 
            numPaymentReceived.Location = new Point(137, 339);
            numPaymentReceived.Name = "numPaymentReceived";
            numPaymentReceived.Size = new Size(195, 23);
            numPaymentReceived.TabIndex = 51;
            numPaymentReceived.ValueChanged += numPaymentReceived_ValueChanged;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label43.Location = new Point(20, 346);
            label43.Name = "label43";
            label43.Size = new Size(111, 15);
            label43.TabIndex = 49;
            label43.Text = "Payment received:";
            // 
            // lblAmountToPay
            // 
            lblAmountToPay.AutoSize = true;
            lblAmountToPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountToPay.ForeColor = Color.ForestGreen;
            lblAmountToPay.Location = new Point(119, 313);
            lblAmountToPay.Name = "lblAmountToPay";
            lblAmountToPay.Size = new Size(12, 15);
            lblAmountToPay.TabIndex = 46;
            lblAmountToPay.Text = "-";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label40.Location = new Point(20, 313);
            label40.Name = "label40";
            label40.Size = new Size(92, 15);
            label40.TabIndex = 45;
            label40.Text = "Amount to pay:";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ButtonFace;
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(label36);
            panel9.Controls.Add(textBox3);
            panel9.Controls.Add(label37);
            panel9.Controls.Add(textBox4);
            panel9.Controls.Add(label38);
            panel9.Controls.Add(label39);
            panel9.Location = new Point(1551, 59);
            panel9.Name = "panel9";
            panel9.Size = new Size(370, 497);
            panel9.TabIndex = 44;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ControlLight;
            panel10.Controls.Add(label30);
            panel10.Controls.Add(label31);
            panel10.Controls.Add(label32);
            panel10.Controls.Add(label33);
            panel10.Controls.Add(label34);
            panel10.Controls.Add(label35);
            panel10.Location = new Point(15, 164);
            panel10.Name = "panel10";
            panel10.Size = new Size(341, 111);
            panel10.TabIndex = 34;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = SystemColors.ControlLight;
            label30.Location = new Point(110, 79);
            label30.Name = "label30";
            label30.Size = new Size(12, 15);
            label30.TabIndex = 38;
            label30.Text = "-";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = SystemColors.ControlLight;
            label31.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(16, 79);
            label31.Name = "label31";
            label31.Size = new Size(81, 15);
            label31.TabIndex = 37;
            label31.Text = "Total Night(s)";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = SystemColors.ControlLight;
            label32.Location = new Point(110, 48);
            label32.Name = "label32";
            label32.Size = new Size(12, 15);
            label32.TabIndex = 36;
            label32.Text = "-";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BackColor = SystemColors.ControlLight;
            label33.Location = new Point(110, 17);
            label33.Name = "label33";
            label33.Size = new Size(12, 15);
            label33.TabIndex = 35;
            label33.Text = "-";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = SystemColors.ControlLight;
            label34.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.Location = new Point(65, 49);
            label34.Name = "label34";
            label34.Size = new Size(33, 15);
            label34.TabIndex = 34;
            label34.Text = "Rate";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = SystemColors.ControlLight;
            label35.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.Location = new Point(28, 17);
            label35.Name = "label35";
            label35.Size = new Size(69, 15);
            label35.TabIndex = 33;
            label35.Text = "Room Type";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(14, 139);
            label36.Name = "label36";
            label36.Size = new Size(61, 15);
            label36.TabIndex = 8;
            label36.Text = "Paying for";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(102, 87);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(198, 23);
            textBox3.TabIndex = 7;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(35, 94);
            label37.Name = "label37";
            label37.Size = new Size(61, 15);
            label37.TabIndex = 6;
            label37.Text = "Full Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(102, 47);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(198, 23);
            textBox4.TabIndex = 5;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(14, 54);
            label38.Name = "label38";
            label38.Size = new Size(82, 15);
            label38.TabIndex = 4;
            label38.Text = "Reservation ID";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(14, 19);
            label39.Name = "label39";
            label39.Size = new Size(123, 15);
            label39.TabIndex = 3;
            label39.Text = "Downpayment Details";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ControlLight;
            panel8.Controls.Add(lblDpTotalNights);
            panel8.Controls.Add(lblDpSubtotal);
            panel8.Controls.Add(label22);
            panel8.Controls.Add(label29);
            panel8.Controls.Add(lblDpRate);
            panel8.Controls.Add(lblDpRoomType);
            panel8.Controls.Add(label26);
            panel8.Controls.Add(label27);
            panel8.Location = new Point(15, 164);
            panel8.Name = "panel8";
            panel8.Size = new Size(341, 127);
            panel8.TabIndex = 34;
            // 
            // lblDpTotalNights
            // 
            lblDpTotalNights.AutoSize = true;
            lblDpTotalNights.BackColor = SystemColors.ControlLight;
            lblDpTotalNights.Location = new Point(110, 79);
            lblDpTotalNights.Name = "lblDpTotalNights";
            lblDpTotalNights.Size = new Size(12, 15);
            lblDpTotalNights.TabIndex = 38;
            lblDpTotalNights.Text = "-";
            // 
            // lblDpSubtotal
            // 
            lblDpSubtotal.AutoSize = true;
            lblDpSubtotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDpSubtotal.ForeColor = Color.ForestGreen;
            lblDpSubtotal.Location = new Point(110, 105);
            lblDpSubtotal.Name = "lblDpSubtotal";
            lblDpSubtotal.Size = new Size(12, 15);
            lblDpSubtotal.TabIndex = 43;
            lblDpSubtotal.Text = "-";
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
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.Location = new Point(40, 105);
            label29.Name = "label29";
            label29.Size = new Size(57, 15);
            label29.TabIndex = 42;
            label29.Text = "Subtotal:";
            // 
            // lblDpRate
            // 
            lblDpRate.AutoSize = true;
            lblDpRate.BackColor = SystemColors.ControlLight;
            lblDpRate.Location = new Point(110, 48);
            lblDpRate.Name = "lblDpRate";
            lblDpRate.Size = new Size(12, 15);
            lblDpRate.TabIndex = 36;
            lblDpRate.Text = "-";
            // 
            // lblDpRoomType
            // 
            lblDpRoomType.AutoSize = true;
            lblDpRoomType.BackColor = SystemColors.ControlLight;
            lblDpRoomType.Location = new Point(110, 17);
            lblDpRoomType.Name = "lblDpRoomType";
            lblDpRoomType.Size = new Size(12, 15);
            lblDpRoomType.TabIndex = 35;
            lblDpRoomType.Text = "-";
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
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(14, 139);
            label18.Name = "label18";
            label18.Size = new Size(61, 15);
            label18.TabIndex = 8;
            label18.Text = "Paying for";
            // 
            // txtDpFullName
            // 
            txtDpFullName.Location = new Point(102, 87);
            txtDpFullName.Name = "txtDpFullName";
            txtDpFullName.ReadOnly = true;
            txtDpFullName.Size = new Size(198, 23);
            txtDpFullName.TabIndex = 7;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(35, 94);
            label17.Name = "label17";
            label17.Size = new Size(61, 15);
            label17.TabIndex = 6;
            label17.Text = "Full Name";
            // 
            // txtDpReservationID
            // 
            txtDpReservationID.Location = new Point(102, 57);
            txtDpReservationID.Name = "txtDpReservationID";
            txtDpReservationID.ReadOnly = true;
            txtDpReservationID.Size = new Size(198, 23);
            txtDpReservationID.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 60);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 4;
            label4.Text = "Reservation ID";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(14, 19);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(180, 21);
            lbl1.TabIndex = 3;
            lbl1.Text = "Downpayment Details";
            // 
            // btnRecords
            // 
            btnRecords.Location = new Point(14, 389);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(108, 34);
            btnRecords.TabIndex = 42;
            btnRecords.Text = "Billing Records";
            btnRecords.UseVisualStyleBackColor = true;
            btnRecords.Click += btnRecords_Click;
            // 
            // frmReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 658);
            Controls.Add(btnRecords);
            Controls.Add(pnlDownpayment);
            Controls.Add(panel2);
            Controls.Add(pnlRoomList);
            Controls.Add(pnlGuestList);
            Controls.Add(btnLogout);
            Controls.Add(pnlReservationDetails);
            Controls.Add(dgvReservationList);
            Controls.Add(label2);
            Controls.Add(btnReserveGuest);
            Controls.Add(txtSearch);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(btnBilling);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(btnReservation);
            Controls.Add(btnGuestManagement);
            Controls.Add(btnRoom);
            Controls.Add(btnDashboard);
            Name = "frmReservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmReservation";
            WindowState = FormWindowState.Maximized;
            Load += frmReservation_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservationList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            pnlReservationDetails.ResumeLayout(false);
            pnlReservationDetails.PerformLayout();
            pnlCheckInDate.ResumeLayout(false);
            pnlCheckOutDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numberOfGuest).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGuestList).EndInit();
            pnlGuestList.ResumeLayout(false);
            pnlGuestList.PerformLayout();
            pnlRoomList.ResumeLayout(false);
            pnlRoomList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlDownpayment.ResumeLayout(false);
            pnlDownpayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPaymentReceived).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBilling;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private Button btnReservation;
        private Button btnGuestManagement;
        private Button btnRoom;
        private Button btnDashboard;
        private Panel panel3;
        private Label lblTotalCheckIn;
        private Label label6;
        private Panel panel4;
        private Label lblTotalPending;
        private Label label8;
        private Panel panel1;
        private Label lblTotalReservation;
        private Label label1;
        private TextBox txtSearch;
        private Button btnReserveGuest;
        private Label label2;
        private DataGridView dgvReservationList;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem EditToolStripMenuItem;
        private Panel pnlReservationDetails;
        private Label label10;
        private Label label9;
        private Label label7;
        private TextBox txtGuestName;
        private Label label5;
        private TextBox txtSearchGuest;
        private DataGridView dgvGuestList;
        private Label label3;
        private Label label11;
        private Label label12;
        private NumericUpDown numberOfGuest;
        private Label label15;
        private Button btnSelectR;
        private Label label14;
        private Button btnCheckInDate;
        private TextBox txtCheckOutDate;
        private TextBox txtCheckInDate;
        private Label label16;
        private Button btnCheckOutDate;
        private Label lblTotalPrice;
        private Label label19;
        private TextBox txtRoomNumber;
        private Label lblRate;
        private Label lblRoomType;
        private Panel pnlCheckInDate;
        private MonthCalendar monthCalendarCheckIn;
        private Panel pnlCheckOutDate;
        private MonthCalendar monthCalendarCheckOut;
        private Button btnLogout;
        private Button btnSelectG;
        private Panel pnlGuestList;
        private Label lblTotalNight;
        private Label label21;
        private Panel panel7;
        private Button btnCancelGuest;
        private Button btnSelectGuest;
        private Panel pnlRoomList;
        private Button btnCancelRoom;
        private Button btnSelectRoom;
        private TextBox txtSearchRoom;
        private Label label23;
        private DataGridView dgvRoomList;
        private Button btnReserve;
        private Panel panel5;
        private Panel panel2;
        private Label lblTotalAwaiting;
        private Label label13;
        private ToolStripMenuItem processPaymentToolStripMenuItem;
        private ToolStripMenuItem awaitCheckInToolStripMenuItem;
        private ToolStripMenuItem cancelToolStripMenuItem;
        private Panel pnlDownpayment;
        private Label lblDpSubtotal;
        private Label label29;
        private Panel panel9;
        private Panel panel10;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private TextBox textBox3;
        private Label label37;
        private TextBox textBox4;
        private Label label38;
        private Label label39;
        private Panel panel8;
        private Label lblDpTotalNights;
        private Label label22;
        private Label lblDpRate;
        private Label lblDpRoomType;
        private Label label26;
        private Label label27;
        private Label label18;
        private TextBox txtDpFullName;
        private Label label17;
        private TextBox txtDpReservationID;
        private Label label4;
        private Label lbl1;
        private Label label43;
        private Label lblAmountToPay;
        private Label label40;
        private Label label44;
        private ComboBox cboPaymentMethod;
        private NumericUpDown numPaymentReceived;
        private Label lblChange;
        private Label label42;
        private Button btnDpProcess;
        private Button btnCancel;
        private Button btnReserveCancel;
        private Button btnRecords;
    }
}