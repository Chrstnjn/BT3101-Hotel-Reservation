namespace HotelReservation.UI.Admin
{
    partial class frmAdminGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminGuest));
            txtSearch = new TextBox();
            lblTotalGuest = new Label();
            dgvGuestsList = new DataGridView();
            btnRecords = new Button();
            btnLogout = new Button();
            btnGuest = new Button();
            btnRoom = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            btnReserved = new Button();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGuestsList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18F);
            txtSearch.Location = new Point(24, 93);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1465, 39);
            txtSearch.TabIndex = 21;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTotalGuest
            // 
            lblTotalGuest.AutoSize = true;
            lblTotalGuest.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTotalGuest.ForeColor = Color.White;
            lblTotalGuest.Location = new Point(228, 26);
            lblTotalGuest.Name = "lblTotalGuest";
            lblTotalGuest.Size = new Size(33, 37);
            lblTotalGuest.TabIndex = 20;
            lblTotalGuest.Text = "0";
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
            dgvGuestsList.TabIndex = 19;
            dgvGuestsList.CellFormatting += dgvGuestsList_CellFormatting;
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
            btnRecords.TabIndex = 49;
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
            btnLogout.TabIndex = 48;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
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
            btnGuest.TabIndex = 47;
            btnGuest.Text = "GUEST";
            btnGuest.UseVisualStyleBackColor = false;
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
            btnRoom.TabIndex = 46;
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
            btnDashboard.TabIndex = 45;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 30);
            label1.Name = "label1";
            label1.Size = new Size(181, 33);
            label1.TabIndex = 50;
            label1.Text = "Total Guests:";
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
            btnReserved.TabIndex = 51;
            btnReserved.Text = "BOOKED";
            btnReserved.UseVisualStyleBackColor = false;
            btnReserved.Click += btnReserved_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 21.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 36);
            label2.Name = "label2";
            label2.Size = new Size(216, 36);
            label2.TabIndex = 52;
            label2.Text = "Guest's Record";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 52, 113);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnRoom);
            panel1.Controls.Add(btnReserved);
            panel1.Controls.Add(btnGuest);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnRecords);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 1044);
            panel1.TabIndex = 53;
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
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 31, 77);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(334, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1572, 108);
            panel2.TabIndex = 54;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(48, 91, 171);
            panel3.Controls.Add(dgvGuestsList);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblTotalGuest);
            panel3.Location = new Point(367, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(1510, 877);
            panel3.TabIndex = 55;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(101, 138, 208);
            label13.Location = new Point(27, 160);
            label13.Name = "label13";
            label13.Size = new Size(86, 15);
            label13.TabIndex = 53;
            label13.Text = "NAVIGATIONS";
            // 
            // frmAdminGuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmAdminGuest";
            Text = "frmAdminGuest";
            Load += frmAdminGuest_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGuestsList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSearch;
        private Label lblTotalGuest;
        private DataGridView dgvGuestsList;
        private Button btnRecords;
        private Button btnLogout;
        private Button btnGuest;
        private Button btnRoom;
        private Button btnDashboard;
        private Label label1;
        private Button btnReserved;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Label label13;
    }
}