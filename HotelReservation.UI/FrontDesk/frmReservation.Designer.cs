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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservation));
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
            pnlGuestList = new Panel();
            btnCancelGuest = new Button();
            btnSelectGuest = new Button();
            txtSearchGuest = new TextBox();
            label3 = new Label();
            dgvGuestList = new DataGridView();
            pnlRoomList = new Panel();
            btnCancelRoom = new Button();
            btnSelectRoom = new Button();
            txtSearchRoom = new TextBox();
            label23 = new Label();
            dgvRoomList = new DataGridView();
            btnReserveCancel = new Button();
            pnlCheckOutDate = new Panel();
            monthCalendarCheckOut = new MonthCalendar();
            btnReserve = new Button();
            pnlCheckInDate = new Panel();
            monthCalendarCheckIn = new MonthCalendar();
            panel7 = new Panel();
            btnSelectG = new Button();
            txtRoomNumber = new TextBox();
            btnCheckOutDate = new Button();
            btnCheckInDate = new Button();
            txtCheckOutDate = new TextBox();
            txtCheckInDate = new TextBox();
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
            panel5 = new Panel();
            label16 = new Label();
            label15 = new Label();
            lblTotalNight = new Label();
            lblRoomType = new Label();
            lblRate = new Label();
            label21 = new Label();
            lblTotalPrice = new Label();
            label19 = new Label();
            btnLogout = new Button();
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
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            label20 = new Label();
            panel11 = new Panel();
            label24 = new Label();
            panel12 = new Panel();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservationList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            pnlReservationDetails.SuspendLayout();
            pnlGuestList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuestList).BeginInit();
            pnlRoomList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).BeginInit();
            pnlCheckOutDate.SuspendLayout();
            pnlCheckInDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberOfGuest).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            pnlDownpayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPaymentReceived).BeginInit();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
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
            btnBilling.TabIndex = 20;
            btnBilling.Text = "BILLING PAYMENT";
            btnBilling.UseVisualStyleBackColor = false;
            btnBilling.Click += btnBilling_Click;
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
            btnCheckOut.TabIndex = 19;
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
            btnCheckIn.TabIndex = 18;
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
            btnReservation.TabIndex = 17;
            btnReservation.Text = "RESERVATION";
            btnReservation.UseVisualStyleBackColor = false;
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
            btnGuestManagement.TabIndex = 16;
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
            btnRoom.TabIndex = 15;
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
            btnDashboard.TabIndex = 14;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(19, 52, 113);
            panel3.Controls.Add(lblTotalCheckIn);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(1522, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 90);
            panel3.TabIndex = 28;
            // 
            // lblTotalCheckIn
            // 
            lblTotalCheckIn.AutoSize = true;
            lblTotalCheckIn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTotalCheckIn.ForeColor = SystemColors.ButtonHighlight;
            lblTotalCheckIn.Location = new Point(260, 21);
            lblTotalCheckIn.Name = "lblTotalCheckIn";
            lblTotalCheckIn.Size = new Size(33, 37);
            lblTotalCheckIn.TabIndex = 1;
            lblTotalCheckIn.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(37, 25);
            label6.Name = "label6";
            label6.Size = new Size(130, 33);
            label6.TabIndex = 0;
            label6.Text = "Check-In";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(254, 159, 77);
            panel4.Controls.Add(lblTotalPending);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(739, 123);
            panel4.Name = "panel4";
            panel4.Size = new Size(370, 90);
            panel4.TabIndex = 27;
            // 
            // lblTotalPending
            // 
            lblTotalPending.AutoSize = true;
            lblTotalPending.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTotalPending.ForeColor = SystemColors.ButtonHighlight;
            lblTotalPending.Location = new Point(269, 21);
            lblTotalPending.Name = "lblTotalPending";
            lblTotalPending.Size = new Size(33, 37);
            lblTotalPending.TabIndex = 1;
            lblTotalPending.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(41, 25);
            label8.Name = "label8";
            label8.Size = new Size(121, 33);
            label8.TabIndex = 0;
            label8.Text = "Pending";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 116, 41);
            panel1.Controls.Add(lblTotalReservation);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(349, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 90);
            panel1.TabIndex = 25;
            // 
            // lblTotalReservation
            // 
            lblTotalReservation.AutoSize = true;
            lblTotalReservation.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTotalReservation.ForeColor = SystemColors.ButtonHighlight;
            lblTotalReservation.Location = new Point(298, 21);
            lblTotalReservation.Name = "lblTotalReservation";
            lblTotalReservation.Size = new Size(33, 37);
            lblTotalReservation.TabIndex = 1;
            lblTotalReservation.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(241, 33);
            label1.TabIndex = 0;
            label1.Text = "Total Reservation";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18F);
            txtSearch.Location = new Point(349, 250);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1322, 39);
            txtSearch.TabIndex = 29;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnReserveGuest
            // 
            btnReserveGuest.BackColor = Color.Green;
            btnReserveGuest.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            btnReserveGuest.ForeColor = SystemColors.ButtonHighlight;
            btnReserveGuest.Location = new Point(1695, 250);
            btnReserveGuest.Name = "btnReserveGuest";
            btnReserveGuest.Size = new Size(197, 39);
            btnReserveGuest.TabIndex = 30;
            btnReserveGuest.Text = "Reserve Guest";
            btnReserveGuest.UseVisualStyleBackColor = false;
            btnReserveGuest.Click += btnReserveGuest_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(30, 13);
            label2.Name = "label2";
            label2.Size = new Size(196, 29);
            label2.TabIndex = 31;
            label2.Text = "Reservation List";
            // 
            // dgvReservationList
            // 
            dgvReservationList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservationList.BackgroundColor = SystemColors.ActiveCaption;
            dgvReservationList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservationList.Location = new Point(30, 56);
            dgvReservationList.Name = "dgvReservationList";
            dgvReservationList.Size = new Size(1487, 646);
            dgvReservationList.TabIndex = 32;
            dgvReservationList.CellMouseDown += dgvReservationList_CellMouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { EditToolStripMenuItem, processPaymentToolStripMenuItem, awaitCheckInToolStripMenuItem, cancelToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(179, 92);
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(178, 22);
            EditToolStripMenuItem.Text = "Edit";
            EditToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // processPaymentToolStripMenuItem
            // 
            processPaymentToolStripMenuItem.Name = "processPaymentToolStripMenuItem";
            processPaymentToolStripMenuItem.Size = new Size(178, 22);
            processPaymentToolStripMenuItem.Text = "Process payment";
            processPaymentToolStripMenuItem.Click += processPaymentToolStripMenuItem_Click;
            // 
            // awaitCheckInToolStripMenuItem
            // 
            awaitCheckInToolStripMenuItem.Name = "awaitCheckInToolStripMenuItem";
            awaitCheckInToolStripMenuItem.Size = new Size(178, 22);
            awaitCheckInToolStripMenuItem.Text = "Process Reservation";
            awaitCheckInToolStripMenuItem.Click += awaitCheckInToolStripMenuItem_Click;
            // 
            // cancelToolStripMenuItem
            // 
            cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            cancelToolStripMenuItem.Size = new Size(178, 22);
            cancelToolStripMenuItem.Text = "Cancel";
            cancelToolStripMenuItem.Click += cancelToolStripMenuItem_Click;
            // 
            // pnlReservationDetails
            // 
            pnlReservationDetails.BackColor = Color.FromArgb(19, 52, 113);
            pnlReservationDetails.Controls.Add(pnlGuestList);
            pnlReservationDetails.Controls.Add(pnlRoomList);
            pnlReservationDetails.Controls.Add(btnReserveCancel);
            pnlReservationDetails.Controls.Add(pnlCheckOutDate);
            pnlReservationDetails.Controls.Add(btnReserve);
            pnlReservationDetails.Controls.Add(pnlCheckInDate);
            pnlReservationDetails.Controls.Add(panel7);
            pnlReservationDetails.Controls.Add(btnSelectG);
            pnlReservationDetails.Controls.Add(txtRoomNumber);
            pnlReservationDetails.Controls.Add(btnCheckOutDate);
            pnlReservationDetails.Controls.Add(btnCheckInDate);
            pnlReservationDetails.Controls.Add(txtCheckOutDate);
            pnlReservationDetails.Controls.Add(txtCheckInDate);
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
            pnlReservationDetails.Controls.Add(panel5);
            pnlReservationDetails.Location = new Point(455, 67);
            pnlReservationDetails.Name = "pnlReservationDetails";
            pnlReservationDetails.Size = new Size(803, 556);
            pnlReservationDetails.TabIndex = 34;
            // 
            // pnlGuestList
            // 
            pnlGuestList.BackColor = Color.FromArgb(48, 91, 171);
            pnlGuestList.Controls.Add(btnCancelGuest);
            pnlGuestList.Controls.Add(btnSelectGuest);
            pnlGuestList.Controls.Add(txtSearchGuest);
            pnlGuestList.Controls.Add(label3);
            pnlGuestList.Controls.Add(dgvGuestList);
            pnlGuestList.Location = new Point(54, 89);
            pnlGuestList.Name = "pnlGuestList";
            pnlGuestList.Size = new Size(732, 355);
            pnlGuestList.TabIndex = 38;
            // 
            // btnCancelGuest
            // 
            btnCancelGuest.BackColor = Color.Firebrick;
            btnCancelGuest.FlatStyle = FlatStyle.Flat;
            btnCancelGuest.Font = new Font("Constantia", 11.25F, FontStyle.Bold);
            btnCancelGuest.ForeColor = SystemColors.ButtonHighlight;
            btnCancelGuest.Location = new Point(606, 307);
            btnCancelGuest.Name = "btnCancelGuest";
            btnCancelGuest.Size = new Size(112, 32);
            btnCancelGuest.TabIndex = 4;
            btnCancelGuest.Text = "Cancel";
            btnCancelGuest.UseVisualStyleBackColor = false;
            btnCancelGuest.Click += btnCancelGuest_Click;
            // 
            // btnSelectGuest
            // 
            btnSelectGuest.BackColor = Color.Green;
            btnSelectGuest.FlatStyle = FlatStyle.Flat;
            btnSelectGuest.Font = new Font("Constantia", 11.25F, FontStyle.Bold);
            btnSelectGuest.ForeColor = SystemColors.ButtonHighlight;
            btnSelectGuest.Location = new Point(480, 307);
            btnSelectGuest.Name = "btnSelectGuest";
            btnSelectGuest.Size = new Size(112, 32);
            btnSelectGuest.TabIndex = 3;
            btnSelectGuest.Text = "Select";
            btnSelectGuest.UseVisualStyleBackColor = false;
            btnSelectGuest.Click += btnSelectGuest_Click;
            // 
            // txtSearchGuest
            // 
            txtSearchGuest.Font = new Font("Segoe UI", 11.25F);
            txtSearchGuest.Location = new Point(17, 50);
            txtSearchGuest.Name = "txtSearchGuest";
            txtSearchGuest.Size = new Size(699, 27);
            txtSearchGuest.TabIndex = 2;
            txtSearchGuest.TextChanged += txtSearchGuest_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(17, 16);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            label3.Text = "Guest List";
            // 
            // dgvGuestList
            // 
            dgvGuestList.AllowUserToAddRows = false;
            dgvGuestList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuestList.BackgroundColor = SystemColors.ActiveCaption;
            dgvGuestList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuestList.Location = new Point(17, 88);
            dgvGuestList.Name = "dgvGuestList";
            dgvGuestList.Size = new Size(699, 202);
            dgvGuestList.TabIndex = 1;
            // 
            // pnlRoomList
            // 
            pnlRoomList.BackColor = Color.FromArgb(48, 91, 171);
            pnlRoomList.Controls.Add(btnCancelRoom);
            pnlRoomList.Controls.Add(btnSelectRoom);
            pnlRoomList.Controls.Add(txtSearchRoom);
            pnlRoomList.Controls.Add(label23);
            pnlRoomList.Controls.Add(dgvRoomList);
            pnlRoomList.Location = new Point(42, 222);
            pnlRoomList.Name = "pnlRoomList";
            pnlRoomList.Size = new Size(732, 318);
            pnlRoomList.TabIndex = 39;
            // 
            // btnCancelRoom
            // 
            btnCancelRoom.BackColor = Color.Firebrick;
            btnCancelRoom.FlatStyle = FlatStyle.Flat;
            btnCancelRoom.Font = new Font("Constantia", 11.25F, FontStyle.Bold);
            btnCancelRoom.ForeColor = SystemColors.ButtonHighlight;
            btnCancelRoom.Location = new Point(606, 276);
            btnCancelRoom.Name = "btnCancelRoom";
            btnCancelRoom.Size = new Size(112, 32);
            btnCancelRoom.TabIndex = 6;
            btnCancelRoom.Text = "Cancel";
            btnCancelRoom.UseVisualStyleBackColor = false;
            btnCancelRoom.Click += btnCancelRoom_Click;
            // 
            // btnSelectRoom
            // 
            btnSelectRoom.BackColor = Color.Green;
            btnSelectRoom.FlatStyle = FlatStyle.Flat;
            btnSelectRoom.Font = new Font("Constantia", 11.25F, FontStyle.Bold);
            btnSelectRoom.ForeColor = SystemColors.ButtonHighlight;
            btnSelectRoom.Location = new Point(482, 276);
            btnSelectRoom.Name = "btnSelectRoom";
            btnSelectRoom.Size = new Size(112, 32);
            btnSelectRoom.TabIndex = 5;
            btnSelectRoom.Text = "Select";
            btnSelectRoom.UseVisualStyleBackColor = false;
            btnSelectRoom.Click += btnSelectRoom_Click;
            // 
            // txtSearchRoom
            // 
            txtSearchRoom.Font = new Font("Segoe UI", 11.25F);
            txtSearchRoom.Location = new Point(20, 51);
            txtSearchRoom.Name = "txtSearchRoom";
            txtSearchRoom.Size = new Size(699, 27);
            txtSearchRoom.TabIndex = 2;
            txtSearchRoom.TextChanged += txtSearchRoom_TextChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            label23.ForeColor = SystemColors.ButtonHighlight;
            label23.Location = new Point(23, 19);
            label23.Name = "label23";
            label23.Size = new Size(101, 23);
            label23.TabIndex = 0;
            label23.Text = "Room List";
            // 
            // dgvRoomList
            // 
            dgvRoomList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomList.BackgroundColor = SystemColors.ActiveCaption;
            dgvRoomList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomList.Location = new Point(20, 86);
            dgvRoomList.Name = "dgvRoomList";
            dgvRoomList.Size = new Size(699, 181);
            dgvRoomList.TabIndex = 1;
            dgvRoomList.Tag = "";
            // 
            // btnReserveCancel
            // 
            btnReserveCancel.BackColor = Color.Firebrick;
            btnReserveCancel.FlatStyle = FlatStyle.Flat;
            btnReserveCancel.Font = new Font("Constantia", 11.25F, FontStyle.Bold);
            btnReserveCancel.ForeColor = SystemColors.ButtonHighlight;
            btnReserveCancel.Location = new Point(674, 495);
            btnReserveCancel.Name = "btnReserveCancel";
            btnReserveCancel.Size = new Size(112, 32);
            btnReserveCancel.TabIndex = 37;
            btnReserveCancel.Text = "Cancel";
            btnReserveCancel.UseVisualStyleBackColor = false;
            btnReserveCancel.Click += btnReserveCancel_Click;
            // 
            // pnlCheckOutDate
            // 
            pnlCheckOutDate.BackColor = Color.FromArgb(48, 91, 171);
            pnlCheckOutDate.Controls.Add(monthCalendarCheckOut);
            pnlCheckOutDate.Location = new Point(540, 134);
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
            // btnReserve
            // 
            btnReserve.BackColor = Color.DarkGreen;
            btnReserve.FlatStyle = FlatStyle.Flat;
            btnReserve.Font = new Font("Constantia", 11.25F, FontStyle.Bold);
            btnReserve.ForeColor = SystemColors.ButtonHighlight;
            btnReserve.Location = new Point(543, 495);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(112, 32);
            btnReserve.TabIndex = 34;
            btnReserve.Text = "Reserve";
            btnReserve.UseVisualStyleBackColor = false;
            btnReserve.Click += btnReserve_Click;
            // 
            // pnlCheckInDate
            // 
            pnlCheckInDate.BackColor = Color.FromArgb(48, 91, 171);
            pnlCheckInDate.Controls.Add(monthCalendarCheckIn);
            pnlCheckInDate.Location = new Point(152, 133);
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
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(48, 91, 171);
            panel7.Location = new Point(4, 242);
            panel7.Name = "panel7";
            panel7.Size = new Size(793, 14);
            panel7.TabIndex = 30;
            // 
            // btnSelectG
            // 
            btnSelectG.Location = new Point(691, 54);
            btnSelectG.Name = "btnSelectG";
            btnSelectG.Size = new Size(95, 31);
            btnSelectG.TabIndex = 29;
            btnSelectG.Text = "Select Guest";
            btnSelectG.UseVisualStyleBackColor = true;
            btnSelectG.Click += btnSelectG_Click;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Segoe UI", 11.25F);
            txtRoomNumber.Location = new Point(152, 192);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.ReadOnly = true;
            txtRoomNumber.Size = new Size(383, 27);
            txtRoomNumber.TabIndex = 26;
            // 
            // btnCheckOutDate
            // 
            btnCheckOutDate.Location = new Point(755, 103);
            btnCheckOutDate.Name = "btnCheckOutDate";
            btnCheckOutDate.Size = new Size(31, 27);
            btnCheckOutDate.TabIndex = 23;
            btnCheckOutDate.Text = "v";
            btnCheckOutDate.UseVisualStyleBackColor = true;
            btnCheckOutDate.Click += btnCheckOutDate_Click;
            // 
            // btnCheckInDate
            // 
            btnCheckInDate.Location = new Point(366, 102);
            btnCheckInDate.Name = "btnCheckInDate";
            btnCheckInDate.Size = new Size(31, 27);
            btnCheckInDate.TabIndex = 22;
            btnCheckInDate.Text = "v";
            btnCheckInDate.UseVisualStyleBackColor = true;
            btnCheckInDate.Click += btnCheckInDate_Click;
            // 
            // txtCheckOutDate
            // 
            txtCheckOutDate.Font = new Font("Segoe UI", 11.25F);
            txtCheckOutDate.Location = new Point(534, 103);
            txtCheckOutDate.Name = "txtCheckOutDate";
            txtCheckOutDate.Size = new Size(215, 27);
            txtCheckOutDate.TabIndex = 21;
            // 
            // txtCheckInDate
            // 
            txtCheckInDate.Font = new Font("Segoe UI", 11.25F);
            txtCheckInDate.Location = new Point(152, 102);
            txtCheckInDate.Name = "txtCheckInDate";
            txtCheckInDate.Size = new Size(208, 27);
            txtCheckInDate.TabIndex = 20;
            // 
            // btnSelectR
            // 
            btnSelectR.Location = new Point(541, 191);
            btnSelectR.Name = "btnSelectR";
            btnSelectR.Size = new Size(95, 30);
            btnSelectR.TabIndex = 17;
            btnSelectR.Text = "Select Room";
            btnSelectR.UseVisualStyleBackColor = true;
            btnSelectR.Click += btnSelectR_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(36, 195);
            label14.Name = "label14";
            label14.Size = new Size(110, 20);
            label14.TabIndex = 15;
            label14.Text = "Room Number";
            // 
            // numberOfGuest
            // 
            numberOfGuest.Font = new Font("Segoe UI", 11.25F);
            numberOfGuest.Location = new Point(152, 148);
            numberOfGuest.Name = "numberOfGuest";
            numberOfGuest.Size = new Size(383, 27);
            numberOfGuest.TabIndex = 12;
            numberOfGuest.ValueChanged += numberOfGuest_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(20, 153);
            label12.Name = "label12";
            label12.Size = new Size(126, 20);
            label12.TabIndex = 11;
            label12.Text = "Number of Guest";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(400, 104);
            label11.Name = "label11";
            label11.Size = new Size(13, 20);
            label11.TabIndex = 10;
            label11.Text = ":";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(412, 105);
            label10.Name = "label10";
            label10.Size = new Size(116, 20);
            label10.TabIndex = 7;
            label10.Text = "Check-Out Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(42, 105);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 6;
            label9.Text = "Check-In Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(54, 59);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 5;
            label7.Text = "Guest Name";
            // 
            // txtGuestName
            // 
            txtGuestName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuestName.Location = new Point(152, 56);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.ReadOnly = true;
            txtGuestName.Size = new Size(533, 27);
            txtGuestName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(8, 11);
            label5.Name = "label5";
            label5.Size = new Size(184, 23);
            label5.TabIndex = 3;
            label5.Text = "Reservation Details";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(lblTotalNight);
            panel5.Controls.Add(lblRoomType);
            panel5.Controls.Add(lblRate);
            panel5.Controls.Add(label21);
            panel5.Controls.Add(lblTotalPrice);
            panel5.Controls.Add(label19);
            panel5.Location = new Point(20, 277);
            panel5.Name = "panel5";
            panel5.Size = new Size(766, 190);
            panel5.TabIndex = 33;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.ControlLight;
            label16.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label16.Location = new Point(97, 60);
            label16.Name = "label16";
            label16.Size = new Size(39, 20);
            label16.TabIndex = 19;
            label16.Text = "Rate";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ControlLight;
            label15.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label15.Location = new Point(51, 12);
            label15.Name = "label15";
            label15.Size = new Size(85, 20);
            label15.TabIndex = 18;
            label15.Text = "Room Type";
            // 
            // lblTotalNight
            // 
            lblTotalNight.AutoSize = true;
            lblTotalNight.BackColor = SystemColors.ControlLight;
            lblTotalNight.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblTotalNight.Location = new Point(156, 104);
            lblTotalNight.Name = "lblTotalNight";
            lblTotalNight.Size = new Size(15, 20);
            lblTotalNight.TabIndex = 32;
            lblTotalNight.Text = "-";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.BackColor = SystemColors.ControlLight;
            lblRoomType.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblRoomType.Location = new Point(157, 12);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(15, 20);
            lblRoomType.TabIndex = 24;
            lblRoomType.Text = "-";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.BackColor = SystemColors.ControlLight;
            lblRate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblRate.Location = new Point(157, 60);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(15, 20);
            lblRate.TabIndex = 25;
            lblRate.Text = "-";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = SystemColors.ControlLight;
            label21.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label21.Location = new Point(35, 104);
            label21.Name = "label21";
            label21.Size = new Size(101, 20);
            label21.TabIndex = 31;
            label21.Text = "Total Night(s)";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblTotalPrice.ForeColor = Color.ForestGreen;
            lblTotalPrice.Location = new Point(157, 150);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(15, 20);
            lblTotalPrice.TabIndex = 28;
            lblTotalPrice.Text = "-";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label19.Location = new Point(90, 150);
            label19.Name = "label19";
            label19.Size = new Size(46, 20);
            label19.TabIndex = 27;
            label19.Text = "Total:";
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
            btnLogout.TabIndex = 37;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 100, 100);
            panel2.Controls.Add(lblTotalAwaiting);
            panel2.Controls.Add(label13);
            panel2.Location = new Point(1130, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 90);
            panel2.TabIndex = 40;
            // 
            // lblTotalAwaiting
            // 
            lblTotalAwaiting.AutoSize = true;
            lblTotalAwaiting.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTotalAwaiting.ForeColor = SystemColors.ButtonHighlight;
            lblTotalAwaiting.Location = new Point(251, 21);
            lblTotalAwaiting.Name = "lblTotalAwaiting";
            lblTotalAwaiting.Size = new Size(33, 37);
            lblTotalAwaiting.TabIndex = 1;
            lblTotalAwaiting.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(34, 25);
            label13.Name = "label13";
            label13.Size = new Size(134, 33);
            label13.TabIndex = 0;
            label13.Text = "Reserved";
            // 
            // pnlDownpayment
            // 
            pnlDownpayment.BackColor = Color.LightSteelBlue;
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
            pnlDownpayment.Location = new Point(605, 63);
            pnlDownpayment.Name = "pnlDownpayment";
            pnlDownpayment.Size = new Size(518, 622);
            pnlDownpayment.TabIndex = 41;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(380, 578);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 34);
            btnCancel.TabIndex = 57;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnDpCancel_Click;
            // 
            // btnDpProcess
            // 
            btnDpProcess.BackColor = Color.ForestGreen;
            btnDpProcess.FlatStyle = FlatStyle.Flat;
            btnDpProcess.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnDpProcess.ForeColor = SystemColors.ButtonFace;
            btnDpProcess.Location = new Point(262, 578);
            btnDpProcess.Name = "btnDpProcess";
            btnDpProcess.Size = new Size(108, 34);
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
            lblChange.Location = new Point(188, 547);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(12, 15);
            lblChange.TabIndex = 55;
            lblChange.Text = "-";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label42.Location = new Point(107, 545);
            label42.Name = "label42";
            label42.Size = new Size(58, 17);
            label42.TabIndex = 54;
            label42.Text = "Change:";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label44.Location = new Point(47, 506);
            label44.Name = "label44";
            label44.Size = new Size(118, 17);
            label44.TabIndex = 53;
            label44.Text = "Payment method:";
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.Font = new Font("Segoe UI", 11.25F);
            cboPaymentMethod.FormattingEnabled = true;
            cboPaymentMethod.Location = new Point(175, 501);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(310, 28);
            cboPaymentMethod.TabIndex = 52;
            // 
            // numPaymentReceived
            // 
            numPaymentReceived.Font = new Font("Segoe UI", 11.25F);
            numPaymentReceived.Location = new Point(175, 464);
            numPaymentReceived.Name = "numPaymentReceived";
            numPaymentReceived.Size = new Size(310, 27);
            numPaymentReceived.TabIndex = 51;
            numPaymentReceived.ValueChanged += numPaymentReceived_ValueChanged;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label43.Location = new Point(44, 468);
            label43.Name = "label43";
            label43.Size = new Size(121, 17);
            label43.TabIndex = 49;
            label43.Text = "Payment received:";
            // 
            // lblAmountToPay
            // 
            lblAmountToPay.AutoSize = true;
            lblAmountToPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountToPay.ForeColor = Color.ForestGreen;
            lblAmountToPay.Location = new Point(188, 426);
            lblAmountToPay.Name = "lblAmountToPay";
            lblAmountToPay.Size = new Size(12, 15);
            lblAmountToPay.TabIndex = 46;
            lblAmountToPay.Text = "-";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label40.Location = new Point(60, 426);
            label40.Name = "label40";
            label40.Size = new Size(105, 17);
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
            panel8.BackColor = SystemColors.GradientInactiveCaption;
            panel8.Controls.Add(lblDpTotalNights);
            panel8.Controls.Add(lblDpSubtotal);
            panel8.Controls.Add(label22);
            panel8.Controls.Add(label29);
            panel8.Controls.Add(lblDpRate);
            panel8.Controls.Add(lblDpRoomType);
            panel8.Controls.Add(label26);
            panel8.Controls.Add(label27);
            panel8.Location = new Point(28, 222);
            panel8.Name = "panel8";
            panel8.Size = new Size(457, 179);
            panel8.TabIndex = 34;
            // 
            // lblDpTotalNights
            // 
            lblDpTotalNights.AutoSize = true;
            lblDpTotalNights.BackColor = SystemColors.GradientInactiveCaption;
            lblDpTotalNights.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblDpTotalNights.Location = new Point(164, 95);
            lblDpTotalNights.Name = "lblDpTotalNights";
            lblDpTotalNights.Size = new Size(11, 16);
            lblDpTotalNights.TabIndex = 38;
            lblDpTotalNights.Text = "-";
            // 
            // lblDpSubtotal
            // 
            lblDpSubtotal.AutoSize = true;
            lblDpSubtotal.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblDpSubtotal.ForeColor = Color.ForestGreen;
            lblDpSubtotal.Location = new Point(164, 135);
            lblDpSubtotal.Name = "lblDpSubtotal";
            lblDpSubtotal.Size = new Size(11, 16);
            lblDpSubtotal.TabIndex = 43;
            lblDpSubtotal.Text = "-";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = SystemColors.GradientInactiveCaption;
            label22.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label22.Location = new Point(19, 97);
            label22.Name = "label22";
            label22.Size = new Size(101, 16);
            label22.TabIndex = 37;
            label22.Text = "Total Night(s)";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label29.Location = new Point(52, 135);
            label29.Name = "label29";
            label29.Size = new Size(68, 16);
            label29.TabIndex = 42;
            label29.Text = "Subtotal:";
            // 
            // lblDpRate
            // 
            lblDpRate.AutoSize = true;
            lblDpRate.BackColor = SystemColors.GradientInactiveCaption;
            lblDpRate.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblDpRate.Location = new Point(164, 60);
            lblDpRate.Name = "lblDpRate";
            lblDpRate.Size = new Size(11, 16);
            lblDpRate.TabIndex = 36;
            lblDpRate.Text = "-";
            // 
            // lblDpRoomType
            // 
            lblDpRoomType.AutoSize = true;
            lblDpRoomType.BackColor = SystemColors.GradientInactiveCaption;
            lblDpRoomType.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblDpRoomType.Location = new Point(164, 22);
            lblDpRoomType.Name = "lblDpRoomType";
            lblDpRoomType.Size = new Size(11, 16);
            lblDpRoomType.TabIndex = 35;
            lblDpRoomType.Text = "-";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = SystemColors.GradientInactiveCaption;
            label26.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label26.Location = new Point(80, 60);
            label26.Name = "label26";
            label26.Size = new Size(40, 16);
            label26.TabIndex = 34;
            label26.Text = "Rate";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = SystemColors.GradientInactiveCaption;
            label27.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label27.Location = new Point(32, 22);
            label27.Name = "label27";
            label27.Size = new Size(88, 16);
            label27.TabIndex = 33;
            label27.Text = "Room Type";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(27, 204);
            label18.Name = "label18";
            label18.Size = new Size(63, 15);
            label18.TabIndex = 8;
            label18.Text = "Paying for";
            // 
            // txtDpFullName
            // 
            txtDpFullName.Font = new Font("Segoe UI", 11.25F);
            txtDpFullName.Location = new Point(165, 149);
            txtDpFullName.Name = "txtDpFullName";
            txtDpFullName.ReadOnly = true;
            txtDpFullName.Size = new Size(298, 27);
            txtDpFullName.TabIndex = 7;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label17.Location = new Point(74, 152);
            label17.Name = "label17";
            label17.Size = new Size(80, 20);
            label17.TabIndex = 6;
            label17.Text = "Full Name";
            // 
            // txtDpReservationID
            // 
            txtDpReservationID.Font = new Font("Segoe UI", 11.25F);
            txtDpReservationID.Location = new Point(165, 93);
            txtDpReservationID.Name = "txtDpReservationID";
            txtDpReservationID.ReadOnly = true;
            txtDpReservationID.Size = new Size(298, 27);
            txtDpReservationID.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(41, 96);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 4;
            label4.Text = "Reservation ID";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            lbl1.Location = new Point(18, 21);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(210, 23);
            lbl1.TabIndex = 3;
            lbl1.Text = "Downpayment Details";
            // 
            // btnRecords
            // 
            btnRecords.BackColor = Color.FromArgb(48, 91, 171);
            btnRecords.FlatStyle = FlatStyle.Popup;
            btnRecords.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnRecords.ForeColor = SystemColors.ButtonHighlight;
            btnRecords.Location = new Point(35, 579);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(263, 43);
            btnRecords.TabIndex = 42;
            btnRecords.Text = "BOOKED RECORDS";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(19, 52, 113);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(label20);
            panel6.Controls.Add(btnDashboard);
            panel6.Controls.Add(btnRoom);
            panel6.Controls.Add(btnRecords);
            panel6.Controls.Add(btnGuestManagement);
            panel6.Controls.Add(btnReservation);
            panel6.Controls.Add(btnCheckIn);
            panel6.Controls.Add(btnCheckOut);
            panel6.Controls.Add(btnBilling);
            panel6.Controls.Add(btnLogout);
            panel6.Location = new Point(0, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(336, 1044);
            panel6.TabIndex = 43;
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
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(101, 138, 208);
            label20.Location = new Point(27, 160);
            label20.Name = "label20";
            label20.Size = new Size(86, 15);
            label20.TabIndex = 72;
            label20.Text = "NAVIGATIONS";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(7, 31, 77);
            panel11.Controls.Add(label24);
            panel11.Location = new Point(334, -1);
            panel11.Name = "panel11";
            panel11.Size = new Size(1572, 108);
            panel11.TabIndex = 44;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Constantia", 21.75F, FontStyle.Bold);
            label24.ForeColor = Color.White;
            label24.Location = new Point(32, 36);
            label24.Name = "label24";
            label24.Size = new Size(195, 36);
            label24.TabIndex = 44;
            label24.Text = "Reservations";
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(48, 91, 171);
            panel12.Controls.Add(pnlDownpayment);
            panel12.Controls.Add(pnlReservationDetails);
            panel12.Controls.Add(dgvReservationList);
            panel12.Controls.Add(label2);
            panel12.Location = new Point(349, 313);
            panel12.Name = "panel12";
            panel12.Size = new Size(1543, 716);
            panel12.TabIndex = 45;
            // 
            // frmReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnReserveGuest);
            Controls.Add(txtSearch);
            Controls.Add(panel4);
            Controls.Add(panel1);
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
            pnlGuestList.ResumeLayout(false);
            pnlGuestList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuestList).EndInit();
            pnlRoomList.ResumeLayout(false);
            pnlRoomList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).EndInit();
            pnlCheckOutDate.ResumeLayout(false);
            pnlCheckInDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numberOfGuest).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
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
        private Panel panel6;
        private Panel panel11;
        private Panel panel12;
        private Label label20;
        private PictureBox pictureBox1;
        private Label label24;
    }
}