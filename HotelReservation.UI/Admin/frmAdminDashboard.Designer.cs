namespace HotelReservation.UI.Admin
{
    partial class frmAdminDashboard
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
            panel3 = new Panel();
            lblTotalRecords = new Label();
            label6 = new Label();
            panel4 = new Panel();
            lblTotalReservation = new Label();
            label8 = new Label();
            panel2 = new Panel();
            lblTotalGuest = new Label();
            label4 = new Label();
            panel1 = new Panel();
            lblTotalRoom = new Label();
            label1 = new Label();
            btnRoom = new Button();
            btnDashboard = new Button();
            btnGuest = new Button();
            btnLogout = new Button();
            btnRecords = new Button();
            panel5 = new Panel();
            lblAvailable = new Label();
            dgvAvailable = new DataGridView();
            lbl2 = new Label();
            panel6 = new Panel();
            dgvRecentBooked = new DataGridView();
            label3 = new Label();
            btnReserved = new Button();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailable).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentBooked).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(lblTotalRecords);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(545, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(120, 55);
            panel3.TabIndex = 41;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Location = new Point(50, 33);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(13, 15);
            lblTotalRecords.TabIndex = 1;
            lblTotalRecords.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 0;
            label6.Text = "Total Checked-Out";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(lblTotalReservation);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(413, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(120, 55);
            panel4.TabIndex = 40;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 9);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 0;
            label8.Text = "Total Booked";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lblTotalGuest);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(282, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 55);
            panel2.TabIndex = 39;
            // 
            // lblTotalGuest
            // 
            lblTotalGuest.AutoSize = true;
            lblTotalGuest.Location = new Point(50, 33);
            lblTotalGuest.Name = "lblTotalGuest";
            lblTotalGuest.Size = new Size(13, 15);
            lblTotalGuest.TabIndex = 1;
            lblTotalGuest.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 9);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 0;
            label4.Text = "Total Guest";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblTotalRoom);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(150, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 55);
            panel1.TabIndex = 38;
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
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Total Rooms";
            // 
            // btnRoom
            // 
            btnRoom.Location = new Point(21, 135);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(108, 34);
            btnRoom.TabIndex = 32;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(21, 95);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(108, 34);
            btnDashboard.TabIndex = 31;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnGuest
            // 
            btnGuest.Location = new Point(21, 175);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(108, 34);
            btnGuest.TabIndex = 42;
            btnGuest.Text = "Guest";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(21, 404);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 34);
            btnLogout.TabIndex = 43;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRecords
            // 
            btnRecords.Location = new Point(21, 255);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(108, 34);
            btnRecords.TabIndex = 44;
            btnRecords.Text = "Invoiced";
            btnRecords.UseVisualStyleBackColor = true;
            btnRecords.Click += btnRecords_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(19, 52, 113);
            panel5.Controls.Add(lblAvailable);
            panel5.Controls.Add(dgvAvailable);
            panel5.Controls.Add(lbl2);
            panel5.Location = new Point(161, 95);
            panel5.Name = "panel5";
            panel5.Size = new Size(315, 343);
            panel5.TabIndex = 45;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.ForeColor = SystemColors.ButtonFace;
            lblAvailable.Location = new Point(75, 19);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(12, 15);
            lblAvailable.TabIndex = 2;
            lblAvailable.Text = "-";
            // 
            // dgvAvailable
            // 
            dgvAvailable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailable.Location = new Point(6, 49);
            dgvAvailable.Name = "dgvAvailable";
            dgvAvailable.Size = new Size(297, 275);
            dgvAvailable.TabIndex = 1;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.ForeColor = SystemColors.ButtonFace;
            lbl2.Location = new Point(14, 19);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(55, 15);
            lbl2.TabIndex = 0;
            lbl2.Text = "Available";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(19, 52, 113);
            panel6.Controls.Add(dgvRecentBooked);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(487, 95);
            panel6.Name = "panel6";
            panel6.Size = new Size(310, 343);
            panel6.TabIndex = 46;
            // 
            // dgvRecentBooked
            // 
            dgvRecentBooked.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentBooked.Location = new Point(10, 49);
            dgvRecentBooked.Name = "dgvRecentBooked";
            dgvRecentBooked.Size = new Size(290, 275);
            dgvRecentBooked.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(8, 19);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 0;
            label3.Text = "Recently Booked";
            // 
            // btnReserved
            // 
            btnReserved.Location = new Point(21, 215);
            btnReserved.Name = "btnReserved";
            btnReserved.Size = new Size(108, 34);
            btnReserved.TabIndex = 47;
            btnReserved.Text = "Booked";
            btnReserved.UseVisualStyleBackColor = true;
            btnReserved.Click += btnReserved_Click;
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 450);
            Controls.Add(btnReserved);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(btnRecords);
            Controls.Add(btnLogout);
            Controls.Add(btnGuest);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnRoom);
            Controls.Add(btnDashboard);
            Name = "frmAdminDashboard";
            Text = "frmAdminDashboard";
            Load += frmAdminDashboard_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailable).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentBooked).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label lblTotalRecords;
        private Label label6;
        private Panel panel4;
        private Label lblTotalReservation;
        private Label label8;
        private Panel panel2;
        private Label lblTotalGuest;
        private Label label4;
        private Panel panel1;
        private Label lblTotalRoom;
        private Label label1;
        private Button btnRoom;
        private Button btnDashboard;
        private Button btnGuest;
        private Button btnLogout;
        private Button btnRecords;
        private Panel panel5;
        private Panel panel6;
        private DataGridView dgvAvailable;
        private Label lbl2;
        private DataGridView dgvRecentBooked;
        private Label label3;
        private Label lblAvailable;
        private Button btnReserved;
    }
}