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
            this.dtgvPatientList = new System.Windows.Forms.DataGridView();
            this.MaCachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxUsageName = new ClinicManagement.Classes.CustomTextBox();
            this.btnSearchUsage = new ClinicManagement.Classes.RJButton();
            this.btnNotSaveUsage = new ClinicManagement.Classes.RJButton();
            this.btnSaveUsage = new ClinicManagement.Classes.RJButton();
            this.btnUpdateUsage = new ClinicManagement.Classes.RJButton();
            this.btnAddUsage = new ClinicManagement.Classes.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new ClinicManagement.Classes.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbxUnitName = new ClinicManagement.Classes.CustomTextBox();
            this.btnSearchUnit = new ClinicManagement.Classes.RJButton();
            this.btnNotSaveUnit = new ClinicManagement.Classes.RJButton();
            this.btnSaveUnit = new ClinicManagement.Classes.RJButton();
            this.btnUpdateUnit = new ClinicManagement.Classes.RJButton();
            this.btnAddUnit = new ClinicManagement.Classes.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.plIllnessCategory.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatientList)).BeginInit();
            this.panel2.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(648, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "Danh sách cách dùng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvPatientList);
            this.panel3.Location = new System.Drawing.Point(349, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 347);
            this.panel3.TabIndex = 18;
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
            this.MaCachDung,
            this.TenCachDung});
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
            this.dtgvPatientList.Size = new System.Drawing.Size(798, 347);
            this.dtgvPatientList.TabIndex = 5;
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
            this.panel2.Controls.Add(this.tbxUsageName);
            this.panel2.Controls.Add(this.btnSearchUsage);
            this.panel2.Controls.Add(this.btnNotSaveUsage);
            this.panel2.Controls.Add(this.btnSaveUsage);
            this.panel2.Controls.Add(this.btnUpdateUsage);
            this.panel2.Controls.Add(this.btnAddUsage);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 347);
            this.panel2.TabIndex = 17;
            // 
            // tbxUsageName
            // 
            this.tbxUsageName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxUsageName.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxUsageName.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxUsageName.BorderSize = 1;
            this.tbxUsageName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxUsageName.ForeColor = System.Drawing.Color.DimGray;
            this.tbxUsageName.Location = new System.Drawing.Point(47, 131);
            this.tbxUsageName.Multiline = false;
            this.tbxUsageName.Name = "tbxUsageName";
            this.tbxUsageName.Padding = new System.Windows.Forms.Padding(7);
            this.tbxUsageName.PasswordChar = false;
            this.tbxUsageName.ReadOnly = false;
            this.tbxUsageName.Size = new System.Drawing.Size(248, 38);
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
            this.btnSearchUsage.Location = new System.Drawing.Point(161, 244);
            this.btnSearchUsage.Name = "btnSearchUsage";
            this.btnSearchUsage.Size = new System.Drawing.Size(110, 51);
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
            this.btnNotSaveUsage.Location = new System.Drawing.Point(43, 244);
            this.btnNotSaveUsage.Name = "btnNotSaveUsage";
            this.btnNotSaveUsage.Size = new System.Drawing.Size(110, 51);
            this.btnNotSaveUsage.TabIndex = 22;
            this.btnNotSaveUsage.Text = "Không lưu";
            this.btnNotSaveUsage.TextColor = System.Drawing.Color.Black;
            this.btnNotSaveUsage.UseVisualStyleBackColor = false;
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
            this.btnSaveUsage.Location = new System.Drawing.Point(224, 188);
            this.btnSaveUsage.Name = "btnSaveUsage";
            this.btnSaveUsage.Size = new System.Drawing.Size(99, 51);
            this.btnSaveUsage.TabIndex = 19;
            this.btnSaveUsage.Text = "Lưu";
            this.btnSaveUsage.TextColor = System.Drawing.Color.Black;
            this.btnSaveUsage.UseVisualStyleBackColor = false;
            this.btnSaveUsage.Click += new System.EventHandler(this.btnSaveUsage_Click);
            // 
            // btnUpdateUsage
            // 
            this.btnUpdateUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnUpdateUsage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnUpdateUsage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnUpdateUsage.BorderRadius = 20;
            this.btnUpdateUsage.BorderSize = 2;
            this.btnUpdateUsage.FlatAppearance.BorderSize = 0;
            this.btnUpdateUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUsage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateUsage.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUsage.Location = new System.Drawing.Point(112, 188);
            this.btnUpdateUsage.Name = "btnUpdateUsage";
            this.btnUpdateUsage.Size = new System.Drawing.Size(106, 51);
            this.btnUpdateUsage.TabIndex = 18;
            this.btnUpdateUsage.Text = "Cập nhật";
            this.btnUpdateUsage.TextColor = System.Drawing.Color.Black;
            this.btnUpdateUsage.UseVisualStyleBackColor = false;
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
            this.btnAddUsage.Location = new System.Drawing.Point(11, 188);
            this.btnAddUsage.Name = "btnAddUsage";
            this.btnAddUsage.Size = new System.Drawing.Size(94, 51);
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
            this.label4.Location = new System.Drawing.Point(47, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tên cách dùng:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(459, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
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
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(671, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Danh sách đơn vị";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(349, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(798, 335);
            this.panel4.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeight = 60;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonVi,
            this.TenDonVi});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(798, 335);
            this.dataGridView1.TabIndex = 5;
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
            this.panel5.Controls.Add(this.tbxUnitName);
            this.panel5.Controls.Add(this.btnSearchUnit);
            this.panel5.Controls.Add(this.btnNotSaveUnit);
            this.panel5.Controls.Add(this.btnSaveUnit);
            this.panel5.Controls.Add(this.btnUpdateUnit);
            this.panel5.Controls.Add(this.btnAddUnit);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 335);
            this.panel5.TabIndex = 17;
            // 
            // tbxUnitName
            // 
            this.tbxUnitName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxUnitName.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxUnitName.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxUnitName.BorderSize = 1;
            this.tbxUnitName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxUnitName.ForeColor = System.Drawing.Color.DimGray;
            this.tbxUnitName.Location = new System.Drawing.Point(33, 120);
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
            this.btnSearchUnit.Location = new System.Drawing.Point(173, 235);
            this.btnSearchUnit.Name = "btnSearchUnit";
            this.btnSearchUnit.Size = new System.Drawing.Size(117, 51);
            this.btnSearchUnit.TabIndex = 23;
            this.btnSearchUnit.Text = "Tra cứu";
            this.btnSearchUnit.TextColor = System.Drawing.Color.Black;
            this.btnSearchUnit.UseVisualStyleBackColor = false;
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
            this.btnNotSaveUnit.Location = new System.Drawing.Point(50, 235);
            this.btnNotSaveUnit.Name = "btnNotSaveUnit";
            this.btnNotSaveUnit.Size = new System.Drawing.Size(117, 51);
            this.btnNotSaveUnit.TabIndex = 22;
            this.btnNotSaveUnit.Text = "Không lưu";
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
            this.btnSaveUnit.Location = new System.Drawing.Point(224, 179);
            this.btnSaveUnit.Name = "btnSaveUnit";
            this.btnSaveUnit.Size = new System.Drawing.Size(99, 51);
            this.btnSaveUnit.TabIndex = 19;
            this.btnSaveUnit.Text = "Lưu";
            this.btnSaveUnit.TextColor = System.Drawing.Color.Black;
            this.btnSaveUnit.UseVisualStyleBackColor = false;
            this.btnSaveUnit.Click += new System.EventHandler(this.btnSaveUnit_Click);
            // 
            // btnUpdateUnit
            // 
            this.btnUpdateUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnUpdateUnit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnUpdateUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnUpdateUnit.BorderRadius = 20;
            this.btnUpdateUnit.BorderSize = 2;
            this.btnUpdateUnit.FlatAppearance.BorderSize = 0;
            this.btnUpdateUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateUnit.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUnit.Location = new System.Drawing.Point(112, 179);
            this.btnUpdateUnit.Name = "btnUpdateUnit";
            this.btnUpdateUnit.Size = new System.Drawing.Size(106, 51);
            this.btnUpdateUnit.TabIndex = 18;
            this.btnUpdateUnit.Text = "Cập nhật";
            this.btnUpdateUnit.TextColor = System.Drawing.Color.Black;
            this.btnUpdateUnit.UseVisualStyleBackColor = false;
            this.btnUpdateUnit.Click += new System.EventHandler(this.btnUpdateUnit_Click);
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
            this.btnAddUnit.Location = new System.Drawing.Point(11, 179);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(94, 51);
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
            this.label3.Location = new System.Drawing.Point(33, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên đơn vị:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(459, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 24);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPatientList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel plIllnessCategory;
        private Label label12;
        private Panel panel3;
        private DataGridView dtgvPatientList;
        private Panel panel2;
        private Classes.RJButton btnSearchUsage;
        private Classes.RJButton btnNotSaveUsage;
        private Classes.RJButton btnSaveUsage;
        private Classes.RJButton btnUpdateUsage;
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaDonVi;
        private DataGridViewTextBoxColumn TenDonVi;
        private Panel panel5;
        private Classes.CustomTextBox tbxUnitName;
        private Classes.RJButton btnSearchUnit;
        private Classes.RJButton btnNotSaveUnit;
        private Classes.RJButton btnSaveUnit;
        private Classes.RJButton btnUpdateUnit;
        private Classes.RJButton btnAddUnit;
        private Label label3;
        private Label label6;
    }
}