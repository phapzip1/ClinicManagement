namespace ClinicManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this._navContainer = new System.Windows.Forms.Panel();
            this._logout = new System.Windows.Forms.Button();
            this._profile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._restore = new System.Windows.Forms.Button();
            this._backup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._importReporting = new System.Windows.Forms.Button();
            this._usageReporting = new System.Windows.Forms.Button();
            this._statistic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._rules = new System.Windows.Forms.Button();
            this._import = new System.Windows.Forms.Button();
            this._usage = new System.Windows.Forms.Button();
            this._illness = new System.Windows.Forms.Button();
            this._ticket = new System.Windows.Forms.Button();
            this._patienBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._logoContainer = new System.Windows.Forms.TableLayoutPanel();
            this._titleBar = new System.Windows.Forms.TableLayoutPanel();
            this._title = new System.Windows.Forms.Label();
            this._controlBar = new System.Windows.Forms.Panel();
            this._nimimizedBtn = new System.Windows.Forms.Button();
            this._resizeBtn = new System.Windows.Forms.Button();
            this._closeBtn = new System.Windows.Forms.Button();
            this._innerFrame = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this._mainLayout.SuspendLayout();
            this._navContainer.SuspendLayout();
            this._titleBar.SuspendLayout();
            this._controlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainLayout
            // 
            this._mainLayout.ColumnCount = 2;
            this._mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this._mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainLayout.Controls.Add(this._navContainer, 0, 1);
            this._mainLayout.Controls.Add(this._logoContainer, 0, 0);
            this._mainLayout.Controls.Add(this._titleBar, 1, 0);
            this._mainLayout.Controls.Add(this._innerFrame, 1, 1);
            this._mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainLayout.Location = new System.Drawing.Point(0, 0);
            this._mainLayout.Margin = new System.Windows.Forms.Padding(0);
            this._mainLayout.Name = "_mainLayout";
            this._mainLayout.RowCount = 2;
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this._mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainLayout.Size = new System.Drawing.Size(1280, 720);
            this._mainLayout.TabIndex = 0;
            this._mainLayout.Click += new System.EventHandler(this.HandleClose);
            // 
            // _navContainer
            // 
            this._navContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this._navContainer.Controls.Add(this._logout);
            this._navContainer.Controls.Add(this._profile);
            this._navContainer.Controls.Add(this.label4);
            this._navContainer.Controls.Add(this._restore);
            this._navContainer.Controls.Add(this._backup);
            this._navContainer.Controls.Add(this.label3);
            this._navContainer.Controls.Add(this._importReporting);
            this._navContainer.Controls.Add(this._usageReporting);
            this._navContainer.Controls.Add(this._statistic);
            this._navContainer.Controls.Add(this.label2);
            this._navContainer.Controls.Add(this._rules);
            this._navContainer.Controls.Add(this._import);
            this._navContainer.Controls.Add(this._usage);
            this._navContainer.Controls.Add(this._illness);
            this._navContainer.Controls.Add(this._ticket);
            this._navContainer.Controls.Add(this._patienBtn);
            this._navContainer.Controls.Add(this.label1);
            this._navContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._navContainer.ForeColor = System.Drawing.Color.White;
            this._navContainer.Location = new System.Drawing.Point(0, 80);
            this._navContainer.Margin = new System.Windows.Forms.Padding(0);
            this._navContainer.Name = "_navContainer";
            this._navContainer.Size = new System.Drawing.Size(250, 640);
            this._navContainer.TabIndex = 1;
            // 
            // _logout
            // 
            this._logout.Dock = System.Windows.Forms.DockStyle.Top;
            this._logout.FlatAppearance.BorderSize = 0;
            this._logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(49)))), ((int)(((byte)(116)))));
            this._logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._logout.ForeColor = System.Drawing.Color.White;
            this._logout.Image = global::ClinicManagement.Resource1.logout;
            this._logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._logout.Location = new System.Drawing.Point(0, 780);
            this._logout.Name = "_logout";
            this._logout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._logout.Size = new System.Drawing.Size(250, 60);
            this._logout.TabIndex = 17;
            this._logout.Tag = "NavBtn";
            this._logout.Text = "     Đăng xuất";
            this._logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._logout.UseVisualStyleBackColor = true;
            this._logout.Click += new System.EventHandler(this.HandleNavigate);
            // 
            // _profile
            // 
            this._profile.Dock = System.Windows.Forms.DockStyle.Top;
            this._profile.FlatAppearance.BorderSize = 0;
            this._profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(90)))), ((int)(((byte)(179)))));
            this._profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._profile.ForeColor = System.Drawing.Color.White;
            this._profile.Image = global::ClinicManagement.Resource1.man;
            this._profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._profile.Location = new System.Drawing.Point(0, 720);
            this._profile.Name = "_profile";
            this._profile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._profile.Size = new System.Drawing.Size(250, 60);
            this._profile.TabIndex = 16;
            this._profile.Tag = "NavBtn";
            this._profile.Text = "     Quản lý tài khoản";
            this._profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._profile.UseVisualStyleBackColor = true;
            this._profile.Click += new System.EventHandler(this.HandleNavigate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 705);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hệ thống";
            // 
            // _restore
            // 
            this._restore.Dock = System.Windows.Forms.DockStyle.Top;
            this._restore.FlatAppearance.BorderSize = 0;
            this._restore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._restore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(90)))), ((int)(((byte)(179)))));
            this._restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._restore.ForeColor = System.Drawing.Color.White;
            this._restore.Image = global::ClinicManagement.Resource1.restore;
            this._restore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._restore.Location = new System.Drawing.Point(0, 645);
            this._restore.Name = "_restore";
            this._restore.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._restore.Size = new System.Drawing.Size(250, 60);
            this._restore.TabIndex = 14;
            this._restore.Tag = "NavBtn";
            this._restore.Text = "     Phục hồi";
            this._restore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._restore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._restore.UseVisualStyleBackColor = true;
            this._restore.Click += new System.EventHandler(this.HandleNavigate);
            // 
            // _backup
            // 
            this._backup.Dock = System.Windows.Forms.DockStyle.Top;
            this._backup.FlatAppearance.BorderSize = 0;
            this._backup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._backup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(90)))), ((int)(((byte)(179)))));
            this._backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._backup.ForeColor = System.Drawing.Color.White;
            this._backup.Image = global::ClinicManagement.Resource1.backup;
            this._backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._backup.Location = new System.Drawing.Point(0, 585);
            this._backup.Name = "_backup";
            this._backup.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._backup.Size = new System.Drawing.Size(250, 60);
            this._backup.TabIndex = 13;
            this._backup.Tag = "NavBtn";
            this._backup.Text = "     Sao lưu";
            this._backup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._backup.UseVisualStyleBackColor = true;
            this._backup.Click += new System.EventHandler(this.HandleNavigate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cơ sở dữ liệu";
            // 
            // _importReporting
            // 
            this._importReporting.Dock = System.Windows.Forms.DockStyle.Top;
            this._importReporting.FlatAppearance.BorderSize = 0;
            this._importReporting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._importReporting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(90)))), ((int)(((byte)(179)))));
            this._importReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._importReporting.ForeColor = System.Drawing.Color.White;
            this._importReporting.Image = global::ClinicManagement.Resource1.reportusage;
            this._importReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._importReporting.Location = new System.Drawing.Point(0, 510);
            this._importReporting.Name = "_importReporting";
            this._importReporting.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._importReporting.Size = new System.Drawing.Size(250, 60);
            this._importReporting.TabIndex = 11;
            this._importReporting.Tag = "NavBtn";
            this._importReporting.Text = "     Báo cáo nhập thuốc";
            this._importReporting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._importReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._importReporting.UseVisualStyleBackColor = true;
            this._importReporting.Click += new System.EventHandler(this.HandleNavigate);
            // 
            // _usageReporting
            // 
            this._usageReporting.Dock = System.Windows.Forms.DockStyle.Top;
            this._usageReporting.FlatAppearance.BorderSize = 0;
            this._usageReporting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._usageReporting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(90)))), ((int)(((byte)(179)))));
            this._usageReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._usageReporting.ForeColor = System.Drawing.Color.White;
            this._usageReporting.Image = global::ClinicManagement.Resource1.reportimport;
            this._usageReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._usageReporting.Location = new System.Drawing.Point(0, 450);
            this._usageReporting.Name = "_usageReporting";
            this._usageReporting.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._usageReporting.Size = new System.Drawing.Size(250, 60);
            this._usageReporting.TabIndex = 10;
            this._usageReporting.Tag = "NavBtn";
            this._usageReporting.Text = "     Báo cáo sử dụng thuốc";
            this._usageReporting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._usageReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._usageReporting.UseVisualStyleBackColor = true;
            this._usageReporting.Click += new System.EventHandler(this.HandleNavigate);
            // 
            // _statistic
            // 
            this._statistic.Dock = System.Windows.Forms.DockStyle.Top;
            this._statistic.FlatAppearance.BorderSize = 0;
            this._statistic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._statistic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(90)))), ((int)(((byte)(179)))));
            this._statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._statistic.ForeColor = System.Drawing.Color.White;
            this._statistic.Image = global::ClinicManagement.Resource1.report;
            this._statistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._statistic.Location = new System.Drawing.Point(0, 390);
            this._statistic.Name = "_statistic";
            this._statistic.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._statistic.Size = new System.Drawing.Size(250, 60);
            this._statistic.TabIndex = 9;
            this._statistic.Tag = "NavBtn";
            this._statistic.Text = "     Báo cáo doanh thu";
            this._statistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._statistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._statistic.UseVisualStyleBackColor = true;
            this._statistic.Click += new System.EventHandler(this.HandleNavigate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thống kê";
            // 
            // _rules
            // 
            this._rules.Dock = System.Windows.Forms.DockStyle.Top;
            this._rules.FlatAppearance.BorderSize = 0;
            this._rules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._rules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(90)))), ((int)(((byte)(179)))));
            this._rules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._rules.ForeColor = System.Drawing.Color.White;
            this._rules.Image = global::ClinicManagement.Resource1.auction;
            this._rules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._rules.Location = new System.Drawing.Point(0, 315);
            this._rules.Name = "_rules";
            this._rules.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._rules.Size = new System.Drawing.Size(250, 60);
            this._rules.TabIndex = 7;
            this._rules.Tag = "NavBtn";
            this._rules.Text = "     Quy định";
            this._rules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._rules.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._rules.UseVisualStyleBackColor = true;
            this._rules.Click += new System.EventHandler(this.HandleNavigate);
            // 
            // _import
            // 
            this._import.Dock = System.Windows.Forms.DockStyle.Top;
            this._import.FlatAppearance.BorderSize = 0;
            this._import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(90)))), ((int)(((byte)(179)))));
            this._import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._import.ForeColor = System.Drawing.Color.White;
            this._import.Image = global::ClinicManagement.Resource1.import;
            this._import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._import.Location = new System.Drawing.Point(0, 255);
            this._import.Name = "_import";
            this._import.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._import.Size = new System.Drawing.Size(250, 60);
            this._import.TabIndex = 6;
            this._import.Tag = "NavBtn";
            this._import.Text = "     Phiếu nhập thuốc";
            this._import.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._import.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._import.UseVisualStyleBackColor = true;
            this._import.Click += new System.EventHandler(this.HandleNavigate);
            // 
            // _usage
            // 
            this._usage.Dock = System.Windows.Forms.DockStyle.Top;
            this._usage.FlatAppearance.BorderSize = 0;
            this._usage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._usage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(90)))), ((int)(((byte)(179)))));
            this._usage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._usage.ForeColor = System.Drawing.Color.White;
            this._usage.Image = global::ClinicManagement.Resource1.investigation;
            this._usage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._usage.Location = new System.Drawing.Point(0, 195);
            this._usage.Name = "_usage";
            this._usage.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._usage.Size = new System.Drawing.Size(250, 60);
            this._usage.TabIndex = 5;
            this._usage.Tag = "NavBtn";
            this._usage.Text = "     Đơn vị và cách dùng";
            this._usage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._usage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._usage.UseVisualStyleBackColor = true;
            this._usage.Click += new System.EventHandler(this.HandleNavigate);
            // 
            // _illness
            // 
            this._illness.Dock = System.Windows.Forms.DockStyle.Top;
            this._illness.FlatAppearance.BorderSize = 0;
            this._illness.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._illness.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(90)))), ((int)(((byte)(179)))));
            this._illness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._illness.ForeColor = System.Drawing.Color.White;
            this._illness.Image = global::ClinicManagement.Resource1.coronavirus;
            this._illness.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._illness.Location = new System.Drawing.Point(0, 135);
            this._illness.Name = "_illness";
            this._illness.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._illness.Size = new System.Drawing.Size(250, 60);
            this._illness.TabIndex = 4;
            this._illness.Tag = "NavBtn";
            this._illness.Text = "     Loại bệnh và bệnh";
            this._illness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._illness.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._illness.UseVisualStyleBackColor = true;
            this._illness.Click += new System.EventHandler(this.HandleNavigate);
            // 
            // _ticket
            // 
            this._ticket.Dock = System.Windows.Forms.DockStyle.Top;
            this._ticket.FlatAppearance.BorderSize = 0;
            this._ticket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._ticket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(90)))), ((int)(((byte)(179)))));
            this._ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ticket.ForeColor = System.Drawing.Color.White;
            this._ticket.Image = global::ClinicManagement.Resource1.file;
            this._ticket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ticket.Location = new System.Drawing.Point(0, 75);
            this._ticket.Name = "_ticket";
            this._ticket.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._ticket.Size = new System.Drawing.Size(250, 60);
            this._ticket.TabIndex = 3;
            this._ticket.Tag = "NavBtn";
            this._ticket.Text = "     Phiếu khám bệnh";
            this._ticket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._ticket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._ticket.UseVisualStyleBackColor = true;
            this._ticket.Click += new System.EventHandler(this.HandleNavigate);
            // 
            // _patienBtn
            // 
            this._patienBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this._patienBtn.FlatAppearance.BorderSize = 0;
            this._patienBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._patienBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(90)))), ((int)(((byte)(179)))));
            this._patienBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._patienBtn.ForeColor = System.Drawing.Color.White;
            this._patienBtn.Image = global::ClinicManagement.Resource1.examination;
            this._patienBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._patienBtn.Location = new System.Drawing.Point(0, 15);
            this._patienBtn.Name = "_patienBtn";
            this._patienBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._patienBtn.Size = new System.Drawing.Size(250, 60);
            this._patienBtn.TabIndex = 2;
            this._patienBtn.Tag = "NavBtn";
            this._patienBtn.Text = "     Bệnh nhân";
            this._patienBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._patienBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._patienBtn.UseVisualStyleBackColor = true;
            this._patienBtn.Click += new System.EventHandler(this.HandleNavigate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý";
            // 
            // _logoContainer
            // 
            this._logoContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this._logoContainer.ColumnCount = 1;
            this._logoContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._logoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._logoContainer.Location = new System.Drawing.Point(0, 0);
            this._logoContainer.Margin = new System.Windows.Forms.Padding(0);
            this._logoContainer.Name = "_logoContainer";
            this._logoContainer.RowCount = 1;
            this._logoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._logoContainer.Size = new System.Drawing.Size(250, 80);
            this._logoContainer.TabIndex = 2;
            // 
            // _titleBar
            // 
            this._titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(124)))), ((int)(((byte)(227)))));
            this._titleBar.ColumnCount = 1;
            this._titleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._titleBar.Controls.Add(this._title, 0, 1);
            this._titleBar.Controls.Add(this._controlBar, 0, 0);
            this._titleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._titleBar.Location = new System.Drawing.Point(250, 0);
            this._titleBar.Margin = new System.Windows.Forms.Padding(0);
            this._titleBar.Name = "_titleBar";
            this._titleBar.RowCount = 2;
            this._titleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this._titleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this._titleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._titleBar.Size = new System.Drawing.Size(1030, 80);
            this._titleBar.TabIndex = 3;
            this._titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarMouseDown);
            // 
            // _title
            // 
            this._title.AutoSize = true;
            this._title.Dock = System.Windows.Forms.DockStyle.Fill;
            this._title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._title.ForeColor = System.Drawing.Color.White;
            this._title.Location = new System.Drawing.Point(0, 32);
            this._title.Margin = new System.Windows.Forms.Padding(0);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(1030, 48);
            this._title.TabIndex = 0;
            this._title.Text = "Page Name";
            this._title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarMouseDown);
            // 
            // _controlBar
            // 
            this._controlBar.Controls.Add(this._nimimizedBtn);
            this._controlBar.Controls.Add(this._resizeBtn);
            this._controlBar.Controls.Add(this._closeBtn);
            this._controlBar.Dock = System.Windows.Forms.DockStyle.Right;
            this._controlBar.Location = new System.Drawing.Point(927, 0);
            this._controlBar.Margin = new System.Windows.Forms.Padding(0);
            this._controlBar.Name = "_controlBar";
            this._controlBar.Size = new System.Drawing.Size(103, 32);
            this._controlBar.TabIndex = 1;
            // 
            // _nimimizedBtn
            // 
            this._nimimizedBtn.BackgroundImage = global::ClinicManagement.Resource1.line;
            this._nimimizedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._nimimizedBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this._nimimizedBtn.FlatAppearance.BorderSize = 0;
            this._nimimizedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._nimimizedBtn.Location = new System.Drawing.Point(7, 0);
            this._nimimizedBtn.Name = "_nimimizedBtn";
            this._nimimizedBtn.Size = new System.Drawing.Size(32, 32);
            this._nimimizedBtn.TabIndex = 2;
            this._nimimizedBtn.UseVisualStyleBackColor = true;
            this._nimimizedBtn.Click += new System.EventHandler(this.HandleMinimize);
            // 
            // _resizeBtn
            // 
            this._resizeBtn.BackgroundImage = global::ClinicManagement.Resource1.fullscreen;
            this._resizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._resizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this._resizeBtn.FlatAppearance.BorderSize = 0;
            this._resizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._resizeBtn.Location = new System.Drawing.Point(39, 0);
            this._resizeBtn.Name = "_resizeBtn";
            this._resizeBtn.Size = new System.Drawing.Size(32, 32);
            this._resizeBtn.TabIndex = 1;
            this._resizeBtn.UseVisualStyleBackColor = true;
            this._resizeBtn.Click += new System.EventHandler(this.HandleResize);
            // 
            // _closeBtn
            // 
            this._closeBtn.BackgroundImage = global::ClinicManagement.Resource1.close;
            this._closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this._closeBtn.FlatAppearance.BorderSize = 0;
            this._closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(31)))), ((int)(((byte)(76)))));
            this._closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._closeBtn.Location = new System.Drawing.Point(71, 0);
            this._closeBtn.Name = "_closeBtn";
            this._closeBtn.Size = new System.Drawing.Size(32, 32);
            this._closeBtn.TabIndex = 0;
            this._closeBtn.UseVisualStyleBackColor = true;
            this._closeBtn.Click += new System.EventHandler(this.HandleClose);
            // 
            // _innerFrame
            // 
            this._innerFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this._innerFrame.Location = new System.Drawing.Point(250, 80);
            this._innerFrame.Margin = new System.Windows.Forms.Padding(0);
            this._innerFrame.Name = "_innerFrame";
            this._innerFrame.Size = new System.Drawing.Size(1030, 640);
            this._innerFrame.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this._mainLayout);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this._mainLayout.ResumeLayout(false);
            this._navContainer.ResumeLayout(false);
            this._navContainer.PerformLayout();
            this._titleBar.ResumeLayout(false);
            this._titleBar.PerformLayout();
            this._controlBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource bindingSource1;
        private TableLayoutPanel _mainLayout;
        private Panel _navContainer;
        private Label label1;
        private Button _patienBtn;
        private Button _importReporting;
        private Button _usageReporting;
        private Button _statistic;
        private Label label2;
        private Button _rules;
        private Button _import;
        private Button _usage;
        private Button _illness;
        private Button _ticket;
        private Button _logout;
        private Button _profile;
        private Label label4;
        private Button _restore;
        private Button _backup;
        private Label label3;
        private TableLayoutPanel _logoContainer;
        private TableLayoutPanel _titleBar;
        private Label _title;
        private Panel _controlBar;
        private Button _nimimizedBtn;
        private Button _resizeBtn;
        private Button _closeBtn;
        private Panel _innerFrame;
    }
}