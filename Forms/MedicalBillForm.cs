using ClinicManagement.Classes;
using ClinicManagement.DbContexts;
using ClinicManagement.Models;
using ClinicManagement.Services;
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
        int Final_Price = 0;

        //Data
        private Guid guid1 = Guid.NewGuid();
        private IDataProvider provider;
        private BindingList<ComboboxItem> IllnessbindingLists;
        private BindingList<ComboboxItem> MedicinesbindingLists;
        private BindingList<ComboboxItem> MethodbindingLists;
        private BindingSource medicineDetailBinding;

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

            //dtgvMedicalBill.Columns["Id"].Visible= false;

            tbxMedicalBillDay.ReadOnly= true;
            tbxMedicalBillDay.Texts = DateTime.Today.ToString("dd/MM/yyyy");
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

            tbxMedicalBillDay.ReadOnly= true;
            tbxMedicalBillPatient.Texts = string.Empty;

            tbxMedicalBillNumber.Texts = string.Empty;
            tbxPrice.Text = string.Empty;
            tbxFinalPrice.Text = string.Empty;

            chxNotList.Checked= false;
        }

        private void getMedicalBill()
        {
            provider.GetAllMedicalNote().ContinueWith(res =>
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
            if (chxNotList.Checked)
            {

            }
            else
            {

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

                if (((List<MedicalNoteDetail>)medicineDetailBinding.List).Where(p => p.MedicineId == value.Id).Count() == 0)
                {
                    medicineDetailBinding.Add(new MedicalNoteDetail(value.Id, int.Parse(tbxQuantity.Texts), value1.Id));
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

                if (((List<Medicine>)medicineDetailBinding.List).Where(p => p.Id == value.Id).Count() == 0)
                {
                    tbxPrice.Texts = value.Price.ToString();
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại");
                }
            }
        }

        private void btnDelMedical_Click(object sender, EventArgs e)
        {
            int count = dtgvMedicalList.SelectedRows.Count;

            for (int i = 0; i < count; i++)
            {
                dtgvMedicalList.Rows.RemoveAt(dtgvMedicalList.SelectedRows[0].Index);
            }
        }

        private void btnSaveMedi_Click(object sender, EventArgs e)
        {
            //Import import = new Import(Guid.NewGuid(), DateTime.Now, int.Parse(_totalTb.Texts), medicineDetailBinding.DataSource as IEnumerable<ImportDetail>);
            //MedicalNoteDetail medicalNoteDetail = new MedicalNoteDetail(tbxMedicalBillNumber.Texts.ToString() ,Guid.NewGuid(), cbxMedicines.Texts.ToString(), )
            //    //Guid medicalNoteId, Guid medicineId, string medicineName, Guid unitId, string unitName, int quantity, Guid methodId, string method
            //creator.CreateImport(import);
            //Console.WriteLine(Guid.NewGuid());
        }

        private void MedicalBillForm_Load(object sender, EventArgs e)
        {
            getMedicalBill();
        }
    }   
}
