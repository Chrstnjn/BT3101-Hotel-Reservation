namespace HotelReservation.UI.FrontDesk
{
    partial class frmRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRooms));
            btnBilling = new Button();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            btnReservation = new Button();
            btnGuestManagement = new Button();
            btnRoom = new Button();
            btnDashboard = new Button();
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
            txtSearch = new TextBox();
            dgvRoomList = new DataGridView();
            dgvRoomTypeList = new DataGridView();
            btnLogout = new Button();
            btnRecords = new Button();
            pnlDateAvailable = new Panel();
            monthCalendarDate = new MonthCalendar();
            btnDate = new Button();
            txtDateDisplay = new TextBox();
            panel5 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            label3 = new Label();
            panel7 = new Panel();
            label16 = new Label();
            panel8 = new Panel();
            label17 = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypeList).BeginInit();
            pnlDateAvailable.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
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
            panel3.Controls.Add(lblTotalRType);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(1522, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 90);
            panel3.TabIndex = 24;
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
            panel4.TabIndex = 23;
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
            panel2.TabIndex = 22;
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
            panel1.TabIndex = 21;
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
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18F);
            txtSearch.Location = new Point(349, 240);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1151, 39);
            txtSearch.TabIndex = 27;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvRoomList
            // 
            dgvRoomList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomList.BackgroundColor = SystemColors.ActiveCaption;
            dgvRoomList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomList.Location = new Point(14, 54);
            dgvRoomList.Name = "dgvRoomList";
            dgvRoomList.ReadOnly = true;
            dgvRoomList.Size = new Size(1514, 292);
            dgvRoomList.TabIndex = 28;
            // 
            // dgvRoomTypeList
            // 
            dgvRoomTypeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomTypeList.BackgroundColor = SystemColors.ActiveCaption;
            dgvRoomTypeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomTypeList.Location = new Point(14, 50);
            dgvRoomTypeList.Name = "dgvRoomTypeList";
            dgvRoomTypeList.ReadOnly = true;
            dgvRoomTypeList.Size = new Size(1514, 292);
            dgvRoomTypeList.TabIndex = 29;
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
            btnLogout.TabIndex = 30;
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
            btnRecords.Text = "BOOKED RECORDS";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // pnlDateAvailable
            // 
            pnlDateAvailable.BackColor = Color.FromArgb(7, 31, 77);
            pnlDateAvailable.Controls.Add(monthCalendarDate);
            pnlDateAvailable.Location = new Point(1620, 285);
            pnlDateAvailable.Name = "pnlDateAvailable";
            pnlDateAvailable.Size = new Size(243, 178);
            pnlDateAvailable.TabIndex = 41;
            pnlDateAvailable.Visible = false;
            // 
            // monthCalendarDate
            // 
            monthCalendarDate.Location = new Point(9, 9);
            monthCalendarDate.Name = "monthCalendarDate";
            monthCalendarDate.TabIndex = 0;
            monthCalendarDate.DateSelected += monthCalendarDate_DateSelected;
            // 
            // btnDate
            // 
            btnDate.BackColor = Color.White;
            btnDate.BackgroundImage = (Image)resources.GetObject("btnDate.BackgroundImage");
            btnDate.BackgroundImageLayout = ImageLayout.Stretch;
            btnDate.FlatStyle = FlatStyle.Flat;
            btnDate.ForeColor = Color.Transparent;
            btnDate.Image = (Image)resources.GetObject("btnDate.Image");
            btnDate.Location = new Point(1825, 240);
            btnDate.Name = "btnDate";
            btnDate.Size = new Size(38, 39);
            btnDate.TabIndex = 39;
            btnDate.UseVisualStyleBackColor = false;
            btnDate.Click += btnDate_Click;
            // 
            // txtDateDisplay
            // 
            txtDateDisplay.BackColor = SystemColors.Window;
            txtDateDisplay.Font = new Font("Segoe UI", 18F);
            txtDateDisplay.Location = new Point(1522, 240);
            txtDateDisplay.Name = "txtDateDisplay";
            txtDateDisplay.ReadOnly = true;
            txtDateDisplay.Size = new Size(326, 39);
            txtDateDisplay.TabIndex = 40;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(19, 52, 113);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(btnDashboard);
            panel5.Controls.Add(btnRoom);
            panel5.Controls.Add(btnGuestManagement);
            panel5.Controls.Add(btnReservation);
            panel5.Controls.Add(btnRecords);
            panel5.Controls.Add(btnCheckIn);
            panel5.Controls.Add(btnLogout);
            panel5.Controls.Add(btnCheckOut);
            panel5.Controls.Add(btnBilling);
            panel5.Location = new Point(0, -1);
            panel5.Name = "panel5";
            panel5.Size = new Size(336, 1044);
            panel5.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(101, 138, 208);
            label2.Location = new Point(27, 160);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 44;
            label2.Text = "NAVIGATIONS";
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
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(7, 31, 77);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(334, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(1572, 108);
            panel6.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 36);
            label3.Name = "label3";
            label3.Size = new Size(109, 36);
            label3.TabIndex = 0;
            label3.Text = "Rooms";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(48, 91, 171);
            panel7.Controls.Add(label16);
            panel7.Controls.Add(dgvRoomList);
            panel7.Location = new Point(349, 292);
            panel7.Name = "panel7";
            panel7.Size = new Size(1543, 360);
            panel7.TabIndex = 44;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(11, 17);
            label16.Name = "label16";
            label16.Size = new Size(98, 22);
            label16.TabIndex = 53;
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
            panel8.TabIndex = 45;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(10, 16);
            label17.Name = "label17";
            label17.Size = new Size(109, 22);
            label17.TabIndex = 54;
            label17.Text = "Room Type";
            // 
            // frmRooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel8);
            Controls.Add(pnlDateAvailable);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(btnDate);
            Controls.Add(txtDateDisplay);
            Controls.Add(txtSearch);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmRooms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRooms";
            Load += frmRooms_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypeList).EndInit();
            pnlDateAvailable.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
        private TextBox txtSearch;
        private DataGridView dgvRoomList;
        private DataGridView dgvRoomTypeList;
        private Button btnLogout;
        private Button btnRecords;
        private Panel pnlDateAvailable;
        private MonthCalendar monthCalendarDate;
        private Button btnDate;
        private TextBox txtDateDisplay;
        private Panel panel5;
        private Panel panel6;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel7;
        private Panel panel8;
        private Label label16;
        private Label label17;
    }
}