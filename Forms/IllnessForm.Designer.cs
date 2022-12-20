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
            this.TenBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrieuChung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plIllnessInfor = new System.Windows.Forms.Panel();
            this.btnDel = new ClinicManagement.Classes.RJButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIllnessSympton = new ClinicManagement.Classes.CustomTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxIllnessName = new ClinicManagement.Classes.CustomTextBox();
            this.btnNotSaveIllness = new ClinicManagement.Classes.RJButton();
            this.btnSaveIllness = new ClinicManagement.Classes.RJButton();
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
            this.TenBenh,
            this.TrieuChung});
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
            this.dtgvIllnessList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvIllnessList_CellClick);
            // 
            // TenBenh
            // 
            this.TenBenh.DataPropertyName = "Name";
            this.TenBenh.FillWeight = 104.5855F;
            this.TenBenh.HeaderText = "Tên bệnh";
            this.TenBenh.MinimumWidth = 6;
            this.TenBenh.Name = "TenBenh";
            // 
            // TrieuChung
            // 
            this.TrieuChung.DataPropertyName = "Symptom";
            this.TrieuChung.FillWeight = 119.1177F;
            this.TrieuChung.HeaderText = "Triệu chứng";
            this.TrieuChung.MinimumWidth = 6;
            this.TrieuChung.Name = "TrieuChung";
            // 
            // plIllnessInfor
            // 
            this.plIllnessInfor.BackColor = System.Drawing.Color.Transparent;
            this.plIllnessInfor.Controls.Add(this.btnDel);
            this.plIllnessInfor.Controls.Add(this.tableLayoutPanel2);
            this.plIllnessInfor.Controls.Add(this.tableLayoutPanel1);
            this.plIllnessInfor.Controls.Add(this.btnNotSaveIllness);
            this.plIllnessInfor.Controls.Add(this.btnSaveIllness);
            this.plIllnessInfor.Controls.Add(this.btnAddIllness);
            this.plIllnessInfor.Location = new System.Drawing.Point(3, 36);
            this.plIllnessInfor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plIllnessInfor.Name = "plIllnessInfor";
            this.plIllnessInfor.Size = new System.Drawing.Size(1154, 135);
            this.plIllnessInfor.TabIndex = 18;
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
            this.btnDel.Location = new System.Drawing.Point(905, 14);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(134, 55);
            this.btnDel.TabIndex = 64;
            this.btnDel.Text = "Xoá";
            this.btnDel.TextColor = System.Drawing.Color.Black;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbxIllnessSympton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(67, 75);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(523, 47);
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
            this.label1.Size = new System.Drawing.Size(203, 47);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên triệu chứng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxIllnessSympton
            // 
            this.tbxIllnessSympton.BackColor = System.Drawing.SystemColors.Window;
            this.tbxIllnessSympton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbxIllnessSympton.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.tbxIllnessSympton.BorderSize = 2;
            this.tbxIllnessSympton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxIllnessSympton.ForeColor = System.Drawing.Color.DimGray;
            this.tbxIllnessSympton.Location = new System.Drawing.Point(212, 3);
            this.tbxIllnessSympton.Multiline = false;
            this.tbxIllnessSympton.Name = "tbxIllnessSympton";
            this.tbxIllnessSympton.Padding = new System.Windows.Forms.Padding(7);
            this.tbxIllnessSympton.PasswordChar = false;
            this.tbxIllnessSympton.ReadOnly = false;
            this.tbxIllnessSympton.Size = new System.Drawing.Size(308, 38);
            this.tbxIllnessSympton.TabIndex = 61;
            this.tbxIllnessSympton.Texts = "";
            this.tbxIllnessSympton.UnderlinedStyle = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxIllnessName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(67, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(523, 47);
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
            this.label3.Size = new System.Drawing.Size(203, 47);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên bệnh:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxIllnessName
            // 
            this.tbxIllnessName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxIllnessName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tbxIllnessName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.tbxIllnessName.BorderSize = 2;
            this.tbxIllnessName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxIllnessName.ForeColor = System.Drawing.Color.DimGray;
            this.tbxIllnessName.Location = new System.Drawing.Point(212, 3);
            this.tbxIllnessName.Multiline = false;
            this.tbxIllnessName.Name = "tbxIllnessName";
            this.tbxIllnessName.Padding = new System.Windows.Forms.Padding(7);
            this.tbxIllnessName.PasswordChar = false;
            this.tbxIllnessName.ReadOnly = false;
            this.tbxIllnessName.Size = new System.Drawing.Size(308, 38);
            this.tbxIllnessName.TabIndex = 60;
            this.tbxIllnessName.Texts = "";
            this.tbxIllnessName.UnderlinedStyle = false;
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
            this.btnNotSaveIllness.Location = new System.Drawing.Point(765, 80);
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
            this.btnSaveIllness.Location = new System.Drawing.Point(765, 14);
            this.btnSaveIllness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveIllness.Name = "btnSaveIllness";
            this.btnSaveIllness.Size = new System.Drawing.Size(134, 55);
            this.btnSaveIllness.TabIndex = 19;
            this.btnSaveIllness.Text = "Lưu";
            this.btnSaveIllness.TextColor = System.Drawing.Color.Black;
            this.btnSaveIllness.UseVisualStyleBackColor = false;
            this.btnSaveIllness.Click += new System.EventHandler(this.btnSaveIllness_Click);
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
            this.btnAddIllness.Location = new System.Drawing.Point(625, 14);
            this.btnAddIllness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddIllness.Name = "btnAddIllness";
            this.btnAddIllness.Size = new System.Drawing.Size(134, 55);
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
            this.Load += new System.EventHandler(this.IllnessForm_Load);
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
        private Classes.RJButton btnAddIllness;
        private Label label3;
        private Classes.RJButton btnNotSaveIllness;
        private Panel panel5;
        private Label label10;
        private DataGridView dtgvIllnessList;
        private Classes.CustomTextBox tbxIllnessSympton;
        private Classes.CustomTextBox tbxIllnessName;
        private Classes.GradientPanel gradientPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Classes.RJButton btnDel;
        private DataGridViewTextBoxColumn TenBenh;
        private DataGridViewTextBoxColumn TrieuChung;
    }
}