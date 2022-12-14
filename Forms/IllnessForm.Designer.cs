namespace ClinicManagement.Forms
{
    partial class IllnessForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pl_IllnessCategory = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv_IllnessList = new System.Windows.Forms.DataGridView();
            this.MaLoaiBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pl_IllnessInfor = new System.Windows.Forms.Panel();
            this.btnSearch_Illness = new ClinicManagement.Classes.RJButton();
            this.btnNotSave_Illness = new ClinicManagement.Classes.RJButton();
            this.btnSave_Illness = new ClinicManagement.Classes.RJButton();
            this.btnUpdate_Illness = new ClinicManagement.Classes.RJButton();
            this.btnAdd_Illness = new ClinicManagement.Classes.RJButton();
            this.txb_IllnessID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_IllnessName = new System.Windows.Forms.TextBox();
            this.lblIllnessCategory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvIllnessList = new System.Windows.Forms.DataGridView();
            this.MaBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrieuChung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThuocDacTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plIllnessInfor = new System.Windows.Forms.Panel();
            this.btnSearchIllness = new ClinicManagement.Classes.RJButton();
            this.btnNotSaveIllness = new ClinicManagement.Classes.RJButton();
            this.cbIllnessName = new System.Windows.Forms.ComboBox();
            this.cbMedicalName = new System.Windows.Forms.ComboBox();
            this.cbMedicalCategoryName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbIllnessSymptom = new System.Windows.Forms.TextBox();
            this.btnSaveIllness = new ClinicManagement.Classes.RJButton();
            this.btnUpdateIllness = new ClinicManagement.Classes.RJButton();
            this.btnAddIllness = new ClinicManagement.Classes.RJButton();
            this.txbIllnessID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbIllnessName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pl_IllnessCategory.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_IllnessList)).BeginInit();
            this.pl_IllnessInfor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIllnessList)).BeginInit();
            this.plIllnessInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(460, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN LOẠI BỆNH";
            // 
            // pl_IllnessCategory
            // 
            this.pl_IllnessCategory.BackColor = System.Drawing.Color.Transparent;
            this.pl_IllnessCategory.Controls.Add(this.label12);
            this.pl_IllnessCategory.Controls.Add(this.panel3);
            this.pl_IllnessCategory.Controls.Add(this.pl_IllnessInfor);
            this.pl_IllnessCategory.Controls.Add(this.label1);
            this.pl_IllnessCategory.Location = new System.Drawing.Point(12, 12);
            this.pl_IllnessCategory.Name = "pl_IllnessCategory";
            this.pl_IllnessCategory.Size = new System.Drawing.Size(1150, 322);
            this.pl_IllnessCategory.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(697, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "Danh sách loại bệnh";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgv_IllnessList);
            this.panel3.Location = new System.Drawing.Point(489, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 251);
            this.panel3.TabIndex = 18;
            // 
            // dtgv_IllnessList
            // 
            this.dtgv_IllnessList.AllowUserToAddRows = false;
            this.dtgv_IllnessList.AllowUserToDeleteRows = false;
            this.dtgv_IllnessList.AllowUserToResizeColumns = false;
            this.dtgv_IllnessList.AllowUserToResizeRows = false;
            this.dtgv_IllnessList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_IllnessList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_IllnessList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgv_IllnessList.ColumnHeadersHeight = 60;
            this.dtgv_IllnessList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv_IllnessList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiBenh,
            this.TenLoaiBenh});
            this.dtgv_IllnessList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_IllnessList.EnableHeadersVisualStyles = false;
            this.dtgv_IllnessList.Location = new System.Drawing.Point(0, 0);
            this.dtgv_IllnessList.Name = "dtgv_IllnessList";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_IllnessList.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgv_IllnessList.RowHeadersVisible = false;
            this.dtgv_IllnessList.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            this.dtgv_IllnessList.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgv_IllnessList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgv_IllnessList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_IllnessList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this.dtgv_IllnessList.RowTemplate.Height = 29;
            this.dtgv_IllnessList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_IllnessList.Size = new System.Drawing.Size(645, 251);
            this.dtgv_IllnessList.TabIndex = 5;
            // 
            // MaLoaiBenh
            // 
            this.MaLoaiBenh.FillWeight = 127.7511F;
            this.MaLoaiBenh.HeaderText = "Mã loại bệnh";
            this.MaLoaiBenh.MinimumWidth = 6;
            this.MaLoaiBenh.Name = "MaLoaiBenh";
            // 
            // TenLoaiBenh
            // 
            this.TenLoaiBenh.FillWeight = 124.0151F;
            this.TenLoaiBenh.HeaderText = "Tên loại bệnh";
            this.TenLoaiBenh.MinimumWidth = 6;
            this.TenLoaiBenh.Name = "TenLoaiBenh";
            // 
            // pl_IllnessInfor
            // 
            this.pl_IllnessInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pl_IllnessInfor.Controls.Add(this.btnSearch_Illness);
            this.pl_IllnessInfor.Controls.Add(this.btnNotSave_Illness);
            this.pl_IllnessInfor.Controls.Add(this.btnSave_Illness);
            this.pl_IllnessInfor.Controls.Add(this.btnUpdate_Illness);
            this.pl_IllnessInfor.Controls.Add(this.btnAdd_Illness);
            this.pl_IllnessInfor.Controls.Add(this.txb_IllnessID);
            this.pl_IllnessInfor.Controls.Add(this.label4);
            this.pl_IllnessInfor.Controls.Add(this.txb_IllnessName);
            this.pl_IllnessInfor.Controls.Add(this.lblIllnessCategory);
            this.pl_IllnessInfor.Location = new System.Drawing.Point(14, 37);
            this.pl_IllnessInfor.Name = "pl_IllnessInfor";
            this.pl_IllnessInfor.Size = new System.Drawing.Size(469, 278);
            this.pl_IllnessInfor.TabIndex = 17;
            // 
            // btnSearch_Illness
            // 
            this.btnSearch_Illness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSearch_Illness.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSearch_Illness.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnSearch_Illness.BorderRadius = 20;
            this.btnSearch_Illness.BorderSize = 2;
            this.btnSearch_Illness.FlatAppearance.BorderSize = 0;
            this.btnSearch_Illness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch_Illness.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch_Illness.ForeColor = System.Drawing.Color.Black;
            this.btnSearch_Illness.Location = new System.Drawing.Point(256, 201);
            this.btnSearch_Illness.Name = "btnSearch_Illness";
            this.btnSearch_Illness.Size = new System.Drawing.Size(117, 50);
            this.btnSearch_Illness.TabIndex = 23;
            this.btnSearch_Illness.Text = "Tra cứu";
            this.btnSearch_Illness.TextColor = System.Drawing.Color.Black;
            this.btnSearch_Illness.UseVisualStyleBackColor = false;
            // 
            // btnNotSave_Illness
            // 
            this.btnNotSave_Illness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnNotSave_Illness.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnNotSave_Illness.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnNotSave_Illness.BorderRadius = 20;
            this.btnNotSave_Illness.BorderSize = 2;
            this.btnNotSave_Illness.FlatAppearance.BorderSize = 0;
            this.btnNotSave_Illness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotSave_Illness.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotSave_Illness.ForeColor = System.Drawing.Color.Black;
            this.btnNotSave_Illness.Location = new System.Drawing.Point(127, 201);
            this.btnNotSave_Illness.Name = "btnNotSave_Illness";
            this.btnNotSave_Illness.Size = new System.Drawing.Size(117, 50);
            this.btnNotSave_Illness.TabIndex = 22;
            this.btnNotSave_Illness.Text = "Không lưu";
            this.btnNotSave_Illness.TextColor = System.Drawing.Color.Black;
            this.btnNotSave_Illness.UseVisualStyleBackColor = false;
            // 
            // btnSave_Illness
            // 
            this.btnSave_Illness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSave_Illness.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSave_Illness.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnSave_Illness.BorderRadius = 20;
            this.btnSave_Illness.BorderSize = 2;
            this.btnSave_Illness.FlatAppearance.BorderSize = 0;
            this.btnSave_Illness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave_Illness.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave_Illness.ForeColor = System.Drawing.Color.Black;
            this.btnSave_Illness.Location = new System.Drawing.Point(307, 125);
            this.btnSave_Illness.Name = "btnSave_Illness";
            this.btnSave_Illness.Size = new System.Drawing.Size(99, 50);
            this.btnSave_Illness.TabIndex = 19;
            this.btnSave_Illness.Text = "Lưu";
            this.btnSave_Illness.TextColor = System.Drawing.Color.Black;
            this.btnSave_Illness.UseVisualStyleBackColor = false;
            // 
            // btnUpdate_Illness
            // 
            this.btnUpdate_Illness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnUpdate_Illness.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnUpdate_Illness.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnUpdate_Illness.BorderRadius = 20;
            this.btnUpdate_Illness.BorderSize = 2;
            this.btnUpdate_Illness.FlatAppearance.BorderSize = 0;
            this.btnUpdate_Illness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_Illness.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate_Illness.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate_Illness.Location = new System.Drawing.Point(195, 125);
            this.btnUpdate_Illness.Name = "btnUpdate_Illness";
            this.btnUpdate_Illness.Size = new System.Drawing.Size(106, 50);
            this.btnUpdate_Illness.TabIndex = 18;
            this.btnUpdate_Illness.Text = "Cập nhật";
            this.btnUpdate_Illness.TextColor = System.Drawing.Color.Black;
            this.btnUpdate_Illness.UseVisualStyleBackColor = false;
            // 
            // btnAdd_Illness
            // 
            this.btnAdd_Illness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnAdd_Illness.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnAdd_Illness.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnAdd_Illness.BorderRadius = 20;
            this.btnAdd_Illness.BorderSize = 2;
            this.btnAdd_Illness.FlatAppearance.BorderSize = 0;
            this.btnAdd_Illness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_Illness.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd_Illness.ForeColor = System.Drawing.Color.Black;
            this.btnAdd_Illness.Location = new System.Drawing.Point(95, 125);
            this.btnAdd_Illness.Name = "btnAdd_Illness";
            this.btnAdd_Illness.Size = new System.Drawing.Size(94, 50);
            this.btnAdd_Illness.TabIndex = 17;
            this.btnAdd_Illness.Text = "Thêm";
            this.btnAdd_Illness.TextColor = System.Drawing.Color.Black;
            this.btnAdd_Illness.UseVisualStyleBackColor = false;
            // 
            // txb_IllnessID
            // 
            this.txb_IllnessID.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txb_IllnessID.Location = new System.Drawing.Point(181, 27);
            this.txb_IllnessID.Name = "txb_IllnessID";
            this.txb_IllnessID.Size = new System.Drawing.Size(260, 27);
            this.txb_IllnessID.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tên loại bệnh:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_IllnessName
            // 
            this.txb_IllnessName.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txb_IllnessName.Location = new System.Drawing.Point(181, 70);
            this.txb_IllnessName.Name = "txb_IllnessName";
            this.txb_IllnessName.Size = new System.Drawing.Size(260, 27);
            this.txb_IllnessName.TabIndex = 14;
            // 
            // lblIllnessCategory
            // 
            this.lblIllnessCategory.AutoSize = true;
            this.lblIllnessCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.lblIllnessCategory.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIllnessCategory.Location = new System.Drawing.Point(15, 28);
            this.lblIllnessCategory.Name = "lblIllnessCategory";
            this.lblIllnessCategory.Size = new System.Drawing.Size(146, 26);
            this.lblIllnessCategory.TabIndex = 15;
            this.lblIllnessCategory.Text = "Mã loại bệnh:";
            this.lblIllnessCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.plIllnessInfor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 494);
            this.panel1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(489, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Danh sách bệnh";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvIllnessList);
            this.panel5.Location = new System.Drawing.Point(16, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1118, 261);
            this.panel5.TabIndex = 19;
            // 
            // dtgvIllnessList
            // 
            this.dtgvIllnessList.AllowUserToAddRows = false;
            this.dtgvIllnessList.AllowUserToDeleteRows = false;
            this.dtgvIllnessList.AllowUserToResizeColumns = false;
            this.dtgvIllnessList.AllowUserToResizeRows = false;
            this.dtgvIllnessList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvIllnessList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvIllnessList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgvIllnessList.ColumnHeadersHeight = 60;
            this.dtgvIllnessList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvIllnessList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBenh,
            this.TenBenh,
            this.TrieuChung,
            this.ThuocDacTri,
            this.LoaiBenh});
            this.dtgvIllnessList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvIllnessList.EnableHeadersVisualStyles = false;
            this.dtgvIllnessList.Location = new System.Drawing.Point(0, 0);
            this.dtgvIllnessList.Name = "dtgvIllnessList";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvIllnessList.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgvIllnessList.RowHeadersVisible = false;
            this.dtgvIllnessList.RowHeadersWidth = 51;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            this.dtgvIllnessList.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dtgvIllnessList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvIllnessList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtgvIllnessList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this.dtgvIllnessList.RowTemplate.Height = 29;
            this.dtgvIllnessList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvIllnessList.Size = new System.Drawing.Size(1118, 261);
            this.dtgvIllnessList.TabIndex = 3;
            // 
            // MaBenh
            // 
            this.MaBenh.FillWeight = 96.88831F;
            this.MaBenh.HeaderText = "Mã bệnh ";
            this.MaBenh.MinimumWidth = 6;
            this.MaBenh.Name = "MaBenh";
            // 
            // TenBenh
            // 
            this.TenBenh.FillWeight = 104.5855F;
            this.TenBenh.HeaderText = "Tên bệnh";
            this.TenBenh.MinimumWidth = 6;
            this.TenBenh.Name = "TenBenh";
            // 
            // TrieuChung
            // 
            this.TrieuChung.FillWeight = 119.1177F;
            this.TrieuChung.HeaderText = "Triệu chứng";
            this.TrieuChung.MinimumWidth = 6;
            this.TrieuChung.Name = "TrieuChung";
            // 
            // ThuocDacTri
            // 
            this.ThuocDacTri.FillWeight = 81.10384F;
            this.ThuocDacTri.HeaderText = "Thuốc đặc trị";
            this.ThuocDacTri.MinimumWidth = 6;
            this.ThuocDacTri.Name = "ThuocDacTri";
            // 
            // LoaiBenh
            // 
            this.LoaiBenh.FillWeight = 93.30489F;
            this.LoaiBenh.HeaderText = "Tên loại bệnh";
            this.LoaiBenh.MinimumWidth = 6;
            this.LoaiBenh.Name = "LoaiBenh";
            // 
            // plIllnessInfor
            // 
            this.plIllnessInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plIllnessInfor.Controls.Add(this.btnSearchIllness);
            this.plIllnessInfor.Controls.Add(this.btnNotSaveIllness);
            this.plIllnessInfor.Controls.Add(this.cbIllnessName);
            this.plIllnessInfor.Controls.Add(this.cbMedicalName);
            this.plIllnessInfor.Controls.Add(this.cbMedicalCategoryName);
            this.plIllnessInfor.Controls.Add(this.label7);
            this.plIllnessInfor.Controls.Add(this.label8);
            this.plIllnessInfor.Controls.Add(this.label9);
            this.plIllnessInfor.Controls.Add(this.label6);
            this.plIllnessInfor.Controls.Add(this.txbIllnessSymptom);
            this.plIllnessInfor.Controls.Add(this.btnSaveIllness);
            this.plIllnessInfor.Controls.Add(this.btnUpdateIllness);
            this.plIllnessInfor.Controls.Add(this.btnAddIllness);
            this.plIllnessInfor.Controls.Add(this.txbIllnessID);
            this.plIllnessInfor.Controls.Add(this.label3);
            this.plIllnessInfor.Controls.Add(this.txbIllnessName);
            this.plIllnessInfor.Controls.Add(this.label5);
            this.plIllnessInfor.Location = new System.Drawing.Point(14, 27);
            this.plIllnessInfor.Name = "plIllnessInfor";
            this.plIllnessInfor.Size = new System.Drawing.Size(1120, 173);
            this.plIllnessInfor.TabIndex = 18;
            // 
            // btnSearchIllness
            // 
            this.btnSearchIllness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSearchIllness.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSearchIllness.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnSearchIllness.BorderRadius = 20;
            this.btnSearchIllness.BorderSize = 2;
            this.btnSearchIllness.FlatAppearance.BorderSize = 0;
            this.btnSearchIllness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchIllness.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchIllness.ForeColor = System.Drawing.Color.Black;
            this.btnSearchIllness.Location = new System.Drawing.Point(975, 95);
            this.btnSearchIllness.Name = "btnSearchIllness";
            this.btnSearchIllness.Size = new System.Drawing.Size(117, 50);
            this.btnSearchIllness.TabIndex = 21;
            this.btnSearchIllness.Text = "Tra cứu";
            this.btnSearchIllness.TextColor = System.Drawing.Color.Black;
            this.btnSearchIllness.UseVisualStyleBackColor = false;
            // 
            // btnNotSaveIllness
            // 
            this.btnNotSaveIllness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnNotSaveIllness.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnNotSaveIllness.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnNotSaveIllness.BorderRadius = 20;
            this.btnNotSaveIllness.BorderSize = 2;
            this.btnNotSaveIllness.FlatAppearance.BorderSize = 0;
            this.btnNotSaveIllness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotSaveIllness.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotSaveIllness.ForeColor = System.Drawing.Color.Black;
            this.btnNotSaveIllness.Location = new System.Drawing.Point(975, 27);
            this.btnNotSaveIllness.Name = "btnNotSaveIllness";
            this.btnNotSaveIllness.Size = new System.Drawing.Size(117, 50);
            this.btnNotSaveIllness.TabIndex = 20;
            this.btnNotSaveIllness.Text = "Không lưu";
            this.btnNotSaveIllness.TextColor = System.Drawing.Color.Black;
            this.btnNotSaveIllness.UseVisualStyleBackColor = false;
            // 
            // cbIllnessName
            // 
            this.cbIllnessName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbIllnessName.FormattingEnabled = true;
            this.cbIllnessName.Location = new System.Drawing.Point(620, 117);
            this.cbIllnessName.Name = "cbIllnessName";
            this.cbIllnessName.Size = new System.Drawing.Size(202, 28);
            this.cbIllnessName.TabIndex = 59;
            // 
            // cbMedicalName
            // 
            this.cbMedicalName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMedicalName.FormattingEnabled = true;
            this.cbMedicalName.Location = new System.Drawing.Point(620, 79);
            this.cbMedicalName.Name = "cbMedicalName";
            this.cbMedicalName.Size = new System.Drawing.Size(202, 28);
            this.cbMedicalName.TabIndex = 58;
            // 
            // cbMedicalCategoryName
            // 
            this.cbMedicalCategoryName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMedicalCategoryName.FormattingEnabled = true;
            this.cbMedicalCategoryName.Location = new System.Drawing.Point(620, 41);
            this.cbMedicalCategoryName.Name = "cbMedicalCategoryName";
            this.cbMedicalCategoryName.Size = new System.Drawing.Size(202, 28);
            this.cbMedicalCategoryName.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(386, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tên loại bệnh:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(386, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 26);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tên thuốc đặc trị:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(386, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 26);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tên loại thuốc đặc trị:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Triệu chứng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbIllnessSymptom
            // 
            this.txbIllnessSymptom.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txbIllnessSymptom.Location = new System.Drawing.Point(159, 118);
            this.txbIllnessSymptom.Name = "txbIllnessSymptom";
            this.txbIllnessSymptom.Size = new System.Drawing.Size(211, 27);
            this.txbIllnessSymptom.TabIndex = 20;
            this.txbIllnessSymptom.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnSaveIllness
            // 
            this.btnSaveIllness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSaveIllness.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSaveIllness.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnSaveIllness.BorderRadius = 20;
            this.btnSaveIllness.BorderSize = 2;
            this.btnSaveIllness.FlatAppearance.BorderSize = 0;
            this.btnSaveIllness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveIllness.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveIllness.ForeColor = System.Drawing.Color.Black;
            this.btnSaveIllness.Location = new System.Drawing.Point(849, 115);
            this.btnSaveIllness.Name = "btnSaveIllness";
            this.btnSaveIllness.Size = new System.Drawing.Size(106, 50);
            this.btnSaveIllness.TabIndex = 19;
            this.btnSaveIllness.Text = "Lưu";
            this.btnSaveIllness.TextColor = System.Drawing.Color.Black;
            this.btnSaveIllness.UseVisualStyleBackColor = false;
            // 
            // btnUpdateIllness
            // 
            this.btnUpdateIllness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnUpdateIllness.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnUpdateIllness.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnUpdateIllness.BorderRadius = 20;
            this.btnUpdateIllness.BorderSize = 2;
            this.btnUpdateIllness.FlatAppearance.BorderSize = 0;
            this.btnUpdateIllness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateIllness.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateIllness.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateIllness.Location = new System.Drawing.Point(849, 59);
            this.btnUpdateIllness.Name = "btnUpdateIllness";
            this.btnUpdateIllness.Size = new System.Drawing.Size(106, 50);
            this.btnUpdateIllness.TabIndex = 18;
            this.btnUpdateIllness.Text = "Cập nhật";
            this.btnUpdateIllness.TextColor = System.Drawing.Color.Black;
            this.btnUpdateIllness.UseVisualStyleBackColor = false;
            // 
            // btnAddIllness
            // 
            this.btnAddIllness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnAddIllness.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnAddIllness.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnAddIllness.BorderRadius = 20;
            this.btnAddIllness.BorderSize = 2;
            this.btnAddIllness.FlatAppearance.BorderSize = 0;
            this.btnAddIllness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIllness.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddIllness.ForeColor = System.Drawing.Color.Black;
            this.btnAddIllness.Location = new System.Drawing.Point(849, 3);
            this.btnAddIllness.Name = "btnAddIllness";
            this.btnAddIllness.Size = new System.Drawing.Size(106, 50);
            this.btnAddIllness.TabIndex = 17;
            this.btnAddIllness.Text = "Thêm";
            this.btnAddIllness.TextColor = System.Drawing.Color.Black;
            this.btnAddIllness.UseVisualStyleBackColor = false;
            // 
            // txbIllnessID
            // 
            this.txbIllnessID.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txbIllnessID.Location = new System.Drawing.Point(160, 38);
            this.txbIllnessID.Name = "txbIllnessID";
            this.txbIllnessID.Size = new System.Drawing.Size(210, 27);
            this.txbIllnessID.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên bệnh:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbIllnessName
            // 
            this.txbIllnessName.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txbIllnessName.Location = new System.Drawing.Point(159, 78);
            this.txbIllnessName.Name = "txbIllnessName";
            this.txbIllnessName.Size = new System.Drawing.Size(211, 27);
            this.txbIllnessName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã bệnh:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(480, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "THÔNG TIN BỆNH";
            // 
            // IllnessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1189, 846);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pl_IllnessCategory);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "IllnessForm";
            this.Text = "Loại bệnh và bệnh";
            this.Load += new System.EventHandler(this.IllnessForm_Load);
            this.pl_IllnessCategory.ResumeLayout(false);
            this.pl_IllnessCategory.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_IllnessList)).EndInit();
            this.pl_IllnessInfor.ResumeLayout(false);
            this.pl_IllnessInfor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIllnessList)).EndInit();
            this.plIllnessInfor.ResumeLayout(false);
            this.plIllnessInfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Panel pl_IllnessCategory;
        private Panel panel1;
        private Label label2;
        private Panel pl_IllnessInfor;
        private TextBox txb_IllnessID;
        private Label label4;
        private TextBox txb_IllnessName;
        private Label lblIllnessCategory;
        private Classes.RJButton btnSave_Illness;
        private Classes.RJButton btnUpdate_Illness;
        private Classes.RJButton btnAdd_Illness;
        private Panel panel3;
        private DataGridView dtgv_IllnessList;
        private DataGridViewTextBoxColumn MaLoaiBenh;
        private DataGridViewTextBoxColumn TenLoaiBenh;
        private Label label12;
        private Panel plIllnessInfor;
        private Classes.RJButton btnSaveIllness;
        private Classes.RJButton btnUpdateIllness;
        private Classes.RJButton btnAddIllness;
        private TextBox txbIllnessID;
        private Label label3;
        private TextBox txbIllnessName;
        private Label label5;
        private Label label6;
        private TextBox txbIllnessSymptom;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cbIllnessName;
        private ComboBox cbMedicalName;
        private ComboBox cbMedicalCategoryName;
        private Classes.RJButton btnSearchIllness;
        private Classes.RJButton btnNotSaveIllness;
        private Classes.RJButton btnSearch_Illness;
        private Classes.RJButton btnNotSave_Illness;
        private Panel panel5;
        private Label label10;
        private DataGridView dtgvIllnessList;
        private DataGridViewTextBoxColumn MaBenh;
        private DataGridViewTextBoxColumn TenBenh;
        private DataGridViewTextBoxColumn TrieuChung;
        private DataGridViewTextBoxColumn ThuocDacTri;
        private DataGridViewTextBoxColumn LoaiBenh;
    }
}