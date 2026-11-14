namespace HotelReservation.UI.FrontDesk
{
    partial class frmCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckIn));
            btnBilling = new Button();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            btnReservation = new Button();
            btnGuestManagement = new Button();
            btnRoom = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            btnLogout = new Button();
            label3 = new Label();
            lblAwaitingCount = new Label();
            dgvCheckIn = new DataGridView();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            processCheckToolStripMenuItem = new ToolStripMenuItem();
            cancelToolStripMenuItem = new ToolStripMenuItem();
            btnRecords = new Button();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCheckIn).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            btnBilling.TabIndex = 27;
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
            btnCheckOut.TabIndex = 26;
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
            btnCheckIn.TabIndex = 25;
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
            btnReservation.TabIndex = 24;
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
            btnGuestManagement.TabIndex = 23;
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
            btnRoom.TabIndex = 22;
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
            btnDashboard.TabIndex = 21;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(137, 36);
            label1.TabIndex = 28;
            label1.Text = "Check In";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18F);
            txtSearch.Location = new Point(24, 93);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1465, 39);
            txtSearch.TabIndex = 30;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            btnLogout.TabIndex = 31;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 30);
            label3.Name = "label3";
            label3.Size = new Size(269, 33);
            label3.TabIndex = 32;
            label3.Text = "Awaiting Check-Ins:";
            // 
            // lblAwaitingCount
            // 
            lblAwaitingCount.AutoSize = true;
            lblAwaitingCount.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            lblAwaitingCount.ForeColor = Color.White;
            lblAwaitingCount.Location = new Point(315, 29);
            lblAwaitingCount.Name = "lblAwaitingCount";
            lblAwaitingCount.Size = new Size(24, 33);
            lblAwaitingCount.TabIndex = 33;
            lblAwaitingCount.Text = "-";
            // 
            // dgvCheckIn
            // 
            dgvCheckIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckIn.BackgroundColor = SystemColors.ActiveCaption;
            dgvCheckIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckIn.GridColor = SystemColors.InactiveCaption;
            dgvCheckIn.Location = new Point(24, 173);
            dgvCheckIn.Name = "dgvCheckIn";
            dgvCheckIn.Size = new Size(1465, 683);
            dgvCheckIn.TabIndex = 34;
            dgvCheckIn.CellFormatting += dgvCheckIn_CellFormatting;
            dgvCheckIn.CellMouseDown += dgvCheckIn_CellMouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1060, 137);
            label2.Name = "label2";
            label2.Size = new Size(429, 33);
            label2.TabIndex = 35;
            label2.Text = "Press 'Right-Click' to view details";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { processCheckToolStripMenuItem, cancelToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(166, 48);
            // 
            // processCheckToolStripMenuItem
            // 
            processCheckToolStripMenuItem.Name = "processCheckToolStripMenuItem";
            processCheckToolStripMenuItem.Size = new Size(165, 22);
            processCheckToolStripMenuItem.Text = "Process Check-In";
            processCheckToolStripMenuItem.Click += processCheckInToolStripMenuItem_Click;
            // 
            // cancelToolStripMenuItem
            // 
            cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            cancelToolStripMenuItem.Size = new Size(165, 22);
            cancelToolStripMenuItem.Text = "Cancel";
            cancelToolStripMenuItem.Click += cancelToolStripMenuItem_Click;
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
            btnRecords.TabIndex = 36;
            btnRecords.Text = "BOOKED RECORDS";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 52, 113);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 1044);
            panel1.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(101, 138, 208);
            label4.Location = new Point(27, 160);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 32;
            label4.Text = "NAVIGATIONS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 31, 77);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(334, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1572, 108);
            panel2.TabIndex = 38;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(48, 91, 171);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblAwaitingCount);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(dgvCheckIn);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(367, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(1510, 877);
            panel3.TabIndex = 39;
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
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // frmCheckIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(btnRecords);
            Controls.Add(btnBilling);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(btnReservation);
            Controls.Add(btnGuestManagement);
            Controls.Add(btnRoom);
            Controls.Add(btnDashboard);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "frmCheckIn";
            Text = "frmCheckIn";
            Load += frmCheckIn_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCheckIn).EndInit();
            contextMenuStrip1.ResumeLayout(false);
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

        private Button btnBilling;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private Button btnReservation;
        private Button btnGuestManagement;
        private Button btnRoom;
        private Button btnDashboard;
        private Label label1;
        private TextBox txtSearch;
        private Button btnLogout;
        private Label label3;
        private Label lblAwaitingCount;
        private DataGridView dgvCheckIn;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem processCheckToolStripMenuItem;
        private ToolStripMenuItem cancelToolStripMenuItem;
        private Button btnRecords;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}