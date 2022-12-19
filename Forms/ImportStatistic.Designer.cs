namespace ClinicManagement.Forms
{
    partial class ImportStatistic
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
            this.gradientPanel1 = new ClinicManagement.Classes.GradientPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbYear = new CustomControls.RJControls.RJComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbMonth = new CustomControls.RJControls.RJComboBox();
            this.btnSeeInformation = new ClinicManagement.Classes.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExport = new ClinicManagement.Classes.RJButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradientPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(166)))), ((int)(((byte)(250)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.gradientPanel1.Controls.Add(this.groupBox1);
            this.gradientPanel1.Controls.Add(this.cbbYear);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.cbbMonth);
            this.gradientPanel1.Controls.Add(this.btnSeeInformation);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.btnExport);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1196, 873);
            this.gradientPanel1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbltotalprice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(51, 702);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 128);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng hợp";
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltotalprice.Location = new System.Drawing.Point(431, 57);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(210, 25);
            this.lbltotalprice.TabIndex = 2;
            this.lbltotalprice.Text = ".................................";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(160, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng chi phí nhập thuốc:";
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
            this.cbbYear.Location = new System.Drawing.Point(426, 52);
            this.cbbYear.MinimumSize = new System.Drawing.Size(50, 20);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Padding = new System.Windows.Forms.Padding(3);
            this.cbbYear.Size = new System.Drawing.Size(108, 41);
            this.cbbYear.TabIndex = 22;
            this.cbbYear.Texts = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(354, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Năm:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(54, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 541);
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
            this.dataGridView1.ColumnHeadersHeight = 55;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MT,
            this.TDV,
            this.SLN,
            this.TT});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
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
            this.dataGridView1.Size = new System.Drawing.Size(1076, 541);
            this.dataGridView1.TabIndex = 1;
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
            this.cbbMonth.Location = new System.Drawing.Point(211, 52);
            this.cbbMonth.MinimumSize = new System.Drawing.Size(50, 20);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Padding = new System.Windows.Forms.Padding(3);
            this.cbbMonth.Size = new System.Drawing.Size(108, 41);
            this.cbbMonth.TabIndex = 20;
            this.cbbMonth.Texts = "";
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
            this.btnSeeInformation.Location = new System.Drawing.Point(677, 47);
            this.btnSeeInformation.Name = "btnSeeInformation";
            this.btnSeeInformation.Size = new System.Drawing.Size(180, 50);
            this.btnSeeInformation.TabIndex = 18;
            this.btnSeeInformation.Text = "Xem báo cáo";
            this.btnSeeInformation.TextColor = System.Drawing.Color.Black;
            this.btnSeeInformation.UseVisualStyleBackColor = false;
            this.btnSeeInformation.Click += new System.EventHandler(this.btnSeeInformation3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(123, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tháng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnExport.Location = new System.Drawing.Point(890, 47);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(180, 50);
            this.btnExport.TabIndex = 19;
            this.btnExport.Text = "In báo cáo";
            this.btnExport.TextColor = System.Drawing.Color.Black;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "Index";
            this.STT.FillWeight = 60F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MT
            // 
            this.MT.DataPropertyName = "MedicineName";
            this.MT.HeaderText = "Tên Thuốc";
            this.MT.MinimumWidth = 6;
            this.MT.Name = "MT";
            this.MT.ReadOnly = true;
            // 
            // TDV
            // 
            this.TDV.DataPropertyName = "UnitName";
            this.TDV.FillWeight = 120F;
            this.TDV.HeaderText = "Tên Đơn Vị";
            this.TDV.MinimumWidth = 6;
            this.TDV.Name = "TDV";
            this.TDV.ReadOnly = true;
            // 
            // SLN
            // 
            this.SLN.DataPropertyName = "Quantity";
            this.SLN.FillWeight = 120F;
            this.SLN.HeaderText = "Số Lượng Nhập";
            this.SLN.MinimumWidth = 6;
            this.SLN.Name = "SLN";
            this.SLN.ReadOnly = true;
            // 
            // TT
            // 
            this.TT.DataPropertyName = "Price";
            this.TT.HeaderText = "Tổng Tiền";
            this.TT.MinimumWidth = 6;
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            // 
            // ImportStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 873);
            this.Controls.Add(this.gradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ImportStatistic";
            this.Text = "Báo cáo nhập thuốc";
            this.Load += new System.EventHandler(this.ImportStatistic_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Classes.GradientPanel gradientPanel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private SaveFileDialog saveFileDialog1;
        private CustomControls.RJControls.RJComboBox cbbYear;
        private Label label1;
        private CustomControls.RJControls.RJComboBox cbbMonth;
        private Classes.RJButton btnSeeInformation;
        private Label label2;
        private Classes.RJButton btnExport;
        private GroupBox groupBox1;
        private Label label4;
        private Label lbltotalprice;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MT;
        private DataGridViewTextBoxColumn TDV;
        private DataGridViewTextBoxColumn SLN;
        private DataGridViewTextBoxColumn TT;
    }
}