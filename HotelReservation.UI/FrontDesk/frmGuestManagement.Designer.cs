namespace HotelReservation.UI.FrontDesk
{
    partial class frmGuestManagement
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
            dgvGuestsList = new DataGridView();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnDashboard = new Button();
            lblTotalGuest = new Label();
            btnAddGuest = new Button();
            txtSearch = new TextBox();
            pnlAddGuest = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtEmergencyNumber = new MaskedTextBox();
            txtEmergencyName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtProvince = new TextBox();
            txtCity = new TextBox();
            txtStreet = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtPhone = new MaskedTextBox();
            cmbGender = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            dtpBirthDate = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnRefresh = new Button();
            cMenuGuest = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            reserveToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvGuestsList).BeginInit();
            pnlAddGuest.SuspendLayout();
            cMenuGuest.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGuestsList
            // 
            dgvGuestsList.AllowUserToAddRows = false;
            dgvGuestsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuestsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuestsList.Location = new Point(127, 98);
            dgvGuestsList.Name = "dgvGuestsList";
            dgvGuestsList.Size = new Size(661, 340);
            dgvGuestsList.TabIndex = 0;
            dgvGuestsList.CellFormatting += dgvGuestsList_CellFormatting;
            dgvGuestsList.CellMouseDown += dgvGuestsList_CellMouseDown;
            // 
            // button7
            // 
            button7.Location = new Point(12, 342);
            button7.Name = "button7";
            button7.Size = new Size(108, 34);
            button7.TabIndex = 13;
            button7.Text = "Payment";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(12, 302);
            button6.Name = "button6";
            button6.Size = new Size(108, 34);
            button6.TabIndex = 12;
            button6.Text = "Check Out";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(13, 262);
            button5.Name = "button5";
            button5.Size = new Size(108, 34);
            button5.TabIndex = 11;
            button5.Text = "Check In";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(13, 222);
            button4.Name = "button4";
            button4.Size = new Size(108, 34);
            button4.TabIndex = 10;
            button4.Text = "Reservation";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(13, 182);
            button3.Name = "button3";
            button3.Size = new Size(108, 34);
            button3.TabIndex = 9;
            button3.Text = "Guest";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(13, 142);
            button2.Name = "button2";
            button2.Size = new Size(108, 34);
            button2.TabIndex = 8;
            button2.Text = "Room";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(13, 102);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(108, 34);
            btnDashboard.TabIndex = 7;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblTotalGuest
            // 
            lblTotalGuest.AutoSize = true;
            lblTotalGuest.Location = new Point(189, 48);
            lblTotalGuest.Name = "lblTotalGuest";
            lblTotalGuest.Size = new Size(13, 15);
            lblTotalGuest.TabIndex = 15;
            lblTotalGuest.Text = "0";
            // 
            // btnAddGuest
            // 
            btnAddGuest.Location = new Point(698, 32);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new Size(90, 31);
            btnAddGuest.TabIndex = 16;
            btnAddGuest.Text = "Add Guest";
            btnAddGuest.UseVisualStyleBackColor = true;
            btnAddGuest.Click += btnAddGuest_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(127, 69);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(661, 23);
            txtSearch.TabIndex = 18;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // pnlAddGuest
            // 
            pnlAddGuest.Controls.Add(textBox2);
            pnlAddGuest.Controls.Add(textBox1);
            pnlAddGuest.Controls.Add(btnCancel);
            pnlAddGuest.Controls.Add(btnSave);
            pnlAddGuest.Controls.Add(txtEmergencyNumber);
            pnlAddGuest.Controls.Add(txtEmergencyName);
            pnlAddGuest.Controls.Add(label10);
            pnlAddGuest.Controls.Add(label9);
            pnlAddGuest.Controls.Add(label8);
            pnlAddGuest.Controls.Add(label7);
            pnlAddGuest.Controls.Add(txtProvince);
            pnlAddGuest.Controls.Add(txtCity);
            pnlAddGuest.Controls.Add(txtStreet);
            pnlAddGuest.Controls.Add(label6);
            pnlAddGuest.Controls.Add(label5);
            pnlAddGuest.Controls.Add(txtPhone);
            pnlAddGuest.Controls.Add(cmbGender);
            pnlAddGuest.Controls.Add(label4);
            pnlAddGuest.Controls.Add(label3);
            pnlAddGuest.Controls.Add(dtpBirthDate);
            pnlAddGuest.Controls.Add(label11);
            pnlAddGuest.Controls.Add(label12);
            pnlAddGuest.Controls.Add(txtLastName);
            pnlAddGuest.Controls.Add(txtFirstName);
            pnlAddGuest.Location = new Point(288, 12);
            pnlAddGuest.Name = "pnlAddGuest";
            pnlAddGuest.Size = new Size(322, 426);
            pnlAddGuest.TabIndex = 22;
            pnlAddGuest.Paint += pnlAddGuest_Paint;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 358);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(52, 23);
            textBox2.TabIndex = 46;
            textBox2.Text = "(+63) -/";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 170);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(52, 23);
            textBox1.TabIndex = 45;
            textBox1.Text = "(+63) -/";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(245, 389);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(65, 27);
            btnCancel.TabIndex = 44;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(174, 389);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(65, 27);
            btnSave.TabIndex = 43;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmergencyNumber
            // 
            txtEmergencyNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmergencyNumber.Location = new Point(64, 358);
            txtEmergencyNumber.Mask = "000-000-0000";
            txtEmergencyNumber.Name = "txtEmergencyNumber";
            txtEmergencyNumber.Size = new Size(102, 23);
            txtEmergencyNumber.TabIndex = 42;
            // 
            // txtEmergencyName
            // 
            txtEmergencyName.Location = new Point(13, 313);
            txtEmergencyName.Name = "txtEmergencyName";
            txtEmergencyName.Size = new Size(276, 23);
            txtEmergencyName.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 340);
            label10.Name = "label10";
            label10.Size = new Size(121, 15);
            label10.TabIndex = 40;
            label10.Text = "Emergency Contact #";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 295);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 39;
            label9.Text = "Emergency Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(153, 251);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 38;
            label8.Text = "Province";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 251);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 37;
            label7.Text = "City";
            // 
            // txtProvince
            // 
            txtProvince.Location = new Point(153, 269);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(137, 23);
            txtProvince.TabIndex = 36;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(14, 269);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(143, 23);
            txtCity.TabIndex = 35;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(14, 224);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(276, 23);
            txtStreet.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 206);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 33;
            label6.Text = "Street";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 154);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 32;
            label5.Text = "Number";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(64, 170);
            txtPhone.Mask = "900-000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(102, 23);
            txtPhone.TabIndex = 31;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(194, 172);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(95, 23);
            cmbGender.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 154);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 29;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 106);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 28;
            label3.Text = "Date of Birth";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(13, 124);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(276, 23);
            dtpBirthDate.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 59);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 26;
            label11.Text = "Last Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 10);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 25;
            label12.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(13, 77);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(276, 23);
            txtLastName.TabIndex = 24;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(13, 28);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(276, 23);
            txtFirstName.TabIndex = 23;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(616, 32);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(76, 31);
            btnRefresh.TabIndex = 23;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cMenuGuest
            // 
            cMenuGuest.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem, reserveToolStripMenuItem });
            cMenuGuest.Name = "cMenuGuest";
            cMenuGuest.Size = new Size(115, 70);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(114, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(114, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // reserveToolStripMenuItem
            // 
            reserveToolStripMenuItem.Name = "reserveToolStripMenuItem";
            reserveToolStripMenuItem.Size = new Size(114, 22);
            reserveToolStripMenuItem.Text = "Reserve";
            // 
            // frmGuestManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlAddGuest);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearch);
            Controls.Add(btnAddGuest);
            Controls.Add(lblTotalGuest);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnDashboard);
            Controls.Add(dgvGuestsList);
            Name = "frmGuestManagement";
            Text = "frmGuestManagement";
            Load += frmGuestManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGuestsList).EndInit();
            pnlAddGuest.ResumeLayout(false);
            pnlAddGuest.PerformLayout();
            cMenuGuest.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGuestsList;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnDashboard;
        private Label lblTotalGuest;
        private Button btnAddGuest;
        private TextBox txtSearch;
        private Panel pnlAddGuest;
        private Button btnCancel;
        private Button btnSave;
        private MaskedTextBox txtEmergencyNumber;
        private TextBox txtEmergencyName;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtProvince;
        private TextBox txtCity;
        private TextBox txtStreet;
        private Label label6;
        private Label label5;
        private MaskedTextBox txtPhone;
        private ComboBox cmbGender;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpBirthDate;
        private Label label11;
        private Label label12;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnRefresh;
        private ContextMenuStrip cMenuGuest;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem reserveToolStripMenuItem;
    }
}