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
            this.btnSearch = new ClinicManagement.Classes.RJButton();
            this.btnRegister = new ClinicManagement.Classes.RJButton();
            this.btnSaveList = new ClinicManagement.Classes.RJButton();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNextPatient = new System.Windows.Forms.Label();
            this.txbPatientID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvPatientList = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvBillList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new ClinicManagement.Classes.RJButton();
            this.btnSave = new ClinicManagement.Classes.RJButton();
            this.btnUpdate = new ClinicManagement.Classes.RJButton();
            this.btnAdd = new ClinicManagement.Classes.RJButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.cbWomen = new System.Windows.Forms.CheckBox();
            this.cbMen = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPatientName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txbPatient = new System.Windows.Forms.TextBox();
            this.lblPatientData = new System.Windows.Forms.Label();
            this.plPatientInfor.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatientList)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // plPatientInfor
            // 
            this.plPatientInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plPatientInfor.Controls.Add(this.btnSearch);
            this.plPatientInfor.Controls.Add(this.btnRegister);
            this.plPatientInfor.Controls.Add(this.btnSaveList);
            this.plPatientInfor.Controls.Add(this.label10);
            this.plPatientInfor.Controls.Add(this.lblNextPatient);
            this.plPatientInfor.Controls.Add(this.txbPatientID);
            this.plPatientInfor.Controls.Add(this.label8);
            this.plPatientInfor.Controls.Add(this.label2);
            this.plPatientInfor.Location = new System.Drawing.Point(442, 12);
            this.plPatientInfor.Name = "plPatientInfor";
            this.plPatientInfor.Size = new System.Drawing.Size(260, 324);
            this.plPatientInfor.TabIndex = 2;
            this.plPatientInfor.Paint += new System.Windows.Forms.PaintEventHandler(this.plPatientInfor_Paint);
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
            this.btnSearch.Location = new System.Drawing.Point(55, 158);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 50);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Tra cứu";
            this.btnSearch.TextColor = System.Drawing.Color.Black;
            this.btnSearch.UseVisualStyleBackColor = false;
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
            this.btnRegister.Location = new System.Drawing.Point(55, 214);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 50);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.TextColor = System.Drawing.Color.Black;
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnSaveList
            // 
            this.btnSaveList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSaveList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSaveList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnSaveList.BorderRadius = 20;
            this.btnSaveList.BorderSize = 2;
            this.btnSaveList.FlatAppearance.BorderSize = 0;
            this.btnSaveList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveList.ForeColor = System.Drawing.Color.Black;
            this.btnSaveList.Location = new System.Drawing.Point(55, 270);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(150, 50);
            this.btnSaveList.TabIndex = 14;
            this.btnSaveList.Text = "Nạp danh sách";
            this.btnSaveList.TextColor = System.Drawing.Color.Black;
            this.btnSaveList.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 87);
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
            this.lblNextPatient.ForeColor = System.Drawing.Color.Red;
            this.lblNextPatient.Location = new System.Drawing.Point(188, 40);
            this.lblNextPatient.Name = "lblNextPatient";
            this.lblNextPatient.Size = new System.Drawing.Size(43, 50);
            this.lblNextPatient.TabIndex = 13;
            this.lblNextPatient.Text = "0";
            this.lblNextPatient.Click += new System.EventHandler(this.label9_Click);
            // 
            // txbPatientID
            // 
            this.txbPatientID.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txbPatientID.Location = new System.Drawing.Point(23, 116);
            this.txbPatientID.Name = "txbPatientID";
            this.txbPatientID.Size = new System.Drawing.Size(217, 27);
            this.txbPatientID.TabIndex = 18;
            this.txbPatientID.TextChanged += new System.EventHandler(this.txbPatientID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "STT tiếp theo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 10);
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
            this.dtgvPatientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PatientID
            // 
            this.PatientID.FillWeight = 113.9461F;
            this.PatientID.HeaderText = "Mã bệnh nhân";
            this.PatientID.MinimumWidth = 6;
            this.PatientID.Name = "PatientID";
            // 
            // PatientName
            // 
            this.PatientName.FillWeight = 122.9984F;
            this.PatientName.HeaderText = "Họ tên bệnh nhân";
            this.PatientName.MinimumWidth = 6;
            this.PatientName.Name = "PatientName";
            // 
            // Gender
            // 
            this.Gender.FillWeight = 52.9412F;
            this.Gender.HeaderText = "Giới tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            // 
            // YearOfBirth
            // 
            this.YearOfBirth.FillWeight = 95.38268F;
            this.YearOfBirth.HeaderText = "Năm sinh";
            this.YearOfBirth.MinimumWidth = 6;
            this.YearOfBirth.Name = "YearOfBirth";
            // 
            // Address
            // 
            this.Address.FillWeight = 109.7318F;
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvBillList);
            this.panel4.Location = new System.Drawing.Point(708, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 297);
            this.panel4.TabIndex = 4;
            // 
            // dtgvBillList
            // 
            this.dtgvBillList.AllowUserToAddRows = false;
            this.dtgvBillList.AllowUserToDeleteRows = false;
            this.dtgvBillList.AllowUserToResizeColumns = false;
            this.dtgvBillList.AllowUserToResizeRows = false;
            this.dtgvBillList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBillList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBillList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvBillList.ColumnHeadersHeight = 60;
            this.dtgvBillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvBillList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dtgvBillList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvBillList.EnableHeadersVisualStyles = false;
            this.dtgvBillList.Location = new System.Drawing.Point(0, 0);
            this.dtgvBillList.Name = "dtgvBillList";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBillList.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvBillList.RowHeadersVisible = false;
            this.dtgvBillList.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dtgvBillList.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgvBillList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvBillList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBillList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this.dtgvBillList.RowTemplate.Height = 29;
            this.dtgvBillList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBillList.Size = new System.Drawing.Size(458, 297);
            this.dtgvBillList.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 127.7511F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 124.0151F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ tên ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 79.53129F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(548, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "Danh sách bệnh nhân";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(824, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "Danh sách hoá đơn";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lblPatientData);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 324);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
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
            this.btnExit.Location = new System.Drawing.Point(320, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 50);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Huỷ";
            this.btnExit.TextColor = System.Drawing.Color.Black;
            this.btnExit.UseVisualStyleBackColor = false;
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
            this.btnSave.Location = new System.Drawing.Point(215, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 50);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.BorderSize = 2;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(103, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 50);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextColor = System.Drawing.Color.Black;
            this.btnUpdate.UseVisualStyleBackColor = false;
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
            this.btnAdd.Location = new System.Drawing.Point(3, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 50);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbAddress);
            this.panel5.Controls.Add(this.cbWomen);
            this.panel5.Controls.Add(this.cbMen);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txbPatientName);
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Controls.Add(this.txbPatient);
            this.panel5.Location = new System.Drawing.Point(3, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(413, 217);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint_1);
            // 
            // txbAddress
            // 
            this.txbAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txbAddress.Location = new System.Drawing.Point(106, 177);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(290, 27);
            this.txbAddress.TabIndex = 3;
            // 
            // cbWomen
            // 
            this.cbWomen.AutoSize = true;
            this.cbWomen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbWomen.Location = new System.Drawing.Point(250, 92);
            this.cbWomen.Name = "cbWomen";
            this.cbWomen.Size = new System.Drawing.Size(61, 32);
            this.cbWomen.TabIndex = 17;
            this.cbWomen.Text = "Nữ";
            this.cbWomen.UseVisualStyleBackColor = true;
            // 
            // cbMen
            // 
            this.cbMen.AutoSize = true;
            this.cbMen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMen.Location = new System.Drawing.Point(168, 92);
            this.cbMen.Name = "cbMen";
            this.cbMen.Size = new System.Drawing.Size(76, 32);
            this.cbMen.TabIndex = 16;
            this.cbMen.Text = "Nam";
            this.cbMen.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
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
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
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
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
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
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
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
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã bệnh nhân:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbPatientName
            // 
            this.txbPatientName.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txbPatientName.Location = new System.Drawing.Point(168, 57);
            this.txbPatientName.Name = "txbPatientName";
            this.txbPatientName.Size = new System.Drawing.Size(227, 27);
            this.txbPatientName.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // txbPatient
            // 
            this.txbPatient.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txbPatient.Location = new System.Drawing.Point(169, 17);
            this.txbPatient.Name = "txbPatient";
            this.txbPatient.Size = new System.Drawing.Size(227, 27);
            this.txbPatient.TabIndex = 1;
            // 
            // lblPatientData
            // 
            this.lblPatientData.AutoSize = true;
            this.lblPatientData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPatientData.ForeColor = System.Drawing.Color.Black;
            this.lblPatientData.Location = new System.Drawing.Point(88, 10);
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
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.plPatientInfor);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PatientForm";
            this.Text = "Bệnh Nhân";
            this.plPatientInfor.ResumeLayout(false);
            this.plPatientInfor.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatientList)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillList)).EndInit();
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
        private Classes.RJButton btnSaveList;
        private Label label10;
        private TextBox txbPatientID;
        private Classes.RJButton btnSearch;
        private Classes.RJButton btnRegister;
        private DataGridView dtgvPatientList;
        private Panel panel4;
        private DataGridView dtgvBillList;
        private Label label11;
        private Label label12;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Classes.RJButton btnExit;
        private Classes.RJButton btnSave;
        private Classes.RJButton btnUpdate;
        private Classes.RJButton btnAdd;
        private Panel panel5;
        private TextBox txbAddress;
        private CheckBox cbWomen;
        private CheckBox cbMen;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txbPatientName;
        private DateTimePicker dateTimePicker1;
        private TextBox txbPatient;
        private Label lblPatientData;
        private DataGridViewTextBoxColumn PatientID;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn YearOfBirth;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}