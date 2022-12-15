using ClinicManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement.Forms
{
    public partial class MedicalBillForm : Form
    {

        //Radio button
        bool isChecked = false;

        public MedicalBillForm()
        {
            InitializeComponent();

            tbxMedicalBillDay.ReadOnly= true;
            tbxMedicalBillDay.Texts = DateTime.Today.ToString("dd/MM/yyyy");
        }

        //Hàm
        private void ResetMedicalBill()
        {
            tbxMedicalBillNumber.Texts = string.Empty;
            tbxMedicalBillNumber.ReadOnly= true;

            tbxMedicalBillDay.ReadOnly= true;
            tbxMedicalBillPatient.Texts = string.Empty;  

            tbxMedicalBillNumber.Texts = string.Empty;
            tbxPrice.Text = string.Empty;
            tbxFinalPrice.Text = string.Empty;
        }

        //Sự kiện
        private void btnExit_Click(object sender, EventArgs e)
        {
            ResetMedicalBill();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxMedicalBillNumber.ReadOnly= true;
            Guid guid= Guid.NewGuid();  
            tbxMedicalBillNumber.Texts= guid.ToString();    
        }

        private void rbtnNotList_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbtnNotMedicalList.Checked;
        }

        private void rbtnNotList_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbtnNotMedicalList.Checked && !isChecked)
                rbtnNotMedicalList.Checked = false;
            else
            {
                rbtnNotMedicalList.Checked = true;
                isChecked = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(isChecked == false && tbxMedicalNumer.Texts == string.Empty)
            {
                MessageBox.Show("Chưa kê khai thuốc!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }

        private void timerMedical_Tick(object sender, EventArgs e)
        {
            lblNextPatient.Text = InforForm.Next_Patient.ToString();
        }
    }
}
