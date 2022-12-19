namespace ClinicManagement.Forms
{
    partial class UsageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plIllnessCategory = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvUsage = new System.Windows.Forms.DataGridView();
            this.MaCachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUsageDel = new ClinicManagement.Classes.RJButton();
            this.tbxUsageName = new ClinicManagement.Classes.CustomTextBox();
            this.btnSearchUsage = new ClinicManagement.Classes.RJButton();
            this.btnNotSaveUsage = new ClinicManagement.Classes.RJButton();
            this.btnSaveUsage = new ClinicManagement.Classes.RJButton();
            this.btnAddUsage = new ClinicManagement.Classes.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new ClinicManagement.Classes.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvUnit = new System.Windows.Forms.DataGridView();
            this.MaDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUnitDel = new ClinicManagement.Classes.RJButton();
            this.tbxUnitName = new ClinicManagement.Classes.CustomTextBox();
            this.btnSearchUnit = new ClinicManagement.Classes.RJButton();
            this.btnNotSaveUnit = new ClinicManagement.Classes.RJButton();
            this.btnSaveUnit = new ClinicManagement.Classes.RJButton();
            this.btnAddUnit = new ClinicManagement.Classes.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.plIllnessCategory.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsage)).BeginInit();
            this.panel2.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUnit)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // plIllnessCategory
            // 
            this.plIllnessCategory.BackColor = System.Drawing.Color.Transparent;
            this.plIllnessCategory.Controls.Add(this.label12);
            this.plIllnessCategory.Controls.Add(this.panel3);
            this.plIllnessCategory.Controls.Add(this.panel2);
            this.plIllnessCategory.Controls.Add(this.label1);
            this.plIllnessCategory.Location = new System.Drawing.Point(27, 420);
            this.plIllnessCategory.Name = "plIllnessCategory";
            this.plIllnessCategory.Size = new System.Drawing.Size(1150, 413);
            this.plIllnessCategory.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(625, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 27);
            this.label12.TabIndex = 19;
            this.label12.Text = "Danh sách cách dùng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvUsage);
            this.panel3.Location = new System.Drawing.Point(349, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 347);
            this.panel3.TabIndex = 18;
            // 
            // dtgvUsage
            // 
            this.dtgvUsage.AllowUserToAddRows = false;
            this.dtgvUsage.AllowUserToDeleteRows = false;
            this.dtgvUsage.AllowUserToResizeColumns = false;
            this.dtgvUsage.AllowUserToResizeRows = false;
            this.dtgvUsage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvUsage.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUsage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvUsage.ColumnHeadersHeight = 60;
            this.dtgvUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvUsage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCachDung,
            this.TenCachDung});
            this.dtgvUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvUsage.EnableHeadersVisualStyles = false;
            this.dtgvUsage.Location = new System.Drawing.Point(0, 0);
            this.dtgvUsage.Name = "dtgvUsage";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUsage.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvUsage.RowHeadersVisible = false;
            this.dtgvUsage.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dtgvUsage.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvUsage.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvUsage.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtgvUsage.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this.dtgvUsage.RowTemplate.Height = 29;
            this.dtgvUsage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvUsage.Size = new System.Drawing.Size(798, 347);
            this.dtgvUsage.TabIndex = 5;
            // 
            // MaCachDung
            // 
            this.MaCachDung.FillWeight = 127.7511F;
            this.MaCachDung.HeaderText = "Mã cách dùng";
            this.MaCachDung.MinimumWidth = 6;
            this.MaCachDung.Name = "MaCachDung";
            // 
            // TenCachDung
            // 
            this.TenCachDung.FillWeight = 124.0151F;
            this.TenCachDung.HeaderText = "Tên cách dùng";
            this.TenCachDung.MinimumWidth = 6;
            this.TenCachDung.Name = "TenCachDung";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnUsageDel);
            this.panel2.Controls.Add(this.tbxUsageName);
            this.panel2.Controls.Add(this.btnSearchUsage);
            this.panel2.Controls.Add(this.btnNotSaveUsage);
            this.panel2.Controls.Add(this.btnSaveUsage);
            this.panel2.Controls.Add(this.btnAddUsage);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 347);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnUsageDel
            // 
            this.btnUsageDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnUsageDel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnUsageDel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnUsageDel.BorderRadius = 20;
            this.btnUsageDel.BorderSize = 2;
            this.btnUsageDel.FlatAppearance.BorderSize = 0;
            this.btnUsageDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsageDel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsageDel.ForeColor = System.Drawing.Color.Black;
            this.btnUsageDel.Location = new System.Drawing.Point(175, 134);
            this.btnUsageDel.Name = "btnUsageDel";
            this.btnUsageDel.Size = new System.Drawing.Size(142, 55);
            this.btnUsageDel.TabIndex = 28;
            this.btnUsageDel.Text = "Xoá";
            this.btnUsageDel.TextColor = System.Drawing.Color.Black;
            this.btnUsageDel.UseVisualStyleBackColor = false;
            this.btnUsageDel.Click += new System.EventHandler(this.btnUsageDel_Click);
            // 
            // tbxUsageName
            // 
            this.tbxUsageName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxUsageName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbxUsageName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.tbxUsageName.BorderSize = 2;
            this.tbxUsageName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxUsageName.ForeColor = System.Drawing.Color.DimGray;
            this.tbxUsageName.Location = new System.Drawing.Point(33, 73);
            this.tbxUsageName.Multiline = false;
            this.tbxUsageName.Name = "tbxUsageName";
            this.tbxUsageName.Padding = new System.Windows.Forms.Padding(7);
            this.tbxUsageName.PasswordChar = false;
            this.tbxUsageName.ReadOnly = false;
            this.tbxUsageName.Size = new System.Drawing.Size(279, 38);
            this.tbxUsageName.TabIndex = 27;
            this.tbxUsageName.Texts = "";
            this.tbxUsageName.UnderlinedStyle = false;
            // 
            // btnSearchUsage
            // 
            this.btnSearchUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSearchUsage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSearchUsage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnSearchUsage.BorderRadius = 20;
            this.btnSearchUsage.BorderSize = 2;
            this.btnSearchUsage.FlatAppearance.BorderSize = 0;
            this.btnSearchUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUsage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchUsage.ForeColor = System.Drawing.Color.Black;
            this.btnSearchUsage.Location = new System.Drawing.Point(25, 256);
            this.btnSearchUsage.Name = "btnSearchUsage";
            this.btnSearchUsage.Size = new System.Drawing.Size(142, 55);
            this.btnSearchUsage.TabIndex = 23;
            this.btnSearchUsage.Text = "Tra cứu";
            this.btnSearchUsage.TextColor = System.Drawing.Color.Black;
            this.btnSearchUsage.UseVisualStyleBackColor = false;
            // 
            // btnNotSaveUsage
            // 
            this.btnNotSaveUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnNotSaveUsage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnNotSaveUsage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnNotSaveUsage.BorderRadius = 20;
            this.btnNotSaveUsage.BorderSize = 2;
            this.btnNotSaveUsage.FlatAppearance.BorderSize = 0;
            this.btnNotSaveUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotSaveUsage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotSaveUsage.ForeColor = System.Drawing.Color.Black;
            this.btnNotSaveUsage.Location = new System.Drawing.Point(175, 195);
            this.btnNotSaveUsage.Name = "btnNotSaveUsage";
            this.btnNotSaveUsage.Size = new System.Drawing.Size(142, 55);
            this.btnNotSaveUsage.TabIndex = 22;
            this.btnNotSaveUsage.Text = "Huỷ";
            this.btnNotSaveUsage.TextColor = System.Drawing.Color.Black;
            this.btnNotSaveUsage.UseVisualStyleBackColor = false;
            this.btnNotSaveUsage.Click += new System.EventHandler(this.btnNotSaveUsage_Click);
            // 
            // btnSaveUsage
            // 
            this.btnSaveUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSaveUsage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSaveUsage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnSaveUsage.BorderRadius = 20;
            this.btnSaveUsage.BorderSize = 2;
            this.btnSaveUsage.FlatAppearance.BorderSize = 0;
            this.btnSaveUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUsage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveUsage.ForeColor = System.Drawing.Color.Black;
            this.btnSaveUsage.Location = new System.Drawing.Point(25, 195);
            this.btnSaveUsage.Name = "btnSaveUsage";
            this.btnSaveUsage.Size = new System.Drawing.Size(142, 55);
            this.btnSaveUsage.TabIndex = 19;
            this.btnSaveUsage.Text = "Lưu";
            this.btnSaveUsage.TextColor = System.Drawing.Color.Black;
            this.btnSaveUsage.UseVisualStyleBackColor = false;
            this.btnSaveUsage.Click += new System.EventHandler(this.btnSaveUsage_Click);
            // 
            // btnAddUsage
            // 
            this.btnAddUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnAddUsage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnAddUsage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnAddUsage.BorderRadius = 20;
            this.btnAddUsage.BorderSize = 2;
            this.btnAddUsage.FlatAppearance.BorderSize = 0;
            this.btnAddUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddUsage.ForeColor = System.Drawing.Color.Black;
            this.btnAddUsage.Location = new System.Drawing.Point(25, 134);
            this.btnAddUsage.Name = "btnAddUsage";
            this.btnAddUsage.Size = new System.Drawing.Size(142, 55);
            this.btnAddUsage.TabIndex = 17;
            this.btnAddUsage.Text = "Thêm";
            this.btnAddUsage.TextColor = System.Drawing.Color.Black;
            this.btnAddUsage.UseVisualStyleBackColor = false;
            this.btnAddUsage.Click += new System.EventHandler(this.btnAddUsage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(91, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tên cách dùng:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN CÁCH DÙNG";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.SystemColors.Menu;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(166)))), ((int)(((byte)(250)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.plIllnessCategory);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1189, 845);
            this.gradientPanel1.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 403);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(655, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Danh sách đơn vị";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvUnit);
            this.panel4.Location = new System.Drawing.Point(349, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(798, 335);
            this.panel4.TabIndex = 18;
            // 
            // dtgvUnit
            // 
            this.dtgvUnit.AllowUserToAddRows = false;
            this.dtgvUnit.AllowUserToDeleteRows = false;
            this.dtgvUnit.AllowUserToResizeColumns = false;
            this.dtgvUnit.AllowUserToResizeRows = false;
            this.dtgvUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvUnit.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUnit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvUnit.ColumnHeadersHeight = 60;
            this.dtgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonVi,
            this.TenDonVi});
            this.dtgvUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvUnit.EnableHeadersVisualStyles = false;
            this.dtgvUnit.Location = new System.Drawing.Point(0, 0);
            this.dtgvUnit.Name = "dtgvUnit";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUnit.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvUnit.RowHeadersVisible = false;
            this.dtgvUnit.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dtgvUnit.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvUnit.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvUnit.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtgvUnit.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this.dtgvUnit.RowTemplate.Height = 29;
            this.dtgvUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvUnit.Size = new System.Drawing.Size(798, 335);
            this.dtgvUnit.TabIndex = 5;
            // 
            // MaDonVi
            // 
            this.MaDonVi.FillWeight = 127.7511F;
            this.MaDonVi.HeaderText = "Mã đơn vị";
            this.MaDonVi.MinimumWidth = 6;
            this.MaDonVi.Name = "MaDonVi";
            // 
            // TenDonVi
            // 
            this.TenDonVi.FillWeight = 124.0151F;
            this.TenDonVi.HeaderText = "Tên đơn vị";
            this.TenDonVi.MinimumWidth = 6;
            this.TenDonVi.Name = "TenDonVi";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.btnUnitDel);
            this.panel5.Controls.Add(this.tbxUnitName);
            this.panel5.Controls.Add(this.btnSearchUnit);
            this.panel5.Controls.Add(this.btnNotSaveUnit);
            this.panel5.Controls.Add(this.btnSaveUnit);
            this.panel5.Controls.Add(this.btnAddUnit);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 335);
            this.panel5.TabIndex = 17;
            // 
            // btnUnitDel
            // 
            this.btnUnitDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnUnitDel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnUnitDel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnUnitDel.BorderRadius = 20;
            this.btnUnitDel.BorderSize = 2;
            this.btnUnitDel.FlatAppearance.BorderSize = 0;
            this.btnUnitDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitDel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUnitDel.ForeColor = System.Drawing.Color.Black;
            this.btnUnitDel.Location = new System.Drawing.Point(175, 134);
            this.btnUnitDel.Name = "btnUnitDel";
            this.btnUnitDel.Size = new System.Drawing.Size(142, 55);
            this.btnUnitDel.TabIndex = 26;
            this.btnUnitDel.Text = "Xoá";
            this.btnUnitDel.TextColor = System.Drawing.Color.Black;
            this.btnUnitDel.UseVisualStyleBackColor = false;
            this.btnUnitDel.Click += new System.EventHandler(this.btnUnitDel_Click);
            // 
            // tbxUnitName
            // 
            this.tbxUnitName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxUnitName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbxUnitName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.tbxUnitName.BorderSize = 2;
            this.tbxUnitName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxUnitName.ForeColor = System.Drawing.Color.DimGray;
            this.tbxUnitName.Location = new System.Drawing.Point(34, 72);
            this.tbxUnitName.Multiline = false;
            this.tbxUnitName.Name = "tbxUnitName";
            this.tbxUnitName.Padding = new System.Windows.Forms.Padding(7);
            this.tbxUnitName.PasswordChar = false;
            this.tbxUnitName.ReadOnly = false;
            this.tbxUnitName.Size = new System.Drawing.Size(279, 38);
            this.tbxUnitName.TabIndex = 25;
            this.tbxUnitName.Texts = "";
            this.tbxUnitName.UnderlinedStyle = false;
            // 
            // btnSearchUnit
            // 
            this.btnSearchUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSearchUnit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSearchUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnSearchUnit.BorderRadius = 20;
            this.btnSearchUnit.BorderSize = 2;
            this.btnSearchUnit.FlatAppearance.BorderSize = 0;
            this.btnSearchUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchUnit.ForeColor = System.Drawing.Color.Black;
            this.btnSearchUnit.Location = new System.Drawing.Point(25, 256);
            this.btnSearchUnit.Name = "btnSearchUnit";
            this.btnSearchUnit.Size = new System.Drawing.Size(142, 55);
            this.btnSearchUnit.TabIndex = 23;
            this.btnSearchUnit.Text = "Tra cứu";
            this.btnSearchUnit.TextColor = System.Drawing.Color.Black;
            this.btnSearchUnit.UseVisualStyleBackColor = false;
            this.btnSearchUnit.Click += new System.EventHandler(this.btnSearchUnit_Click);
            // 
            // btnNotSaveUnit
            // 
            this.btnNotSaveUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnNotSaveUnit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnNotSaveUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnNotSaveUnit.BorderRadius = 20;
            this.btnNotSaveUnit.BorderSize = 2;
            this.btnNotSaveUnit.FlatAppearance.BorderSize = 0;
            this.btnNotSaveUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotSaveUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotSaveUnit.ForeColor = System.Drawing.Color.Black;
            this.btnNotSaveUnit.Location = new System.Drawing.Point(175, 195);
            this.btnNotSaveUnit.Name = "btnNotSaveUnit";
            this.btnNotSaveUnit.Size = new System.Drawing.Size(142, 55);
            this.btnNotSaveUnit.TabIndex = 22;
            this.btnNotSaveUnit.Text = "Huỷ";
            this.btnNotSaveUnit.TextColor = System.Drawing.Color.Black;
            this.btnNotSaveUnit.UseVisualStyleBackColor = false;
            this.btnNotSaveUnit.Click += new System.EventHandler(this.btnNotSaveUnit_Click);
            // 
            // btnSaveUnit
            // 
            this.btnSaveUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSaveUnit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSaveUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnSaveUnit.BorderRadius = 20;
            this.btnSaveUnit.BorderSize = 2;
            this.btnSaveUnit.FlatAppearance.BorderSize = 0;
            this.btnSaveUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveUnit.ForeColor = System.Drawing.Color.Black;
            this.btnSaveUnit.Location = new System.Drawing.Point(25, 195);
            this.btnSaveUnit.Name = "btnSaveUnit";
            this.btnSaveUnit.Size = new System.Drawing.Size(142, 55);
            this.btnSaveUnit.TabIndex = 19;
            this.btnSaveUnit.Text = "Lưu";
            this.btnSaveUnit.TextColor = System.Drawing.Color.Black;
            this.btnSaveUnit.UseVisualStyleBackColor = false;
            this.btnSaveUnit.Click += new System.EventHandler(this.btnSaveUnit_Click);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnAddUnit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnAddUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnAddUnit.BorderRadius = 20;
            this.btnAddUnit.BorderSize = 2;
            this.btnAddUnit.FlatAppearance.BorderSize = 0;
            this.btnAddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddUnit.ForeColor = System.Drawing.Color.Black;
            this.btnAddUnit.Location = new System.Drawing.Point(25, 134);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(142, 55);
            this.btnAddUnit.TabIndex = 17;
            this.btnAddUnit.Text = "Thêm";
            this.btnAddUnit.TextColor = System.Drawing.Color.Black;
            this.btnAddUnit.UseVisualStyleBackColor = false;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(104, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên đơn vị:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(53, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "THÔNG TIN ĐƠN VỊ";
            // 
            // UsageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1189, 845);
            this.Controls.Add(this.gradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UsageForm";
            this.Text = "Đơn vị và cách dùng";
            this.plIllnessCategory.ResumeLayout(false);
            this.plIllnessCategory.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUnit)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel plIllnessCategory;
        private Label label12;
        private Panel panel3;
        private DataGridView dtgvUsage;
        private Panel panel2;
        private Classes.RJButton btnSearchUsage;
        private Classes.RJButton btnNotSaveUsage;
        private Classes.RJButton btnSaveUsage;
        private Classes.RJButton btnAddUsage;
        private Label label4;
        private Label label1;
        private DataGridViewTextBoxColumn MaCachDung;
        private DataGridViewTextBoxColumn TenCachDung;
        private Classes.CustomTextBox tbxUsageName;
        private Classes.GradientPanel gradientPanel1;
        private Panel panel1;
        private Label label2;
        private Panel panel4;
        private DataGridView dtgvUnit;
        private DataGridViewTextBoxColumn MaDonVi;
        private DataGridViewTextBoxColumn TenDonVi;
        private Panel panel5;
        private Classes.CustomTextBox tbxUnitName;
        private Classes.RJButton btnSearchUnit;
        private Classes.RJButton btnNotSaveUnit;
        private Classes.RJButton btnSaveUnit;
        private Classes.RJButton btnAddUnit;
        private Label label3;
        private Label label6;
        private Classes.RJButton btnUsageDel;
        private Classes.RJButton btnUnitDel;
    }
}