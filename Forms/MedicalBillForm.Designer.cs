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
            this.plMedicalBillInfor = new System.Windows.Forms.Panel();
            this.tbxMedicalBillDay = new ClinicManagement.Classes.CustomTextBox();
            this.cbxIllness = new CustomControls.RJControls.RJComboBox();
            this.cbxSympton = new CustomControls.RJControls.RJComboBox();
            this.cbxUsage = new CustomControls.RJControls.RJComboBox();
            this.cbx_MedicalCate = new CustomControls.RJControls.RJComboBox();
            this.tbxMedicalNumer = new ClinicManagement.Classes.CustomTextBox();
            this.tbxPrice = new ClinicManagement.Classes.CustomTextBox();
            this.tbxFinalPrice = new ClinicManagement.Classes.CustomTextBox();
            this.tbxMedicalBillPatient = new ClinicManagement.Classes.CustomTextBox();
            this.tbxMedicalBillNumber = new ClinicManagement.Classes.CustomTextBox();
            this.rbtnNotMedicalList = new ClinicManagement.Classes.RJRadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnHistory = new ClinicManagement.Classes.RJButton();
            this.btnExit = new ClinicManagement.Classes.RJButton();
            this.btnSave = new ClinicManagement.Classes.RJButton();
            this.btnUpdate = new ClinicManagement.Classes.RJButton();
            this.btnAdd = new ClinicManagement.Classes.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvPatientList = new System.Windows.Forms.DataGridView();
            this.lblNextPatient = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvMedicalBill = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plMedicalBillInfor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatientList)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalBill)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalList)).BeginInit();
            this.SuspendLayout();
            // 
            // plMedicalBillInfor
            // 
            this.plMedicalBillInfor.BackColor = System.Drawing.Color.SkyBlue;
            this.plMedicalBillInfor.Controls.Add(this.tbxMedicalBillDay);
            this.plMedicalBillInfor.Controls.Add(this.cbxIllness);
            this.plMedicalBillInfor.Controls.Add(this.cbxSympton);
            this.plMedicalBillInfor.Controls.Add(this.cbxUsage);
            this.plMedicalBillInfor.Controls.Add(this.cbx_MedicalCate);
            this.plMedicalBillInfor.Controls.Add(this.tbxMedicalNumer);
            this.plMedicalBillInfor.Controls.Add(this.tbxPrice);
            this.plMedicalBillInfor.Controls.Add(this.tbxFinalPrice);
            this.plMedicalBillInfor.Controls.Add(this.tbxMedicalBillPatient);
            this.plMedicalBillInfor.Controls.Add(this.tbxMedicalBillNumber);
            this.plMedicalBillInfor.Controls.Add(this.rbtnNotMedicalList);
            this.plMedicalBillInfor.Controls.Add(this.label8);
            this.plMedicalBillInfor.Controls.Add(this.label9);
            this.plMedicalBillInfor.Controls.Add(this.label10);
            this.plMedicalBillInfor.Controls.Add(this.label11);
            this.plMedicalBillInfor.Controls.Add(this.label12);
            this.plMedicalBillInfor.Controls.Add(this.btnHistory);
            this.plMedicalBillInfor.Controls.Add(this.btnExit);
            this.plMedicalBillInfor.Controls.Add(this.btnSave);
            this.plMedicalBillInfor.Controls.Add(this.btnUpdate);
            this.plMedicalBillInfor.Controls.Add(this.btnAdd);
            this.plMedicalBillInfor.Controls.Add(this.label2);
            this.plMedicalBillInfor.Controls.Add(this.label1);
            this.plMedicalBillInfor.Controls.Add(this.label6);
            this.plMedicalBillInfor.Controls.Add(this.label5);
            this.plMedicalBillInfor.Controls.Add(this.label4);
            this.plMedicalBillInfor.Controls.Add(this.label3);
            this.plMedicalBillInfor.Location = new System.Drawing.Point(12, 9);
            this.plMedicalBillInfor.Name = "plMedicalBillInfor";
            this.plMedicalBillInfor.Size = new System.Drawing.Size(781, 348);
            this.plMedicalBillInfor.TabIndex = 2;
            // 
            // tbxMedicalBillDay
            // 
            this.tbxMedicalBillDay.BackColor = System.Drawing.SystemColors.Window;
            this.tbxMedicalBillDay.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxMedicalBillDay.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxMedicalBillDay.BorderSize = 2;
            this.tbxMedicalBillDay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMedicalBillDay.ForeColor = System.Drawing.Color.DimGray;
            this.tbxMedicalBillDay.Location = new System.Drawing.Point(183, 70);
            this.tbxMedicalBillDay.Multiline = false;
            this.tbxMedicalBillDay.Name = "tbxMedicalBillDay";
            this.tbxMedicalBillDay.Padding = new System.Windows.Forms.Padding(7);
            this.tbxMedicalBillDay.PasswordChar = false;
            this.tbxMedicalBillDay.ReadOnly = false;
            this.tbxMedicalBillDay.Size = new System.Drawing.Size(216, 38);
            this.tbxMedicalBillDay.TabIndex = 74;
            this.tbxMedicalBillDay.Texts = "";
            this.tbxMedicalBillDay.UnderlinedStyle = false;
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
            this.cbxIllness.Location = new System.Drawing.Point(183, 202);
            this.cbxIllness.MinimumSize = new System.Drawing.Size(50, 20);
            this.cbxIllness.Name = "cbxIllness";
            this.cbxIllness.Padding = new System.Windows.Forms.Padding(2);
            this.cbxIllness.Size = new System.Drawing.Size(216, 38);
            this.cbxIllness.TabIndex = 73;
            this.cbxIllness.Texts = "";
            // 
            // cbxSympton
            // 
            this.cbxSympton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxSympton.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cbxSympton.BorderSize = 2;
            this.cbxSympton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxSympton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxSympton.ForeColor = System.Drawing.Color.DimGray;
            this.cbxSympton.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbxSympton.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxSympton.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxSympton.Location = new System.Drawing.Point(183, 158);
            this.cbxSympton.MinimumSize = new System.Drawing.Size(50, 20);
            this.cbxSympton.Name = "cbxSympton";
            this.cbxSympton.Padding = new System.Windows.Forms.Padding(2);
            this.cbxSympton.Size = new System.Drawing.Size(216, 38);
            this.cbxSympton.TabIndex = 69;
            this.cbxSympton.Texts = "";
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
            this.cbxUsage.Location = new System.Drawing.Point(562, 202);
            this.cbxUsage.MinimumSize = new System.Drawing.Size(50, 20);
            this.cbxUsage.Name = "cbxUsage";
            this.cbxUsage.Padding = new System.Windows.Forms.Padding(2);
            this.cbxUsage.Size = new System.Drawing.Size(216, 38);
            this.cbxUsage.TabIndex = 68;
            this.cbxUsage.Texts = "";
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
            this.cbx_MedicalCate.Location = new System.Drawing.Point(562, 27);
            this.cbx_MedicalCate.MinimumSize = new System.Drawing.Size(50, 20);
            this.cbx_MedicalCate.Name = "cbx_MedicalCate";
            this.cbx_MedicalCate.Padding = new System.Windows.Forms.Padding(2);
            this.cbx_MedicalCate.Size = new System.Drawing.Size(216, 38);
            this.cbx_MedicalCate.TabIndex = 67;
            this.cbx_MedicalCate.Texts = "";
            // 
            // tbxMedicalNumer
            // 
            this.tbxMedicalNumer.BackColor = System.Drawing.SystemColors.Window;
            this.tbxMedicalNumer.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxMedicalNumer.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxMedicalNumer.BorderSize = 2;
            this.tbxMedicalNumer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMedicalNumer.ForeColor = System.Drawing.Color.DimGray;
            this.tbxMedicalNumer.Location = new System.Drawing.Point(562, 71);
            this.tbxMedicalNumer.Multiline = false;
            this.tbxMedicalNumer.Name = "tbxMedicalNumer";
            this.tbxMedicalNumer.Padding = new System.Windows.Forms.Padding(7);
            this.tbxMedicalNumer.PasswordChar = false;
            this.tbxMedicalNumer.ReadOnly = false;
            this.tbxMedicalNumer.Size = new System.Drawing.Size(216, 38);
            this.tbxMedicalNumer.TabIndex = 66;
            this.tbxMedicalNumer.Texts = "0";
            this.tbxMedicalNumer.UnderlinedStyle = false;
            // 
            // tbxPrice
            // 
            this.tbxPrice.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPrice.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxPrice.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxPrice.BorderSize = 2;
            this.tbxPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPrice.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPrice.Location = new System.Drawing.Point(562, 114);
            this.tbxPrice.Multiline = false;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPrice.PasswordChar = false;
            this.tbxPrice.ReadOnly = false;
            this.tbxPrice.Size = new System.Drawing.Size(216, 38);
            this.tbxPrice.TabIndex = 65;
            this.tbxPrice.Texts = "0";
            this.tbxPrice.UnderlinedStyle = false;
            // 
            // tbxFinalPrice
            // 
            this.tbxFinalPrice.BackColor = System.Drawing.SystemColors.Window;
            this.tbxFinalPrice.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxFinalPrice.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxFinalPrice.BorderSize = 2;
            this.tbxFinalPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxFinalPrice.ForeColor = System.Drawing.Color.DimGray;
            this.tbxFinalPrice.Location = new System.Drawing.Point(562, 158);
            this.tbxFinalPrice.Multiline = false;
            this.tbxFinalPrice.Name = "tbxFinalPrice";
            this.tbxFinalPrice.Padding = new System.Windows.Forms.Padding(7);
            this.tbxFinalPrice.PasswordChar = false;
            this.tbxFinalPrice.ReadOnly = false;
            this.tbxFinalPrice.Size = new System.Drawing.Size(216, 38);
            this.tbxFinalPrice.TabIndex = 64;
            this.tbxFinalPrice.Texts = "0";
            this.tbxFinalPrice.UnderlinedStyle = false;
            // 
            // tbxMedicalBillPatient
            // 
            this.tbxMedicalBillPatient.BackColor = System.Drawing.SystemColors.Window;
            this.tbxMedicalBillPatient.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxMedicalBillPatient.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxMedicalBillPatient.BorderSize = 2;
            this.tbxMedicalBillPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMedicalBillPatient.ForeColor = System.Drawing.Color.DimGray;
            this.tbxMedicalBillPatient.Location = new System.Drawing.Point(183, 114);
            this.tbxMedicalBillPatient.Multiline = false;
            this.tbxMedicalBillPatient.Name = "tbxMedicalBillPatient";
            this.tbxMedicalBillPatient.Padding = new System.Windows.Forms.Padding(7);
            this.tbxMedicalBillPatient.PasswordChar = false;
            this.tbxMedicalBillPatient.ReadOnly = false;
            this.tbxMedicalBillPatient.Size = new System.Drawing.Size(216, 38);
            this.tbxMedicalBillPatient.TabIndex = 61;
            this.tbxMedicalBillPatient.Texts = "";
            this.tbxMedicalBillPatient.UnderlinedStyle = false;
            // 
            // tbxMedicalBillNumber
            // 
            this.tbxMedicalBillNumber.BackColor = System.Drawing.SystemColors.Window;
            this.tbxMedicalBillNumber.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxMedicalBillNumber.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxMedicalBillNumber.BorderSize = 2;
            this.tbxMedicalBillNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMedicalBillNumber.ForeColor = System.Drawing.Color.DimGray;
            this.tbxMedicalBillNumber.Location = new System.Drawing.Point(183, 27);
            this.tbxMedicalBillNumber.Multiline = false;
            this.tbxMedicalBillNumber.Name = "tbxMedicalBillNumber";
            this.tbxMedicalBillNumber.Padding = new System.Windows.Forms.Padding(7);
            this.tbxMedicalBillNumber.PasswordChar = false;
            this.tbxMedicalBillNumber.ReadOnly = false;
            this.tbxMedicalBillNumber.Size = new System.Drawing.Size(216, 38);
            this.tbxMedicalBillNumber.TabIndex = 60;
            this.tbxMedicalBillNumber.Texts = "";
            this.tbxMedicalBillNumber.UnderlinedStyle = false;
            // 
            // rbtnNotMedicalList
            // 
            this.rbtnNotMedicalList.AutoSize = true;
            this.rbtnNotMedicalList.CheckedColor = System.Drawing.Color.Navy;
            this.rbtnNotMedicalList.Location = new System.Drawing.Point(183, 246);
            this.rbtnNotMedicalList.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnNotMedicalList.Name = "rbtnNotMedicalList";
            this.rbtnNotMedicalList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnNotMedicalList.Size = new System.Drawing.Size(174, 24);
            this.rbtnNotMedicalList.TabIndex = 59;
            this.rbtnNotMedicalList.TabStop = true;
            this.rbtnNotMedicalList.Text = "Không kê khai thuốc";
            this.rbtnNotMedicalList.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnNotMedicalList.UseVisualStyleBackColor = true;
            this.rbtnNotMedicalList.CheckedChanged += new System.EventHandler(this.rbtnNotList_CheckedChanged);
            this.rbtnNotMedicalList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtnNotList_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(411, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 26);
            this.label8.TabIndex = 53;
            this.label8.Text = "Cách dùng:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(411, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 26);
            this.label9.TabIndex = 52;
            this.label9.Text = "Thành tiền:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(411, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 26);
            this.label10.TabIndex = 51;
            this.label10.Text = "Đơn giá:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(411, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 26);
            this.label11.TabIndex = 50;
            this.label11.Text = "Số lượng:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(411, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 26);
            this.label12.TabIndex = 49;
            this.label12.Text = "Tên thuốc:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnHistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnHistory.BorderRadius = 20;
            this.btnHistory.BorderSize = 2;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.Location = new System.Drawing.Point(602, 287);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(156, 50);
            this.btnHistory.TabIndex = 46;
            this.btnHistory.Text = "Lịch sử khám";
            this.btnHistory.TextColor = System.Drawing.Color.Black;
            this.btnHistory.UseVisualStyleBackColor = false;
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
            this.btnExit.Location = new System.Drawing.Point(457, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 50);
            this.btnExit.TabIndex = 39;
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
            this.btnSave.Location = new System.Drawing.Point(312, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 50);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Xong";
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(167, 288);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 50);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Lưu";
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
            this.btnAdd.Location = new System.Drawing.Point(22, 288);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 50);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Khám";
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên bệnh:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thông tin phiếu khám bệnh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "Triệu chứng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mã bệnh nhân:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số phiếu khám:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblNextPatient);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(967, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 471);
            this.panel2.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvPatientList);
            this.panel4.Location = new System.Drawing.Point(0, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 380);
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
            this.dtgvPatientList.Size = new System.Drawing.Size(210, 380);
            this.dtgvPatientList.TabIndex = 4;
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
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(399, 360);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(278, 24);
            this.label15.TabIndex = 15;
            this.label15.Text = "Danh sách phiếu khám bệnh";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvMedicalBill);
            this.panel3.Location = new System.Drawing.Point(12, 387);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(949, 447);
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
            this.STT,
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
            this.dtgvMedicalBill.Size = new System.Drawing.Size(949, 447);
            this.dtgvMedicalBill.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.FillWeight = 47.72726F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.FillWeight = 104.2424F;
            this.Ngay.HeaderText = "Ngày khám";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // Trieuchung
            // 
            this.Trieuchung.FillWeight = 130.303F;
            this.Trieuchung.HeaderText = "Triệu chứng";
            this.Trieuchung.MinimumWidth = 6;
            this.Trieuchung.Name = "Trieuchung";
            this.Trieuchung.ReadOnly = true;
            // 
            // Benh
            // 
            this.Benh.FillWeight = 104.2424F;
            this.Benh.HeaderText = "Bệnh";
            this.Benh.MinimumWidth = 6;
            this.Benh.Name = "Benh";
            this.Benh.ReadOnly = true;
            // 
            // Thuoc
            // 
            this.Thuoc.FillWeight = 104.2424F;
            this.Thuoc.HeaderText = "Thuốc";
            this.Thuoc.MinimumWidth = 6;
            this.Thuoc.Name = "Thuoc";
            this.Thuoc.ReadOnly = true;
            // 
            // Soluong
            // 
            this.Soluong.FillWeight = 104.2424F;
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(910, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 24);
            this.label16.TabIndex = 17;
            this.label16.Text = "Danh sách thuốc";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvMedicalList);
            this.panel5.Location = new System.Drawing.Point(799, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(378, 321);
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
            this.dtgvMedicalList.Size = new System.Drawing.Size(378, 321);
            this.dtgvMedicalList.TabIndex = 5;
            // 
            // Sothutu
            // 
            this.Sothutu.FillWeight = 87.63398F;
            this.Sothutu.HeaderText = "STT";
            this.Sothutu.MinimumWidth = 6;
            this.Sothutu.Name = "Sothutu";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 120.0586F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Thuốc";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Soluongthuoc
            // 
            this.Soluongthuoc.FillWeight = 120.0586F;
            this.Soluongthuoc.HeaderText = "Số lượng";
            this.Soluongthuoc.MinimumWidth = 6;
            this.Soluongthuoc.Name = "Soluongthuoc";
            // 
            // timerMedical
            // 
            this.timerMedical.Tick += new System.EventHandler(this.timerMedical_Tick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 124.0151F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ tên ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // MedicalBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1189, 846);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.plMedicalBillInfor);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MedicalBillForm";
            this.Text = "Phiếu khám bệnh";
            this.plMedicalBillInfor.ResumeLayout(false);
            this.plMedicalBillInfor.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatientList)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalBill)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicalList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel plMedicalBillInfor;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Classes.RJButton btnExit;
        private Classes.RJButton btnSave;
        private Classes.RJButton btnUpdate;
        private Classes.RJButton btnAdd;
        private Label label14;
        private Panel panel2;
        private Label lblNextPatient;
        private Label label15;
        private Panel panel4;
        private Panel panel3;
        private DataGridView dtgvPatientList;
        private DataGridView dtgvMedicalBill;
        private Classes.RJButton btnHistory;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label16;
        private Panel panel5;
        private DataGridView dtgvMedicalList;
        private DataGridViewTextBoxColumn Sothutu;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Soluongthuoc;
        private Classes.RJRadioButton rbtnNotMedicalList;
        private Classes.CustomTextBox tbxMedicalBillNumber;
        private Classes.CustomTextBox tbxMedicalNumer;
        private Classes.CustomTextBox tbxPrice;
        private Classes.CustomTextBox tbxFinalPrice;
        private Classes.CustomTextBox tbxMedicalBillPatient;
        private CustomControls.RJControls.RJComboBox cbxSympton;
        private CustomControls.RJControls.RJComboBox cbxUsage;
        private CustomControls.RJControls.RJComboBox cbx_MedicalCate;
        private CustomControls.RJControls.RJComboBox cbxIllness;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Ngay;
        private DataGridViewTextBoxColumn Trieuchung;
        private DataGridViewTextBoxColumn Benh;
        private DataGridViewTextBoxColumn Thuoc;
        private DataGridViewTextBoxColumn Soluong;
        private Classes.CustomTextBox tbxMedicalBillDay;
        private System.Windows.Forms.Timer timerMedical;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}