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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFrontDashboard));
            btnDashboard = new Button();
            btnRoom = new Button();
            btnGuestManagement = new Button();
            btnReservation = new Button();
            btnCheckIn = new Button();
            btnCheckOut = new Button();
            btnPayment = new Button();
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
            pictureBox5 = new PictureBox();
            lblTotalCheckOut = new Label();
            label6 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            lblTotalCheckIn = new Label();
            label8 = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            lblTotalReservation = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lblTotalGuest = new Label();
            label1 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            panel8 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableRoom).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
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
            btnRoom.TabIndex = 1;
            btnRoom.Text = "ROOM";
            btnRoom.UseVisualStyleBackColor = false;
            btnRoom.Click += btnRoom_Click;
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
            btnGuestManagement.TabIndex = 2;
            btnGuestManagement.Text = "GUEST";
            btnGuestManagement.UseVisualStyleBackColor = false;
            btnGuestManagement.Click += btnGuestManagement_Click;
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
            btnReservation.TabIndex = 3;
            btnReservation.Text = "RESERVATION";
            btnReservation.UseVisualStyleBackColor = false;
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
            btnCheckIn.TabIndex = 4;
            btnCheckIn.Text = "CHECK IN";
            btnCheckIn.UseVisualStyleBackColor = false;
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
            btnCheckOut.TabIndex = 5;
            btnCheckOut.Text = "CHECK OUT";
            btnCheckOut.UseVisualStyleBackColor = false;
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
            btnPayment.TabIndex = 6;
            btnPayment.Text = "PAYMENT";
            btnPayment.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(19, 52, 113);
            panel5.Controls.Add(dgvAvailableRoom);
            panel5.Controls.Add(dtDate);
            panel5.Controls.Add(lblDateForAvailRoom);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(lblAvailRoom);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(360, 420);
            panel5.Name = "panel5";
            panel5.Size = new Size(753, 598);
            panel5.TabIndex = 11;
            // 
            // dgvAvailableRoom
            // 
            dgvAvailableRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailableRoom.BackgroundColor = SystemColors.ControlLight;
            dgvAvailableRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableRoom.Location = new Point(13, 75);
            dgvAvailableRoom.Name = "dgvAvailableRoom";
            dgvAvailableRoom.Size = new Size(728, 511);
            dgvAvailableRoom.TabIndex = 4;
            // 
            // dtDate
            // 
            dtDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dtDate.Location = new Point(461, 23);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(256, 29);
            dtDate.TabIndex = 0;
            // 
            // lblDateForAvailRoom
            // 
            lblDateForAvailRoom.AutoSize = true;
            lblDateForAvailRoom.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDateForAvailRoom.ForeColor = SystemColors.Control;
            lblDateForAvailRoom.Location = new Point(160, 10);
            lblDateForAvailRoom.Name = "lblDateForAvailRoom";
            lblDateForAvailRoom.Size = new Size(19, 21);
            lblDateForAvailRoom.TabIndex = 3;
            lblDateForAvailRoom.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(90, 10);
            label12.Name = "label12";
            label12.Size = new Size(46, 21);
            label12.TabIndex = 2;
            label12.Text = "Date";
            // 
            // lblAvailRoom
            // 
            lblAvailRoom.AutoSize = true;
            lblAvailRoom.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAvailRoom.ForeColor = SystemColors.Control;
            lblAvailRoom.Location = new Point(160, 39);
            lblAvailRoom.Name = "lblAvailRoom";
            lblAvailRoom.Size = new Size(19, 21);
            lblAvailRoom.TabIndex = 1;
            lblAvailRoom.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(11, 41);
            label10.Name = "label10";
            label10.Size = new Size(127, 21);
            label10.TabIndex = 0;
            label10.Text = "Available room";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(19, 52, 113);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(dateTimePicker1);
            panel7.Controls.Add(dgvHistory);
            panel7.Location = new Point(1129, 420);
            panel7.Name = "panel7";
            panel7.Size = new Size(753, 598);
            panel7.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(29, 23);
            label9.Name = "label9";
            label9.Size = new Size(66, 21);
            label9.TabIndex = 3;
            label9.Text = "History";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            dateTimePicker1.Location = new Point(463, 23);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(256, 29);
            dateTimePicker1.TabIndex = 2;
            // 
            // dgvHistory
            // 
            dgvHistory.BackgroundColor = SystemColors.ControlLight;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(13, 75);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.Size = new Size(728, 511);
            dgvHistory.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(lblTotalCheckOut);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(360, 270);
            panel3.Name = "panel3";
            panel3.Size = new Size(499, 109);
            panel3.TabIndex = 17;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.ErrorImage = null;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = null;
            pictureBox5.Location = new Point(6, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(97, 97);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // lblTotalCheckOut
            // 
            lblTotalCheckOut.AutoSize = true;
            lblTotalCheckOut.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalCheckOut.ForeColor = Color.FromArgb(19, 52, 113);
            lblTotalCheckOut.Location = new Point(219, 53);
            lblTotalCheckOut.Name = "lblTotalCheckOut";
            lblTotalCheckOut.Size = new Size(38, 45);
            lblTotalCheckOut.TabIndex = 1;
            lblTotalCheckOut.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 18F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(102, 108, 130);
            label6.Location = new Point(160, 15);
            label6.Name = "label6";
            label6.Size = new Size(156, 29);
            label6.TabIndex = 0;
            label6.Text = "CHECK OUT";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(lblTotalCheckIn);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(1383, 146);
            panel4.Name = "panel4";
            panel4.Size = new Size(499, 109);
            panel4.TabIndex = 16;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = null;
            pictureBox4.Location = new Point(6, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(97, 97);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // lblTotalCheckIn
            // 
            lblTotalCheckIn.AutoSize = true;
            lblTotalCheckIn.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalCheckIn.ForeColor = Color.FromArgb(19, 52, 113);
            lblTotalCheckIn.Location = new Point(219, 52);
            lblTotalCheckIn.Name = "lblTotalCheckIn";
            lblTotalCheckIn.Size = new Size(38, 45);
            lblTotalCheckIn.TabIndex = 1;
            lblTotalCheckIn.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 18F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(102, 108, 130);
            label8.Location = new Point(166, 10);
            label8.Name = "label8";
            label8.Size = new Size(130, 29);
            label8.TabIndex = 0;
            label8.Text = "CHECK IN";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(lblTotalReservation);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(872, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(499, 109);
            panel2.TabIndex = 15;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(6, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(97, 97);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // lblTotalReservation
            // 
            lblTotalReservation.AutoSize = true;
            lblTotalReservation.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalReservation.ForeColor = Color.FromArgb(19, 52, 113);
            lblTotalReservation.Location = new Point(232, 52);
            lblTotalReservation.Name = "lblTotalReservation";
            lblTotalReservation.Size = new Size(38, 45);
            lblTotalReservation.TabIndex = 1;
            lblTotalReservation.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(102, 108, 130);
            label4.Location = new Point(158, 10);
            label4.Name = "label4";
            label4.Size = new Size(178, 29);
            label4.TabIndex = 0;
            label4.Text = "RESERVATION";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblTotalGuest);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(360, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 109);
            panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(6, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(97, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // lblTotalGuest
            // 
            lblTotalGuest.AutoSize = true;
            lblTotalGuest.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalGuest.ForeColor = Color.FromArgb(19, 52, 113);
            lblTotalGuest.Location = new Point(219, 52);
            lblTotalGuest.Name = "lblTotalGuest";
            lblTotalGuest.Size = new Size(38, 45);
            lblTotalGuest.TabIndex = 1;
            lblTotalGuest.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(102, 108, 130);
            label1.Location = new Point(149, 10);
            label1.Name = "label1";
            label1.Size = new Size(176, 29);
            label1.TabIndex = 0;
            label1.Text = "TOTAL GUEST";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(7, 31, 77);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(334, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(1572, 108);
            panel6.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 36);
            label3.Name = "label3";
            label3.Size = new Size(325, 36);
            label3.TabIndex = 0;
            label3.Text = "Front Desk Dashboard";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(19, 52, 113);
            panel8.Controls.Add(label2);
            panel8.Controls.Add(pictureBox1);
            panel8.Controls.Add(btnDashboard);
            panel8.Controls.Add(btnRoom);
            panel8.Controls.Add(btnGuestManagement);
            panel8.Controls.Add(btnReservation);
            panel8.Controls.Add(btnCheckIn);
            panel8.Controls.Add(btnCheckOut);
            panel8.Controls.Add(btnPayment);
            panel8.Location = new Point(0, -1);
            panel8.Name = "panel8";
            panel8.Size = new Size(336, 1044);
            panel8.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(101, 138, 208);
            label2.Location = new Point(27, 160);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 9;
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
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // frmFrontDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel6);
            Controls.Add(panel8);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Name = "frmFrontDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFrontDashboard";
            Load += frmFrontDashboard_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableRoom).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDashboard;
        private Button btnRoom;
        private Button btnGuestManagement;
        private Button btnReservation;
        private Button btnCheckIn;
        private Button btnCheckOut;
        private Button btnPayment;
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
        private Panel panel6;
        private Panel panel8;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label3;
    }
}