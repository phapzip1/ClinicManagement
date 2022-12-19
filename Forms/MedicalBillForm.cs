using ClinicManagement.Classes;
using ClinicManagement.Models;
using ClinicManagement.Services;
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
        //bool isChecked = false;

        //Data
        private IDataProvider provider;
        private BindingList<ComboboxItem> bindingLists;

        public MedicalBillForm()
        {
            InitializeComponent();



            lblNextPatient.Text = Models.InforForm.Next_Patient.ToString();
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

            cbxNotList.Checked= false;
        }

        //Sự kiện
        private void timerMedical_Tick(object sender, EventArgs e)
        {
            lblNextPatient.Text = InforForm.Next_Patient.ToString();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult= MessageBox.Show("Bạn chắc chắn muốn huỷ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                ResetMedicalBill();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            tbxMedicalBillNumber.ReadOnly= true;
            Guid guid = Guid.NewGuid();
            tbxMedicalBillNumber.Texts= guid.ToString();
        }

        //private void rbtnNotMedicalList_CheckedChanged(object sender, EventArgs e)
        //{
        //    isChecked = rbtnNotMedicalList.Checked;
        //}

        //private void rbtnNotMedicalList_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (rbtnNotMedicalList.Checked && !isChecked)
        //        rbtnNotMedicalList.Checked = false;
        //    else
        //    {
        //        rbtnNotMedicalList.Checked = true;
        //        isChecked = false;
        //    }
        //}
    }   
}
