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
            this.gradientPanel1 = new ClinicManagement.Classes.GradientPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._price = new ClinicManagement.Classes.CustomTextBox();
            this._patient = new ClinicManagement.Classes.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._BtnSave = new ClinicManagement.Classes.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.gradientPanel1.Size = new System.Drawing.Size(512, 159);
            this.gradientPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this._price, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._patient, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._BtnSave, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 159);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _price
            // 
            this._price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._price.BackColor = System.Drawing.SystemColors.Window;
            this._price.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this._price.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this._price.BorderSize = 3;
            this._price.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._price.ForeColor = System.Drawing.Color.DimGray;
            this._price.Location = new System.Drawing.Point(204, 63);
            this._price.Margin = new System.Windows.Forms.Padding(0);
            this._price.Multiline = false;
            this._price.Name = "_price";
            this._price.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this._price.PasswordChar = false;
            this._price.ReadOnly = false;
            this._price.Size = new System.Drawing.Size(308, 30);
            this._price.TabIndex = 28;
            this._price.Texts = "";
            this._price.UnderlinedStyle = false;
            // 
            // _patient
            // 
            this._patient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._patient.BackColor = System.Drawing.SystemColors.Window;
            this._patient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this._patient.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this._patient.BorderSize = 3;
            this._patient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._patient.ForeColor = System.Drawing.Color.DimGray;
            this._patient.Location = new System.Drawing.Point(204, 11);
            this._patient.Margin = new System.Windows.Forms.Padding(0);
            this._patient.Multiline = false;
            this._patient.Name = "_patient";
            this._patient.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this._patient.PasswordChar = false;
            this._patient.ReadOnly = false;
            this._patient.Size = new System.Drawing.Size(308, 30);
            this._patient.TabIndex = 27;
            this._patient.Texts = "";
            this._patient.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Số bệnh nhân tối đa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _BtnSave
            // 
            this._BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this._BtnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this._BtnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this._BtnSave.BorderRadius = 20;
            this._BtnSave.BorderSize = 2;
            this.tableLayoutPanel1.SetColumnSpan(this._BtnSave, 2);
            this._BtnSave.FlatAppearance.BorderSize = 0;
            this._BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._BtnSave.ForeColor = System.Drawing.Color.Black;
            this._BtnSave.Location = new System.Drawing.Point(20, 112);
            this._BtnSave.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this._BtnSave.Name = "_BtnSave";
            this._BtnSave.Size = new System.Drawing.Size(472, 38);
            this._BtnSave.TabIndex = 23;
            this._BtnSave.Text = "Lưu";
            this._BtnSave.TextColor = System.Drawing.Color.Black;
            this._BtnSave.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Số tiền khám";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegulationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 159);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "RegulationsForm";
            this.Text = "Thay đổi quy định";
            this.gradientPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Classes.GradientPanel gradientPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Classes.RJButton _BtnSave;
        private Label label1;
        private Label label2;
        private Classes.CustomTextBox _price;
        private Classes.CustomTextBox _patient;
    }
}