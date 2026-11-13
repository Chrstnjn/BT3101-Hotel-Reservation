namespace HotelReservation.UI.Admin
{
    partial class frmAdminReserved
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminReserved));
            btnReserved = new Button();
            btnRecords = new Button();
            btnLogout = new Button();
            btnGuest = new Button();
            btnRoom = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSearch = new TextBox();
            lblTotalBooked = new Label();
            dgvBooked = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvBooked).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            btnReserved.TabIndex = 57;
            btnReserved.Text = "BOOKED";
            btnReserved.UseVisualStyleBackColor = false;
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
            btnRecords.TabIndex = 56;
            btnRecords.Text = "INVOICED";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
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
            btnLogout.TabIndex = 55;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
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
            btnGuest.TabIndex = 54;
            btnGuest.Text = "GUEST";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += btnGuest_Click;
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
            btnRoom.TabIndex = 53;
            btnRoom.Text = "ROOMS";
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
            btnDashboard.TabIndex = 52;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 21.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 36);
            label2.Name = "label2";
            label2.Size = new Size(236, 36);
            label2.TabIndex = 62;
            label2.Text = "Booked Records";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 30);
            label1.Name = "label1";
            label1.Size = new Size(191, 33);
            label1.TabIndex = 61;
            label1.Text = "Total Booked:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18F);
            txtSearch.Location = new Point(24, 93);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1465, 39);
            txtSearch.TabIndex = 60;
            // 
            // lblTotalBooked
            // 
            lblTotalBooked.AutoSize = true;
            lblTotalBooked.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTotalBooked.ForeColor = Color.White;
            lblTotalBooked.Location = new Point(228, 26);
            lblTotalBooked.Name = "lblTotalBooked";
            lblTotalBooked.Size = new Size(33, 37);
            lblTotalBooked.TabIndex = 59;
            lblTotalBooked.Text = "0";
            // 
            // dgvBooked
            // 
            dgvBooked.AllowUserToAddRows = false;
            dgvBooked.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooked.BackgroundColor = SystemColors.ActiveCaption;
            dgvBooked.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooked.Location = new Point(24, 173);
            dgvBooked.Name = "dgvBooked";
            dgvBooked.Size = new Size(1465, 683);
            dgvBooked.TabIndex = 58;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 52, 113);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnRoom);
            panel1.Controls.Add(btnGuest);
            panel1.Controls.Add(btnRecords);
            panel1.Controls.Add(btnReserved);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 1044);
            panel1.TabIndex = 63;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 31, 77);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(334, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1572, 108);
            panel2.TabIndex = 64;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(48, 91, 171);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblTotalBooked);
            panel3.Controls.Add(dgvBooked);
            panel3.Controls.Add(txtSearch);
            panel3.Location = new Point(367, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(1510, 877);
            panel3.TabIndex = 65;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(101, 138, 208);
            label13.Location = new Point(27, 160);
            label13.Name = "label13";
            label13.Size = new Size(86, 15);
            label13.TabIndex = 58;
            label13.Text = "NAVIGATIONS";
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
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // frmAdminReserved
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmAdminReserved";
            Text = "frmAdminReserved";
            Load += frmAdminReserved_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooked).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnReserved;
        private Button btnRecords;
        private Button btnLogout;
        private Button btnGuest;
        private Button btnRoom;
        private Button btnDashboard;
        private Label label2;
        private Label label1;
        private TextBox txtSearch;
        private Label lblTotalBooked;
        private DataGridView dgvBooked;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label13;
        private PictureBox pictureBox1;
    }
}