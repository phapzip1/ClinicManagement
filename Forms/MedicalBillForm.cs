using ClinicManagement.Classes;
using ClinicManagement.DbContexts;
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
        private Guid guid1= Guid.NewGuid();
        private IDataProvider provider;
        private BindingList<ComboboxItem> bindingLists;
        private BindingSource medicineDetailBinding;

        private ClinicDbContextFactory _clinicDbContextFactory;

        public MedicalBillForm()
        {
            InitializeComponent();

            _clinicDbContextFactory = new ClinicDbContextFactory(Program.Configuration.GetSection("ConnectionStrings").Value.ToString());

            bindingLists = new BindingList<ComboboxItem>();

            provider = new DBProvider(_clinicDbContextFactory);

            lblNextPatient.Text = Models.InforForm.Next_Patient.ToString();
            tbxMedicalBillDay.ReadOnly= true;
            tbxMedicalBillDay.Texts = DateTime.Today.ToString("dd/MM/yyyy");

            provider.GetAllIllness().ContinueWith(res =>
            {
                if (IsHandleCreated)
                {
                    cbxSympton.Invoke((MethodInvoker)delegate
                    {
                        foreach (var item in res.Result)
                        {
                            bindingLists.Add(new ComboboxItem(item.Symptom, item));
                            bindingLists.ResetBindings();
                        }
                    });
                }
            });

            tbxMedicalBillNumber.ReadOnly= true;
            tbxMedicalBillPatient.ReadOnly= true;
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

            tbxMedicalBillPatient.Texts = InforForm.PatientNow_id.ToString();
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
            tbxMedicalBillPatient.Texts= InforForm.PatientNow_id.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

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
