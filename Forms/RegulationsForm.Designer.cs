namespace ClinicManagement.Forms
{
    partial class RegulationsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._max = new ClinicManagement.Classes.CustomTextBox();
            this._fee = new ClinicManagement.Classes.CustomTextBox();
            this.rjButton1 = new ClinicManagement.Classes.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rjButton1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(230, 129);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 182);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.9416F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.0584F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this._max, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this._fee, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(100, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.54054F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.45946F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(149, 80);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số bệnh nhân";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiền khám";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _max
            // 
            this._max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._max.BackColor = System.Drawing.SystemColors.Window;
            this._max.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._max.BorderFocusColor = System.Drawing.Color.Turquoise;
            this._max.BorderSize = 1;
            this._max.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._max.ForeColor = System.Drawing.Color.DimGray;
            this._max.Location = new System.Drawing.Point(50, 0);
            this._max.Margin = new System.Windows.Forms.Padding(0);
            this._max.Multiline = false;
            this._max.Name = "_max";
            this._max.Padding = new System.Windows.Forms.Padding(7);
            this._max.PasswordChar = false;
            this._max.ReadOnly = false;
            this._max.Size = new System.Drawing.Size(99, 34);
            this._max.TabIndex = 2;
            this._max.Texts = "";
            this._max.UnderlinedStyle = false;
            // 
            // _fee
            // 
            this._fee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._fee.BackColor = System.Drawing.SystemColors.Window;
            this._fee.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._fee.BorderFocusColor = System.Drawing.Color.Turquoise;
            this._fee.BorderSize = 1;
            this._fee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._fee.ForeColor = System.Drawing.Color.DimGray;
            this._fee.Location = new System.Drawing.Point(50, 42);
            this._fee.Margin = new System.Windows.Forms.Padding(0);
            this._fee.Multiline = false;
            this._fee.Name = "_fee";
            this._fee.Padding = new System.Windows.Forms.Padding(7);
            this._fee.PasswordChar = false;
            this._fee.ReadOnly = false;
            this._fee.Size = new System.Drawing.Size(99, 34);
            this._fee.TabIndex = 3;
            this._fee.Texts = "";
            this._fee.UnderlinedStyle = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(103, 93);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(143, 40);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = "Lưu";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.Save_Handler);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // RegulationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "RegulationsForm";
            this.Text = "Thay đổi quy định";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Classes.RJButton rjButton1;
        private Panel panel1;
        private Classes.CustomTextBox _max;
        private Classes.CustomTextBox _fee;
    }
}