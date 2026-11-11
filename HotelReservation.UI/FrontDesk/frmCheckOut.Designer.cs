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
            // 
            // btnBilling
            // 
            btnBilling.Location = new Point(12, 342);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(108, 34);
            btnBilling.TabIndex = 38;
            btnBilling.Text = "Billing Payment";
            btnBilling.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(12, 302);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(108, 34);
            btnCheckOut.TabIndex = 37;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(13, 262);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(108, 34);
            btnCheckIn.TabIndex = 36;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnReservation
            // 
            btnReservation.Location = new Point(13, 222);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(108, 34);
            btnReservation.TabIndex = 35;
            btnReservation.Text = "Reservation";
            btnReservation.UseVisualStyleBackColor = true;
            // 
            // btnGuestManagement
            // 
            btnGuestManagement.Location = new Point(13, 182);
            btnGuestManagement.Name = "btnGuestManagement";
            btnGuestManagement.Size = new Size(108, 34);
            btnGuestManagement.TabIndex = 34;
            btnGuestManagement.Text = "Guest";
            btnGuestManagement.UseVisualStyleBackColor = true;
            // 
            // btnRoom
            // 
            btnRoom.Location = new Point(13, 142);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(108, 34);
            btnRoom.TabIndex = 33;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(13, 102);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(108, 34);
            btnDashboard.TabIndex = 32;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 28);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 40;
            label1.Text = "Check In";
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
            // frmCheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}