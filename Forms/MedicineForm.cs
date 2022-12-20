using ClinicManagement.Classes;
using ClinicManagement.DbContexts;
using ClinicManagement.Models;
using ClinicManagement.Services;
using System.ComponentModel;

namespace ClinicManagement.Forms
{
    public partial class MedicineForm : Form
    {
        private ClinicDbContextFactory factory;
        private IDataCreator creator;
        private IDataUpdater updater;
        private IDataProvider provider;
        private BindingSource bindingSource;
        private BindingList<ComboboxItem> cbList;
        private bool loaded;
        public MedicineForm()
        {
            InitializeComponent();
            factory = new ClinicDbContextFactory(Program.Configuration.GetSection("ConnectionStrings").Value.ToString());
            creator = new DBCreator(factory);
            updater = new DBUpdater(factory);
            provider = new DBProvider(factory);
            bindingSource = new BindingSource() { DataSource = new List<Medicine>() };
            _datagridView.DataSource = bindingSource;
            _datagridView.Columns["Id"].Visible = false;
            _datagridView.Columns["UnitId"].Visible = false;

            cbList = new BindingList<ComboboxItem>();
            _cbUnit.DataSource = cbList;

            provider.GetAllUnits().ContinueWith(res =>
            {
                if (IsHandleCreated)
                {
                    _cbUnit.Invoke((MethodInvoker)delegate
                    {
                        cbList.Clear();
                        foreach (var item in res.Result)
                        {
                            cbList.Add(new ComboboxItem(item.Name, item));
                        }
                        cbList.ResetBindings();
                    });
                }
            });

            _stock.Minimum = 0;
            _stock.Maximum = decimal.MaxValue;
            _price.Minimum = 0;
            _price.Maximum = decimal.MaxValue;

            LoadData();

        }

        private void LoadData()
        {
            provider.GetMedicines().ContinueWith(res =>
            {
                if (IsHandleCreated)
                {

                    _datagridView.Invoke((MethodInvoker)delegate
                    {
                        loaded = false;
                        bindingSource.Clear();
                        foreach (var item in res.Result)
                        {
                            bindingSource.Add(item);
                        }
                        loaded = true;
                    });
                }
            });
        }

        private void AddHandler(object sender, EventArgs e)
        {
            ComboboxItem item = (ComboboxItem)_cbUnit.SelectedItem;
            if (!string.IsNullOrEmpty(_name.Texts) && item != null)
            {
                creator.CreateMedicine(new Medicine(Guid.NewGuid(), _name.Texts, ((Unit)item.Value).Id, (int)_stock.Value, (int)_price.Value))
                    .ContinueWith(res =>
                    {
                        if (!res.IsFaulted)
                        {
                            MessageBox.Show("Thêm Thành công");
                        }
                    }).ContinueWith(res =>
                    {
                        LoadData();
                    });
            }
            else
            {
                MessageBox.Show("Trường tên hoặc đơn vị trống!");
            }
        }

        private void RemoveHandler(object sender, EventArgs e)
        {
            int index = _datagridView.SelectedRows[0].Index;
            Guid id = ((Medicine)bindingSource.List[index]).Id;
            updater.RemoveMedicine(id).ContinueWith(res =>
            {
                if (!res.IsFaulted)
                {
                    MessageBox.Show("Xóa Thành công");
                }
            }).ContinueWith(res =>
            {
                LoadData();
            });
        }

        private void UpdateHandler(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_name.Texts))
            {
                int index = _datagridView.SelectedRows[0].Index;
                Medicine item = (Medicine)bindingSource.List[index];
                ComboboxItem unit = (ComboboxItem)_cbUnit.SelectedItem;
                updater.UpdateMedicine(new Medicine(item.Id, _name.Texts, ((Unit)unit.Value).Id, (int)_stock.Value, (int)_price.Value)).ContinueWith(res =>
                {
                    if (!res.IsFaulted)
                    {
                        MessageBox.Show("Thêm Thành công");
                    }
                }).ContinueWith(res =>
                {
                    LoadData();
                });
            }
            else
            {
                MessageBox.Show("Trường tên trống!");
            }
        }

        private void _datagridView_SelectionChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                int index = _datagridView.SelectedRows[0].Index;
                Medicine item = (Medicine)bindingSource.List[index];
                _name.Texts = item.Name;
                ComboboxItem unit = cbList.FirstOrDefault(p => ((Unit)p.Value).Id == item.UnitId);
                _cbUnit.SelectedItem = cbList[cbList.IndexOf(unit)];
                _price.Value = item.Price;
                _stock.Value = item.Stock;
            }
        }
    }
}
