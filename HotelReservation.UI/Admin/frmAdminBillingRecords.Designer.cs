namespace HotelReservation.UI.Admin
{
    partial class frmAdminBillingRecords
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
            btnPrint = new Button();
            dgvCheckOut = new DataGridView();
            txtSearch = new TextBox();
            lblTotalCheckOut = new Label();
            label3 = new Label();
            label1 = new Label();
            btnReserved = new Button();
            btnLogout = new Button();
            btnGuest = new Button();
            btnRoom = new Button();
            btnDashboard = new Button();
            btnRecords = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).BeginInit();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(687, 62);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(101, 23);
            btnPrint.TabIndex = 93;
            btnPrint.Text = "View Receipt";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // dgvCheckOut
            // 
            dgvCheckOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckOut.BackgroundColor = SystemColors.ActiveCaption;
            dgvCheckOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckOut.GridColor = SystemColors.InactiveCaption;
            dgvCheckOut.Location = new Point(155, 122);
            dgvCheckOut.Name = "dgvCheckOut";
            dgvCheckOut.Size = new Size(633, 321);
            dgvCheckOut.TabIndex = 92;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(155, 93);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(633, 23);
            txtSearch.TabIndex = 91;
            // 
            // lblTotalCheckOut
            // 
            lblTotalCheckOut.AutoSize = true;
            lblTotalCheckOut.Location = new Point(288, 66);
            lblTotalCheckOut.Name = "lblTotalCheckOut";
            lblTotalCheckOut.Size = new Size(12, 15);
            lblTotalCheckOut.TabIndex = 90;
            lblTotalCheckOut.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 66);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 89;
            label3.Text = "Total Check-Outs";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 33);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 88;
            label1.Text = "Invoiced Records";
            // 
            // btnReserved
            // 
            btnReserved.Location = new Point(12, 209);
            btnReserved.Name = "btnReserved";
            btnReserved.Size = new Size(108, 34);
            btnReserved.TabIndex = 98;
            btnReserved.Text = "Booked";
            btnReserved.UseVisualStyleBackColor = true;
            btnReserved.Click += btnReserved_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 398);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 34);
            btnLogout.TabIndex = 97;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnGuest
            // 
            btnGuest.Location = new Point(12, 169);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(108, 34);
            btnGuest.TabIndex = 96;
            btnGuest.Text = "Guest";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // btnRoom
            // 
            btnRoom.Location = new Point(12, 129);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(108, 34);
            btnRoom.TabIndex = 95;
            btnRoom.Text = "Rooms";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(12, 89);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(108, 34);
            btnDashboard.TabIndex = 94;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnRecords
            // 
            btnRecords.Location = new Point(12, 249);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(108, 34);
            btnRecords.TabIndex = 99;
            btnRecords.Text = "Invoiced";
            btnRecords.UseVisualStyleBackColor = true;
            // 
            // frmAdminBillingRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRecords);
            Controls.Add(btnReserved);
            Controls.Add(btnLogout);
            Controls.Add(btnGuest);
            Controls.Add(btnRoom);
            Controls.Add(btnDashboard);
            Controls.Add(btnPrint);
            Controls.Add(dgvCheckOut);
            Controls.Add(txtSearch);
            Controls.Add(lblTotalCheckOut);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmAdminBillingRecords";
            Text = "frmAdminBillingRecords";
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrint;
        private DataGridView dgvCheckOut;
        private TextBox txtSearch;
        private Label lblTotalCheckOut;
        private Label label3;
        private Label label1;
        private Button btnReserved;
        private Button btnLogout;
        private Button btnGuest;
        private Button btnRoom;
        private Button btnDashboard;
        private Button btnRecords;
    }
}