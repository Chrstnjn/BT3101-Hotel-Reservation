namespace HotelReservation.UI.Admin
{
    partial class frmRoomManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoomManagement));
            pnlRoomType = new Panel();
            btnCancel = new Button();
            btnAdd = new Button();
            txtPricePerNight = new TextBox();
            textBox3 = new TextBox();
            txtNumberofBed = new NumericUpDown();
            txtNumberofPerson = new NumericUpDown();
            label9 = new Label();
            txtRoomType = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvRoomTypeList = new DataGridView();
            dgvRoomList = new DataGridView();
            txtSearch = new TextBox();
            btnAddRoom = new Button();
            btnAddRoomType = new Button();
            panel3 = new Panel();
            lblTotalRType = new Label();
            label6 = new Label();
            panel4 = new Panel();
            lblTotalMaintenance = new Label();
            label8 = new Label();
            panel2 = new Panel();
            lblTotalAvailable = new Label();
            label4 = new Label();
            panel1 = new Panel();
            lblTotalRoom = new Label();
            label1 = new Label();
            btnPayment = new Button();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            btnReservation = new Button();
            btnGuestManagement = new Button();
            btnRoom = new Button();
            btnDashboard = new Button();
            pnlRoom = new Panel();
            label13 = new Label();
            btnBack = new Button();
            btnRoomAdd = new Button();
            txtRoomNumber = new TextBox();
            cmbRoomType = new ComboBox();
            cmbStatus = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            cMenuRoom = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            cMenuRoomType = new ContextMenuStrip(components);
            editToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            panel6 = new Panel();
            label14 = new Label();
            panel5 = new Panel();
            btnLogout = new Button();
            label15 = new Label();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            label16 = new Label();
            panel8 = new Panel();
            label17 = new Label();
            pnlRoomType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtNumberofBed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNumberofPerson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pnlRoom.SuspendLayout();
            cMenuRoom.SuspendLayout();
            cMenuRoomType.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRoomType
            // 
            pnlRoomType.BackColor = SystemColors.ActiveCaption;
            pnlRoomType.Controls.Add(btnCancel);
            pnlRoomType.Controls.Add(btnAdd);
            pnlRoomType.Controls.Add(txtPricePerNight);
            pnlRoomType.Controls.Add(textBox3);
            pnlRoomType.Controls.Add(txtNumberofBed);
            pnlRoomType.Controls.Add(txtNumberofPerson);
            pnlRoomType.Controls.Add(label9);
            pnlRoomType.Controls.Add(txtRoomType);
            pnlRoomType.Controls.Add(label7);
            pnlRoomType.Controls.Add(label5);
            pnlRoomType.Controls.Add(label3);
            pnlRoomType.Controls.Add(label2);
            pnlRoomType.Location = new Point(841, 239);
            pnlRoomType.Name = "pnlRoomType";
            pnlRoomType.Size = new Size(504, 431);
            pnlRoomType.TabIndex = 47;
            pnlRoomType.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(19, 52, 113);
            btnCancel.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(347, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 36);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(19, 52, 113);
            btnAdd.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(219, 380);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 36);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPricePerNight
            // 
            txtPricePerNight.Font = new Font("Segoe UI", 14.25F);
            txtPricePerNight.Location = new Point(227, 305);
            txtPricePerNight.Name = "txtPricePerNight";
            txtPricePerNight.Size = new Size(234, 33);
            txtPricePerNight.TabIndex = 11;
            txtPricePerNight.KeyPress += txtPricePerNight_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F);
            textBox3.Location = new Point(168, 305);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(165, 33);
            textBox3.TabIndex = 10;
            textBox3.Text = "  ₱";
            // 
            // txtNumberofBed
            // 
            txtNumberofBed.Font = new Font("Segoe UI", 14.25F);
            txtNumberofBed.Location = new Point(168, 155);
            txtNumberofBed.Name = "txtNumberofBed";
            txtNumberofBed.Size = new Size(293, 33);
            txtNumberofBed.TabIndex = 9;
            // 
            // txtNumberofPerson
            // 
            txtNumberofPerson.Font = new Font("Segoe UI", 14.25F);
            txtNumberofPerson.Location = new Point(168, 233);
            txtNumberofPerson.Name = "txtNumberofPerson";
            txtNumberofPerson.Size = new Size(293, 33);
            txtNumberofPerson.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(13, 15);
            label9.Name = "label9";
            label9.Size = new Size(204, 26);
            label9.TabIndex = 6;
            label9.Text = "Room Type Details";
            // 
            // txtRoomType
            // 
            txtRoomType.Font = new Font("Segoe UI", 14.25F);
            txtRoomType.Location = new Point(168, 82);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(293, 33);
            txtRoomType.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(37, 162);
            label7.Name = "label7";
            label7.Size = new Size(125, 19);
            label7.TabIndex = 3;
            label7.Text = "Number of Bed";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(18, 240);
            label5.Name = "label5";
            label5.Size = new Size(144, 19);
            label5.TabIndex = 2;
            label5.Text = "Maximum Person";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(39, 313);
            label3.Name = "label3";
            label3.Size = new Size(123, 19);
            label3.TabIndex = 1;
            label3.Text = "Price per Night";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(67, 90);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 0;
            label2.Text = "Room Type";
            // 
            // dgvRoomTypeList
            // 
            dgvRoomTypeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomTypeList.BackgroundColor = SystemColors.ActiveCaption;
            dgvRoomTypeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomTypeList.GridColor = SystemColors.InactiveCaption;
            dgvRoomTypeList.Location = new Point(14, 50);
            dgvRoomTypeList.Name = "dgvRoomTypeList";
            dgvRoomTypeList.Size = new Size(1514, 292);
            dgvRoomTypeList.TabIndex = 46;
            dgvRoomTypeList.CellMouseDown += dgvRoomTypeList_CellMouseDown;
            // 
            // dgvRoomList
            // 
            dgvRoomList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomList.BackgroundColor = SystemColors.ActiveCaption;
            dgvRoomList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomList.GridColor = SystemColors.InactiveCaption;
            dgvRoomList.Location = new Point(14, 54);
            dgvRoomList.Name = "dgvRoomList";
            dgvRoomList.Size = new Size(1514, 292);
            dgvRoomList.TabIndex = 45;
            dgvRoomList.CellMouseDown += dgvRoomList_CellMouseDown;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(349, 240);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1151, 39);
            txtSearch.TabIndex = 44;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.FromArgb(6, 116, 41);
            btnAddRoom.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(1538, 239);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(169, 43);
            btnAddRoom.TabIndex = 43;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // btnAddRoomType
            // 
            btnAddRoomType.BackColor = Color.FromArgb(6, 116, 41);
            btnAddRoomType.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnAddRoomType.ForeColor = Color.White;
            btnAddRoomType.Location = new Point(1723, 239);
            btnAddRoomType.Name = "btnAddRoomType";
            btnAddRoomType.Size = new Size(169, 43);
            btnAddRoomType.TabIndex = 42;
            btnAddRoomType.Text = "Add Room Type";
            btnAddRoomType.UseVisualStyleBackColor = false;
            btnAddRoomType.Click += btnAddRoomType_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(19, 52, 113);
            panel3.Controls.Add(lblTotalRType);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(1522, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 90);
            panel3.TabIndex = 41;
            // 
            // lblTotalRType
            // 
            lblTotalRType.AutoSize = true;
            lblTotalRType.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTotalRType.ForeColor = Color.White;
            lblTotalRType.Location = new Point(264, 21);
            lblTotalRType.Name = "lblTotalRType";
            lblTotalRType.Size = new Size(33, 37);
            lblTotalRType.TabIndex = 1;
            lblTotalRType.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(37, 25);
            label6.Name = "label6";
            label6.Size = new Size(157, 33);
            label6.TabIndex = 0;
            label6.Text = "Room Type";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 100, 100);
            panel4.Controls.Add(lblTotalMaintenance);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(1130, 123);
            panel4.Name = "panel4";
            panel4.Size = new Size(370, 90);
            panel4.TabIndex = 40;
            // 
            // lblTotalMaintenance
            // 
            lblTotalMaintenance.AutoSize = true;
            lblTotalMaintenance.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTotalMaintenance.ForeColor = Color.White;
            lblTotalMaintenance.Location = new Point(272, 21);
            lblTotalMaintenance.Name = "lblTotalMaintenance";
            lblTotalMaintenance.Size = new Size(33, 37);
            lblTotalMaintenance.TabIndex = 1;
            lblTotalMaintenance.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(34, 25);
            label8.Name = "label8";
            label8.Size = new Size(181, 33);
            label8.TabIndex = 0;
            label8.Text = "Maintenance";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(254, 159, 77);
            panel2.Controls.Add(lblTotalAvailable);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(739, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 90);
            panel2.TabIndex = 39;
            // 
            // lblTotalAvailable
            // 
            lblTotalAvailable.AutoSize = true;
            lblTotalAvailable.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTotalAvailable.ForeColor = Color.White;
            lblTotalAvailable.Location = new Point(269, 21);
            lblTotalAvailable.Name = "lblTotalAvailable";
            lblTotalAvailable.Size = new Size(33, 37);
            lblTotalAvailable.TabIndex = 1;
            lblTotalAvailable.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(41, 25);
            label4.Name = "label4";
            label4.Size = new Size(132, 33);
            label4.TabIndex = 0;
            label4.Text = "Available";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 116, 41);
            panel1.Controls.Add(lblTotalRoom);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(349, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 90);
            panel1.TabIndex = 38;
            // 
            // lblTotalRoom
            // 
            lblTotalRoom.AutoSize = true;
            lblTotalRoom.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTotalRoom.ForeColor = Color.White;
            lblTotalRoom.Location = new Point(258, 21);
            lblTotalRoom.Name = "lblTotalRoom";
            lblTotalRoom.Size = new Size(33, 37);
            lblTotalRoom.TabIndex = 1;
            lblTotalRoom.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 25);
            label1.Name = "label1";
            label1.Size = new Size(162, 33);
            label1.TabIndex = 0;
            label1.Text = "Total Room";
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.FromArgb(48, 91, 171);
            btnPayment.FlatStyle = FlatStyle.Popup;
            btnPayment.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnPayment.ForeColor = SystemColors.ButtonHighlight;
            btnPayment.Location = new Point(35, 521);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(263, 43);
            btnPayment.TabIndex = 37;
            btnPayment.Text = "PAYMENT";
            btnPayment.UseVisualStyleBackColor = false;
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
            btnCheckOut.TabIndex = 36;
            btnCheckOut.Text = "CHECK OUT";
            btnCheckOut.UseVisualStyleBackColor = false;
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
            btnCheckIn.TabIndex = 35;
            btnCheckIn.Text = "CHECK IN";
            btnCheckIn.UseVisualStyleBackColor = false;
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
            btnReservation.TabIndex = 34;
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
            btnGuestManagement.TabIndex = 33;
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
            btnRoom.TabIndex = 32;
            btnRoom.Text = "ROOM";
            btnRoom.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(48, 91, 171);
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ButtonHighlight;
            btnDashboard.Location = new Point(35, 181);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(263, 43);
            btnDashboard.TabIndex = 31;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlRoom
            // 
            pnlRoom.BackColor = SystemColors.ActiveCaption;
            pnlRoom.Controls.Add(label13);
            pnlRoom.Controls.Add(btnBack);
            pnlRoom.Controls.Add(btnRoomAdd);
            pnlRoom.Controls.Add(txtRoomNumber);
            pnlRoom.Controls.Add(cmbRoomType);
            pnlRoom.Controls.Add(cmbStatus);
            pnlRoom.Controls.Add(label12);
            pnlRoom.Controls.Add(label11);
            pnlRoom.Controls.Add(label10);
            pnlRoom.Location = new Point(841, 239);
            pnlRoom.Name = "pnlRoom";
            pnlRoom.Size = new Size(503, 370);
            pnlRoom.TabIndex = 48;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(18, 17);
            label13.Name = "label13";
            label13.Size = new Size(148, 26);
            label13.TabIndex = 15;
            label13.Text = "Create Room";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(19, 52, 113);
            btnBack.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(345, 305);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 36);
            btnBack.TabIndex = 14;
            btnBack.Text = "Cancel";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRoomAdd
            // 
            btnRoomAdd.BackColor = Color.FromArgb(19, 52, 113);
            btnRoomAdd.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoomAdd.ForeColor = Color.White;
            btnRoomAdd.Location = new Point(225, 305);
            btnRoomAdd.Name = "btnRoomAdd";
            btnRoomAdd.Size = new Size(114, 36);
            btnRoomAdd.TabIndex = 13;
            btnRoomAdd.Text = "Add";
            btnRoomAdd.UseVisualStyleBackColor = false;
            btnRoomAdd.Click += btnRoomAdd_Click;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomNumber.Location = new Point(146, 82);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(311, 33);
            txtRoomNumber.TabIndex = 12;
            txtRoomNumber.KeyPress += txtRoomNumber_KeyPress;
            // 
            // cmbRoomType
            // 
            cmbRoomType.Font = new Font("Segoe UI", 14.25F);
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(145, 154);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(311, 33);
            cmbRoomType.TabIndex = 11;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 14.25F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(145, 226);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(311, 33);
            cmbStatus.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(84, 234);
            label12.Name = "label12";
            label12.Size = new Size(55, 19);
            label12.TabIndex = 9;
            label12.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(44, 162);
            label11.Name = "label11";
            label11.Size = new Size(95, 19);
            label11.TabIndex = 8;
            label11.Text = "Room Type";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(18, 88);
            label10.Name = "label10";
            label10.Size = new Size(122, 19);
            label10.TabIndex = 7;
            label10.Text = "Room Number";
            // 
            // cMenuRoom
            // 
            cMenuRoom.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            cMenuRoom.Name = "cMenuRoom";
            cMenuRoom.Size = new Size(108, 48);
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
            // cMenuRoomType
            // 
            cMenuRoomType.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem1, deleteToolStripMenuItem1 });
            cMenuRoomType.Name = "cMenuRoomType";
            cMenuRoomType.Size = new Size(108, 48);
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(107, 22);
            editToolStripMenuItem1.Text = "Edit";
            editToolStripMenuItem1.Click += editRoomTypeToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(107, 22);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteRoomTypeToolStripMenuItem_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(7, 31, 77);
            panel6.Controls.Add(label14);
            panel6.Location = new Point(334, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(1611, 108);
            panel6.TabIndex = 49;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Constantia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(32, 36);
            label14.Name = "label14";
            label14.Size = new Size(285, 36);
            label14.TabIndex = 0;
            label14.Text = "Room Management";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(19, 52, 113);
            panel5.Controls.Add(btnLogout);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(btnDashboard);
            panel5.Controls.Add(btnRoom);
            panel5.Controls.Add(btnGuestManagement);
            panel5.Controls.Add(btnReservation);
            panel5.Controls.Add(btnCheckIn);
            panel5.Controls.Add(btnCheckOut);
            panel5.Controls.Add(btnPayment);
            panel5.Location = new Point(0, -1);
            panel5.Name = "panel5";
            panel5.Size = new Size(336, 1044);
            panel5.TabIndex = 50;
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
            btnLogout.TabIndex = 52;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(101, 138, 208);
            label15.Location = new Point(27, 160);
            label15.Name = "label15";
            label15.Size = new Size(86, 15);
            label15.TabIndex = 51;
            label15.Text = "NAVIGATIONS";
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
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(48, 91, 171);
            panel7.Controls.Add(label16);
            panel7.Controls.Add(dgvRoomList);
            panel7.Location = new Point(349, 292);
            panel7.Name = "panel7";
            panel7.Size = new Size(1543, 360);
            panel7.TabIndex = 51;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(11, 17);
            label16.Name = "label16";
            label16.Size = new Size(98, 22);
            label16.TabIndex = 52;
            label16.Text = "Room List";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(48, 91, 171);
            panel8.Controls.Add(label17);
            panel8.Controls.Add(dgvRoomTypeList);
            panel8.Location = new Point(349, 673);
            panel8.Name = "panel8";
            panel8.Size = new Size(1543, 356);
            panel8.TabIndex = 52;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(10, 16);
            label17.Name = "label17";
            label17.Size = new Size(109, 22);
            label17.TabIndex = 53;
            label17.Text = "Room Type";
            // 
            // frmRoomManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel8);
            Controls.Add(pnlRoom);
            Controls.Add(pnlRoomType);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(txtSearch);
            Controls.Add(btnAddRoom);
            Controls.Add(btnAddRoomType);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmRoomManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRoomManagement";
            WindowState = FormWindowState.Maximized;
            Load += frmRoomManagement_Load;
            pnlRoomType.ResumeLayout(false);
            pnlRoomType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtNumberofBed).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNumberofPerson).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypeList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlRoom.ResumeLayout(false);
            pnlRoom.PerformLayout();
            cMenuRoom.ResumeLayout(false);
            cMenuRoomType.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlRoomType;
        private Button btnCancel;
        private Button btnAdd;
        private TextBox txtPricePerNight;
        private TextBox textBox3;
        private NumericUpDown txtNumberofBed;
        private NumericUpDown txtNumberofPerson;
        private Label label9;
        private TextBox txtRoomType;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label2;
        private DataGridView dgvRoomTypeList;
        private DataGridView dgvRoomList;
        private TextBox txtSearch;
        private Button btnAddRoom;
        private Button btnAddRoomType;
        private Panel panel3;
        private Label lblTotalRType;
        private Label label6;
        private Panel panel4;
        private Label lblTotalMaintenance;
        private Label label8;
        private Panel panel2;
        private Label lblTotalAvailable;
        private Label label4;
        private Panel panel1;
        private Label lblTotalRoom;
        private Label label1;
        private Button btnPayment;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private Button btnReservation;
        private Button btnGuestManagement;
        private Button btnRoom;
        private Button btnDashboard;
        private Panel pnlRoom;
        private Button btnBack;
        private Button btnRoomAdd;
        private TextBox txtRoomNumber;
        private ComboBox cmbRoomType;
        private ComboBox cmbStatus;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label13;
        private ContextMenuStrip cMenuRoom;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ContextMenuStrip cMenuRoomType;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private Panel panel6;
        private Label label14;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label label15;
        private Panel panel7;
        private Panel panel8;
        private Label label16;
        private Label label17;
        private Button btnLogout;
    }
}