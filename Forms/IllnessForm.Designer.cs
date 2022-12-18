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
            this.plIllnessInfor = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIllnessSympton = new ClinicManagement.Classes.CustomTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxIllnessName = new ClinicManagement.Classes.CustomTextBox();
            this.btnSearchIllness = new ClinicManagement.Classes.RJButton();
            this.btnNotSaveIllness = new ClinicManagement.Classes.RJButton();
            this.btnSaveIllness = new ClinicManagement.Classes.RJButton();
            this.btnUpdateIllness = new ClinicManagement.Classes.RJButton();
            this.btnAddIllness = new ClinicManagement.Classes.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new ClinicManagement.Classes.GradientPanel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIllnessList)).BeginInit();
            this.plIllnessInfor.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.plIllnessInfor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 813);
            this.panel1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(497, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 27);
            this.label10.TabIndex = 20;
            this.label10.Text = "Danh sách bệnh";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvIllnessList);
            this.panel5.Location = new System.Drawing.Point(3, 206);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1154, 603);
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
            this.ThuocDacTri});
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
            this.dtgvIllnessList.Size = new System.Drawing.Size(1154, 603);
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
            // plIllnessInfor
            // 
            this.plIllnessInfor.BackColor = System.Drawing.Color.Transparent;
            this.plIllnessInfor.Controls.Add(this.tableLayoutPanel2);
            this.plIllnessInfor.Controls.Add(this.tableLayoutPanel1);
            this.plIllnessInfor.Controls.Add(this.btnSearchIllness);
            this.plIllnessInfor.Controls.Add(this.btnNotSaveIllness);
            this.plIllnessInfor.Controls.Add(this.btnSaveIllness);
            this.plIllnessInfor.Controls.Add(this.btnUpdateIllness);
            this.plIllnessInfor.Controls.Add(this.btnAddIllness);
            this.plIllnessInfor.Location = new System.Drawing.Point(3, 36);
            this.plIllnessInfor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plIllnessInfor.Name = "plIllnessInfor";
            this.plIllnessInfor.Size = new System.Drawing.Size(1154, 135);
            this.plIllnessInfor.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbxIllnessSympton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 71);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(482, 47);
            this.tableLayoutPanel2.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 47);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên triệu chứng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxIllnessSympton
            // 
            this.tbxIllnessSympton.BackColor = System.Drawing.SystemColors.Window;
            this.tbxIllnessSympton.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxIllnessSympton.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxIllnessSympton.BorderSize = 2;
            this.tbxIllnessSympton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxIllnessSympton.ForeColor = System.Drawing.Color.DimGray;
            this.tbxIllnessSympton.Location = new System.Drawing.Point(195, 3);
            this.tbxIllnessSympton.Multiline = false;
            this.tbxIllnessSympton.Name = "tbxIllnessSympton";
            this.tbxIllnessSympton.Padding = new System.Windows.Forms.Padding(7);
            this.tbxIllnessSympton.PasswordChar = false;
            this.tbxIllnessSympton.ReadOnly = false;
            this.tbxIllnessSympton.Size = new System.Drawing.Size(284, 38);
            this.tbxIllnessSympton.TabIndex = 61;
            this.tbxIllnessSympton.Texts = "";
            this.tbxIllnessSympton.UnderlinedStyle = false;
            this.tbxIllnessSympton._TextChanged += new System.EventHandler(this.tbxIllnessSympton__TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxIllnessName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 47);
            this.tableLayoutPanel1.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 47);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên bệnh:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxIllnessName
            // 
            this.tbxIllnessName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxIllnessName.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.tbxIllnessName.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.tbxIllnessName.BorderSize = 2;
            this.tbxIllnessName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxIllnessName.ForeColor = System.Drawing.Color.DimGray;
            this.tbxIllnessName.Location = new System.Drawing.Point(195, 3);
            this.tbxIllnessName.Multiline = false;
            this.tbxIllnessName.Name = "tbxIllnessName";
            this.tbxIllnessName.Padding = new System.Windows.Forms.Padding(7);
            this.tbxIllnessName.PasswordChar = false;
            this.tbxIllnessName.ReadOnly = false;
            this.tbxIllnessName.Size = new System.Drawing.Size(284, 38);
            this.tbxIllnessName.TabIndex = 60;
            this.tbxIllnessName.Texts = "";
            this.tbxIllnessName.UnderlinedStyle = false;
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
            this.btnSearchIllness.Location = new System.Drawing.Point(1015, 41);
            this.btnSearchIllness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchIllness.Name = "btnSearchIllness";
            this.btnSearchIllness.Size = new System.Drawing.Size(134, 55);
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
            this.btnNotSaveIllness.Location = new System.Drawing.Point(875, 41);
            this.btnNotSaveIllness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNotSaveIllness.Name = "btnNotSaveIllness";
            this.btnNotSaveIllness.Size = new System.Drawing.Size(134, 55);
            this.btnNotSaveIllness.TabIndex = 20;
            this.btnNotSaveIllness.Text = "Huỷ";
            this.btnNotSaveIllness.TextColor = System.Drawing.Color.Black;
            this.btnNotSaveIllness.UseVisualStyleBackColor = false;
            this.btnNotSaveIllness.Click += new System.EventHandler(this.btnNotSaveIllness_Click);
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
            this.btnSaveIllness.Location = new System.Drawing.Point(748, 41);
            this.btnSaveIllness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveIllness.Name = "btnSaveIllness";
            this.btnSaveIllness.Size = new System.Drawing.Size(121, 55);
            this.btnSaveIllness.TabIndex = 19;
            this.btnSaveIllness.Text = "Lưu";
            this.btnSaveIllness.TextColor = System.Drawing.Color.Black;
            this.btnSaveIllness.UseVisualStyleBackColor = false;
            this.btnSaveIllness.Click += new System.EventHandler(this.btnSaveIllness_Click);
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
            this.btnUpdateIllness.Location = new System.Drawing.Point(621, 41);
            this.btnUpdateIllness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateIllness.Name = "btnUpdateIllness";
            this.btnUpdateIllness.Size = new System.Drawing.Size(121, 55);
            this.btnUpdateIllness.TabIndex = 18;
            this.btnUpdateIllness.Text = "Cập nhật";
            this.btnUpdateIllness.TextColor = System.Drawing.Color.Black;
            this.btnUpdateIllness.UseVisualStyleBackColor = false;
            this.btnUpdateIllness.Click += new System.EventHandler(this.btnUpdateIllness_Click);
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
            this.btnAddIllness.Location = new System.Drawing.Point(494, 41);
            this.btnAddIllness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddIllness.Name = "btnAddIllness";
            this.btnAddIllness.Size = new System.Drawing.Size(121, 55);
            this.btnAddIllness.TabIndex = 17;
            this.btnAddIllness.Text = "Thêm";
            this.btnAddIllness.TextColor = System.Drawing.Color.Black;
            this.btnAddIllness.UseVisualStyleBackColor = false;
            this.btnAddIllness.Click += new System.EventHandler(this.btnAddIllness_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(482, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "THÔNG TIN BỆNH";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(166)))), ((int)(((byte)(250)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1189, 845);
            this.gradientPanel1.TabIndex = 21;
            // 
            // IllnessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1189, 845);
            this.Controls.Add(this.gradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "IllnessForm";
            this.Text = "Loại bệnh và bệnh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIllnessList)).EndInit();
            this.plIllnessInfor.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
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
        private Classes.RJButton btnSearchIllness;
        private Classes.RJButton btnNotSaveIllness;
        private Panel panel5;
        private Label label10;
        private DataGridView dtgvIllnessList;
        private Classes.CustomTextBox tbxIllnessSympton;
        private Classes.CustomTextBox tbxIllnessName;
        private Classes.GradientPanel gradientPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn MaBenh;
        private DataGridViewTextBoxColumn TenBenh;
        private DataGridViewTextBoxColumn TrieuChung;
        private DataGridViewTextBoxColumn ThuocDacTri;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
    }
}