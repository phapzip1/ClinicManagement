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
    public partial class BillForm : Form
    {
        public string name;
        public string date;
        public int medicine_price;
        public string medical_price;
        public string count_price;
        public BindingSource _medicineBinding;
        int medicalPrice = 0;
        int Discount = 0;
        private Guid _guid;

        private IDataCreator creator;
        private IDataProvider provider;
        private ClinicDbContextFactory _clinicDbContextFactory;
        public BillForm(List<MedicalNoteDetail> list, Guid guid)
        {
            InitializeComponent();

            _clinicDbContextFactory = new ClinicDbContextFactory(Program.Configuration.GetSection("ConnectionStrings").Value.ToString());

            provider = new DBProvider(_clinicDbContextFactory);
            creator = new DBCreator(_clinicDbContextFactory);

            provider.GetParams().ContinueWith(res =>
            {
                medicalPrice = res.Result["MedicalCost"];
            });

            _medicineBinding = new BindingSource() { DataSource = list};
            dtgvMedicineList.DataSource = _medicineBinding;

            dtgvMedicineList.Columns["MedicalNoteId"].Visible= false;
            dtgvMedicineList.Columns["UnitId"].Visible= false;
            dtgvMedicineList.Columns["UnitName"].Visible= false; 
            dtgvMedicineList.Columns["MedicineId"].Visible= false;
            dtgvMedicineList.Columns["MethodId"].Visible= false;

            _guid = guid;
        }

        public BillForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult= MessageBox.Show("Bạn chắc chắn chứ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.OK)
            {
                Close();
            }                
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            tbxName.Texts= name;
            tbxDate.Texts= DateTime.Now.ToString("dd/MM/yyyy");
            tbxMedicine_price.Texts= medicine_price.ToString();
            tbxMedical_price.Texts= medicalPrice.ToString();
            tbxCount_price.Texts= (medicine_price + medicalPrice).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Guid guid = Guid.NewGuid();
                Bill bill = new Bill(guid, _guid, medicine_price, int.Parse(medical_price));
                creator.CreateBill(bill);
                Console.WriteLine(guid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
