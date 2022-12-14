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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveIllness = new ClinicManagement.Classes.RJButton();
            this.btnUpdateIllness = new ClinicManagement.Classes.RJButton();
            this.btnAddIllness = new ClinicManagement.Classes.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customTextBox2 = new ClinicManagement.Classes.CustomTextBox();
            this.customTextBox3 = new ClinicManagement.Classes.CustomTextBox();
            this.rjComboBox1 = new CustomControls.RJControls.RJComboBox();
            this.rjComboBox2 = new CustomControls.RJControls.RJComboBox();
            this.rjComboBox3 = new CustomControls.RJControls.RJComboBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIllnessList)).BeginInit();
            this.plIllnessInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.plIllnessInfor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 1001);
            this.panel1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(559, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Danh sách bệnh";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvIllnessList);
            this.panel5.Location = new System.Drawing.Point(18, 307);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1278, 348);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvIllnessList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dtgvIllnessList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvIllnessList.Name = "dtgvIllnessList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvIllnessList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvIllnessList.RowHeadersVisible = false;
            this.dtgvIllnessList.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dtgvIllnessList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvIllnessList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvIllnessList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtgvIllnessList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this.dtgvIllnessList.RowTemplate.Height = 29;
            this.dtgvIllnessList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvIllnessList.Size = new System.Drawing.Size(1278, 348);
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
            this.plIllnessInfor.BackColor = System.Drawing.Color.SkyBlue;
            this.plIllnessInfor.Controls.Add(this.rjComboBox3);
            this.plIllnessInfor.Controls.Add(this.rjComboBox2);
            this.plIllnessInfor.Controls.Add(this.rjComboBox1);
            this.plIllnessInfor.Controls.Add(this.customTextBox3);
            this.plIllnessInfor.Controls.Add(this.customTextBox2);
            this.plIllnessInfor.Controls.Add(this.btnSearchIllness);
            this.plIllnessInfor.Controls.Add(this.btnNotSaveIllness);
            this.plIllnessInfor.Controls.Add(this.label7);
            this.plIllnessInfor.Controls.Add(this.label8);
            this.plIllnessInfor.Controls.Add(this.label9);
            this.plIllnessInfor.Controls.Add(this.label6);
            this.plIllnessInfor.Controls.Add(this.btnSaveIllness);
            this.plIllnessInfor.Controls.Add(this.btnUpdateIllness);
            this.plIllnessInfor.Controls.Add(this.btnAddIllness);
            this.plIllnessInfor.Controls.Add(this.label3);
            this.plIllnessInfor.Location = new System.Drawing.Point(16, 36);
            this.plIllnessInfor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plIllnessInfor.Name = "plIllnessInfor";
            this.plIllnessInfor.Size = new System.Drawing.Size(1280, 231);
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
            this.btnSearchIllness.Location = new System.Drawing.Point(1114, 127);
            this.btnSearchIllness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchIllness.Name = "btnSearchIllness";
            this.btnSearchIllness.Size = new System.Drawing.Size(134, 67);
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
            this.btnNotSaveIllness.Location = new System.Drawing.Point(1114, 36);
            this.btnNotSaveIllness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNotSaveIllness.Name = "btnNotSaveIllness";
            this.btnNotSaveIllness.Size = new System.Drawing.Size(134, 67);
            this.btnNotSaveIllness.TabIndex = 20;
            this.btnNotSaveIllness.Text = "Không lưu";
            this.btnNotSaveIllness.TextColor = System.Drawing.Color.Black;
            this.btnNotSaveIllness.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(441, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tên loại bệnh:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(441, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 26);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tên thuốc đặc trị:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(441, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 26);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tên loại thuốc đặc trị:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Triệu chứng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSaveIllness.Location = new System.Drawing.Point(970, 153);
            this.btnSaveIllness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveIllness.Name = "btnSaveIllness";
            this.btnSaveIllness.Size = new System.Drawing.Size(121, 67);
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
            this.btnUpdateIllness.Location = new System.Drawing.Point(970, 79);
            this.btnUpdateIllness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateIllness.Name = "btnUpdateIllness";
            this.btnUpdateIllness.Size = new System.Drawing.Size(121, 67);
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
            this.btnAddIllness.Location = new System.Drawing.Point(970, 4);
            this.btnAddIllness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddIllness.Name = "btnAddIllness";
            this.btnAddIllness.Size = new System.Drawing.Size(121, 67);
            this.btnAddIllness.TabIndex = 17;
            this.btnAddIllness.Text = "Thêm";
            this.btnAddIllness.TextColor = System.Drawing.Color.Black;
            this.btnAddIllness.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên bệnh:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(549, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "THÔNG TIN BỆNH";
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox2.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.customTextBox2.BorderSize = 1;
            this.customTextBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox2.Location = new System.Drawing.Point(145, 95);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBox2.PasswordChar = false;
            this.customTextBox2.ReadOnly = false;
            this.customTextBox2.Size = new System.Drawing.Size(290, 38);
            this.customTextBox2.TabIndex = 60;
            this.customTextBox2.Texts = "";
            this.customTextBox2.UnderlinedStyle = false;
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox3.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.customTextBox3.BorderSize = 1;
            this.customTextBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox3.Location = new System.Drawing.Point(145, 146);
            this.customTextBox3.Multiline = false;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBox3.PasswordChar = false;
            this.customTextBox3.ReadOnly = false;
            this.customTextBox3.Size = new System.Drawing.Size(290, 38);
            this.customTextBox3.TabIndex = 61;
            this.customTextBox3.Texts = "";
            this.customTextBox3.UnderlinedStyle = false;
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(692, 40);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(50, 20);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox1.Size = new System.Drawing.Size(197, 38);
            this.rjComboBox1.TabIndex = 62;
            this.rjComboBox1.Texts = "";
            // 
            // rjComboBox2
            // 
            this.rjComboBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox2.BorderSize = 1;
            this.rjComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjComboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox2.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox2.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox2.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox2.Location = new System.Drawing.Point(692, 95);
            this.rjComboBox2.MinimumSize = new System.Drawing.Size(50, 20);
            this.rjComboBox2.Name = "rjComboBox2";
            this.rjComboBox2.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox2.Size = new System.Drawing.Size(197, 38);
            this.rjComboBox2.TabIndex = 63;
            this.rjComboBox2.Texts = "";
            // 
            // rjComboBox3
            // 
            this.rjComboBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox3.BorderSize = 1;
            this.rjComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjComboBox3.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox3.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox3.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox3.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox3.Location = new System.Drawing.Point(692, 139);
            this.rjComboBox3.MinimumSize = new System.Drawing.Size(50, 20);
            this.rjComboBox3.Name = "rjComboBox3";
            this.rjComboBox3.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox3.Size = new System.Drawing.Size(197, 38);
            this.rjComboBox3.TabIndex = 64;
            this.rjComboBox3.Texts = "";
            // 
            // IllnessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1359, 1055);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "IllnessForm";
            this.Text = "Loại bệnh và bệnh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIllnessList)).EndInit();
            this.plIllnessInfor.ResumeLayout(false);
            this.plIllnessInfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Panel plIllnessInfor;
        private Classes.RJButton btnSaveIllness;
        private Classes.RJButton btnUpdateIllness;
        private Classes.RJButton btnAddIllness;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Classes.RJButton btnSearchIllness;
        private Classes.RJButton btnNotSaveIllness;
        private Panel panel5;
        private Label label10;
        private DataGridView dtgvIllnessList;
        private DataGridViewTextBoxColumn MaBenh;
        private DataGridViewTextBoxColumn TenBenh;
        private DataGridViewTextBoxColumn TrieuChung;
        private DataGridViewTextBoxColumn ThuocDacTri;
        private DataGridViewTextBoxColumn LoaiBenh;
        private CustomControls.RJControls.RJComboBox rjComboBox3;
        private CustomControls.RJControls.RJComboBox rjComboBox2;
        private CustomControls.RJControls.RJComboBox rjComboBox1;
        private Classes.CustomTextBox customTextBox3;
        private Classes.CustomTextBox customTextBox2;
    }
}