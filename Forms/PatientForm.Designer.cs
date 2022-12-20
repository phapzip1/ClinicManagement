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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plPatientInfor = new System.Windows.Forms.Panel();
            this.btnDel = new ClinicManagement.Classes.RJButton();
            this.btnGo = new ClinicManagement.Classes.RJButton();
            this.tbxPatientIDNow = new ClinicManagement.Classes.CustomTextBox();
            this.btnRegister = new ClinicManagement.Classes.RJButton();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNextPatient = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new ClinicManagement.Classes.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvPatientList = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxGender = new CustomControls.RJControls.RJComboBox();
            this.dtpkBob = new ClinicManagement.Classes.RJDatePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPatientAddress = new ClinicManagement.Classes.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPatientName = new ClinicManagement.Classes.CustomTextBox();
            this.tbxPatientID = new ClinicManagement.Classes.CustomTextBox();
            this.btnExit = new ClinicManagement.Classes.RJButton();
            this.btnSave = new ClinicManagement.Classes.RJButton();
            this.btnAdd = new ClinicManagement.Classes.RJButton();
            this.lblPatientData = new System.Windows.Forms.Label();
            this.gradientPanel1 = new ClinicManagement.Classes.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvQueue = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plPatientInfor.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatientList)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // plPatientInfor
            // 
            this.plPatientInfor.BackColor = System.Drawing.Color.Transparent;
            this.plPatientInfor.Controls.Add(this.btnDel);
            this.plPatientInfor.Controls.Add(this.btnGo);
            this.plPatientInfor.Controls.Add(this.tbxPatientIDNow);
            this.plPatientInfor.Controls.Add(this.btnRegister);
            this.plPatientInfor.Controls.Add(this.label10);
            this.plPatientInfor.Controls.Add(this.lblNextPatient);
            this.plPatientInfor.Controls.Add(this.label8);
            this.plPatientInfor.Controls.Add(this.label2);
            this.plPatientInfor.Location = new System.Drawing.Point(591, 23);
            this.plPatientInfor.Name = "plPatientInfor";
            this.plPatientInfor.Size = new System.Drawing.Size(295, 324);
            this.plPatientInfor.TabIndex = 2;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnDel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnDel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnDel.BorderRadius = 20;
            this.btnDel.BorderSize = 2;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Location = new System.Drawing.Point(80, 266);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(137, 51);
            this.btnDel.TabIndex = 25;
            this.btnDel.Text = "Xoá";
            this.btnDel.TextColor = System.Drawing.Color.Black;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnGo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnGo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnGo.BorderRadius = 20;
            this.btnGo.BorderSize = 2;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGo.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(151, 211);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(137, 51);
            this.btnGo.TabIndex = 24;
            this.btnGo.Text = "Vào khám";
            this.btnGo.TextColor = System.Drawing.Color.Black;
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbxPatientIDNow
            // 
            this.tbxPatientIDNow.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPatientIDNow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbxPatientIDNow.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.tbxPatientIDNow.BorderSize = 2;
            this.tbxPatientIDNow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPatientIDNow.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientIDNow.Location = new System.Drawing.Point(13, 140);
            this.tbxPatientIDNow.Multiline = false;
            this.tbxPatientIDNow.Name = "tbxPatientIDNow";
            this.tbxPatientIDNow.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPatientIDNow.PasswordChar = false;
            this.tbxPatientIDNow.ReadOnly = false;
            this.tbxPatientIDNow.Size = new System.Drawing.Size(265, 38);
            this.tbxPatientIDNow.TabIndex = 23;
            this.tbxPatientIDNow.Texts = "";
            this.tbxPatientIDNow.UnderlinedStyle = false;
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
            this.btnRegister.Location = new System.Drawing.Point(8, 211);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(137, 51);
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
            this.label10.Location = new System.Drawing.Point(13, 97);
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
            this.lblNextPatient.Location = new System.Drawing.Point(223, 46);
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
            this.label8.Location = new System.Drawing.Point(13, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Số thứ tự tiếp theo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "THÔNG TIN ĐĂNG KÝ";
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
            this.btnSearch.Location = new System.Drawing.Point(276, 266);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 51);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Tra cứu";
            this.btnSearch.TextColor = System.Drawing.Color.Black;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvPatientList);
            this.panel3.Location = new System.Drawing.Point(12, 393);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1165, 449);
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
            this.PatientID,
            this.PatientName,
            this.Gender,
            this.YearOfBirth,
            this.DiaChi});
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
            this.dtgvPatientList.Size = new System.Drawing.Size(1165, 449);
            this.dtgvPatientList.TabIndex = 2;
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "Id";
            this.PatientID.FillWeight = 113.6557F;
            this.PatientID.HeaderText = "Mã bệnh nhân";
            this.PatientID.MinimumWidth = 6;
            this.PatientID.Name = "PatientID";
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "Fullname";
            this.PatientName.FillWeight = 116.8409F;
            this.PatientName.HeaderText = "Họ tên bệnh nhân";
            this.PatientName.MinimumWidth = 6;
            this.PatientName.Name = "PatientName";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.FillWeight = 63.32629F;
            this.Gender.HeaderText = "Giới tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            // 
            // YearOfBirth
            // 
            this.YearOfBirth.DataPropertyName = "Dob";
            this.YearOfBirth.FillWeight = 66.37107F;
            this.YearOfBirth.HeaderText = "Năm sinh";
            this.YearOfBirth.MinimumWidth = 6;
            this.YearOfBirth.Name = "YearOfBirth";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "Address";
            this.DiaChi.FillWeight = 113.4867F;
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(492, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(259, 27);
            this.label11.TabIndex = 13;
            this.label11.Text = "Danh sách bệnh nhân";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblPatientData);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 324);
            this.panel1.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.33569F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.66431F));
            this.tableLayoutPanel1.Controls.Add(this.cbxGender, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpkBob, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbxPatientAddress, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxPatientName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxPatientID, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 218);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // cbxGender
            // 
            this.cbxGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.cbxGender.BorderSize = 2;
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxGender.ForeColor = System.Drawing.Color.DimGray;
            this.cbxGender.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxGender.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(218)))), ((int)(((byte)(252)))));
            this.cbxGender.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxGender.Location = new System.Drawing.Point(184, 89);
            this.cbxGender.MinimumSize = new System.Drawing.Size(50, 20);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Padding = new System.Windows.Forms.Padding(2);
            this.cbxGender.Size = new System.Drawing.Size(328, 37);
            this.cbxGender.TabIndex = 74;
            this.cbxGender.Texts = "";
            // 
            // dtpkBob
            // 
            this.dtpkBob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpkBob.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpkBob.BorderSize = 0;
            this.dtpkBob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkBob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkBob.Location = new System.Drawing.Point(184, 133);
            this.dtpkBob.Name = "dtpkBob";
            this.dtpkBob.Size = new System.Drawing.Size(328, 34);
            this.dtpkBob.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.dtpkBob.TabIndex = 26;
            this.dtpkBob.TextColor = System.Drawing.Color.Black;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 46);
            this.label7.TabIndex = 15;
            this.label7.Text = "Địa chỉ:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPatientAddress
            // 
            this.tbxPatientAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPatientAddress.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPatientAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbxPatientAddress.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.tbxPatientAddress.BorderSize = 2;
            this.tbxPatientAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPatientAddress.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientAddress.Location = new System.Drawing.Point(184, 176);
            this.tbxPatientAddress.Multiline = false;
            this.tbxPatientAddress.Name = "tbxPatientAddress";
            this.tbxPatientAddress.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPatientAddress.PasswordChar = false;
            this.tbxPatientAddress.ReadOnly = false;
            this.tbxPatientAddress.Size = new System.Drawing.Size(328, 38);
            this.tbxPatientAddress.TabIndex = 24;
            this.tbxPatientAddress.Texts = "";
            this.tbxPatientAddress.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 43);
            this.label6.TabIndex = 14;
            this.label6.Text = "Năm sinh:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 43);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giới tính: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 43);
            this.label4.TabIndex = 12;
            this.label4.Text = "Họ tên: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 43);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã bệnh nhân:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPatientName
            // 
            this.tbxPatientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPatientName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPatientName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbxPatientName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.tbxPatientName.BorderSize = 2;
            this.tbxPatientName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPatientName.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientName.Location = new System.Drawing.Point(184, 46);
            this.tbxPatientName.Multiline = false;
            this.tbxPatientName.Name = "tbxPatientName";
            this.tbxPatientName.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPatientName.PasswordChar = false;
            this.tbxPatientName.ReadOnly = false;
            this.tbxPatientName.Size = new System.Drawing.Size(328, 38);
            this.tbxPatientName.TabIndex = 23;
            this.tbxPatientName.Texts = "";
            this.tbxPatientName.UnderlinedStyle = false;
            // 
            // tbxPatientID
            // 
            this.tbxPatientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPatientID.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPatientID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbxPatientID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.tbxPatientID.BorderSize = 2;
            this.tbxPatientID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPatientID.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientID.Location = new System.Drawing.Point(184, 3);
            this.tbxPatientID.Multiline = false;
            this.tbxPatientID.Name = "tbxPatientID";
            this.tbxPatientID.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPatientID.PasswordChar = false;
            this.tbxPatientID.ReadOnly = false;
            this.tbxPatientID.Size = new System.Drawing.Size(328, 38);
            this.tbxPatientID.TabIndex = 22;
            this.tbxPatientID.Texts = "";
            this.tbxPatientID.UnderlinedStyle = false;
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
            this.btnExit.Location = new System.Drawing.Point(378, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 47);
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
            this.btnSave.Location = new System.Drawing.Point(171, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 51);
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
            this.btnAdd.Location = new System.Drawing.Point(71, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 51);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPatientData
            // 
            this.lblPatientData.AutoSize = true;
            this.lblPatientData.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPatientData.ForeColor = System.Drawing.Color.Black;
            this.lblPatientData.Location = new System.Drawing.Point(149, 0);
            this.lblPatientData.Name = "lblPatientData";
            this.lblPatientData.Size = new System.Drawing.Size(286, 27);
            this.lblPatientData.TabIndex = 0;
            this.lblPatientData.Text = "THÔNG TIN BỆNH NHÂN";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.SystemColors.Menu;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(166)))), ((int)(((byte)(250)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.panel4);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.label11);
            this.gradientPanel1.Controls.Add(this.plPatientInfor);
            this.gradientPanel1.Controls.Add(this.panel3);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1189, 845);
            this.gradientPanel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(911, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 27);
            this.label1.TabIndex = 35;
            this.label1.Text = "Bệnh nhân đang chờ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvQueue);
            this.panel4.Location = new System.Drawing.Point(892, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 294);
            this.panel4.TabIndex = 34;
            // 
            // dtgvQueue
            // 
            this.dtgvQueue.AllowUserToAddRows = false;
            this.dtgvQueue.AllowUserToDeleteRows = false;
            this.dtgvQueue.AllowUserToResizeColumns = false;
            this.dtgvQueue.AllowUserToResizeRows = false;
            this.dtgvQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvQueue.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQueue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvQueue.ColumnHeadersHeight = 60;
            this.dtgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.dataGridViewTextBoxColumn2});
            this.dtgvQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvQueue.EnableHeadersVisualStyles = false;
            this.dtgvQueue.Location = new System.Drawing.Point(0, 0);
            this.dtgvQueue.Name = "dtgvQueue";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQueue.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvQueue.RowHeadersVisible = false;
            this.dtgvQueue.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dtgvQueue.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgvQueue.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvQueue.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtgvQueue.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this.dtgvQueue.RowTemplate.Height = 29;
            this.dtgvQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQueue.Size = new System.Drawing.Size(285, 294);
            this.dtgvQueue.TabIndex = 4;
            // 
            // STT
            // 
            this.STT.FillWeight = 59.89708F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 164.118F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ tên ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(166)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1189, 845);
            this.Controls.Add(this.gradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PatientForm";
            this.Text = "Bệnh Nhân";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.plPatientInfor.ResumeLayout(false);
            this.plPatientInfor.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatientList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQueue)).EndInit();
            this.ResumeLayout(false);

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
        private Label lblPatientData;
        private Classes.CustomTextBox tbxPatientIDNow;
        private Classes.RJButton btnGo;
        private Classes.GradientPanel gradientPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Classes.RJDatePicker dtpkBob;
        private Label label7;
        private Classes.CustomTextBox tbxPatientAddress;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Classes.CustomTextBox tbxPatientName;
        private Classes.CustomTextBox tbxPatientID;
        private CustomControls.RJControls.RJComboBox cbxGender;
        private Classes.RJButton btnDel;
        private Panel panel4;
        private DataGridView dtgvQueue;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label1;
        private DataGridViewTextBoxColumn PatientID;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn YearOfBirth;
        private DataGridViewTextBoxColumn DiaChi;
    }
}