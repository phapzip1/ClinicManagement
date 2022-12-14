namespace ClinicManagement.Forms
{
    partial class StatisticForm
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gradientPanel1 = new ClinicManagement.Classes.GradientPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltotalrevenue = new System.Windows.Forms.Label();
            this.lbltotalpatients = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbYear = new CustomControls.RJControls.RJComboBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.cbbMonth = new CustomControls.RJControls.RJComboBox();
            this.labelMonth = new System.Windows.Forms.Label();
            this.btnExport = new ClinicManagement.Classes.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSeeInformation = new ClinicManagement.Classes.RJButton();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradientPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(166)))), ((int)(((byte)(250)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.gradientPanel1.Controls.Add(this.groupBox1);
            this.gradientPanel1.Controls.Add(this.cbbYear);
            this.gradientPanel1.Controls.Add(this.labelYear);
            this.gradientPanel1.Controls.Add(this.cbbMonth);
            this.gradientPanel1.Controls.Add(this.labelMonth);
            this.gradientPanel1.Controls.Add(this.btnExport);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.btnSeeInformation);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1040, 634);
            this.gradientPanel1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbltotalrevenue);
            this.groupBox1.Controls.Add(this.lbltotalpatients);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(47, 495);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(942, 122);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng hợp báo cáo";
            // 
            // lbltotalrevenue
            // 
            this.lbltotalrevenue.AutoSize = true;
            this.lbltotalrevenue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltotalrevenue.Location = new System.Drawing.Point(438, 80);
            this.lbltotalrevenue.Name = "lbltotalrevenue";
            this.lbltotalrevenue.Size = new System.Drawing.Size(210, 22);
            this.lbltotalrevenue.TabIndex = 3;
            this.lbltotalrevenue.Text = "........................................";
            // 
            // lbltotalpatients
            // 
            this.lbltotalpatients.AutoSize = true;
            this.lbltotalpatients.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltotalpatients.Location = new System.Drawing.Point(438, 38);
            this.lbltotalpatients.Name = "lbltotalpatients";
            this.lbltotalpatients.Size = new System.Drawing.Size(210, 22);
            this.lbltotalpatients.TabIndex = 2;
            this.lbltotalpatients.Text = "........................................";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(133, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng số bệnh nhân trong tháng: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(133, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng doanh thu tháng: ";
            // 
            // cbbYear
            // 
            this.cbbYear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.cbbYear.BorderSize = 3;
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbYear.ForeColor = System.Drawing.Color.DimGray;
            this.cbbYear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbbYear.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(218)))), ((int)(((byte)(252)))));
            this.cbbYear.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbYear.Location = new System.Drawing.Point(363, 40);
            this.cbbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbYear.MinimumSize = new System.Drawing.Size(44, 15);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbYear.Size = new System.Drawing.Size(94, 31);
            this.cbbYear.TabIndex = 16;
            this.cbbYear.Texts = "";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.BackColor = System.Drawing.Color.Transparent;
            this.labelYear.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYear.Location = new System.Drawing.Point(300, 46);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(54, 22);
            this.labelYear.TabIndex = 14;
            this.labelYear.Text = "Năm:";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbMonth
            // 
            this.cbbMonth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.cbbMonth.BorderSize = 3;
            this.cbbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbMonth.ForeColor = System.Drawing.Color.DimGray;
            this.cbbMonth.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbMonth.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(218)))), ((int)(((byte)(252)))));
            this.cbbMonth.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbMonth.Location = new System.Drawing.Point(175, 40);
            this.cbbMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMonth.MinimumSize = new System.Drawing.Size(44, 15);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMonth.Size = new System.Drawing.Size(94, 31);
            this.cbbMonth.TabIndex = 13;
            this.cbbMonth.Texts = "";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.BackColor = System.Drawing.Color.Transparent;
            this.labelMonth.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMonth.Location = new System.Drawing.Point(98, 46);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(68, 22);
            this.labelMonth.TabIndex = 5;
            this.labelMonth.Text = "Tháng:";
            this.labelMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnExport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnExport.BorderRadius = 20;
            this.btnExport.BorderSize = 2;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Location = new System.Drawing.Point(769, 37);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(158, 38);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "In báo cáo";
            this.btnExport.TextColor = System.Drawing.Color.Black;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(47, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 369);
            this.panel2.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ngay,
            this.SBN,
            this.DT,
            this.TL});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(942, 369);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSeeInformation
            // 
            this.btnSeeInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSeeInformation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSeeInformation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.btnSeeInformation.BorderRadius = 20;
            this.btnSeeInformation.BorderSize = 2;
            this.btnSeeInformation.FlatAppearance.BorderSize = 0;
            this.btnSeeInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeInformation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeeInformation.ForeColor = System.Drawing.Color.Black;
            this.btnSeeInformation.Location = new System.Drawing.Point(583, 37);
            this.btnSeeInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeeInformation.Name = "btnSeeInformation";
            this.btnSeeInformation.Size = new System.Drawing.Size(158, 38);
            this.btnSeeInformation.TabIndex = 10;
            this.btnSeeInformation.Text = "Xem báo cáo";
            this.btnSeeInformation.TextColor = System.Drawing.Color.Black;
            this.btnSeeInformation.UseVisualStyleBackColor = false;
            this.btnSeeInformation.Click += new System.EventHandler(this.btnSeeInformation_Click_1);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "Index";
            this.STT.FillWeight = 70F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Day";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // SBN
            // 
            this.SBN.DataPropertyName = "PatientCount";
            this.SBN.FillWeight = 125F;
            this.SBN.HeaderText = "Số Bệnh Nhân";
            this.SBN.MinimumWidth = 6;
            this.SBN.Name = "SBN";
            this.SBN.ReadOnly = true;
            // 
            // DT
            // 
            this.DT.DataPropertyName = "Revenue";
            this.DT.HeaderText = "Doanh Thu";
            this.DT.MinimumWidth = 6;
            this.DT.Name = "DT";
            this.DT.ReadOnly = true;
            // 
            // TL
            // 
            this.TL.DataPropertyName = "Ratio";
            this.TL.HeaderText = "Tỷ Lệ (%)";
            this.TL.MinimumWidth = 6;
            this.TL.Name = "TL";
            this.TL.ReadOnly = true;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 634);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "StatisticForm";
            this.Text = "Báo cáo doanh thu";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SaveFileDialog saveFileDialog1;
        private TableLayoutPanel tableLayoutPanel4;
        private Classes.GradientPanel gradientPanel1;
        private Label labelMonth;
        private Classes.RJButton btnExport;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Classes.RJButton btnSeeInformation;
        private CustomControls.RJControls.RJComboBox cbbMonth;
        private Label labelYear;
        private CustomControls.RJControls.RJComboBox cbbYear;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label lbltotalrevenue;
        private Label lbltotalpatients;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Ngay;
        private DataGridViewTextBoxColumn SBN;
        private DataGridViewTextBoxColumn DT;
        private DataGridViewTextBoxColumn TL;
    }
}