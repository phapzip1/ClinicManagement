namespace ClinicManagement.Forms
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rjButton1 = new ClinicManagement.Classes.RJButton();
            this.btnSeeInformation = new ClinicManagement.Classes.RJButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(509, 167);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.52525F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.47475F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 147);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu mới";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập lại mật khẩu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rjButton1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSeeInformation, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(159, 88);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(330, 59);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(168, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(159, 50);
            this.rjButton1.TabIndex = 20;
            this.rjButton1.Text = "Hủy bỏ";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
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
            this.btnSeeInformation.Location = new System.Drawing.Point(3, 3);
            this.btnSeeInformation.Name = "btnSeeInformation";
            this.btnSeeInformation.Size = new System.Drawing.Size(159, 50);
            this.btnSeeInformation.TabIndex = 19;
            this.btnSeeInformation.Text = "Lưu";
            this.btnSeeInformation.TextColor = System.Drawing.Color.Black;
            this.btnSeeInformation.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 167);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Classes.RJButton rjButton1;
        private Classes.RJButton btnSeeInformation;
    }
}