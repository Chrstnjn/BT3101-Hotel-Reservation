namespace HotelReservation.UI.Admin
{
    partial class frmRoomManagement
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
            pnlRoomType = new Panel();
            btnCancel = new Button();
            btnAdd = new Button();
            txtPricePerNight = new TextBox();
            textBox3 = new TextBox();
            txtNumberofBed = new NumericUpDown();
            txtNumberofPerson = new NumericUpDown();
            label9 = new Label();
            txtRoomType = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvRoomTypeList = new DataGridView();
            dgvRoomList = new DataGridView();
            txtSearch = new TextBox();
            btnAddRoom = new Button();
            btnAddRoomType = new Button();
            panel3 = new Panel();
            lblTotalRType = new Label();
            label6 = new Label();
            panel4 = new Panel();
            lblTotalMaintenance = new Label();
            label8 = new Label();
            panel2 = new Panel();
            lblTotalAvailable = new Label();
            label4 = new Label();
            panel1 = new Panel();
            lblTotalRoom = new Label();
            label1 = new Label();
            btnPayment = new Button();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            btnReservation = new Button();
            btnGuestManagement = new Button();
            btnRoom = new Button();
            btnDashboard = new Button();
            pnlRoom = new Panel();
            label13 = new Label();
            btnBack = new Button();
            btnRoomAdd = new Button();
            txtRoomNumber = new TextBox();
            cmbRoomType = new ComboBox();
            cmbStatus = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            cMenuRoom = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            cMenuRoomType = new ContextMenuStrip(components);
            editToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            pnlRoomType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtNumberofBed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNumberofPerson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pnlRoom.SuspendLayout();
            cMenuRoom.SuspendLayout();
            cMenuRoomType.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRoomType
            // 
            pnlRoomType.Controls.Add(btnCancel);
            pnlRoomType.Controls.Add(btnAdd);
            pnlRoomType.Controls.Add(txtPricePerNight);
            pnlRoomType.Controls.Add(textBox3);
            pnlRoomType.Controls.Add(txtNumberofBed);
            pnlRoomType.Controls.Add(txtNumberofPerson);
            pnlRoomType.Controls.Add(label9);
            pnlRoomType.Controls.Add(txtRoomType);
            pnlRoomType.Controls.Add(label7);
            pnlRoomType.Controls.Add(label5);
            pnlRoomType.Controls.Add(label3);
            pnlRoomType.Controls.Add(label2);
            pnlRoomType.Location = new Point(463, 135);
            pnlRoomType.Name = "pnlRoomType";
            pnlRoomType.Size = new Size(294, 245);
            pnlRoomType.TabIndex = 47;
            pnlRoomType.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(203, 202);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(67, 26);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(130, 202);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(67, 26);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPricePerNight
            // 
            txtPricePerNight.Location = new Point(149, 159);
            txtPricePerNight.Name = "txtPricePerNight";
            txtPricePerNight.Size = new Size(125, 23);
            txtPricePerNight.TabIndex = 11;
            txtPricePerNight.KeyPress += txtPricePerNight_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(121, 159);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(27, 23);
            textBox3.TabIndex = 10;
            textBox3.Text = "  ₱";
            // 
            // txtNumberofBed
            // 
            txtNumberofBed.Location = new Point(121, 82);
            txtNumberofBed.Name = "txtNumberofBed";
            txtNumberofBed.Size = new Size(153, 23);
            txtNumberofBed.TabIndex = 9;
            // 
            // txtNumberofPerson
            // 
            txtNumberofPerson.Location = new Point(121, 120);
            txtNumberofPerson.Name = "txtNumberofPerson";
            txtNumberofPerson.Size = new Size(153, 23);
            txtNumberofPerson.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 15);
            label9.Name = "label9";
            label9.Size = new Size(105, 15);
            label9.TabIndex = 6;
            label9.Text = "Room Type Details";
            // 
            // txtRoomType
            // 
            txtRoomType.Location = new Point(121, 45);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(153, 23);
            txtRoomType.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 82);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 3;
            label7.Text = "Number of Bed";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 122);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 2;
            label5.Text = "Maximum Person";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 162);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 1;
            label3.Text = "Price per Night";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 51);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "Room Type";
            // 
            // dgvRoomTypeList
            // 
            dgvRoomTypeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomTypeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomTypeList.Location = new Point(150, 276);
            dgvRoomTypeList.Name = "dgvRoomTypeList";
            dgvRoomTypeList.Size = new Size(630, 155);
            dgvRoomTypeList.TabIndex = 46;
            // 
            // dgvRoomList
            // 
            dgvRoomList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomList.Location = new Point(150, 120);
            dgvRoomList.Name = "dgvRoomList";
            dgvRoomList.Size = new Size(630, 150);
            dgvRoomList.TabIndex = 45;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(150, 91);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(430, 23);
            txtSearch.TabIndex = 44;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAddRoom
            // 
            btnAddRoom.Location = new Point(586, 84);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(87, 34);
            btnAddRoom.TabIndex = 43;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = true;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // btnAddRoomType
            // 
            btnAddRoomType.Location = new Point(679, 84);
            btnAddRoomType.Name = "btnAddRoomType";
            btnAddRoomType.Size = new Size(101, 34);
            btnAddRoomType.TabIndex = 42;
            btnAddRoomType.Text = "Add Room Type";
            btnAddRoomType.UseVisualStyleBackColor = true;
            btnAddRoomType.Click += btnAddRoomType_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(lblTotalRType);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(545, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(120, 55);
            panel3.TabIndex = 41;
            // 
            // lblTotalRType
            // 
            lblTotalRType.AutoSize = true;
            lblTotalRType.Location = new Point(50, 33);
            lblTotalRType.Name = "lblTotalRType";
            lblTotalRType.Size = new Size(13, 15);
            lblTotalRType.TabIndex = 1;
            lblTotalRType.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 9);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 0;
            label6.Text = "Room Type";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(lblTotalMaintenance);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(413, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(120, 55);
            panel4.TabIndex = 40;
            // 
            // lblTotalMaintenance
            // 
            lblTotalMaintenance.AutoSize = true;
            lblTotalMaintenance.Location = new Point(50, 33);
            lblTotalMaintenance.Name = "lblTotalMaintenance";
            lblTotalMaintenance.Size = new Size(13, 15);
            lblTotalMaintenance.TabIndex = 1;
            lblTotalMaintenance.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 9);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 0;
            label8.Text = "Maintenance";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lblTotalAvailable);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(282, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 55);
            panel2.TabIndex = 39;
            // 
            // lblTotalAvailable
            // 
            lblTotalAvailable.AutoSize = true;
            lblTotalAvailable.Location = new Point(50, 33);
            lblTotalAvailable.Name = "lblTotalAvailable";
            lblTotalAvailable.Size = new Size(13, 15);
            lblTotalAvailable.TabIndex = 1;
            lblTotalAvailable.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 9);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 0;
            label4.Text = "Available";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblTotalRoom);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(150, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 55);
            panel1.TabIndex = 38;
            // 
            // lblTotalRoom
            // 
            lblTotalRoom.AutoSize = true;
            lblTotalRoom.Location = new Point(50, 33);
            lblTotalRoom.Name = "lblTotalRoom";
            lblTotalRoom.Size = new Size(13, 15);
            lblTotalRoom.TabIndex = 1;
            lblTotalRoom.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Total Room";
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(20, 335);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(108, 34);
            btnPayment.TabIndex = 37;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(20, 295);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(108, 34);
            btnCheckOut.TabIndex = 36;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(21, 255);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(108, 34);
            btnCheckIn.TabIndex = 35;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnReservation
            // 
            btnReservation.Location = new Point(21, 215);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(108, 34);
            btnReservation.TabIndex = 34;
            btnReservation.Text = "Reservation";
            btnReservation.UseVisualStyleBackColor = true;
            // 
            // btnGuestManagement
            // 
            btnGuestManagement.Location = new Point(21, 175);
            btnGuestManagement.Name = "btnGuestManagement";
            btnGuestManagement.Size = new Size(108, 34);
            btnGuestManagement.TabIndex = 33;
            btnGuestManagement.Text = "Guest";
            btnGuestManagement.UseVisualStyleBackColor = true;
            // 
            // btnRoom
            // 
            btnRoom.Location = new Point(21, 135);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(108, 34);
            btnRoom.TabIndex = 32;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(21, 95);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(108, 34);
            btnDashboard.TabIndex = 31;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlRoom
            // 
            pnlRoom.Controls.Add(label13);
            pnlRoom.Controls.Add(btnBack);
            pnlRoom.Controls.Add(btnRoomAdd);
            pnlRoom.Controls.Add(txtRoomNumber);
            pnlRoom.Controls.Add(cmbRoomType);
            pnlRoom.Controls.Add(cmbStatus);
            pnlRoom.Controls.Add(label12);
            pnlRoom.Controls.Add(label11);
            pnlRoom.Controls.Add(label10);
            pnlRoom.Location = new Point(165, 149);
            pnlRoom.Name = "pnlRoom";
            pnlRoom.Size = new Size(266, 193);
            pnlRoom.TabIndex = 48;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 5);
            label13.Name = "label13";
            label13.Size = new Size(76, 15);
            label13.TabIndex = 15;
            label13.Text = "Create Room";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(175, 140);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(67, 26);
            btnBack.TabIndex = 14;
            btnBack.Text = "Cancel";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnRoomAdd
            // 
            btnRoomAdd.Location = new Point(102, 140);
            btnRoomAdd.Name = "btnRoomAdd";
            btnRoomAdd.Size = new Size(67, 26);
            btnRoomAdd.TabIndex = 13;
            btnRoomAdd.Text = "Add";
            btnRoomAdd.UseVisualStyleBackColor = true;
            btnRoomAdd.Click += btnRoomAdd_Click;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(110, 21);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(132, 23);
            txtRoomNumber.TabIndex = 12;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(110, 58);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(132, 23);
            cmbRoomType.TabIndex = 11;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(110, 91);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(132, 23);
            cmbStatus.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 94);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 9;
            label12.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 58);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 8;
            label11.Text = "Room Type";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 27);
            label10.Name = "label10";
            label10.Size = new Size(86, 15);
            label10.TabIndex = 7;
            label10.Text = "Room Number";
            // 
            // cMenuRoom
            // 
            cMenuRoom.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            cMenuRoom.Name = "cMenuRoom";
            cMenuRoom.Size = new Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // cMenuRoomType
            // 
            cMenuRoomType.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem1, deleteToolStripMenuItem1 });
            cMenuRoomType.Name = "cMenuRoomType";
            cMenuRoomType.Size = new Size(108, 48);
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(107, 22);
            editToolStripMenuItem1.Text = "Edit";
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(107, 22);
            deleteToolStripMenuItem1.Text = "Delete";
            // 
            // frmRoomManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlRoom);
            Controls.Add(pnlRoomType);
            Controls.Add(dgvRoomTypeList);
            Controls.Add(dgvRoomList);
            Controls.Add(txtSearch);
            Controls.Add(btnAddRoom);
            Controls.Add(btnAddRoomType);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnPayment);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(btnReservation);
            Controls.Add(btnGuestManagement);
            Controls.Add(btnRoom);
            Controls.Add(btnDashboard);
            Name = "frmRoomManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRoomManagement";
            Load += frmRoomManagement_Load;
            pnlRoomType.ResumeLayout(false);
            pnlRoomType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtNumberofBed).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNumberofPerson).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypeList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlRoom.ResumeLayout(false);
            pnlRoom.PerformLayout();
            cMenuRoom.ResumeLayout(false);
            cMenuRoomType.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlRoomType;
        private Button btnCancel;
        private Button btnAdd;
        private TextBox txtPricePerNight;
        private TextBox textBox3;
        private NumericUpDown txtNumberofBed;
        private NumericUpDown txtNumberofPerson;
        private Label label9;
        private TextBox txtRoomType;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label2;
        private DataGridView dgvRoomTypeList;
        private DataGridView dgvRoomList;
        private TextBox txtSearch;
        private Button btnAddRoom;
        private Button btnAddRoomType;
        private Panel panel3;
        private Label lblTotalRType;
        private Label label6;
        private Panel panel4;
        private Label lblTotalMaintenance;
        private Label label8;
        private Panel panel2;
        private Label lblTotalAvailable;
        private Label label4;
        private Panel panel1;
        private Label lblTotalRoom;
        private Label label1;
        private Button btnPayment;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private Button btnReservation;
        private Button btnGuestManagement;
        private Button btnRoom;
        private Button btnDashboard;
        private Panel pnlRoom;
        private Button btnBack;
        private Button btnRoomAdd;
        private TextBox txtRoomNumber;
        private ComboBox cmbRoomType;
        private ComboBox cmbStatus;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label13;
        private ContextMenuStrip cMenuRoom;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ContextMenuStrip cMenuRoomType;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem1;
    }
}