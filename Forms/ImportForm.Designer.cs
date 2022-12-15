namespace ClinicManagement.Forms
{
    partial class ImportForm
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
            this.gradientPanel1 = new ClinicManagement.Classes.GradientPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._unitTb = new ClinicManagement.Classes.CustomTextBox();
            this._medicineCombobox = new CustomControls.RJControls.RJComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rjButton1 = new ClinicManagement.Classes.RJButton();
            this.rjButton2 = new ClinicManagement.Classes.RJButton();
            this.rjButton3 = new ClinicManagement.Classes.RJButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this._totalTb = new ClinicManagement.Classes.CustomTextBox();
            this._quantityTb = new System.Windows.Forms.NumericUpDown();
            this._priceTb = new System.Windows.Forms.NumericUpDown();
            this.gradientPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._quantityTb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._priceTb)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Empty;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.tableLayoutPanel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.gradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.gradientPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 430);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 129);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.Controls.Add(this._priceTb, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this._unitTb, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this._medicineCombobox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this._quantityTb, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(570, 129);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Thuốc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn Vị";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(300, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 64);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(300, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 65);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn Giá Nhập";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _unitTb
            // 
            this._unitTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._unitTb.BackColor = System.Drawing.SystemColors.Window;
            this._unitTb.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._unitTb.BorderFocusColor = System.Drawing.Color.Turquoise;
            this._unitTb.BorderSize = 1;
            this._unitTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._unitTb.ForeColor = System.Drawing.Color.DimGray;
            this._unitTb.Location = new System.Drawing.Point(81, 78);
            this._unitTb.Margin = new System.Windows.Forms.Padding(0);
            this._unitTb.Multiline = false;
            this._unitTb.Name = "_unitTb";
            this._unitTb.Padding = new System.Windows.Forms.Padding(7);
            this._unitTb.PasswordChar = false;
            this._unitTb.ReadOnly = true;
            this._unitTb.Size = new System.Drawing.Size(189, 36);
            this._unitTb.TabIndex = 5;
            this._unitTb.Texts = "";
            this._unitTb.UnderlinedStyle = false;
            // 
            // _medicineCombobox
            // 
            this._medicineCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._medicineCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this._medicineCombobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._medicineCombobox.BorderSize = 1;
            this._medicineCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._medicineCombobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._medicineCombobox.ForeColor = System.Drawing.Color.DimGray;
            this._medicineCombobox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._medicineCombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._medicineCombobox.ListTextColor = System.Drawing.Color.DimGray;
            this._medicineCombobox.Location = new System.Drawing.Point(81, 22);
            this._medicineCombobox.Margin = new System.Windows.Forms.Padding(0);
            this._medicineCombobox.MinimumSize = new System.Drawing.Size(50, 20);
            this._medicineCombobox.Name = "_medicineCombobox";
            this._medicineCombobox.Padding = new System.Windows.Forms.Padding(1);
            this._medicineCombobox.Size = new System.Drawing.Size(189, 20);
            this._medicineCombobox.TabIndex = 8;
            this._medicineCombobox.Texts = "";
            this._medicineCombobox.OnSelectedIndexChanged += new System.EventHandler(this.Item_Changed);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.rjButton1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rjButton2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.rjButton3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(590, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(190, 129);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(3, 12);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(89, 40);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "Thêm";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.Add_ImportDetail_Handler);
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(98, 12);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(89, 40);
            this.rjButton2.TabIndex = 1;
            this.rjButton2.Text = "Lưu";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.Save_Handler);
            // 
            // rjButton3
            // 
            this.rjButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 0;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(3, 76);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(89, 40);
            this.rjButton3.TabIndex = 2;
            this.rjButton3.Text = "Xóa";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.Remove_Row_Handler);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.unit,
            this.quantity,
            this.price,
            this.total});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(774, 252);
            this.dataGridView1.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "Name";
            this.name.FillWeight = 300F;
            this.name.HeaderText = "Tên thuốc";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit.DataPropertyName = "UnitName";
            this.unit.FillWeight = 150F;
            this.unit.HeaderText = "Đơn Vị";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "Quantity";
            this.quantity.FillWeight = 150F;
            this.quantity.HeaderText = "Số lượng nhập";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "Price";
            this.price.FillWeight = 200F;
            this.price.HeaderText = "Đơn giá nhập";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.DataPropertyName = "Sum";
            this.total.FillWeight = 200F;
            this.total.HeaderText = "Tổng cộng";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this._totalTb, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 387);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(300, 43);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng Cộng";
            // 
            // _totalTb
            // 
            this._totalTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._totalTb.BackColor = System.Drawing.SystemColors.Window;
            this._totalTb.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._totalTb.BorderFocusColor = System.Drawing.Color.Turquoise;
            this._totalTb.BorderSize = 1;
            this._totalTb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._totalTb.ForeColor = System.Drawing.Color.DimGray;
            this._totalTb.Location = new System.Drawing.Point(99, 4);
            this._totalTb.Margin = new System.Windows.Forms.Padding(0);
            this._totalTb.Multiline = false;
            this._totalTb.Name = "_totalTb";
            this._totalTb.Padding = new System.Windows.Forms.Padding(7);
            this._totalTb.PasswordChar = false;
            this._totalTb.ReadOnly = true;
            this._totalTb.Size = new System.Drawing.Size(201, 34);
            this._totalTb.TabIndex = 1;
            this._totalTb.Texts = "0";
            this._totalTb.UnderlinedStyle = false;
            // 
            // _quantityTb
            // 
            this._quantityTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._quantityTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._quantityTb.Location = new System.Drawing.Point(381, 17);
            this._quantityTb.Margin = new System.Windows.Forms.Padding(0);
            this._quantityTb.Name = "_quantityTb";
            this._quantityTb.Size = new System.Drawing.Size(189, 29);
            this._quantityTb.TabIndex = 9;
            // 
            // _priceTb
            // 
            this._priceTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._priceTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._priceTb.Location = new System.Drawing.Point(381, 82);
            this._priceTb.Margin = new System.Windows.Forms.Padding(0);
            this._priceTb.Name = "_priceTb";
            this._priceTb.Size = new System.Drawing.Size(189, 29);
            this._priceTb.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 27);
            this.textBox3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(315, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 6;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(627, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 34);
            this.rjButton1.TabIndex = 7;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(627, 43);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 34);
            this.rjButton2.TabIndex = 8;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 0;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(627, 83);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(150, 34);
            this.rjButton3.TabIndex = 9;
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(107, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(315, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(419, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(419, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(107, 83);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 27);
            this.textBox4.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(3, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.Load += new System.EventHandler(this.Form_Loaded);
            this.gradientPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._quantityTb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._priceTb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Classes.GradientPanel gradientPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Classes.CustomTextBox _unitTb;
        private TableLayoutPanel tableLayoutPanel4;
        private Classes.RJButton rjButton1;
        private Classes.RJButton rjButton2;
        private Classes.RJButton rjButton3;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label5;
        private Classes.CustomTextBox _totalTb;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn unit;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn total;
        private CustomControls.RJControls.RJComboBox _medicineCombobox;
        private NumericUpDown _priceTb;
        private NumericUpDown _quantityTb;
    }
}