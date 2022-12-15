using ClinicManagement.Models;
using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ClinicManagement.Forms
{
    public partial class PatientForm : Form
    {
        //Giá trị
        int yearnow = DateTime.Now.Year;
        DBAccess dBAccess = new DBAccess();

        static int MaxPatientInDay = 40;
        static int ClickCount = 0;

        Guid patient;

        //Khởi tạo
        public PatientForm()
        {
            InitializeComponent();

            //MaxPatientInDay= dBAccess.executeQuery("SELECT SOBNTOIDA FROM THAMSO");

            dtpkBob.MaxDate= DateTime.Now;
            ResetMonitor();

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
            tbxPatientID.ReadOnly = false;
            tbxPatientName.Texts = "";
            rbtnPatientMale.Checked = rbtnPatientFemale.Checked = false;
            tbxPatientAddress.Texts = "";
            dtpkBob.Value = DateTime.Today;
        }

        //Sự kiện
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxPatientID.ReadOnly= true;

            patient = new Guid();
            //Khoá mã bệnh nhân
            tbxPatientID.ReadOnly = true;
            //Tạo mã bệnh nhân mới
            tbxPatientID.Texts = patient.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ClickCount > MaxPatientInDay) {
                MessageBox.Show("Vượt quá số bệnh nhân có thể tiếp nhận trong ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id, fullname, gender;

            id = tbxPatientID.Text.ToString();
            fullname = tbxPatientName.Text.ToString();
            if (rbtnPatientMale.Checked) { gender = "male"; }
            else { gender = "female"; }

            Patient aPatient = new Patient(tbxPatientID.Text.ToString(), fullname, gender, dtpkBob.Value, tbxPatientAddress.Text.ToString());

            //Quy định
            if (fullname.Length> 30)
            {
                MessageBox.Show("Tên quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (rbtnPatientFemale.Checked == rbtnPatientMale.Checked == false)
            {
                MessageBox.Show("Hãy chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Lưu thông tin bệnh nhân


            //Đặt màn hình về mặc định
            btnExit_Click(sender, e);
            tbxPatientID.ReadOnly = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ResetMonitor();
        }
    }
}
