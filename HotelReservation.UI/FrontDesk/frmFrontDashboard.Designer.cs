namespace HotelReservation.UI.FrontDesk
{
    partial class frmFrontDashboard
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
            button1 = new Button();
            button2 = new Button();
            btnGuestManagement = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            panel5 = new Panel();
            dgvAvailableRoom = new DataGridView();
            dtDate = new DateTimePicker();
            lblDateForAvailRoom = new Label();
            label12 = new Label();
            lblAvailRoom = new Label();
            label10 = new Label();
            panel7 = new Panel();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dgvHistory = new DataGridView();
            panel3 = new Panel();
            lblTotalCheckOut = new Label();
            label6 = new Label();
            panel4 = new Panel();
            lblTotalCheckIn = new Label();
            label8 = new Label();
            panel2 = new Panel();
            lblTotalReservation = new Label();
            label4 = new Label();
            panel1 = new Panel();
            lblTotalGuest = new Label();
            label1 = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableRoom).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(13, 102);
            button1.Name = "button1";
            button1.Size = new Size(108, 34);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(13, 142);
            button2.Name = "button2";
            button2.Size = new Size(108, 34);
            button2.TabIndex = 1;
            button2.Text = "Room";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnGuestManagement
            // 
            btnGuestManagement.Location = new Point(13, 182);
            btnGuestManagement.Name = "btnGuestManagement";
            btnGuestManagement.Size = new Size(108, 34);
            btnGuestManagement.TabIndex = 2;
            btnGuestManagement.Text = "Guest";
            btnGuestManagement.UseVisualStyleBackColor = true;
            btnGuestManagement.Click += btnGuestManagement_Click;
            // 
            // button4
            // 
            button4.Location = new Point(13, 222);
            button4.Name = "button4";
            button4.Size = new Size(108, 34);
            button4.TabIndex = 3;
            button4.Text = "Reservation";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(13, 262);
            button5.Name = "button5";
            button5.Size = new Size(108, 34);
            button5.TabIndex = 4;
            button5.Text = "Check In";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(12, 302);
            button6.Name = "button6";
            button6.Size = new Size(108, 34);
            button6.TabIndex = 5;
            button6.Text = "Check Out";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 342);
            button7.Name = "button7";
            button7.Size = new Size(108, 34);
            button7.TabIndex = 6;
            button7.Text = "Payment";
            button7.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(dgvAvailableRoom);
            panel5.Controls.Add(dtDate);
            panel5.Controls.Add(lblDateForAvailRoom);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(lblAvailRoom);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(139, 90);
            panel5.Name = "panel5";
            panel5.Size = new Size(332, 347);
            panel5.TabIndex = 11;
            // 
            // dgvAvailableRoom
            // 
            dgvAvailableRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailableRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableRoom.Location = new Point(0, 34);
            dgvAvailableRoom.Name = "dgvAvailableRoom";
            dgvAvailableRoom.Size = new Size(332, 314);
            dgvAvailableRoom.TabIndex = 4;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(132, 5);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(194, 23);
            dtDate.TabIndex = 0;
            // 
            // lblDateForAvailRoom
            // 
            lblDateForAvailRoom.AutoSize = true;
            lblDateForAvailRoom.Location = new Point(37, 0);
            lblDateForAvailRoom.Name = "lblDateForAvailRoom";
            lblDateForAvailRoom.Size = new Size(13, 15);
            lblDateForAvailRoom.TabIndex = 3;
            lblDateForAvailRoom.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 2;
            label12.Text = "Date";
            // 
            // lblAvailRoom
            // 
            lblAvailRoom.AutoSize = true;
            lblAvailRoom.Location = new Point(83, 16);
            lblAvailRoom.Name = "lblAvailRoom";
            lblAvailRoom.Size = new Size(13, 15);
            lblAvailRoom.TabIndex = 1;
            lblAvailRoom.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 15);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 0;
            label10.Text = "available room";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaption;
            panel7.Controls.Add(label9);
            panel7.Controls.Add(dateTimePicker1);
            panel7.Controls.Add(dgvHistory);
            panel7.Location = new Point(484, 90);
            panel7.Name = "panel7";
            panel7.Size = new Size(304, 347);
            panel7.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 11);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 3;
            label9.Text = "History";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(111, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(190, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(0, 34);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.Size = new Size(304, 314);
            dgvHistory.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(lblTotalCheckOut);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(534, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(120, 55);
            panel3.TabIndex = 17;
            // 
            // lblTotalCheckOut
            // 
            lblTotalCheckOut.AutoSize = true;
            lblTotalCheckOut.Location = new Point(50, 33);
            lblTotalCheckOut.Name = "lblTotalCheckOut";
            lblTotalCheckOut.Size = new Size(13, 15);
            lblTotalCheckOut.TabIndex = 1;
            lblTotalCheckOut.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 9);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 0;
            label6.Text = "Check Out";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(lblTotalCheckIn);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(402, 29);
            panel4.Name = "panel4";
            panel4.Size = new Size(120, 55);
            panel4.TabIndex = 16;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 9);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 0;
            label8.Text = "Check In";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lblTotalReservation);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(271, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 55);
            panel2.TabIndex = 15;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 9);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 0;
            label4.Text = "Reservation ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblTotalGuest);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(139, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 55);
            panel1.TabIndex = 14;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Total Guests";
            // 
            // frmFrontDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnGuestManagement);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmFrontDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFrontDashboard";
            WindowState = FormWindowState.Maximized;
            Load += frmFrontDashboard_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableRoom).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnGuestManagement;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Panel panel5;
        private Panel panel7;
        private Panel panel3;
        private Label lblTotalCheckOut;
        private Label label6;
        private Panel panel4;
        private Label lblTotalCheckIn;
        private Label label8;
        private Panel panel2;
        private Label lblTotalReservation;
        private Label label4;
        private Panel panel1;
        private Label lblTotalGuest;
        private Label label1;
        private DataGridView dgvAvailableRoom;
        private Label lblDateForAvailRoom;
        private Label label12;
        private Label lblAvailRoom;
        private Label label10;
        private DateTimePicker dtDate;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgvHistory;
        private Label label9;
    }
}