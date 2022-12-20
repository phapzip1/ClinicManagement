using ClinicManagement.Classes;
using ClinicManagement.DbContexts;
using ClinicManagement.Models;
using ClinicManagement.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Office.Interop.Excel;
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
        static int Final_Price = 0;

        //Data
        private Guid guid1 = Guid.NewGuid();
        private IDataProvider provider;
        private IDataCreator creator;

        private BindingList<ComboboxItem> IllnessbindingLists;
        private BindingList<ComboboxItem> MedicinesbindingLists;
        private BindingList<ComboboxItem> MethodbindingLists;
        private BindingSource medicineDetailBinding;

        private BindingSource medicineBinding;

        private ClinicDbContextFactory _clinicDbContextFactory;

        public MedicalBillForm()
        {
            InitializeComponent();

            _clinicDbContextFactory = new ClinicDbContextFactory(Program.Configuration.GetSection("ConnectionStrings").Value.ToString());

            IllnessbindingLists = new BindingList<ComboboxItem>();
            MedicinesbindingLists = new BindingList<ComboboxItem>();
            MethodbindingLists= new BindingList<ComboboxItem>();

            cbxIllness.DataSource= IllnessbindingLists;
            cbxMedicines.DataSource= MedicinesbindingLists;
            cbxUsage.DataSource= MethodbindingLists;

            provider = new DBProvider(_clinicDbContextFactory);
            creator = new DBCreator(_clinicDbContextFactory);

            #region tenbenh, tenthuoc, cachdung
            //Ten benh
            provider.GetAllIllness().ContinueWith(res =>
            {
                if (IsHandleCreated)
                {
                    cbxIllness.Invoke((MethodInvoker)delegate
                    {
                        foreach (var item in res.Result)
                        {
                            IllnessbindingLists.Add(new ComboboxItem(item.Name, item));
                            IllnessbindingLists.ResetBindings();
                        }
                    });
                }
            });

            //Ten thuoc
            provider.GetMedicines().ContinueWith(res =>
            {
                if (IsHandleCreated)
                {
                    cbxIllness.Invoke((MethodInvoker)delegate
                    {
                        foreach (var item in res.Result)
                        {
                            MedicinesbindingLists.Add(new ComboboxItem(item.Name, item));
                            MedicinesbindingLists.ResetBindings();
                        }
                    });
                }
            });

            //Cach dung
            provider.GetAllMethods().ContinueWith(res =>
            {
                if (IsHandleCreated)
                {
                    cbxUsage.Invoke((MethodInvoker)delegate
                    {
                        foreach (var item in res.Result)
                        {
                            MethodbindingLists.Add(new ComboboxItem(item.Name, item));
                            MethodbindingLists.ResetBindings();
                        }
                    });
                }
            });
            #endregion

            //datagridview
            medicineDetailBinding = new BindingSource() { DataSource = new List<MedicalNote>() };
            dtgvMedicalBill.DataSource = medicineDetailBinding;

            dtgvMedicalBill.Columns["IllnessId"].Visible= false;
            dtgvMedicalBill.Columns["PatientId"].Visible= false;
            dtgvMedicalBill.Columns["PatientName"].Visible= false;
            dtgvMedicalBill.Columns["Details"].Visible= false;

            medicineBinding = new BindingSource() { DataSource = new List<MedicalNoteDetail>() };
            dtgvMedicineList.DataSource = medicineBinding;

            dtgvMedicineList.Columns["MedicalNoteId"].Visible= false;
            dtgvMedicineList.Columns["MedicineId"].Visible= false;
            dtgvMedicineList.Columns["UnitId"].Visible= false;
            dtgvMedicineList.Columns["UnitName"].Visible= false;
            dtgvMedicineList.Columns["MethodId"].Visible= false;

            dtpkMedicalBillDay.Value = DateTime.Now;
            tbxMedicalBillNumber.ReadOnly= true;
            tbxMedicalBillPatient.ReadOnly= true;
            tbxPrice.ReadOnly= true;
            tbxFinalPrice.ReadOnly= true;
        }

        //Hàm
        private void ResetMedicalBill()
        {
            tbxMedicalBillNumber.Texts = string.Empty;
            tbxMedicalBillNumber.ReadOnly= true;

            tbxMedicalBillPatient.Texts = string.Empty;

            tbxMedicalBillNumber.Texts = string.Empty;
            tbxPrice.Text = string.Empty;
            tbxFinalPrice.Text = string.Empty;
        }

        private void getMedicalBill()
        {
            string id = InforForm.PatientNow_id;
            provider.GetAllMedicalNote(id).ContinueWith(res =>
            {
                if (IsHandleCreated)
                {
                    if (res.Result.Count() >= 1)
                    {
                        dtgvMedicalBill.Invoke((MethodInvoker)delegate
                        {
                            medicineDetailBinding.Clear();
                            foreach (var item in res.Result)
                            {
                                medicineDetailBinding.Add(item);
                            }
                        });
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phiếu khám bệnh!", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            });
        }

        //Sự kiện
        private void timerMedical_Tick(object sender, EventArgs e)
        {

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
            guid1 = Guid.NewGuid();
            tbxMedicalBillNumber.Texts= guid1.ToString();
            tbxMedicalBillPatient.Texts= InforForm.PatientNow_id.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbxIllness.SelectedItem != null)
            {
                ComboboxItem item = (ComboboxItem)cbxIllness.SelectedItem;
                Illness value = (Illness)item.Value;
                if (value != null)
                {
                    MedicalNote medicalNote = new MedicalNote(Guid.NewGuid(), InforForm.PatientNow_id, tbxMedicalBillPatient.Texts.ToString(), value.Id,
                        item.Value.ToString(), tbxSympton.Texts.ToString(), DateTime.Now, medicineBinding.DataSource as IEnumerable<MedicalNoteDetail>);

                    creator.CreateMedicalNote(medicalNote);

                    List<MedicalNoteDetail> medicalNoteDetails = (List<MedicalNoteDetail>)medicineBinding.List;

                    BillForm billForm = new BillForm(medicalNoteDetails);
                    billForm.name= tbxMedicalBillPatient.Texts.ToString();
                    billForm.medical_price= Final_Price.ToString();
                    billForm._medicineBinding.DataSource= medicineBinding.DataSource;
                    billForm.ShowDialog();

                    Console.WriteLine(Guid.NewGuid());
                }
                else
                {
                    MessageBox.Show("Hãy chọn bệnh");
                }
            }           
        }

        private void btnAddMedical_Click(object sender, EventArgs e)
        {
            if (cbxMedicines.SelectedItem != null)
            {
                ComboboxItem item = (ComboboxItem)cbxMedicines.SelectedItem;
                Medicine value = (Medicine)item.Value;

                ComboboxItem item1 = (ComboboxItem)cbxUsage.SelectedItem;
                Method value1 = (Method)item1.Value;

                if (((List<MedicalNoteDetail>)medicineBinding.List).Where(p => p.MedicineId == value.Id).Count() == 0)
                {
                    medicineBinding.Add(new MedicalNoteDetail(value.Id, int.Parse(tbxQuantity.Texts), value1.Id, 
                        cbxMedicines.Texts.ToString(), cbxUsage.Texts.ToString()));
                    Final_Price += int.Parse(tbxPrice.Texts);
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại");
                }
            }
        }

        private void cbxMedicines_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMedicines.SelectedItem != null)
            {
                ComboboxItem item = (ComboboxItem)cbxMedicines.SelectedItem;
                Medicine value = (Medicine)item.Value;
                tbxPrice.Texts = value.Price.ToString();
            }
            int quantity, price;
            if (int.TryParse(tbxQuantity.Texts, out quantity) && int.TryParse(tbxPrice.Texts, out price))
            {
                tbxFinalPrice.Texts= (quantity*price).ToString();
            }
        }

        private void btnDelMedical_Click(object sender, EventArgs e)
        {
            int count = dtgvMedicineList.SelectedRows.Count;

            for (int i = 0; i < count; i++)
            {
                dtgvMedicineList.Rows.RemoveAt(dtgvMedicineList.SelectedRows[0].Index);
            }
        }

        private void MedicalBillForm_Load(object sender, EventArgs e)
        {
            getMedicalBill();

            tbxMedicalBillNumber.Texts= guid1.ToString();
            tbxMedicalBillPatient.Texts= InforForm.Next_Patient;
        }

        private void tbxQuantity__TextChanged(object sender, EventArgs e)
        {
            int quantity, price;
            if (int.TryParse(tbxQuantity.Texts, out quantity) && int.TryParse(tbxPrice.Texts, out price))
            {
                tbxFinalPrice.Texts= (quantity*price).ToString();
            }
            else
                MessageBox.Show("Chỉ nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }   
}
