namespace HotelReservation.UI.FrontDesk
{
    partial class frmCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckOut));
            btnLogout = new Button();
            btnBilling = new Button();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            btnReservation = new Button();
            btnGuestManagement = new Button();
            btnRoom = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            lblPendingCheckOut = new Label();
            label3 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            dgvCheckOut = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            processCheckOutToolStripMenuItem = new ToolStripMenuItem();
            processBillingToolStripMenuItem = new ToolStripMenuItem();
            btnRecords = new Button();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 100, 100);
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(35, 973);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(263, 43);
            btnLogout.TabIndex = 39;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBilling
            // 
            btnBilling.BackColor = Color.FromArgb(48, 91, 171);
            btnBilling.FlatStyle = FlatStyle.Popup;
            btnBilling.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnBilling.ForeColor = Color.White;
            btnBilling.Location = new Point(35, 521);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(263, 43);
            btnBilling.TabIndex = 38;
            btnBilling.Text = "BILLING PAYMENT";
            btnBilling.UseVisualStyleBackColor = false;
            btnBilling.Click += btnBilling_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.FromArgb(48, 91, 171);
            btnCheckOut.FlatStyle = FlatStyle.Popup;
            btnCheckOut.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Location = new Point(35, 463);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(263, 43);
            btnCheckOut.TabIndex = 37;
            btnCheckOut.Text = "CHECK OUT";
            btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // btnCheckIn
            // 
            btnCheckIn.BackColor = Color.FromArgb(48, 91, 171);
            btnCheckIn.FlatStyle = FlatStyle.Popup;
            btnCheckIn.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnCheckIn.ForeColor = Color.White;
            btnCheckIn.Location = new Point(35, 405);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(263, 43);
            btnCheckIn.TabIndex = 36;
            btnCheckIn.Text = "CHECK IN";
            btnCheckIn.UseVisualStyleBackColor = false;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnReservation
            // 
            btnReservation.BackColor = Color.FromArgb(48, 91, 171);
            btnReservation.FlatStyle = FlatStyle.Popup;
            btnReservation.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnReservation.ForeColor = Color.White;
            btnReservation.Location = new Point(35, 348);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(263, 43);
            btnReservation.TabIndex = 35;
            btnReservation.Text = "RESERVATION";
            btnReservation.UseVisualStyleBackColor = false;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnGuestManagement
            // 
            btnGuestManagement.BackColor = Color.FromArgb(48, 91, 171);
            btnGuestManagement.FlatStyle = FlatStyle.Popup;
            btnGuestManagement.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnGuestManagement.ForeColor = Color.White;
            btnGuestManagement.Location = new Point(35, 293);
            btnGuestManagement.Name = "btnGuestManagement";
            btnGuestManagement.Size = new Size(263, 43);
            btnGuestManagement.TabIndex = 34;
            btnGuestManagement.Text = "GUEST";
            btnGuestManagement.UseVisualStyleBackColor = false;
            btnGuestManagement.Click += btnGuestManagement_Click;
            // 
            // btnRoom
            // 
            btnRoom.BackColor = Color.FromArgb(48, 91, 171);
            btnRoom.FlatStyle = FlatStyle.Popup;
            btnRoom.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnRoom.ForeColor = Color.White;
            btnRoom.Location = new Point(35, 237);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(263, 43);
            btnRoom.TabIndex = 33;
            btnRoom.Text = "ROOM";
            btnRoom.UseVisualStyleBackColor = false;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(48, 91, 171);
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(35, 181);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(263, 43);
            btnDashboard.TabIndex = 32;
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
            label1.Size = new Size(160, 36);
            label1.TabIndex = 40;
            label1.Text = "Check Out";
            // 
            // lblPendingCheckOut
            // 
            lblPendingCheckOut.AutoSize = true;
            lblPendingCheckOut.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            lblPendingCheckOut.ForeColor = Color.White;
            lblPendingCheckOut.Location = new Point(321, 30);
            lblPendingCheckOut.Name = "lblPendingCheckOut";
            lblPendingCheckOut.Size = new Size(24, 33);
            lblPendingCheckOut.TabIndex = 42;
            lblPendingCheckOut.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 30);
            label3.Name = "label3";
            label3.Size = new Size(276, 33);
            label3.TabIndex = 41;
            label3.Text = "Pending Check-Outs";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18F);
            txtSearch.Location = new Point(24, 93);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1465, 39);
            txtSearch.TabIndex = 43;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1060, 137);
            label2.Name = "label2";
            label2.Size = new Size(429, 33);
            label2.TabIndex = 44;
            label2.Text = "Press 'Right-Click' to view details";
            // 
            // dgvCheckOut
            // 
            dgvCheckOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckOut.BackgroundColor = SystemColors.ActiveCaption;
            dgvCheckOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckOut.GridColor = SystemColors.InactiveCaption;
            dgvCheckOut.Location = new Point(24, 173);
            dgvCheckOut.Name = "dgvCheckOut";
            dgvCheckOut.Size = new Size(1465, 683);
            dgvCheckOut.TabIndex = 45;
            dgvCheckOut.CellFormatting += dgvCheckIn_CellFormatting;
            dgvCheckOut.CellMouseDown += dgvCheckOut_CellMouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { processCheckOutToolStripMenuItem, processBillingToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(176, 48);
            // 
            // processCheckOutToolStripMenuItem
            // 
            processCheckOutToolStripMenuItem.Name = "processCheckOutToolStripMenuItem";
            processCheckOutToolStripMenuItem.Size = new Size(175, 22);
            processCheckOutToolStripMenuItem.Text = "Process Check-Out";
            processCheckOutToolStripMenuItem.Click += processCheckOutToolStripMenuItem_Click;
            // 
            // processBillingToolStripMenuItem
            // 
            processBillingToolStripMenuItem.Name = "processBillingToolStripMenuItem";
            processBillingToolStripMenuItem.Size = new Size(175, 22);
            processBillingToolStripMenuItem.Text = "Process Billing";
            processBillingToolStripMenuItem.Click += btnBilling_Click;
            // 
            // btnRecords
            // 
            btnRecords.BackColor = Color.FromArgb(48, 91, 171);
            btnRecords.FlatStyle = FlatStyle.Popup;
            btnRecords.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnRecords.ForeColor = Color.White;
            btnRecords.Location = new Point(35, 579);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(263, 43);
            btnRecords.TabIndex = 46;
            btnRecords.Text = "BOOKED RECORDS";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 52, 113);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnReservation);
            panel1.Controls.Add(btnRecords);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnBilling);
            panel1.Controls.Add(btnRoom);
            panel1.Controls.Add(btnCheckOut);
            panel1.Controls.Add(btnGuestManagement);
            panel1.Controls.Add(btnCheckIn);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 1044);
            panel1.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(101, 138, 208);
            label4.Location = new Point(27, 160);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 48;
            label4.Text = "NAVIGATIONS";
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
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 31, 77);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(334, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1572, 108);
            panel2.TabIndex = 48;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(48, 91, 171);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblPendingCheckOut);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dgvCheckOut);
            panel3.Controls.Add(txtSearch);
            panel3.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(367, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(1510, 877);
            panel3.TabIndex = 49;
            // 
            // frmCheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "frmCheckOut";
            Text = "frmCheckOut";
            Load += frmCheckOut_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).EndInit();
            contextMenuStrip1.ResumeLayout(false);
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

        private Button btnLogout;
        private Button btnBilling;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private Button btnReservation;
        private Button btnGuestManagement;
        private Button btnRoom;
        private Button btnDashboard;
        private Label label1;
        private Label lblPendingCheckOut;
        private Label label3;
        private TextBox txtSearch;
        private Label label2;
        private DataGridView dgvCheckOut;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem processCheckOutToolStripMenuItem;
        private ToolStripMenuItem processBillingToolStripMenuItem;
        private Button btnRecords;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}