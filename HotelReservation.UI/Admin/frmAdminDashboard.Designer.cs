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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            btnRoom = new Button();
            btnDashboard = new Button();
            btnGuest = new Button();
            btnLogout = new Button();
            btnRecords = new Button();
            panel5 = new Panel();
            lblAvailable = new Label();
            dgvAvailable = new DataGridView();
            lbl2 = new Label();
            btnReserved = new Button();
            panel7 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel8 = new Panel();
            panel4 = new Panel();
            lblTotalReservation = new Label();
            label8 = new Label();
            panel2 = new Panel();
            lblTotalGuest = new Label();
            label4 = new Label();
            panel1 = new Panel();
            lblTotalRoom = new Label();
            label1 = new Label();
            panel3 = new Panel();
            lblTotalRecords = new Label();
            label6 = new Label();
            panel6 = new Panel();
            dgvRecentBooked = new DataGridView();
            label3 = new Label();
            label5 = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailable).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentBooked).BeginInit();
            SuspendLayout();
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
            btnDashboard.TabIndex = 31;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.FromArgb(48, 91, 171);
            btnGuest.FlatStyle = FlatStyle.Popup;
            btnGuest.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnGuest.ForeColor = SystemColors.ButtonHighlight;
            btnGuest.Location = new Point(35, 293);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(263, 43);
            btnGuest.TabIndex = 42;
            btnGuest.Text = "GUEST";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += btnGuest_Click;
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
            btnLogout.TabIndex = 43;
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
            btnRecords.Location = new Point(35, 405);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(263, 43);
            btnRecords.TabIndex = 44;
            btnRecords.Text = "INVOICED";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(19, 52, 113);
            panel5.Controls.Add(lblAvailable);
            panel5.Controls.Add(dgvAvailable);
            panel5.Controls.Add(lbl2);
            panel5.Location = new Point(349, 248);
            panel5.Name = "panel5";
            panel5.Size = new Size(771, 781);
            panel5.TabIndex = 45;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            lblAvailable.ForeColor = SystemColors.ButtonFace;
            lblAvailable.Location = new Point(140, 23);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(16, 22);
            lblAvailable.TabIndex = 2;
            lblAvailable.Text = "-";
            // 
            // dgvAvailable
            // 
            dgvAvailable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailable.Location = new Point(15, 69);
            dgvAvailable.Name = "dgvAvailable";
            dgvAvailable.Size = new Size(737, 699);
            dgvAvailable.TabIndex = 1;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            lbl2.ForeColor = SystemColors.ButtonFace;
            lbl2.Location = new Point(30, 23);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(90, 22);
            lbl2.TabIndex = 0;
            lbl2.Text = "Available";
            // 
            // btnReserved
            // 
            btnReserved.BackColor = Color.FromArgb(48, 91, 171);
            btnReserved.FlatStyle = FlatStyle.Popup;
            btnReserved.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnReserved.ForeColor = SystemColors.ButtonHighlight;
            btnReserved.Location = new Point(35, 348);
            btnReserved.Name = "btnReserved";
            btnReserved.Size = new Size(263, 43);
            btnReserved.TabIndex = 47;
            btnReserved.Text = "BOOKED";
            btnReserved.UseVisualStyleBackColor = false;
            btnReserved.Click += btnReserved_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(19, 52, 113);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(pictureBox1);
            panel7.Controls.Add(btnReserved);
            panel7.Controls.Add(btnDashboard);
            panel7.Controls.Add(btnRoom);
            panel7.Controls.Add(btnGuest);
            panel7.Controls.Add(btnRecords);
            panel7.Location = new Point(0, -1);
            panel7.Name = "panel7";
            panel7.Size = new Size(336, 1044);
            panel7.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(101, 138, 208);
            label2.Location = new Point(27, 160);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 50;
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
            pictureBox1.TabIndex = 101;
            pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(7, 31, 77);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(334, -1);
            panel8.Name = "panel8";
            panel8.Size = new Size(1572, 108);
            panel8.TabIndex = 49;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(lblTotalReservation);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(739, 123);
            panel4.Name = "panel4";
            panel4.Size = new Size(370, 90);
            panel4.TabIndex = 40;
            // 
            // lblTotalReservation
            // 
            lblTotalReservation.AutoSize = true;
            lblTotalReservation.Font = new Font("Segoe UI", 15.75F);
            lblTotalReservation.ForeColor = SystemColors.ButtonHighlight;
            lblTotalReservation.Location = new Point(164, 47);
            lblTotalReservation.Name = "lblTotalReservation";
            lblTotalReservation.Size = new Size(24, 30);
            lblTotalReservation.TabIndex = 1;
            lblTotalReservation.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 18F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(96, 9);
            label8.Name = "label8";
            label8.Size = new Size(162, 29);
            label8.TabIndex = 0;
            label8.Text = "Total Booked";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lblTotalGuest);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(1130, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 90);
            panel2.TabIndex = 39;
            // 
            // lblTotalGuest
            // 
            lblTotalGuest.AutoSize = true;
            lblTotalGuest.Font = new Font("Segoe UI", 15.75F);
            lblTotalGuest.ForeColor = SystemColors.ButtonHighlight;
            lblTotalGuest.Location = new Point(173, 47);
            lblTotalGuest.Name = "lblTotalGuest";
            lblTotalGuest.Size = new Size(24, 30);
            lblTotalGuest.TabIndex = 1;
            lblTotalGuest.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 18F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(105, 9);
            label4.Name = "label4";
            label4.Size = new Size(142, 29);
            label4.TabIndex = 0;
            label4.Text = "Total Guest";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
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
            lblTotalRoom.Font = new Font("Segoe UI", 15.75F);
            lblTotalRoom.ForeColor = SystemColors.ButtonHighlight;
            lblTotalRoom.Location = new Point(172, 47);
            lblTotalRoom.Name = "lblTotalRoom";
            lblTotalRoom.Size = new Size(24, 30);
            lblTotalRoom.TabIndex = 1;
            lblTotalRoom.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(109, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 29);
            label1.TabIndex = 0;
            label1.Text = "Total Rooms";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(lblTotalRecords);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(1522, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 90);
            panel3.TabIndex = 41;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Font = new Font("Segoe UI", 15.75F);
            lblTotalRecords.ForeColor = SystemColors.ButtonHighlight;
            lblTotalRecords.Location = new Point(185, 47);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(24, 30);
            lblTotalRecords.TabIndex = 1;
            lblTotalRecords.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 18F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(69, 9);
            label6.Name = "label6";
            label6.Size = new Size(226, 29);
            label6.TabIndex = 0;
            label6.Text = "Total Checked-Out";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(19, 52, 113);
            panel6.Controls.Add(dgvRecentBooked);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(1130, 248);
            panel6.Name = "panel6";
            panel6.Size = new Size(762, 781);
            panel6.TabIndex = 46;
            // 
            // dgvRecentBooked
            // 
            dgvRecentBooked.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentBooked.Location = new Point(17, 69);
            dgvRecentBooked.Name = "dgvRecentBooked";
            dgvRecentBooked.Size = new Size(730, 699);
            dgvRecentBooked.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(17, 23);
            label3.Name = "label3";
            label3.Size = new Size(155, 22);
            label3.TabIndex = 0;
            label3.Text = "Recently Booked";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 21.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(50, 37);
            label5.Name = "label5";
            label5.Size = new Size(267, 36);
            label5.TabIndex = 0;
            label5.Text = "Admin Dashboard";
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(panel5);
            Controls.Add(btnLogout);
            Controls.Add(panel7);
            Name = "frmAdminDashboard";
            Text = "frmAdminDashboard";
            Load += frmAdminDashboard_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailable).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentBooked).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRoom;
        private Button btnDashboard;
        private Button btnGuest;
        private Button btnLogout;
        private Button btnRecords;
        private Panel panel5;
        private DataGridView dgvAvailable;
        private Label lbl2;
        private Label lblAvailable;
        private Button btnReserved;
        private Panel panel7;
        private Panel panel8;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel4;
        private Label lblTotalReservation;
        private Label label8;
        private Panel panel2;
        private Label lblTotalGuest;
        private Label label4;
        private Panel panel1;
        private Label lblTotalRoom;
        private Label label1;
        private Panel panel3;
        private Label lblTotalRecords;
        private Label label6;
        private Panel panel6;
        private DataGridView dgvRecentBooked;
        private Label label3;
        private Label label5;
    }
}