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
            ((System.ComponentModel.ISupportInitialize)dgvCheckIn).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBilling
            // 
            btnBilling.Location = new Point(12, 342);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(108, 34);
            btnBilling.TabIndex = 27;
            btnBilling.Text = "Billing";
            btnBilling.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(12, 302);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(108, 34);
            btnCheckOut.TabIndex = 26;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(13, 262);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(108, 34);
            btnCheckIn.TabIndex = 25;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnReservation
            // 
            btnReservation.Location = new Point(13, 222);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(108, 34);
            btnReservation.TabIndex = 24;
            btnReservation.Text = "Reservation";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnGuestManagement
            // 
            btnGuestManagement.Location = new Point(13, 182);
            btnGuestManagement.Name = "btnGuestManagement";
            btnGuestManagement.Size = new Size(108, 34);
            btnGuestManagement.TabIndex = 23;
            btnGuestManagement.Text = "Guest";
            btnGuestManagement.UseVisualStyleBackColor = true;
            btnGuestManagement.Click += btnGuestManagement_Click;
            // 
            // btnRoom
            // 
            btnRoom.Location = new Point(13, 142);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(108, 34);
            btnRoom.TabIndex = 22;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(13, 102);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(108, 34);
            btnDashboard.TabIndex = 21;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 24);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 28;
            label1.Text = "Check In";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(155, 88);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(623, 23);
            txtSearch.TabIndex = 30;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 404);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 34);
            btnLogout.TabIndex = 31;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 59);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 32;
            label3.Text = "Awaiting Check-Ins:";
            // 
            // lblAwaitingCount
            // 
            lblAwaitingCount.AutoSize = true;
            lblAwaitingCount.Location = new Point(266, 59);
            lblAwaitingCount.Name = "lblAwaitingCount";
            lblAwaitingCount.Size = new Size(12, 15);
            lblAwaitingCount.TabIndex = 33;
            lblAwaitingCount.Text = "-";
            // 
            // dgvCheckIn
            // 
            dgvCheckIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckIn.BackgroundColor = SystemColors.ActiveCaption;
            dgvCheckIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckIn.GridColor = SystemColors.InactiveCaption;
            dgvCheckIn.Location = new Point(155, 142);
            dgvCheckIn.Name = "dgvCheckIn";
            dgvCheckIn.Size = new Size(633, 296);
            dgvCheckIn.TabIndex = 34;
            dgvCheckIn.CellMouseDown += dgvCheckIn_CellMouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(605, 121);
            label2.Name = "label2";
            label2.Size = new Size(180, 15);
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
            // frmCheckIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(dgvCheckIn);
            Controls.Add(lblAwaitingCount);
            Controls.Add(label3);
            Controls.Add(btnLogout);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnBilling);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(btnReservation);
            Controls.Add(btnGuestManagement);
            Controls.Add(btnRoom);
            Controls.Add(btnDashboard);
            Name = "frmCheckIn";
            Text = "frmCheckIn";
            Load += frmCheckIn_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCheckIn).EndInit();
            contextMenuStrip1.ResumeLayout(false);
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
    }
}