using ClinicManagement.Classes;
using ClinicManagement.DbContexts;
using ClinicManagement.Models;
using ClinicManagement.Services;
using System.ComponentModel;

namespace ClinicManagement.Forms
{
    public partial class ImportForm : Form
    {
        private BindingSource medicineDetailBinding;
        private BindingList<ComboboxItem> bindingLists;

        private ClinicDbContextFactory _clinicDbContextFactory;
        private IDataCreator creator;
        private IDataProvider provider;
        public ImportForm()
        {
            InitializeComponent();

            _clinicDbContextFactory = new ClinicDbContextFactory(Program.Configuration.GetSection("ConnectionStrings").Value.ToString());
            provider = new DBProvider(_clinicDbContextFactory);
            creator = new DBCreator(_clinicDbContextFactory);

            medicineDetailBinding = new BindingSource() { DataSource = new List<ImportDetail>() };
            bindingLists = new BindingList<ComboboxItem>();


            medicineDetailBinding.ListChanged += BindingSource_ListChanged;

            dataGridView1.DataSource = medicineDetailBinding;
            _medicineCombobox.DataSource = bindingLists;
            _medicineCombobox.DisplayMember = "Text";
            _medicineCombobox.ValueMember = "Value";

            dataGridView1.Columns["MedicineId"].Visible = false;
            dataGridView1.Columns["ImportId"].Visible = false;


            _quantityTb.Minimum = 0;
            _priceTb.Minimum = 0;
            _quantityTb.Maximum = decimal.MaxValue;
            _priceTb.Maximum = decimal.MaxValue;
        }


        private void BindingSource_ListChanged(object? sender, ListChangedEventArgs e)
        {
            int sum = 0;
            foreach (ImportDetail item in medicineDetailBinding.List)
            {
                sum += item.Sum;
            }
            _totalTb.Texts = sum.ToString();
        }

        private void Add_ImportDetail_Handler(object sender, EventArgs e)
        {
            if (_medicineCombobox.SelectedItem != null)
            {
                ComboboxItem item = (ComboboxItem)_medicineCombobox.SelectedItem;
                Medicine value = (Medicine)item.Value;

                int qty = int.Parse(_quantityTb.Text);
                int price = int.Parse(_priceTb.Text);
                if (((List<ImportDetail>)medicineDetailBinding.List).Where(p => p.MedicineId == value.Id).Count() == 0)
                {
                    medicineDetailBinding.Add(new ImportDetail(Guid.Empty, value.Id, value.Name, value.UnitName, qty, price));
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Item_Changed(object sender, EventArgs e)
        {
            ComboboxItem item = (ComboboxItem)_medicineCombobox.SelectedItem;
            _unitTb.Texts = ((Medicine)item.Value).UnitName;
        }

        private void Remove_Row_Handler(object sender, EventArgs e)
        {
            int count = dataGridView1.SelectedRows.Count;

            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void Save_Handler(object sender, EventArgs e)
        {
            Import import = new Import(Guid.NewGuid(), DateTime.Now, int.Parse(_totalTb.Texts), medicineDetailBinding.DataSource as IEnumerable<ImportDetail>);
            creator.CreateImport(import);
            Console.WriteLine(Guid.NewGuid());
        }

        private void Form_Loaded(object sender, EventArgs e)
        {
            provider.GetMedicines().ContinueWith(res =>
            {
                if (IsHandleCreated)
                {
                    _medicineCombobox.Invoke((MethodInvoker)delegate
                    {
                        foreach (var item in res.Result)
                        {
                            bindingLists.Add(new ComboboxItem(item.Name, item));
                            bindingLists.ResetBindings();
                        }
                    });
                }
            });
        }
    }
}
