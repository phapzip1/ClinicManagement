namespace ClinicManagement.Forms
{
    partial class MedicineForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._datagridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrieuChung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._price = new System.Windows.Forms.NumericUpDown();
            this._btnRemove = new ClinicManagement.Classes.RJButton();
            this._btnSave = new ClinicManagement.Classes.RJButton();
            this._btnAdd = new ClinicManagement.Classes.RJButton();
            this._name = new ClinicManagement.Classes.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._stock = new System.Windows.Forms.NumericUpDown();
            this._cbUnit = new CustomControls.RJControls.RJComboBox();
            this.gradientPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._datagridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._stock)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(166)))), ((int)(((byte)(250)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.gradientPanel1.Controls.Add(this.tableLayoutPanel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1040, 634);
            this.gradientPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._datagridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1040, 634);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _datagridView
            // 
            this._datagridView.AllowUserToAddRows = false;
            this._datagridView.AllowUserToDeleteRows = false;
            this._datagridView.AllowUserToResizeColumns = false;
            this._datagridView.AllowUserToResizeRows = false;
            this._datagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._datagridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._datagridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._datagridView.ColumnHeadersHeight = 60;
            this._datagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._datagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.TrieuChung,
            this.stock,
            this.price});
            this._datagridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._datagridView.EnableHeadersVisualStyles = false;
            this._datagridView.Location = new System.Drawing.Point(0, 158);
            this._datagridView.Margin = new System.Windows.Forms.Padding(0);
            this._datagridView.MultiSelect = false;
            this._datagridView.Name = "_datagridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._datagridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._datagridView.RowHeadersVisible = false;
            this._datagridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._datagridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this._datagridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this._datagridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this._datagridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(250)))));
            this._datagridView.RowTemplate.Height = 29;
            this._datagridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._datagridView.Size = new System.Drawing.Size(1040, 476);
            this._datagridView.TabIndex = 4;
            this._datagridView.SelectionChanged += new System.EventHandler(this._datagridView_SelectionChanged);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "Name";
            this.name.FillWeight = 200F;
            this.name.HeaderText = "Tên thuốc";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // TrieuChung
            // 
            this.TrieuChung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrieuChung.DataPropertyName = "UnitName";
            this.TrieuChung.HeaderText = "Đơn vị";
            this.TrieuChung.MinimumWidth = 6;
            this.TrieuChung.Name = "TrieuChung";
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock.DataPropertyName = "Stock";
            this.stock.HeaderText = "Số lượng tồn";
            this.stock.Name = "stock";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "Đơn giá";
            this.price.Name = "price";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this._price, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this._btnRemove, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this._btnSave, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this._btnAdd, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this._name, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this._stock, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this._cbUnit, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(90, 15);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(90, 15, 90, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.57143F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(860, 128);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // _price
            // 
            this._price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._price.Location = new System.Drawing.Point(444, 82);
            this._price.Margin = new System.Windows.Forms.Padding(0);
            this._price.Name = "_price";
            this._price.Size = new System.Drawing.Size(136, 23);
            this._price.TabIndex = 26;
            // 
            // _btnRemove
            // 
            this._btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this._btnRemove.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this._btnRemove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this._btnRemove.BorderRadius = 20;
            this._btnRemove.BorderSize = 2;
            this._btnRemove.FlatAppearance.BorderSize = 0;
            this._btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnRemove.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnRemove.ForeColor = System.Drawing.Color.Black;
            this._btnRemove.Location = new System.Drawing.Point(640, 74);
            this._btnRemove.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(94, 38);
            this._btnRemove.TabIndex = 24;
            this._btnRemove.Text = "Xóa";
            this._btnRemove.TextColor = System.Drawing.Color.Black;
            this._btnRemove.UseVisualStyleBackColor = false;
            this._btnRemove.Click += new System.EventHandler(this.RemoveHandler);
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this._btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this._btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this._btnSave.BorderRadius = 20;
            this._btnSave.BorderSize = 2;
            this._btnSave.FlatAppearance.BorderSize = 0;
            this._btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnSave.ForeColor = System.Drawing.Color.Black;
            this._btnSave.Location = new System.Drawing.Point(754, 10);
            this._btnSave.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(96, 38);
            this._btnSave.TabIndex = 23;
            this._btnSave.Text = "Lưu";
            this._btnSave.TextColor = System.Drawing.Color.Black;
            this._btnSave.UseVisualStyleBackColor = false;
            this._btnSave.Click += new System.EventHandler(this.UpdateHandler);
            // 
            // _btnAdd
            // 
            this._btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this._btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this._btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this._btnAdd.BorderRadius = 20;
            this._btnAdd.BorderSize = 2;
            this._btnAdd.FlatAppearance.BorderSize = 0;
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnAdd.ForeColor = System.Drawing.Color.Black;
            this._btnAdd.Location = new System.Drawing.Point(640, 10);
            this._btnAdd.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(94, 38);
            this._btnAdd.TabIndex = 22;
            this._btnAdd.Text = "Thêm";
            this._btnAdd.TextColor = System.Drawing.Color.Black;
            this._btnAdd.UseVisualStyleBackColor = false;
            this._btnAdd.Click += new System.EventHandler(this.AddHandler);
            // 
            // _name
            // 
            this._name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._name.BackColor = System.Drawing.SystemColors.Window;
            this._name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this._name.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this._name.BorderSize = 3;
            this._name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._name.ForeColor = System.Drawing.Color.DimGray;
            this._name.Location = new System.Drawing.Point(106, 14);
            this._name.Margin = new System.Windows.Forms.Padding(0);
            this._name.Multiline = false;
            this._name.Name = "_name";
            this._name.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this._name.PasswordChar = false;
            this._name.ReadOnly = false;
            this._name.Size = new System.Drawing.Size(159, 30);
            this._name.TabIndex = 6;
            this._name.Texts = "";
            this._name.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thuốc";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn vị";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(318, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng tồn";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(318, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // _stock
            // 
            this._stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._stock.Location = new System.Drawing.Point(444, 18);
            this._stock.Margin = new System.Windows.Forms.Padding(0);
            this._stock.Name = "_stock";
            this._stock.ReadOnly = true;
            this._stock.Size = new System.Drawing.Size(136, 23);
            this._stock.TabIndex = 25;
            // 
            // _cbUnit
            // 
            this._cbUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cbUnit.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this._cbUnit.BorderSize = 3;
            this._cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbUnit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbUnit.ForeColor = System.Drawing.Color.DimGray;
            this._cbUnit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._cbUnit.Items.AddRange(new object[] {
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
            this._cbUnit.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(218)))), ((int)(((byte)(252)))));
            this._cbUnit.ListTextColor = System.Drawing.Color.DimGray;
            this._cbUnit.Location = new System.Drawing.Point(106, 78);
            this._cbUnit.Margin = new System.Windows.Forms.Padding(0);
            this._cbUnit.MinimumSize = new System.Drawing.Size(44, 15);
            this._cbUnit.Name = "_cbUnit";
            this._cbUnit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cbUnit.Size = new System.Drawing.Size(159, 31);
            this._cbUnit.TabIndex = 27;
            this._cbUnit.Texts = "";
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 634);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "MedicineForm";
            this.Text = "Thuốc";
            this.gradientPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._datagridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Classes.GradientPanel gradientPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView _datagridView;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Classes.CustomTextBox _name;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn TrieuChung;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn price;
        private Classes.RJButton _btnRemove;
        private Classes.RJButton _btnSave;
        private Classes.RJButton _btnAdd;
        private NumericUpDown _price;
        private NumericUpDown _stock;
        private CustomControls.RJControls.RJComboBox _cbUnit;
    }
}