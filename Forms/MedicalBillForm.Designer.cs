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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvPatientList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNextPatient = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvMedicalBill = new System.Windows.Forms.DataGridView();
            this.SPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trieuchung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Benh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvMedicalList = new System.Windows.Forms.DataGridView();
            this.Sothutu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluongthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerMedical = new System.Windows.Forms.Timer(this.components);
            this.gradientPanel1 = new ClinicManagement.Classes.GradientPanel();
            this.plMedicalBillInfor = new System.Windows.Forms.Panel();
            this.lblPatientData = new System.Windows.Forms.Label();
            this.cbxNotList = new System.Windows.Forms.CheckBox();
            this.btnEdit = new ClinicManagement.Classes.RJButton();
            this.btnDelMedical = new ClinicManagement.Classes.RJButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxUsage = new CustomControls.RJControls.RJComboBox();
            this.cbxIllness = new CustomControls.RJControls.RJComboBox();
            this.tbxFinalPrice = new ClinicManagement.Classes.CustomTextBox();
            this.tbxPrice = new ClinicManagement.Classes.CustomTextBox();
            this.tbxMedicalNumer = new ClinicManagement.Classes.CustomTextBox();
            this.cbx_MedicalCate = new CustomControls.RJControls.RJComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxMedicalBillNumber = new ClinicManagement.Classes.CustomTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxMedicalBillDay = new ClinicManagement.Classes.CustomTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxMedicalBillPatient = new ClinicManagement.Classes.CustomTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddMedical = new ClinicManagement.Classes.RJButton();
            this.btnUpdate = new ClinicManagement.Classes.RJButton();
            this.btnAdd = new ClinicManagement.Classes.RJButton();
            this.tbxSympton = new ClinicManagement.Classes.CustomTextBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatientList)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalBill)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalList)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.plMedicalBillInfor.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(3, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(204, 26);
            this.label14.TabIndex = 13;
            this.label14.Text = "Số thứ tự tiếp theo:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblNextPatient);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(967, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 435);
            this.panel2.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvPatientList);
            this.panel4.Location = new System.Drawing.Point(0, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 356);
            this.panel4.TabIndex = 15;
            // 
            // dtgvPatientList
            // 
            this.dtgvPatientList.AllowUserToAddRows = false;
            this.dtgvPatientList.AllowUserToDeleteRows = false;
            this.dtgvPatientList.AllowUserToResizeColumns = false;
            this.dtgvPatientList.AllowUserToResizeRows = false;
            this.dtgvPatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPatientList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPatientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvPatientList.ColumnHeadersHeight = 60;
            this.dtgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dtgvPatientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvPatientList.EnableHeadersVisualStyles = false;
            this.dtgvPatientList.Location = new System.Drawing.Point(0, 0);
            this.dtgvPatientList.Name = "dtgvPatientList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPatientList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvPatientList.RowHeadersVisible = false;
            this.dtgvPatientList.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dtgvPatientList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvPatientList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvPatientList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtgvPatientList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this.dtgvPatientList.RowTemplate.Height = 29;
            this.dtgvPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPatientList.Size = new System.Drawing.Size(210, 356);
            this.dtgvPatientList.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 124.0151F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ tên ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // lblNextPatient
            // 
            this.lblNextPatient.AutoSize = true;
            this.lblNextPatient.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNextPatient.ForeColor = System.Drawing.Color.Red;
            this.lblNextPatient.Location = new System.Drawing.Point(82, 38);
            this.lblNextPatient.Name = "lblNextPatient";
            this.lblNextPatient.Size = new System.Drawing.Size(43, 50);
            this.lblNextPatient.TabIndex = 14;
            this.lblNextPatient.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(347, 372);
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
            this.panel3.Size = new System.Drawing.Size(949, 435);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMedicalBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvMedicalBill.ColumnHeadersHeight = 40;
            this.dtgvMedicalBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvMedicalBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SPK,
            this.Ngay,
            this.Trieuchung,
            this.Benh,
            this.Thuoc,
            this.Soluong});
            this.dtgvMedicalBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvMedicalBill.EnableHeadersVisualStyles = false;
            this.dtgvMedicalBill.Location = new System.Drawing.Point(0, 0);
            this.dtgvMedicalBill.Name = "dtgvMedicalBill";
            this.dtgvMedicalBill.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMedicalBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvMedicalBill.RowHeadersVisible = false;
            this.dtgvMedicalBill.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dtgvMedicalBill.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvMedicalBill.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvMedicalBill.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtgvMedicalBill.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this.dtgvMedicalBill.RowTemplate.Height = 29;
            this.dtgvMedicalBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMedicalBill.Size = new System.Drawing.Size(949, 435);
            this.dtgvMedicalBill.TabIndex = 2;
            // 
            // SPK
            // 
            this.SPK.FillWeight = 95.45452F;
            this.SPK.HeaderText = "SPK";
            this.SPK.MinimumWidth = 6;
            this.SPK.Name = "SPK";
            this.SPK.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.FillWeight = 95.15149F;
            this.Ngay.HeaderText = "Ngày khám";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // Trieuchung
            // 
            this.Trieuchung.FillWeight = 118.9394F;
            this.Trieuchung.HeaderText = "Triệu chứng";
            this.Trieuchung.MinimumWidth = 6;
            this.Trieuchung.Name = "Trieuchung";
            this.Trieuchung.ReadOnly = true;
            // 
            // Benh
            // 
            this.Benh.FillWeight = 95.15149F;
            this.Benh.HeaderText = "Bệnh";
            this.Benh.MinimumWidth = 6;
            this.Benh.Name = "Benh";
            this.Benh.ReadOnly = true;
            // 
            // Thuoc
            // 
            this.Thuoc.FillWeight = 95.15149F;
            this.Thuoc.HeaderText = "Thuốc";
            this.Thuoc.MinimumWidth = 6;
            this.Thuoc.Name = "Thuoc";
            this.Thuoc.ReadOnly = true;
            // 
            // Soluong
            // 
            this.Soluong.FillWeight = 95.15149F;
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
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
            this.panel5.Controls.Add(this.dtgvMedicalList);
            this.panel5.Location = new System.Drawing.Point(799, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(378, 318);
            this.panel5.TabIndex = 18;
            // 
            // dtgvMedicalList
            // 
            this.dtgvMedicalList.AllowUserToAddRows = false;
            this.dtgvMedicalList.AllowUserToDeleteRows = false;
            this.dtgvMedicalList.AllowUserToResizeColumns = false;
            this.dtgvMedicalList.AllowUserToResizeRows = false;
            this.dtgvMedicalList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMedicalList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMedicalList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvMedicalList.ColumnHeadersHeight = 60;
            this.dtgvMedicalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvMedicalList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sothutu,
            this.dataGridViewTextBoxColumn3,
            this.Soluongthuoc});
            this.dtgvMedicalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvMedicalList.EnableHeadersVisualStyles = false;
            this.dtgvMedicalList.Location = new System.Drawing.Point(0, 0);
            this.dtgvMedicalList.Name = "dtgvMedicalList";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMedicalList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvMedicalList.RowHeadersVisible = false;
            this.dtgvMedicalList.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dtgvMedicalList.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvMedicalList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvMedicalList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtgvMedicalList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this.dtgvMedicalList.RowTemplate.Height = 29;
            this.dtgvMedicalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMedicalList.Size = new System.Drawing.Size(378, 318);
            this.dtgvMedicalList.TabIndex = 5;
            // 
            // Sothutu
            // 
            this.Sothutu.FillWeight = 64.33887F;
            this.Sothutu.HeaderText = "STT";
            this.Sothutu.MinimumWidth = 6;
            this.Sothutu.Name = "Sothutu";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 175.268F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Thuốc";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Soluongthuoc
            // 
            this.Soluongthuoc.FillWeight = 88.14429F;
            this.Soluongthuoc.HeaderText = "Số lượng";
            this.Soluongthuoc.MinimumWidth = 6;
            this.Soluongthuoc.Name = "Soluongthuoc";
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
            this.gradientPanel1.Controls.Add(this.panel2);
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
            this.plMedicalBillInfor.Controls.Add(this.cbxNotList);
            this.plMedicalBillInfor.Controls.Add(this.btnEdit);
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
            // cbxNotList
            // 
            this.cbxNotList.AutoSize = true;
            this.cbxNotList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxNotList.Location = new System.Drawing.Point(190, 262);
            this.cbxNotList.Name = "cbxNotList";
            this.cbxNotList.Size = new System.Drawing.Size(194, 27);
            this.cbxNotList.TabIndex = 64;
            this.cbxNotList.Text = "Không kê khai thuốc ";
            this.cbxNotList.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.BorderSize = 2;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(623, 295);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 50);
            this.btnEdit.TabIndex = 63;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextColor = System.Drawing.Color.Black;
            this.btnEdit.UseVisualStyleBackColor = false;
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
            this.btnDelMedical.Location = new System.Drawing.Point(508, 295);
            this.btnDelMedical.Name = "btnDelMedical";
            this.btnDelMedical.Size = new System.Drawing.Size(109, 50);
            this.btnDelMedical.TabIndex = 62;
            this.btnDelMedical.Text = "Xoá";
            this.btnDelMedical.TextColor = System.Drawing.Color.Black;
            this.btnDelMedical.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.85496F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.62596F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.89313F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.62596F));
            this.tableLayoutPanel1.Controls.Add(this.cbxUsage, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbxIllness, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbxFinalPrice, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxPrice, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbxMedicalNumer, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbx_MedicalCate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxMedicalBillNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbxMedicalBillDay, 1, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 213);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // cbxUsage
            // 
            this.cbxUsage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxUsage.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbxUsage.BorderSize = 2;
            this.cbxUsage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxUsage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxUsage.ForeColor = System.Drawing.Color.DimGray;
            this.cbxUsage.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxUsage.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxUsage.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxUsage.Location = new System.Drawing.Point(554, 171);
            this.cbxUsage.MinimumSize = new System.Drawing.Size(50, 20);
            this.cbxUsage.Name = "cbxUsage";
            this.cbxUsage.Padding = new System.Windows.Forms.Padding(2);
            this.cbxUsage.Size = new System.Drawing.Size(206, 38);
            this.cbxUsage.TabIndex = 68;
            this.cbxUsage.Texts = "";
            // 
            // cbxIllness
            // 
            this.cbxIllness.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxIllness.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbxIllness.BorderSize = 2;
            this.cbxIllness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxIllness.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxIllness.ForeColor = System.Drawing.Color.DimGray;
            this.cbxIllness.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxIllness.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxIllness.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxIllness.Location = new System.Drawing.Point(187, 171);
            this.cbxIllness.MinimumSize = new System.Drawing.Size(50, 20);
            this.cbxIllness.Name = "cbxIllness";
            this.cbxIllness.Padding = new System.Windows.Forms.Padding(2);
            this.cbxIllness.Size = new System.Drawing.Size(205, 38);
            this.cbxIllness.TabIndex = 73;
            this.cbxIllness.Texts = "";
            // 
            // tbxFinalPrice
            // 
            this.tbxFinalPrice.BackColor = System.Drawing.SystemColors.Window;
            this.tbxFinalPrice.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxFinalPrice.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxFinalPrice.BorderSize = 2;
            this.tbxFinalPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxFinalPrice.ForeColor = System.Drawing.Color.DimGray;
            this.tbxFinalPrice.Location = new System.Drawing.Point(554, 129);
            this.tbxFinalPrice.Multiline = false;
            this.tbxFinalPrice.Name = "tbxFinalPrice";
            this.tbxFinalPrice.Padding = new System.Windows.Forms.Padding(7);
            this.tbxFinalPrice.PasswordChar = false;
            this.tbxFinalPrice.ReadOnly = false;
            this.tbxFinalPrice.Size = new System.Drawing.Size(206, 38);
            this.tbxFinalPrice.TabIndex = 64;
            this.tbxFinalPrice.Texts = "0";
            this.tbxFinalPrice.UnderlinedStyle = false;
            // 
            // tbxPrice
            // 
            this.tbxPrice.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPrice.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxPrice.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxPrice.BorderSize = 2;
            this.tbxPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPrice.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPrice.Location = new System.Drawing.Point(554, 87);
            this.tbxPrice.Multiline = false;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPrice.PasswordChar = false;
            this.tbxPrice.ReadOnly = false;
            this.tbxPrice.Size = new System.Drawing.Size(206, 38);
            this.tbxPrice.TabIndex = 65;
            this.tbxPrice.Texts = "0";
            this.tbxPrice.UnderlinedStyle = false;
            // 
            // tbxMedicalNumer
            // 
            this.tbxMedicalNumer.BackColor = System.Drawing.SystemColors.Window;
            this.tbxMedicalNumer.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxMedicalNumer.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxMedicalNumer.BorderSize = 2;
            this.tbxMedicalNumer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMedicalNumer.ForeColor = System.Drawing.Color.DimGray;
            this.tbxMedicalNumer.Location = new System.Drawing.Point(554, 45);
            this.tbxMedicalNumer.Multiline = false;
            this.tbxMedicalNumer.Name = "tbxMedicalNumer";
            this.tbxMedicalNumer.Padding = new System.Windows.Forms.Padding(7);
            this.tbxMedicalNumer.PasswordChar = false;
            this.tbxMedicalNumer.ReadOnly = false;
            this.tbxMedicalNumer.Size = new System.Drawing.Size(206, 38);
            this.tbxMedicalNumer.TabIndex = 66;
            this.tbxMedicalNumer.Texts = "0";
            this.tbxMedicalNumer.UnderlinedStyle = false;
            // 
            // cbx_MedicalCate
            // 
            this.cbx_MedicalCate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_MedicalCate.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbx_MedicalCate.BorderSize = 2;
            this.cbx_MedicalCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbx_MedicalCate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_MedicalCate.ForeColor = System.Drawing.Color.DimGray;
            this.cbx_MedicalCate.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbx_MedicalCate.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbx_MedicalCate.ListTextColor = System.Drawing.Color.DimGray;
            this.cbx_MedicalCate.Location = new System.Drawing.Point(554, 3);
            this.cbx_MedicalCate.MinimumSize = new System.Drawing.Size(50, 20);
            this.cbx_MedicalCate.Name = "cbx_MedicalCate";
            this.cbx_MedicalCate.Padding = new System.Windows.Forms.Padding(2);
            this.cbx_MedicalCate.Size = new System.Drawing.Size(206, 36);
            this.cbx_MedicalCate.TabIndex = 67;
            this.cbx_MedicalCate.Texts = "";
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
            this.tbxMedicalBillNumber.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxMedicalBillNumber.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxMedicalBillNumber.BorderSize = 2;
            this.tbxMedicalBillNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMedicalBillNumber.ForeColor = System.Drawing.Color.DimGray;
            this.tbxMedicalBillNumber.Location = new System.Drawing.Point(187, 3);
            this.tbxMedicalBillNumber.Multiline = false;
            this.tbxMedicalBillNumber.Name = "tbxMedicalBillNumber";
            this.tbxMedicalBillNumber.Padding = new System.Windows.Forms.Padding(7);
            this.tbxMedicalBillNumber.PasswordChar = false;
            this.tbxMedicalBillNumber.ReadOnly = false;
            this.tbxMedicalBillNumber.Size = new System.Drawing.Size(205, 38);
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
            // tbxMedicalBillDay
            // 
            this.tbxMedicalBillDay.BackColor = System.Drawing.SystemColors.Window;
            this.tbxMedicalBillDay.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxMedicalBillDay.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxMedicalBillDay.BorderSize = 2;
            this.tbxMedicalBillDay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMedicalBillDay.ForeColor = System.Drawing.Color.DimGray;
            this.tbxMedicalBillDay.Location = new System.Drawing.Point(187, 45);
            this.tbxMedicalBillDay.Multiline = false;
            this.tbxMedicalBillDay.Name = "tbxMedicalBillDay";
            this.tbxMedicalBillDay.Padding = new System.Windows.Forms.Padding(7);
            this.tbxMedicalBillDay.PasswordChar = false;
            this.tbxMedicalBillDay.ReadOnly = false;
            this.tbxMedicalBillDay.Size = new System.Drawing.Size(205, 38);
            this.tbxMedicalBillDay.TabIndex = 74;
            this.tbxMedicalBillDay.Texts = "";
            this.tbxMedicalBillDay.UnderlinedStyle = false;
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
            this.tbxMedicalBillPatient.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxMedicalBillPatient.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxMedicalBillPatient.BorderSize = 2;
            this.tbxMedicalBillPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMedicalBillPatient.ForeColor = System.Drawing.Color.DimGray;
            this.tbxMedicalBillPatient.Location = new System.Drawing.Point(187, 87);
            this.tbxMedicalBillPatient.Multiline = false;
            this.tbxMedicalBillPatient.Name = "tbxMedicalBillPatient";
            this.tbxMedicalBillPatient.Padding = new System.Windows.Forms.Padding(7);
            this.tbxMedicalBillPatient.PasswordChar = false;
            this.tbxMedicalBillPatient.ReadOnly = false;
            this.tbxMedicalBillPatient.Size = new System.Drawing.Size(205, 38);
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
            this.btnAddMedical.Location = new System.Drawing.Point(393, 295);
            this.btnAddMedical.Name = "btnAddMedical";
            this.btnAddMedical.Size = new System.Drawing.Size(109, 50);
            this.btnAddMedical.TabIndex = 61;
            this.btnAddMedical.Text = "Thêm";
            this.btnAddMedical.TextColor = System.Drawing.Color.Black;
            this.btnAddMedical.UseVisualStyleBackColor = false;
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
            this.btnUpdate.Location = new System.Drawing.Point(278, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 50);
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
            this.btnAdd.Location = new System.Drawing.Point(163, 295);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 50);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Khám";
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // tbxSympton
            // 
            this.tbxSympton.BackColor = System.Drawing.SystemColors.Window;
            this.tbxSympton.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxSympton.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxSympton.BorderSize = 2;
            this.tbxSympton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxSympton.ForeColor = System.Drawing.Color.DimGray;
            this.tbxSympton.Location = new System.Drawing.Point(187, 129);
            this.tbxSympton.Multiline = false;
            this.tbxSympton.Name = "tbxSympton";
            this.tbxSympton.Padding = new System.Windows.Forms.Padding(7);
            this.tbxSympton.PasswordChar = false;
            this.tbxSympton.ReadOnly = false;
            this.tbxSympton.Size = new System.Drawing.Size(205, 38);
            this.tbxSympton.TabIndex = 75;
            this.tbxSympton.Texts = "";
            this.tbxSympton.UnderlinedStyle = false;
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatientList)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalBill)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalList)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.plMedicalBillInfor.ResumeLayout(false);
            this.plMedicalBillInfor.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label14;
        private Panel panel2;
        private Label lblNextPatient;
        private Label label15;
        private Panel panel4;
        private Panel panel3;
        private DataGridView dtgvPatientList;
        private DataGridView dtgvMedicalBill;
        private Label label16;
        private Panel panel5;
        private DataGridView dtgvMedicalList;
        private System.Windows.Forms.Timer timerMedical;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Classes.GradientPanel gradientPanel1;
        private Panel plMedicalBillInfor;
        private Classes.RJButton btnUpdate;
        private Classes.RJButton btnAdd;
        private DataGridViewTextBoxColumn Sothutu;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Soluongthuoc;
        private DataGridViewTextBoxColumn SPK;
        private DataGridViewTextBoxColumn Ngay;
        private DataGridViewTextBoxColumn Trieuchung;
        private DataGridViewTextBoxColumn Benh;
        private DataGridViewTextBoxColumn Thuoc;
        private DataGridViewTextBoxColumn Soluong;
        private Classes.RJButton btnDelMedical;
        private Classes.RJButton btnAddMedical;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.RJControls.RJComboBox cbxUsage;
        private CustomControls.RJControls.RJComboBox cbxIllness;
        private Classes.CustomTextBox tbxFinalPrice;
        private Classes.CustomTextBox tbxPrice;
        private Classes.CustomTextBox tbxMedicalNumer;
        private CustomControls.RJControls.RJComboBox cbx_MedicalCate;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label2;
        private Label label9;
        private Classes.CustomTextBox tbxMedicalBillNumber;
        private Label label10;
        private Classes.CustomTextBox tbxMedicalBillDay;
        private Label label11;
        private Classes.CustomTextBox tbxMedicalBillPatient;
        private Label label12;
        private Classes.RJButton btnEdit;
        private CheckBox cbxNotList;
        private Label lblPatientData;
        private Classes.CustomTextBox tbxSympton;
    }
}