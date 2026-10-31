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
            btnPayment = new Button();
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
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypeList).BeginInit();
            SuspendLayout();
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(12, 342);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(108, 34);
            btnPayment.TabIndex = 20;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(12, 302);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(108, 34);
            btnCheckOut.TabIndex = 19;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(13, 262);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(108, 34);
            btnCheckIn.TabIndex = 18;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnReservation
            // 
            btnReservation.Location = new Point(13, 222);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(108, 34);
            btnReservation.TabIndex = 17;
            btnReservation.Text = "Reservation";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
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
            panel3.Controls.Add(lblTotalRType);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(537, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(120, 55);
            panel3.TabIndex = 24;
            // 
            // lblTotalRType
            // 
            lblTotalRType.AutoSize = true;
            lblTotalRType.Location = new Point(50, 33);
            lblTotalRType.Name = "lblTotalRType";
            lblTotalRType.Size = new Size(13, 15);
            lblTotalRType.TabIndex = 1;
            lblTotalRType.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 9);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 0;
            label6.Text = "Room Type";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(lblTotalMaintenance);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(405, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(120, 55);
            panel4.TabIndex = 23;
            // 
            // lblTotalMaintenance
            // 
            lblTotalMaintenance.AutoSize = true;
            lblTotalMaintenance.Location = new Point(50, 33);
            lblTotalMaintenance.Name = "lblTotalMaintenance";
            lblTotalMaintenance.Size = new Size(13, 15);
            lblTotalMaintenance.TabIndex = 1;
            lblTotalMaintenance.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 9);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 0;
            label8.Text = "Maintenance";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lblTotalAvailable);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(274, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 55);
            panel2.TabIndex = 22;
            // 
            // lblTotalAvailable
            // 
            lblTotalAvailable.AutoSize = true;
            lblTotalAvailable.Location = new Point(50, 33);
            lblTotalAvailable.Name = "lblTotalAvailable";
            lblTotalAvailable.Size = new Size(13, 15);
            lblTotalAvailable.TabIndex = 1;
            lblTotalAvailable.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 9);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 0;
            label4.Text = "Available";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblTotalRoom);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(142, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 55);
            panel1.TabIndex = 21;
            // 
            // lblTotalRoom
            // 
            lblTotalRoom.AutoSize = true;
            lblTotalRoom.Location = new Point(50, 33);
            lblTotalRoom.Name = "lblTotalRoom";
            lblTotalRoom.Size = new Size(13, 15);
            lblTotalRoom.TabIndex = 1;
            lblTotalRoom.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Total Room";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(142, 98);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(630, 23);
            txtSearch.TabIndex = 27;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvRoomList
            // 
            dgvRoomList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomList.Location = new Point(142, 127);
            dgvRoomList.Name = "dgvRoomList";
            dgvRoomList.ReadOnly = true;
            dgvRoomList.Size = new Size(630, 150);
            dgvRoomList.TabIndex = 28;
            // 
            // dgvRoomTypeList
            // 
            dgvRoomTypeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomTypeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomTypeList.Location = new Point(142, 283);
            dgvRoomTypeList.Name = "dgvRoomTypeList";
            dgvRoomTypeList.ReadOnly = true;
            dgvRoomTypeList.Size = new Size(630, 155);
            dgvRoomTypeList.TabIndex = 29;
            // 
            // frmRooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvRoomTypeList);
            Controls.Add(dgvRoomList);
            Controls.Add(txtSearch);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnPayment);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(btnReservation);
            Controls.Add(btnGuestManagement);
            Controls.Add(btnRoom);
            Controls.Add(btnDashboard);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPayment;
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
    }
}