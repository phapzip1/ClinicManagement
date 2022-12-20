namespace ClinicManagement.Forms
{
    partial class MedicalBillForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvMedicalBill = new System.Windows.Forms.DataGridView();
            this.SPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trieuchung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Benh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvMedicineList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluongthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cachdung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerMedical = new System.Windows.Forms.Timer(this.components);
            this.gradientPanel1 = new ClinicManagement.Classes.GradientPanel();
            this.plMedicalBillInfor = new System.Windows.Forms.Panel();
            this.lblPatientData = new System.Windows.Forms.Label();
            this.btnDelMedical = new ClinicManagement.Classes.RJButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpkMedicalBillDay = new ClinicManagement.Classes.RJDatePicker();
            this.cbxUsage = new CustomControls.RJControls.RJComboBox();
            this.cbxIllness = new CustomControls.RJControls.RJComboBox();
            this.tbxFinalPrice = new ClinicManagement.Classes.CustomTextBox();
            this.tbxPrice = new ClinicManagement.Classes.CustomTextBox();
            this.tbxQuantity = new ClinicManagement.Classes.CustomTextBox();
            this.cbxMedicines = new CustomControls.RJControls.RJComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxMedicalBillNumber = new ClinicManagement.Classes.CustomTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxMedicalBillPatient = new ClinicManagement.Classes.CustomTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxSympton = new ClinicManagement.Classes.CustomTextBox();
            this.btnAddMedical = new ClinicManagement.Classes.RJButton();
            this.btnUpdate = new ClinicManagement.Classes.RJButton();
            this.btnAdd = new ClinicManagement.Classes.RJButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalBill)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicineList)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.plMedicalBillInfor.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(462, 372);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(331, 27);
            this.label15.TabIndex = 15;
            this.label15.Text = "Danh sách phiếu khám bệnh";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvMedicalBill);
            this.panel3.Location = new System.Drawing.Point(12, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1165, 435);
            this.panel3.TabIndex = 16;
            // 
            // dtgvMedicalBill
            // 
            this.dtgvMedicalBill.AllowUserToAddRows = false;
            this.dtgvMedicalBill.AllowUserToDeleteRows = false;
            this.dtgvMedicalBill.AllowUserToResizeColumns = false;
            this.dtgvMedicalBill.AllowUserToResizeRows = false;
            this.dtgvMedicalBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMedicalBill.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMedicalBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvMedicalBill.ColumnHeadersHeight = 40;
            this.dtgvMedicalBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvMedicalBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SPK,
            this.Ngay,
            this.Trieuchung,
            this.Benh});
            this.dtgvMedicalBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvMedicalBill.EnableHeadersVisualStyles = false;
            this.dtgvMedicalBill.Location = new System.Drawing.Point(0, 0);
            this.dtgvMedicalBill.Name = "dtgvMedicalBill";
            this.dtgvMedicalBill.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMedicalBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvMedicalBill.RowHeadersVisible = false;
            this.dtgvMedicalBill.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dtgvMedicalBill.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvMedicalBill.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvMedicalBill.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtgvMedicalBill.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this.dtgvMedicalBill.RowTemplate.Height = 29;
            this.dtgvMedicalBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMedicalBill.Size = new System.Drawing.Size(1165, 435);
            this.dtgvMedicalBill.TabIndex = 2;
            // 
            // SPK
            // 
            this.SPK.DataPropertyName = "Id";
            this.SPK.FillWeight = 151.4908F;
            this.SPK.HeaderText = "SPK";
            this.SPK.MinimumWidth = 6;
            this.SPK.Name = "SPK";
            this.SPK.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "CreateIn";
            this.Ngay.FillWeight = 77.90955F;
            this.Ngay.HeaderText = "Ngày khám";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // Trieuchung
            // 
            this.Trieuchung.DataPropertyName = "Symtoms";
            this.Trieuchung.FillWeight = 97.38698F;
            this.Trieuchung.HeaderText = "Triệu chứng";
            this.Trieuchung.MinimumWidth = 6;
            this.Trieuchung.Name = "Trieuchung";
            this.Trieuchung.ReadOnly = true;
            // 
            // Benh
            // 
            this.Benh.DataPropertyName = "IllnessName";
            this.Benh.FillWeight = 77.90955F;
            this.Benh.HeaderText = "Bệnh";
            this.Benh.MinimumWidth = 6;
            this.Benh.Name = "Benh";
            this.Benh.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(889, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(203, 27);
            this.label16.TabIndex = 17;
            this.label16.Text = "Danh sách thuốc";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvMedicineList);
            this.panel5.Location = new System.Drawing.Point(799, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(378, 318);
            this.panel5.TabIndex = 18;
            // 
            // dtgvMedicineList
            // 
            this.dtgvMedicineList.AllowUserToAddRows = false;
            this.dtgvMedicineList.AllowUserToDeleteRows = false;
            this.dtgvMedicineList.AllowUserToResizeColumns = false;
            this.dtgvMedicineList.AllowUserToResizeRows = false;
            this.dtgvMedicineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMedicineList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMedicineList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvMedicineList.ColumnHeadersHeight = 60;
            this.dtgvMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvMedicineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Soluongthuoc,
            this.Cachdung});
            this.dtgvMedicineList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvMedicineList.EnableHeadersVisualStyles = false;
            this.dtgvMedicineList.Location = new System.Drawing.Point(0, 0);
            this.dtgvMedicineList.Name = "dtgvMedicineList";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMedicineList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvMedicineList.RowHeadersVisible = false;
            this.dtgvMedicineList.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dtgvMedicineList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvMedicineList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvMedicineList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtgvMedicineList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this.dtgvMedicineList.RowTemplate.Height = 29;
            this.dtgvMedicineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMedicineList.Size = new System.Drawing.Size(378, 318);
            this.dtgvMedicineList.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MedicineName";
            this.dataGridViewTextBoxColumn3.FillWeight = 106.7489F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Thuốc";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Soluongthuoc
            // 
            this.Soluongthuoc.DataPropertyName = "Quantity";
            this.Soluongthuoc.FillWeight = 78.87059F;
            this.Soluongthuoc.HeaderText = "Số lượng";
            this.Soluongthuoc.MinimumWidth = 6;
            this.Soluongthuoc.Name = "Soluongthuoc";
            // 
            // Cachdung
            // 
            this.Cachdung.DataPropertyName = "Method";
            this.Cachdung.FillWeight = 142.1316F;
            this.Cachdung.HeaderText = "Cách dùng";
            this.Cachdung.MinimumWidth = 6;
            this.Cachdung.Name = "Cachdung";
            // 
            // timerMedical
            // 
            this.timerMedical.Tick += new System.EventHandler(this.timerMedical_Tick);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(166)))), ((int)(((byte)(250)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.gradientPanel1.Controls.Add(this.plMedicalBillInfor);
            this.gradientPanel1.Controls.Add(this.label15);
            this.gradientPanel1.Controls.Add(this.panel3);
            this.gradientPanel1.Controls.Add(this.panel5);
            this.gradientPanel1.Controls.Add(this.label16);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1189, 846);
            this.gradientPanel1.TabIndex = 75;
            // 
            // plMedicalBillInfor
            // 
            this.plMedicalBillInfor.BackColor = System.Drawing.Color.Transparent;
            this.plMedicalBillInfor.Controls.Add(this.lblPatientData);
            this.plMedicalBillInfor.Controls.Add(this.btnDelMedical);
            this.plMedicalBillInfor.Controls.Add(this.tableLayoutPanel1);
            this.plMedicalBillInfor.Controls.Add(this.btnAddMedical);
            this.plMedicalBillInfor.Controls.Add(this.btnUpdate);
            this.plMedicalBillInfor.Controls.Add(this.btnAdd);
            this.plMedicalBillInfor.Location = new System.Drawing.Point(12, 12);
            this.plMedicalBillInfor.Name = "plMedicalBillInfor";
            this.plMedicalBillInfor.Size = new System.Drawing.Size(781, 348);
            this.plMedicalBillInfor.TabIndex = 19;
            // 
            // lblPatientData
            // 
            this.lblPatientData.AutoSize = true;
            this.lblPatientData.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPatientData.ForeColor = System.Drawing.Color.Black;
            this.lblPatientData.Location = new System.Drawing.Point(253, 0);
            this.lblPatientData.Name = "lblPatientData";
            this.lblPatientData.Size = new System.Drawing.Size(286, 27);
            this.lblPatientData.TabIndex = 65;
            this.lblPatientData.Text = "THÔNG TIN BỆNH NHÂN";
            // 
            // btnDelMedical
            // 
            this.btnDelMedical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnDelMedical.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnDelMedical.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnDelMedical.BorderRadius = 20;
            this.btnDelMedical.BorderSize = 2;
            this.btnDelMedical.FlatAppearance.BorderSize = 0;
            this.btnDelMedical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelMedical.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelMedical.ForeColor = System.Drawing.Color.Black;
            this.btnDelMedical.Location = new System.Drawing.Point(564, 295);
            this.btnDelMedical.Name = "btnDelMedical";
            this.btnDelMedical.Size = new System.Drawing.Size(140, 50);
            this.btnDelMedical.TabIndex = 62;
            this.btnDelMedical.Text = "Xoá thuốc";
            this.btnDelMedical.TextColor = System.Drawing.Color.Black;
            this.btnDelMedical.UseVisualStyleBackColor = false;
            this.btnDelMedical.Click += new System.EventHandler(this.btnDelMedical_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.85496F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.62596F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.89313F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.62596F));
            this.tableLayoutPanel1.Controls.Add(this.dtpkMedicalBillDay, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxUsage, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbxIllness, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbxFinalPrice, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxPrice, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbxQuantity, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxMedicines, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxMedicalBillNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxMedicalBillPatient, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxSympton, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 213);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dtpkMedicalBillDay
            // 
            this.dtpkMedicalBillDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpkMedicalBillDay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpkMedicalBillDay.BorderSize = 0;
            this.dtpkMedicalBillDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkMedicalBillDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkMedicalBillDay.Location = new System.Drawing.Point(187, 46);
            this.dtpkMedicalBillDay.Name = "dtpkMedicalBillDay";
            this.dtpkMedicalBillDay.Size = new System.Drawing.Size(215, 34);
            this.dtpkMedicalBillDay.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.dtpkMedicalBillDay.TabIndex = 27;
            this.dtpkMedicalBillDay.TextColor = System.Drawing.Color.Black;
            // 
            // cbxUsage
            // 
            this.cbxUsage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxUsage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.cbxUsage.BorderSize = 2;
            this.cbxUsage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxUsage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxUsage.ForeColor = System.Drawing.Color.DimGray;
            this.cbxUsage.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxUsage.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(218)))), ((int)(((byte)(252)))));
            this.cbxUsage.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxUsage.Location = new System.Drawing.Point(554, 171);
            this.cbxUsage.MinimumSize = new System.Drawing.Size(50, 20);
            this.cbxUsage.Name = "cbxUsage";
            this.cbxUsage.Padding = new System.Windows.Forms.Padding(2);
            this.cbxUsage.Size = new System.Drawing.Size(218, 38);
            this.cbxUsage.TabIndex = 68;
            this.cbxUsage.Texts = "";
            // 
            // cbxIllness
            // 
            this.cbxIllness.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxIllness.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.cbxIllness.BorderSize = 2;
            this.cbxIllness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxIllness.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxIllness.ForeColor = System.Drawing.Color.DimGray;
            this.cbxIllness.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxIllness.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(218)))), ((int)(((byte)(252)))));
            this.cbxIllness.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxIllness.Location = new System.Drawing.Point(187, 171);
            this.cbxIllness.MinimumSize = new System.Drawing.Size(50, 20);
            this.cbxIllness.Name = "cbxIllness";
            this.cbxIllness.Padding = new System.Windows.Forms.Padding(2);
            this.cbxIllness.Size = new System.Drawing.Size(215, 38);
            this.cbxIllness.TabIndex = 73;
            this.cbxIllness.Texts = "";
            // 
            // tbxFinalPrice
            // 
            this.tbxFinalPrice.BackColor = System.Drawing.SystemColors.Window;
            this.tbxFinalPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbxFinalPrice.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.tbxFinalPrice.BorderSize = 2;
            this.tbxFinalPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxFinalPrice.ForeColor = System.Drawing.Color.DimGray;
            this.tbxFinalPrice.Location = new System.Drawing.Point(554, 129);
            this.tbxFinalPrice.Multiline = false;
            this.tbxFinalPrice.Name = "tbxFinalPrice";
            this.tbxFinalPrice.Padding = new System.Windows.Forms.Padding(7);
            this.tbxFinalPrice.PasswordChar = false;
            this.tbxFinalPrice.ReadOnly = false;
            this.tbxFinalPrice.Size = new System.Drawing.Size(218, 38);
            this.tbxFinalPrice.TabIndex = 64;
            this.tbxFinalPrice.Texts = "0";
            this.tbxFinalPrice.UnderlinedStyle = false;
            // 
            // tbxPrice
            // 
            this.tbxPrice.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbxPrice.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.tbxPrice.BorderSize = 2;
            this.tbxPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPrice.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPrice.Location = new System.Drawing.Point(554, 87);
            this.tbxPrice.Multiline = false;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPrice.PasswordChar = false;
            this.tbxPrice.ReadOnly = false;
            this.tbxPrice.Size = new System.Drawing.Size(218, 38);
            this.tbxPrice.TabIndex = 65;
            this.tbxPrice.Texts = "0";
            this.tbxPrice.UnderlinedStyle = false;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.tbxQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbxQuantity.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.tbxQuantity.BorderSize = 2;
            this.tbxQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.tbxQuantity.Location = new System.Drawing.Point(554, 45);
            this.tbxQuantity.Multiline = false;
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Padding = new System.Windows.Forms.Padding(7);
            this.tbxQuantity.PasswordChar = false;
            this.tbxQuantity.ReadOnly = false;
            this.tbxQuantity.Size = new System.Drawing.Size(218, 38);
            this.tbxQuantity.TabIndex = 66;
            this.tbxQuantity.Texts = "0";
            this.tbxQuantity.UnderlinedStyle = false;
            this.tbxQuantity._TextChanged += new System.EventHandler(this.tbxQuantity__TextChanged);
            this.tbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantity_KeyPress);
            // 
            // cbxMedicines
            // 
            this.cbxMedicines.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxMedicines.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.cbxMedicines.BorderSize = 2;
            this.cbxMedicines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxMedicines.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxMedicines.ForeColor = System.Drawing.Color.DimGray;
            this.cbxMedicines.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxMedicines.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(218)))), ((int)(((byte)(252)))));
            this.cbxMedicines.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxMedicines.Location = new System.Drawing.Point(554, 3);
            this.cbxMedicines.MinimumSize = new System.Drawing.Size(50, 20);
            this.cbxMedicines.Name = "cbxMedicines";
            this.cbxMedicines.Padding = new System.Windows.Forms.Padding(2);
            this.cbxMedicines.Size = new System.Drawing.Size(218, 36);
            this.cbxMedicines.TabIndex = 67;
            this.cbxMedicines.Texts = "";
            this.cbxMedicines.OnSelectedIndexChanged += new System.EventHandler(this.cbxMedicines_OnSelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 42);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số phiếu khám:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 42);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 42);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mã bệnh nhân:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 42);
            this.label6.TabIndex = 19;
            this.label6.Text = "Triệu chứng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(408, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 45);
            this.label8.TabIndex = 53;
            this.label8.Text = "Cách dùng:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 45);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên bệnh:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(408, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 42);
            this.label9.TabIndex = 52;
            this.label9.Text = "Thành tiền:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxMedicalBillNumber
            // 
            this.tbxMedicalBillNumber.BackColor = System.Drawing.SystemColors.Window;
            this.tbxMedicalBillNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbxMedicalBillNumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.tbxMedicalBillNumber.BorderSize = 2;
            this.tbxMedicalBillNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMedicalBillNumber.ForeColor = System.Drawing.Color.DimGray;
            this.tbxMedicalBillNumber.Location = new System.Drawing.Point(187, 3);
            this.tbxMedicalBillNumber.Multiline = false;
            this.tbxMedicalBillNumber.Name = "tbxMedicalBillNumber";
            this.tbxMedicalBillNumber.Padding = new System.Windows.Forms.Padding(7);
            this.tbxMedicalBillNumber.PasswordChar = false;
            this.tbxMedicalBillNumber.ReadOnly = false;
            this.tbxMedicalBillNumber.Size = new System.Drawing.Size(215, 38);
            this.tbxMedicalBillNumber.TabIndex = 60;
            this.tbxMedicalBillNumber.Texts = "";
            this.tbxMedicalBillNumber.UnderlinedStyle = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(408, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 42);
            this.label10.TabIndex = 51;
            this.label10.Text = "Đơn giá:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(408, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 42);
            this.label11.TabIndex = 50;
            this.label11.Text = "Số lượng:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxMedicalBillPatient
            // 
            this.tbxMedicalBillPatient.BackColor = System.Drawing.SystemColors.Window;
            this.tbxMedicalBillPatient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbxMedicalBillPatient.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.tbxMedicalBillPatient.BorderSize = 2;
            this.tbxMedicalBillPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMedicalBillPatient.ForeColor = System.Drawing.Color.DimGray;
            this.tbxMedicalBillPatient.Location = new System.Drawing.Point(187, 87);
            this.tbxMedicalBillPatient.Multiline = false;
            this.tbxMedicalBillPatient.Name = "tbxMedicalBillPatient";
            this.tbxMedicalBillPatient.Padding = new System.Windows.Forms.Padding(7);
            this.tbxMedicalBillPatient.PasswordChar = false;
            this.tbxMedicalBillPatient.ReadOnly = false;
            this.tbxMedicalBillPatient.Size = new System.Drawing.Size(215, 38);
            this.tbxMedicalBillPatient.TabIndex = 61;
            this.tbxMedicalBillPatient.Texts = "";
            this.tbxMedicalBillPatient.UnderlinedStyle = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(408, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 42);
            this.label12.TabIndex = 49;
            this.label12.Text = "Tên thuốc:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxSympton
            // 
            this.tbxSympton.BackColor = System.Drawing.SystemColors.Window;
            this.tbxSympton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbxSympton.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.tbxSympton.BorderSize = 2;
            this.tbxSympton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxSympton.ForeColor = System.Drawing.Color.DimGray;
            this.tbxSympton.Location = new System.Drawing.Point(187, 129);
            this.tbxSympton.Multiline = false;
            this.tbxSympton.Name = "tbxSympton";
            this.tbxSympton.Padding = new System.Windows.Forms.Padding(7);
            this.tbxSympton.PasswordChar = false;
            this.tbxSympton.ReadOnly = false;
            this.tbxSympton.Size = new System.Drawing.Size(215, 38);
            this.tbxSympton.TabIndex = 75;
            this.tbxSympton.Texts = "";
            this.tbxSympton.UnderlinedStyle = false;
            // 
            // btnAddMedical
            // 
            this.btnAddMedical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnAddMedical.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnAddMedical.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnAddMedical.BorderRadius = 20;
            this.btnAddMedical.BorderSize = 2;
            this.btnAddMedical.FlatAppearance.BorderSize = 0;
            this.btnAddMedical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedical.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddMedical.ForeColor = System.Drawing.Color.Black;
            this.btnAddMedical.Location = new System.Drawing.Point(418, 295);
            this.btnAddMedical.Name = "btnAddMedical";
            this.btnAddMedical.Size = new System.Drawing.Size(140, 50);
            this.btnAddMedical.TabIndex = 61;
            this.btnAddMedical.Text = "Thêm thuốc";
            this.btnAddMedical.TextColor = System.Drawing.Color.Black;
            this.btnAddMedical.UseVisualStyleBackColor = false;
            this.btnAddMedical.Click += new System.EventHandler(this.btnAddMedical_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(272, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 50);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Lưu";
            this.btnUpdate.TextColor = System.Drawing.Color.Black;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(126, 295);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 50);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Khám";
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // MedicalBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1189, 846);
            this.Controls.Add(this.gradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MedicalBillForm";
            this.Text = "Phiếu khám bệnh";
            this.Load += new System.EventHandler(this.MedicalBillForm_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalBill)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicineList)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.plMedicalBillInfor.ResumeLayout(false);
            this.plMedicalBillInfor.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label15;
        private Panel panel3;
        private DataGridView dtgvMedicalBill;
        private Label label16;
        private Panel panel5;
        private DataGridView dtgvMedicineList;
        private System.Windows.Forms.Timer timerMedical;
        private Classes.GradientPanel gradientPanel1;
        private Panel plMedicalBillInfor;
        private Classes.RJButton btnUpdate;
        private Classes.RJButton btnAdd;
        private Classes.RJButton btnDelMedical;
        private Classes.RJButton btnAddMedical;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.RJControls.RJComboBox cbxUsage;
        private CustomControls.RJControls.RJComboBox cbxIllness;
        private Classes.CustomTextBox tbxFinalPrice;
        private Classes.CustomTextBox tbxPrice;
        private Classes.CustomTextBox tbxQuantity;
        private CustomControls.RJControls.RJComboBox cbxMedicines;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label2;
        private Label label9;
        private Classes.CustomTextBox tbxMedicalBillNumber;
        private Label label10;
        private Label label11;
        private Classes.CustomTextBox tbxMedicalBillPatient;
        private Label label12;
        private Label lblPatientData;
        private Classes.CustomTextBox tbxSympton;
        private DataGridViewTextBoxColumn SPK;
        private DataGridViewTextBoxColumn Ngay;
        private DataGridViewTextBoxColumn Trieuchung;
        private DataGridViewTextBoxColumn Benh;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Soluongthuoc;
        private DataGridViewTextBoxColumn Cachdung;
        private Classes.RJDatePicker dtpkMedicalBillDay;
    }
}