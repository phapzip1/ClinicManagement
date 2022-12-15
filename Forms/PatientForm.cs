using ClinicManagement.DbContexts;
using ClinicManagement.Models;
using ClinicManagement.Services;
using DatabaseProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Rectangle = System.Drawing.Rectangle;

namespace ClinicManagement.Forms
{
    public partial class PatientForm : Form
    {
        //Giá trị
        bool timer = false;
        //DBAccess dBAccess = new DBAccess();

        int max_Patient = 40;
        int nextP = 0;

        static Guid patient = new Guid();
        InforForm InforForm = new InforForm();
        Patient aPatient;

        //Khởi tạo
        public PatientForm()
        {
            InitializeComponent();

            ResetMonitor();
            lblNiceSave.Hide();
            timerPatient.Enabled = false;

            try
            {
                /*
                 * Nạp số bệnh nhân tối đa trong ngày vào max_Patient
                 */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // fill cbxPatientBirthday
            //for (int i = yearnow; i >= 1900; i--)
            //{
            //    cbxPatientBirthday.Items.Add(i.ToString());
            //}
            //cbxPatientBirthday.SelectedItem = yearnow.ToString();
        }

        //Hàm
        private void ResetMonitor()
        {
            //Đặt màn hình về mặc định
            tbxPatientID.Texts = "";
            tbxPatientID.ReadOnly = true;
            tbxPatientName.Texts = "";
            tbxPatientName.ReadOnly = true;
            rbtnPatientMale.Checked = rbtnPatientFemale.Checked = false;
            tbxPatientAddress.Texts = "";
            tbxPatientAddress.ReadOnly = true;
            dtpkBob.Value = DateTime.Now;

            timerPatient.Enabled = false;
        }

        private void StartMonitor()
        {
                tbxPatientID.Texts = "";
                tbxPatientID.ReadOnly = false;
                tbxPatientName.Texts = "";
                tbxPatientName.ReadOnly = false;
                rbtnPatientMale.Checked = rbtnPatientFemale.Checked = false;
                tbxPatientAddress.Texts = "";
                tbxPatientAddress.ReadOnly = false;
                dtpkBob.Value = DateTime.Today;
        }

        //Sự kiện
        private void btnAdd_Click(object sender, EventArgs e)
        {
            StartMonitor();
            //Tạo mã bệnh nhân mới
            //tbxPatientID.Texts = patient.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (InforForm.Patient_Count >= max_Patient) {
                MessageBox.Show("Vượt quá số bệnh nhân có thể tiếp nhận trong ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(tbxPatientIDNow.Texts == string.Empty) {
                MessageBox.Show("Hãy điền mã bệnh nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            else
            {
                InforForm.Patient_Count++;
                InforForm.Next_Patient++;
                lblNextPatient.Text = InforForm.Next_Patient.ToString();

                //dtgvPatientList.Rows.Add(Patient());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id, fullname, gender;

            id = tbxPatientID.Text.ToString();
            fullname = tbxPatientName.Text.ToString();
            if (rbtnPatientMale.Checked) { gender = "male"; }
            else { gender = "female"; }

            aPatient = new Patient(tbxPatientID.Text.ToString(), fullname, gender, dtpkBob.Value, tbxPatientAddress.Text.ToString());

            //Quy định
            if (fullname.Length> 30)
            {
                MessageBox.Show("Tên quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (rbtnPatientFemale.Checked == false && rbtnPatientMale.Checked == false)
            {
                MessageBox.Show("Hãy chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Lưu thông tin bệnh nhân
            try
            {
                ClinicDbContextFactory _clinicDbContextFactory = new ClinicDbContextFactory(InforForm.Connects_String);
                using (ClinicDbContext dbContext = _clinicDbContextFactory.CreateDbContext())
                {
                    IDataCreator dataCreator = new DBCreator(_clinicDbContextFactory);
                    dbContext.Database.Migrate();
                    dataCreator.CreatePatient(new Models.Patient(id, fullname, gender, dtpkBob.Value, tbxPatientAddress.Texts.ToString()));
                    
                    //dataCreator.CreatePatient(aPatient);

                    timerPatient.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Đặt màn hình về mặc định
            ResetMonitor();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ResetMonitor();
        }

        private void timerPatient_Tick(object sender, EventArgs e)
        {
            lblNiceSave.Hide();
            timerPatient.Enabled = false;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            nextP++;
            Models.InforForm.Next_Patient = nextP;
        }

        private void rbtnPatientFemale_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics= e.Graphics;
            
            Rectangle arena = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(arena, Color.FromArgb(115, 166, 250),
                Color.FromArgb(184, 216, 252), 90F);
            graphics.FillRectangle(linearGradientBrush, arena);
        }
    }
}
