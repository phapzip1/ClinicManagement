﻿using System;
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
        }

        //Hàm
        private void ResetMedicalBill()
        {
            tbxMedicalillNumber.Texts = string.Empty;
            tbxMedicalillNumber.ReadOnly= true;

            dtpkMedicalBill.Value = DateTime.Today;
            tbxMedicalBillPatient.Texts = string.Empty;  

            tbxMedicalillNumber.Texts = string.Empty;
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
    }
}
