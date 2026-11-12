namespace HotelReservation.UI.FrontDesk
{
    partial class frmGuestManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuestManagement));
            dgvGuestsList = new DataGridView();
            btnBilling = new Button();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            btnReservation = new Button();
            btnGuestManagement = new Button();
            btnRoom = new Button();
            btnDashboard = new Button();
            lblTotalGuest = new Label();
            btnAddGuest = new Button();
            txtSearch = new TextBox();
            pnlAddGuest = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtEmergencyNumber = new MaskedTextBox();
            txtEmergencyName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtProvince = new TextBox();
            txtCity = new TextBox();
            txtStreet = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtPhone = new MaskedTextBox();
            cmbGender = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            dtpBirthDate = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnRefresh = new Button();
            cMenuGuest = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            btnLogout = new Button();
            btnRecords = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGuestsList).BeginInit();
            pnlAddGuest.SuspendLayout();
            cMenuGuest.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGuestsList
            // 
            dgvGuestsList.AllowUserToAddRows = false;
            dgvGuestsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuestsList.BackgroundColor = SystemColors.ActiveCaption;
            dgvGuestsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuestsList.Location = new Point(24, 173);
            dgvGuestsList.Name = "dgvGuestsList";
            dgvGuestsList.Size = new Size(1465, 683);
            dgvGuestsList.TabIndex = 0;
            dgvGuestsList.CellFormatting += dgvGuestsList_CellFormatting;
            dgvGuestsList.CellMouseDown += dgvGuestsList_CellMouseDown;
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
            btnBilling.TabIndex = 13;
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
            btnCheckOut.TabIndex = 12;
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
            btnCheckIn.TabIndex = 11;
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
            btnReservation.TabIndex = 10;
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
            btnGuestManagement.TabIndex = 9;
            btnGuestManagement.Text = "GUEST";
            btnGuestManagement.UseVisualStyleBackColor = false;
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
            btnRoom.TabIndex = 8;
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
            btnDashboard.TabIndex = 7;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblTotalGuest
            // 
            lblTotalGuest.AutoSize = true;
            lblTotalGuest.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTotalGuest.ForeColor = Color.White;
            lblTotalGuest.Location = new Point(228, 26);
            lblTotalGuest.Name = "lblTotalGuest";
            lblTotalGuest.Size = new Size(33, 37);
            lblTotalGuest.TabIndex = 15;
            lblTotalGuest.Text = "0";
            // 
            // btnAddGuest
            // 
            btnAddGuest.BackColor = Color.Green;
            btnAddGuest.FlatStyle = FlatStyle.Flat;
            btnAddGuest.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            btnAddGuest.ForeColor = SystemColors.ButtonHighlight;
            btnAddGuest.Location = new Point(1325, 93);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new Size(164, 39);
            btnAddGuest.TabIndex = 16;
            btnAddGuest.Text = "Add Guest";
            btnAddGuest.UseVisualStyleBackColor = false;
            btnAddGuest.Click += btnAddGuest_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18F);
            txtSearch.Location = new Point(24, 93);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1096, 39);
            txtSearch.TabIndex = 18;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // pnlAddGuest
            // 
            pnlAddGuest.BackColor = Color.FromArgb(7, 31, 77);
            pnlAddGuest.Controls.Add(textBox2);
            pnlAddGuest.Controls.Add(textBox1);
            pnlAddGuest.Controls.Add(btnCancel);
            pnlAddGuest.Controls.Add(btnSave);
            pnlAddGuest.Controls.Add(txtEmergencyNumber);
            pnlAddGuest.Controls.Add(txtEmergencyName);
            pnlAddGuest.Controls.Add(label10);
            pnlAddGuest.Controls.Add(label9);
            pnlAddGuest.Controls.Add(label8);
            pnlAddGuest.Controls.Add(label7);
            pnlAddGuest.Controls.Add(txtProvince);
            pnlAddGuest.Controls.Add(txtCity);
            pnlAddGuest.Controls.Add(txtStreet);
            pnlAddGuest.Controls.Add(label6);
            pnlAddGuest.Controls.Add(label5);
            pnlAddGuest.Controls.Add(txtPhone);
            pnlAddGuest.Controls.Add(cmbGender);
            pnlAddGuest.Controls.Add(label4);
            pnlAddGuest.Controls.Add(label3);
            pnlAddGuest.Controls.Add(dtpBirthDate);
            pnlAddGuest.Controls.Add(label11);
            pnlAddGuest.Controls.Add(label12);
            pnlAddGuest.Controls.Add(txtLastName);
            pnlAddGuest.Controls.Add(txtFirstName);
            pnlAddGuest.Location = new Point(425, 196);
            pnlAddGuest.Name = "pnlAddGuest";
            pnlAddGuest.Size = new Size(477, 643);
            pnlAddGuest.TabIndex = 22;
            pnlAddGuest.Paint += pnlAddGuest_Paint;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox2.Location = new Point(26, 525);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(52, 29);
            textBox2.TabIndex = 46;
            textBox2.Text = "(+63) -/";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.Location = new Point(24, 251);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(52, 29);
            textBox1.TabIndex = 45;
            textBox1.Text = "(+63) -/";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(342, 587);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 33);
            btnCancel.TabIndex = 44;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(222, 587);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 33);
            btnSave.TabIndex = 43;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmergencyNumber
            // 
            txtEmergencyNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtEmergencyNumber.Location = new Point(80, 525);
            txtEmergencyNumber.Mask = "000-000-0000";
            txtEmergencyNumber.Name = "txtEmergencyNumber";
            txtEmergencyNumber.Size = new Size(370, 29);
            txtEmergencyNumber.TabIndex = 42;
            // 
            // txtEmergencyName
            // 
            txtEmergencyName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtEmergencyName.Location = new Point(24, 457);
            txtEmergencyName.Name = "txtEmergencyName";
            txtEmergencyName.Size = new Size(426, 29);
            txtEmergencyName.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(24, 499);
            label10.Name = "label10";
            label10.Size = new Size(197, 23);
            label10.TabIndex = 40;
            label10.Text = "Emergency Contact #";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(24, 431);
            label9.Name = "label9";
            label9.Size = new Size(165, 23);
            label9.TabIndex = 39;
            label9.Text = "Emergency Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(242, 362);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 38;
            label8.Text = "Province";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(24, 362);
            label7.Name = "label7";
            label7.Size = new Size(46, 23);
            label7.TabIndex = 37;
            label7.Text = "City";
            // 
            // txtProvince
            // 
            txtProvince.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtProvince.Location = new Point(242, 388);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(208, 29);
            txtProvince.TabIndex = 36;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtCity.Location = new Point(24, 388);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(212, 29);
            txtCity.TabIndex = 35;
            // 
            // txtStreet
            // 
            txtStreet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtStreet.Location = new Point(24, 320);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(426, 29);
            txtStreet.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(24, 294);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 33;
            label6.Text = "Street";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(24, 225);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 32;
            label5.Text = "Number";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtPhone.Location = new Point(77, 251);
            txtPhone.Mask = "900-000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(220, 29);
            txtPhone.TabIndex = 31;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(303, 251);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(147, 29);
            cmbGender.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(303, 225);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 29;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(23, 158);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 28;
            label3.Text = "Date of Birth";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dtpBirthDate.Location = new Point(24, 184);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(426, 29);
            dtpBirthDate.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(23, 90);
            label11.Name = "label11";
            label11.Size = new Size(104, 23);
            label11.TabIndex = 26;
            label11.Text = "Last Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(24, 22);
            label12.Name = "label12";
            label12.Size = new Size(108, 23);
            label12.TabIndex = 25;
            label12.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtLastName.Location = new Point(24, 116);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(426, 29);
            txtLastName.TabIndex = 24;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(23, 48);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(427, 29);
            txtFirstName.TabIndex = 23;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Green;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            btnRefresh.ForeColor = SystemColors.ButtonHighlight;
            btnRefresh.Location = new Point(1145, 93);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(164, 39);
            btnRefresh.TabIndex = 23;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cMenuGuest
            // 
            cMenuGuest.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            cMenuGuest.Name = "cMenuGuest";
            cMenuGuest.Size = new Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
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
            btnLogout.TabIndex = 24;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
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
            btnRecords.TabIndex = 37;
            btnRecords.Text = "BILLING RECORDS";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 52, 113);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnRoom);
            panel1.Controls.Add(btnGuestManagement);
            panel1.Controls.Add(btnRecords);
            panel1.Controls.Add(btnReservation);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnCheckIn);
            panel1.Controls.Add(btnCheckOut);
            panel1.Controls.Add(btnBilling);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 1044);
            panel1.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 31, 77);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(334, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1572, 108);
            panel2.TabIndex = 39;
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
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(48, 91, 171);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pnlAddGuest);
            panel3.Controls.Add(dgvGuestsList);
            panel3.Controls.Add(lblTotalGuest);
            panel3.Controls.Add(btnAddGuest);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(btnRefresh);
            panel3.Location = new Point(367, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(1510, 877);
            panel3.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 30);
            label1.Name = "label1";
            label1.Size = new Size(161, 33);
            label1.TabIndex = 24;
            label1.Text = "Total Guest";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 36);
            label2.Name = "label2";
            label2.Size = new Size(282, 36);
            label2.TabIndex = 1;
            label2.Text = "Guest Management";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(101, 138, 208);
            label13.Location = new Point(27, 160);
            label13.Name = "label13";
            label13.Size = new Size(86, 15);
            label13.TabIndex = 46;
            label13.Text = "NAVIGATIONS";
            // 
            // frmGuestManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmGuestManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGuestManagement";
            Load += frmGuestManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGuestsList).EndInit();
            pnlAddGuest.ResumeLayout(false);
            pnlAddGuest.PerformLayout();
            cMenuGuest.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGuestsList;
        private Button btnBilling;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private Button btnReservation;
        private Button btnGuestManagement;
        private Button btnRoom;
        private Button btnDashboard;
        private Label lblTotalGuest;
        private Button btnAddGuest;
        private TextBox txtSearch;
        private Panel pnlAddGuest;
        private Button btnCancel;
        private Button btnSave;
        private MaskedTextBox txtEmergencyNumber;
        private TextBox txtEmergencyName;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtProvince;
        private TextBox txtCity;
        private TextBox txtStreet;
        private Label label6;
        private Label label5;
        private MaskedTextBox txtPhone;
        private ComboBox cmbGender;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpBirthDate;
        private Label label11;
        private Label label12;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnRefresh;
        private ContextMenuStrip cMenuGuest;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button btnLogout;
        private Button btnRecords;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label13;
    }
}