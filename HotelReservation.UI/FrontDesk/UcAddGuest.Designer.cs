namespace HotelReservation.UI.FrontDesk
{
    partial class UcAddGuest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dtpBirthDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            cmbGender = new ComboBox();
            txtPhone = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            txtStreet = new TextBox();
            txtCity = new TextBox();
            txtProvince = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtEmergencyName = new TextBox();
            txtEmergencyNumber = new MaskedTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(49, 29);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(276, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(49, 78);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(276, 23);
            txtLastName.TabIndex = 1;
            txtLastName.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 11);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 60);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(49, 125);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(276, 23);
            dtpBirthDate.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 107);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 5;
            label3.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 155);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(230, 173);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(95, 23);
            cmbGender.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(50, 173);
            txtPhone.Mask = "(+63) 000-000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(143, 23);
            txtPhone.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 155);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 207);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 11;
            label6.Text = "Street";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(50, 225);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(276, 23);
            txtStreet.TabIndex = 12;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(50, 270);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(143, 23);
            txtCity.TabIndex = 13;
            // 
            // txtProvince
            // 
            txtProvince.Location = new Point(189, 270);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(137, 23);
            txtProvince.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 252);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 15;
            label7.Text = "City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(189, 252);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 16;
            label8.Text = "Province";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(49, 296);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 17;
            label9.Text = "Emergency Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(49, 341);
            label10.Name = "label10";
            label10.Size = new Size(121, 15);
            label10.TabIndex = 18;
            label10.Text = "Emergency Contact #";
            // 
            // txtEmergencyName
            // 
            txtEmergencyName.Location = new Point(49, 314);
            txtEmergencyName.Name = "txtEmergencyName";
            txtEmergencyName.Size = new Size(276, 23);
            txtEmergencyName.TabIndex = 19;
            // 
            // txtEmergencyNumber
            // 
            txtEmergencyNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmergencyNumber.Location = new Point(49, 359);
            txtEmergencyNumber.Mask = "(+63) 000-000-0000";
            txtEmergencyNumber.Name = "txtEmergencyNumber";
            txtEmergencyNumber.Size = new Size(143, 23);
            txtEmergencyNumber.TabIndex = 20;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(210, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(65, 27);
            btnSave.TabIndex = 21;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(281, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(65, 27);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // UcAddGuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtEmergencyNumber);
            Controls.Add(txtEmergencyName);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtProvince);
            Controls.Add(txtCity);
            Controls.Add(txtStreet);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(cmbGender);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpBirthDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "UcAddGuest";
            Size = new Size(380, 431);
            Load += UcAddGuest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpBirthDate;
        private Label label3;
        private Label label4;
        private ComboBox cmbGender;
        private MaskedTextBox txtPhone;
        private Label label5;
        private Label label6;
        private TextBox txtStreet;
        private TextBox txtCity;
        private TextBox txtProvince;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtEmergencyName;
        private MaskedTextBox txtEmergencyNumber;
        private Button btnSave;
        private Button btnCancel;
    }
}
