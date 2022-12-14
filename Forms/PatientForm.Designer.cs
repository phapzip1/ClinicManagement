namespace ClinicManagement.Forms
{
    partial class PatientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plPatientInfor = new System.Windows.Forms.Panel();
            this.btnGo = new ClinicManagement.Classes.RJButton();
            this.tbxPatientIDNow = new ClinicManagement.Classes.CustomTextBox();
            this.btnSearch = new ClinicManagement.Classes.RJButton();
            this.btnRegister = new ClinicManagement.Classes.RJButton();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNextPatient = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvPatientList = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpkBob = new ClinicManagement.Classes.RJDatePicker();
            this.rbtnPatientFemale = new ClinicManagement.Classes.RJRadioButton();
            this.rbtnPatientMale = new ClinicManagement.Classes.RJRadioButton();
            this.tbxPatientAddress = new ClinicManagement.Classes.CustomTextBox();
            this.tbxPatientName = new ClinicManagement.Classes.CustomTextBox();
            this.tbxPatientID = new ClinicManagement.Classes.CustomTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new ClinicManagement.Classes.RJButton();
            this.btnSave = new ClinicManagement.Classes.RJButton();
            this.btnAdd = new ClinicManagement.Classes.RJButton();
            this.lblPatientData = new System.Windows.Forms.Label();
            this.plPatientInfor.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatientList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // plPatientInfor
            // 
            this.plPatientInfor.BackColor = System.Drawing.Color.SkyBlue;
            this.plPatientInfor.Controls.Add(this.btnGo);
            this.plPatientInfor.Controls.Add(this.tbxPatientIDNow);
            this.plPatientInfor.Controls.Add(this.btnSearch);
            this.plPatientInfor.Controls.Add(this.btnRegister);
            this.plPatientInfor.Controls.Add(this.label10);
            this.plPatientInfor.Controls.Add(this.lblNextPatient);
            this.plPatientInfor.Controls.Add(this.label8);
            this.plPatientInfor.Controls.Add(this.label2);
            this.plPatientInfor.Location = new System.Drawing.Point(658, 12);
            this.plPatientInfor.Name = "plPatientInfor";
            this.plPatientInfor.Size = new System.Drawing.Size(438, 324);
            this.plPatientInfor.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnGo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnGo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnGo.BorderRadius = 20;
            this.btnGo.BorderSize = 2;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGo.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(149, 260);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(137, 50);
            this.btnGo.TabIndex = 24;
            this.btnGo.Text = "Vào khám";
            this.btnGo.TextColor = System.Drawing.Color.Black;
            this.btnGo.UseVisualStyleBackColor = false;
            // 
            // tbxPatientIDNow
            // 
            this.tbxPatientIDNow.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPatientIDNow.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxPatientIDNow.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxPatientIDNow.BorderSize = 1;
            this.tbxPatientIDNow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPatientIDNow.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientIDNow.Location = new System.Drawing.Point(88, 212);
            this.tbxPatientIDNow.Multiline = false;
            this.tbxPatientIDNow.Name = "tbxPatientIDNow";
            this.tbxPatientIDNow.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPatientIDNow.PasswordChar = false;
            this.tbxPatientIDNow.ReadOnly = false;
            this.tbxPatientIDNow.Size = new System.Drawing.Size(280, 38);
            this.tbxPatientIDNow.TabIndex = 23;
            this.tbxPatientIDNow.Texts = "";
            this.tbxPatientIDNow.UnderlinedStyle = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.BorderSize = 2;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(292, 260);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 50);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Tra cứu";
            this.btnSearch.TextColor = System.Drawing.Color.Black;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnRegister.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnRegister.BorderRadius = 20;
            this.btnRegister.BorderSize = 2;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(6, 260);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(137, 50);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.TextColor = System.Drawing.Color.Black;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(146, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 26);
            this.label10.TabIndex = 19;
            this.label10.Text = "Mã bệnh nhân:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNextPatient
            // 
            this.lblNextPatient.AutoSize = true;
            this.lblNextPatient.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNextPatient.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNextPatient.Location = new System.Drawing.Point(202, 109);
            this.lblNextPatient.Name = "lblNextPatient";
            this.lblNextPatient.Size = new System.Drawing.Size(43, 50);
            this.lblNextPatient.TabIndex = 13;
            this.lblNextPatient.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(130, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Số thứ tự tiếp theo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(117, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "THÔNG TIN ĐĂNG KÝ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvPatientList);
            this.panel3.Location = new System.Drawing.Point(12, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1154, 456);
            this.panel3.TabIndex = 3;
            // 
            // dtgvPatientList
            // 
            this.dtgvPatientList.AllowUserToAddRows = false;
            this.dtgvPatientList.AllowUserToDeleteRows = false;
            this.dtgvPatientList.AllowUserToResizeColumns = false;
            this.dtgvPatientList.AllowUserToResizeRows = false;
            this.dtgvPatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPatientList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPatientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvPatientList.ColumnHeadersHeight = 60;
            this.dtgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.PatientID,
            this.PatientName,
            this.Gender,
            this.YearOfBirth,
            this.Address});
            this.dtgvPatientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvPatientList.EnableHeadersVisualStyles = false;
            this.dtgvPatientList.Location = new System.Drawing.Point(0, 0);
            this.dtgvPatientList.Name = "dtgvPatientList";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPatientList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvPatientList.RowHeadersVisible = false;
            this.dtgvPatientList.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dtgvPatientList.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvPatientList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvPatientList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtgvPatientList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this.dtgvPatientList.RowTemplate.Height = 29;
            this.dtgvPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPatientList.Size = new System.Drawing.Size(1154, 456);
            this.dtgvPatientList.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.FillWeight = 63.63638F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // PatientID
            // 
            this.PatientID.FillWeight = 122.3168F;
            this.PatientID.HeaderText = "Mã bệnh nhân";
            this.PatientID.MinimumWidth = 6;
            this.PatientID.Name = "PatientID";
            // 
            // PatientName
            // 
            this.PatientName.FillWeight = 132.0341F;
            this.PatientName.HeaderText = "Họ tên bệnh nhân";
            this.PatientName.MinimumWidth = 6;
            this.PatientName.Name = "PatientName";
            // 
            // Gender
            // 
            this.Gender.FillWeight = 56.83035F;
            this.Gender.HeaderText = "Giới tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            // 
            // YearOfBirth
            // 
            this.YearOfBirth.FillWeight = 102.3897F;
            this.YearOfBirth.HeaderText = "Năm sinh";
            this.YearOfBirth.MinimumWidth = 6;
            this.YearOfBirth.Name = "YearOfBirth";
            // 
            // Address
            // 
            this.Address.FillWeight = 117.7929F;
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(526, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "Danh sách bệnh nhân";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblPatientData);
            this.panel1.Location = new System.Drawing.Point(53, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 324);
            this.panel1.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtpkBob);
            this.panel5.Controls.Add(this.rbtnPatientFemale);
            this.panel5.Controls.Add(this.rbtnPatientMale);
            this.panel5.Controls.Add(this.tbxPatientAddress);
            this.panel5.Controls.Add(this.tbxPatientName);
            this.panel5.Controls.Add(this.tbxPatientID);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(61, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(482, 217);
            this.panel5.TabIndex = 1;
            // 
            // dtpkBob
            // 
            this.dtpkBob.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpkBob.BorderSize = 0;
            this.dtpkBob.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkBob.Location = new System.Drawing.Point(159, 135);
            this.dtpkBob.Name = "dtpkBob";
            this.dtpkBob.Size = new System.Drawing.Size(318, 29);
            this.dtpkBob.SkinColor = System.Drawing.Color.Navy;
            this.dtpkBob.TabIndex = 26;
            this.dtpkBob.TextColor = System.Drawing.Color.White;
            // 
            // rbtnPatientFemale
            // 
            this.rbtnPatientFemale.AutoSize = true;
            this.rbtnPatientFemale.CheckedColor = System.Drawing.Color.Navy;
            this.rbtnPatientFemale.Location = new System.Drawing.Point(227, 98);
            this.rbtnPatientFemale.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnPatientFemale.Name = "rbtnPatientFemale";
            this.rbtnPatientFemale.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnPatientFemale.Size = new System.Drawing.Size(60, 24);
            this.rbtnPatientFemale.TabIndex = 25;
            this.rbtnPatientFemale.TabStop = true;
            this.rbtnPatientFemale.Text = "Nữ";
            this.rbtnPatientFemale.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnPatientFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnPatientMale
            // 
            this.rbtnPatientMale.AutoSize = true;
            this.rbtnPatientMale.CheckedColor = System.Drawing.Color.Navy;
            this.rbtnPatientMale.Location = new System.Drawing.Point(161, 98);
            this.rbtnPatientMale.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnPatientMale.Name = "rbtnPatientMale";
            this.rbtnPatientMale.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnPatientMale.Size = new System.Drawing.Size(72, 24);
            this.rbtnPatientMale.TabIndex = 24;
            this.rbtnPatientMale.TabStop = true;
            this.rbtnPatientMale.Text = "Nam";
            this.rbtnPatientMale.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnPatientMale.UseVisualStyleBackColor = true;
            // 
            // tbxPatientAddress
            // 
            this.tbxPatientAddress.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPatientAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxPatientAddress.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxPatientAddress.BorderSize = 1;
            this.tbxPatientAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPatientAddress.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientAddress.Location = new System.Drawing.Point(159, 166);
            this.tbxPatientAddress.Multiline = false;
            this.tbxPatientAddress.Name = "tbxPatientAddress";
            this.tbxPatientAddress.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPatientAddress.PasswordChar = false;
            this.tbxPatientAddress.ReadOnly = false;
            this.tbxPatientAddress.Size = new System.Drawing.Size(318, 38);
            this.tbxPatientAddress.TabIndex = 24;
            this.tbxPatientAddress.Texts = "";
            this.tbxPatientAddress.UnderlinedStyle = false;
            // 
            // tbxPatientName
            // 
            this.tbxPatientName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPatientName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxPatientName.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxPatientName.BorderSize = 1;
            this.tbxPatientName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPatientName.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientName.Location = new System.Drawing.Point(159, 46);
            this.tbxPatientName.Multiline = false;
            this.tbxPatientName.Name = "tbxPatientName";
            this.tbxPatientName.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPatientName.PasswordChar = false;
            this.tbxPatientName.ReadOnly = false;
            this.tbxPatientName.Size = new System.Drawing.Size(318, 38);
            this.tbxPatientName.TabIndex = 23;
            this.tbxPatientName.Texts = "";
            this.tbxPatientName.UnderlinedStyle = false;
            // 
            // tbxPatientID
            // 
            this.tbxPatientID.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPatientID.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxPatientID.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxPatientID.BorderSize = 1;
            this.tbxPatientID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPatientID.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientID.Location = new System.Drawing.Point(159, 6);
            this.tbxPatientID.Multiline = false;
            this.tbxPatientID.Name = "tbxPatientID";
            this.tbxPatientID.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPatientID.PasswordChar = false;
            this.tbxPatientID.ReadOnly = false;
            this.tbxPatientID.Size = new System.Drawing.Size(318, 38);
            this.tbxPatientID.TabIndex = 22;
            this.tbxPatientID.Texts = "";
            this.tbxPatientID.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Địa chỉ:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Năm sinh:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giới tính: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Họ tên: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã bệnh nhân:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnExit.BorderRadius = 20;
            this.btnExit.BorderSize = 2;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(370, 260);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 50);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Huỷ";
            this.btnExit.TextColor = System.Drawing.Color.Black;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 2;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(265, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 50);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 2;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(165, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 50);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPatientData
            // 
            this.lblPatientData.AutoSize = true;
            this.lblPatientData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPatientData.ForeColor = System.Drawing.Color.Black;
            this.lblPatientData.Location = new System.Drawing.Point(198, 10);
            this.lblPatientData.Name = "lblPatientData";
            this.lblPatientData.Size = new System.Drawing.Size(244, 24);
            this.lblPatientData.TabIndex = 0;
            this.lblPatientData.Text = "THÔNG TIN BỆNH NHÂN";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1189, 846);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.plPatientInfor);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PatientForm";
            this.Text = "Bệnh Nhân";
            this.plPatientInfor.ResumeLayout(false);
            this.plPatientInfor.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatientList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel plPatientInfor;
        private Panel panel3;
        private Label label2;
        private Label lblNextPatient;
        private Label label8;
        private Label label10;
        private Classes.RJButton btnSearch;
        private Classes.RJButton btnRegister;
        private DataGridView dtgvPatientList;
        private Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Classes.RJButton btnExit;
        private Classes.RJButton btnSave;
        private Classes.RJButton btnAdd;
        private Panel panel5;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblPatientData;
        private Classes.CustomTextBox tbxPatientIDNow;
        private Classes.CustomTextBox tbxPatientName;
        private Classes.CustomTextBox tbxPatientID;
        private Classes.CustomTextBox tbxPatientAddress;
        private Classes.RJRadioButton rbtnPatientFemale;
        private Classes.RJRadioButton rbtnPatientMale;
        private Classes.RJDatePicker dtpkBob;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn PatientID;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn YearOfBirth;
        private DataGridViewTextBoxColumn Address;
        private Classes.RJButton btnGo;
    }
}