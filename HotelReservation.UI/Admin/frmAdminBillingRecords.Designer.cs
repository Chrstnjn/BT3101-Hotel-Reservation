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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminBillingRecords));
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
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(6, 116, 41);
            btnPrint.FlatStyle = FlatStyle.Popup;
            btnPrint.Font = new Font("Constantia", 9.75F, FontStyle.Bold);
            btnPrint.ForeColor = SystemColors.ButtonHighlight;
            btnPrint.Location = new Point(1364, 29);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(119, 33);
            btnPrint.TabIndex = 93;
            btnPrint.Text = "View Receipt";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
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
            dgvCheckOut.TabIndex = 92;
            dgvCheckOut.CellFormatting += dgvGuestsList_CellFormatting;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 18F);
            txtSearch.Location = new Point(24, 93);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1465, 39);
            txtSearch.TabIndex = 91;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTotalCheckOut
            // 
            lblTotalCheckOut.AutoSize = true;
            lblTotalCheckOut.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            lblTotalCheckOut.ForeColor = Color.White;
            lblTotalCheckOut.Location = new Point(283, 30);
            lblTotalCheckOut.Name = "lblTotalCheckOut";
            lblTotalCheckOut.Size = new Size(24, 33);
            lblTotalCheckOut.TabIndex = 90;
            lblTotalCheckOut.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 20.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 30);
            label3.Name = "label3";
            label3.Size = new Size(235, 33);
            label3.TabIndex = 89;
            label3.Text = "Total Check-Outs";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 37);
            label1.Name = "label1";
            label1.Size = new Size(249, 36);
            label1.TabIndex = 88;
            label1.Text = "Invoiced Records";
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
            btnReserved.TabIndex = 98;
            btnReserved.Text = "BOOKED";
            btnReserved.UseVisualStyleBackColor = false;
            btnReserved.Click += btnReserved_Click;
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
            btnLogout.TabIndex = 97;
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
            btnGuest.TabIndex = 96;
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
            btnRoom.TabIndex = 95;
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
            btnDashboard.TabIndex = 94;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
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
            btnRecords.TabIndex = 99;
            btnRecords.Text = "INVOICED";
            btnRecords.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 52, 113);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnRecords);
            panel1.Controls.Add(btnRoom);
            panel1.Controls.Add(btnReserved);
            panel1.Controls.Add(btnGuest);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 1044);
            panel1.TabIndex = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(101, 138, 208);
            label2.Location = new Point(27, 160);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 101;
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
            pictureBox1.TabIndex = 100;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 31, 77);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(334, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1572, 108);
            panel2.TabIndex = 101;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(48, 91, 171);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dgvCheckOut);
            panel3.Controls.Add(btnPrint);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(lblTotalCheckOut);
            panel3.Location = new Point(367, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(1510, 877);
            panel3.TabIndex = 102;
            // 
            // frmAdminBillingRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "frmAdminBillingRecords";
            Text = "frmAdminBillingRecords";
            Load += frmFrontBillingRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCheckOut).EndInit();
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
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label2;
    }
}