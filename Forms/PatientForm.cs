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

        string id, fullname, address;
        string gender;
        DateTime dob;

        //Khởi tạo
        public PatientForm()
        {
            InitializeComponent();

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
            tbxPatientID.ReadOnly = true;
            tbxPatientName.Texts = "";
            rbtnPatientMale.Checked = rbtnPatientFemale.Checked = false;
            tbxPatientAddress.Texts = "";
            dtpkBob.Value = DateTime.Today;
        }

        //Sự kiện
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int _id = 1;
            _id = dBAccess.executeQuery("SELECT MAX(MABN) FROM BENHNHAN");
            if (_id > 1) { _id++; }
            else _id = 1;
            //Khoá mã bệnh nhân
            tbxPatientID.ReadOnly = true;
            //Tạo mã bệnh nhân mới
            tbxPatientID.Texts = _id.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            id = tbxPatientID.Text.ToString();
            fullname = tbxPatientName.Text.ToString();
            if (rbtnPatientMale.Checked) { gender = "1"; }
            else { gender = "0"; }
            address= tbxPatientAddress.Text.ToString();

            //Quy định
            if(fullname.Length> 30)
            {
                MessageBox.Show("Tên quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbtnPatientFemale.Checked == rbtnPatientMale.Checked == false)
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
