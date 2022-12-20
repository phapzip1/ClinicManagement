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
    public partial class BillForm : Form
    {
        public string name;
        public string date;
        public string medicine_price;
        public string medical_price;
        public string count_price;
        public BindingSource _medicineBinding;
        int medicinePrice = 0;
        int Discount = 0;

        DBProvider provider;
        private ClinicDbContextFactory _clinicDbContextFactory;
        public BillForm(List<MedicalNoteDetail> list)
        {
            InitializeComponent();

            _clinicDbContextFactory = new ClinicDbContextFactory(Program.Configuration.GetSection("ConnectionStrings").Value.ToString());
            provider = new DBProvider(_clinicDbContextFactory);
            provider.GetParams().ContinueWith(res =>
            {
                medicinePrice = res.Result["MedicalCost"];
            });

            _medicineBinding = new BindingSource() { DataSource = list};
            dtgvMedicineList.DataSource = _medicineBinding;
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
            tbxDate.Texts= date;
            tbxMedicine_price.Texts= medical_price;
            tbxMedical_price.Texts= medicinePrice.ToString();
            tbxCount_price.Texts= (int.Parse(medical_price) + medicinePrice).ToString();
        }
    }
}
