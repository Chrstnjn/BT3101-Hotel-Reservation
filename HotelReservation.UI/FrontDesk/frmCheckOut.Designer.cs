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
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 404);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 34);
            btnLogout.TabIndex = 39;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBilling
            // 
            btnBilling.Location = new Point(11, 301);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(108, 34);
            btnBilling.TabIndex = 38;
            btnBilling.Text = "Billing Payment";
            btnBilling.UseVisualStyleBackColor = true;
            btnBilling.Click += btnBilling_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(11, 261);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(108, 34);
            btnCheckOut.TabIndex = 37;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(12, 221);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(108, 34);
            btnCheckIn.TabIndex = 36;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnReservation
            // 
            btnReservation.Location = new Point(12, 181);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(108, 34);
            btnReservation.TabIndex = 35;
            btnReservation.Text = "Reservation";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnGuestManagement
            // 
            btnGuestManagement.Location = new Point(12, 141);
            btnGuestManagement.Name = "btnGuestManagement";
            btnGuestManagement.Size = new Size(108, 34);
            btnGuestManagement.TabIndex = 34;
            btnGuestManagement.Text = "Guest";
            btnGuestManagement.UseVisualStyleBackColor = true;
            btnGuestManagement.Click += btnGuestManagement_Click;
            // 
            // btnRoom
            // 
            btnRoom.Location = new Point(12, 101);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(108, 34);
            btnRoom.TabIndex = 33;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(12, 61);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(108, 34);
            btnDashboard.TabIndex = 32;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 28);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 40;
            label1.Text = "Check Out";
            // 
            // lblPendingCheckOut
            // 
            lblPendingCheckOut.AutoSize = true;
            lblPendingCheckOut.Location = new Point(288, 61);
            lblPendingCheckOut.Name = "lblPendingCheckOut";
            lblPendingCheckOut.Size = new Size(12, 15);
            lblPendingCheckOut.TabIndex = 42;
            lblPendingCheckOut.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 61);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 41;
            label3.Text = "Pending Check-Outs";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(165, 88);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(623, 23);
            txtSearch.TabIndex = 43;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(608, 121);
            label2.Name = "label2";
            label2.Size = new Size(180, 15);
            label2.TabIndex = 44;
            label2.Text = "Press 'Right-Click' to view details";
            // 
            // dgvCheckOut
            // 
            dgvCheckOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckOut.BackgroundColor = SystemColors.ActiveCaption;
            dgvCheckOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckOut.GridColor = SystemColors.InactiveCaption;
            dgvCheckOut.Location = new Point(155, 142);
            dgvCheckOut.Name = "dgvCheckOut";
            dgvCheckOut.Size = new Size(633, 296);
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
            // 
            // btnRecords
            // 
            btnRecords.Location = new Point(12, 341);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(108, 34);
            btnRecords.TabIndex = 46;
            btnRecords.Text = "Billing Records";
            btnRecords.UseVisualStyleBackColor = true;
            btnRecords.Click += btnRecords_Click;
            // 
            // frmCheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRecords);
            Controls.Add(dgvCheckOut);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(lblPendingCheckOut);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnBilling);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(btnReservation);
            Controls.Add(btnGuestManagement);
            Controls.Add(btnRoom);
            Controls.Add(btnDashboard);
            Name = "frmCheckOut";
            Text = "frmCheckOut";
            Load += frmCheckOut_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
    }
}