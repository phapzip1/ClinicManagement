using ClinicManagement.DbContexts;
using ClinicManagement.Models;
using ClinicManagement.Services;
using Microsoft.Office.Interop.Excel;

namespace ClinicManagement.Forms
{
    public partial class RegulationsForm : Form
    {
        private ClinicDbContextFactory _clinicDbContextFactory;
        private IDataProvider provider;
        private IDataUpdater updater;

        public RegulationsForm()
        {
            InitializeComponent();

            _clinicDbContextFactory = new ClinicDbContextFactory(Program.Configuration.GetSection("ConnectionStrings").Value.ToString());

            provider = new DBProvider(_clinicDbContextFactory);
            updater = new DBUpdater(_clinicDbContextFactory);

            provider.GetParams().ContinueWith(res =>
            {
                _fee.Texts = res.Result["MedicalCost"].ToString();
                _max.Texts = res.Result["MaxPatients"].ToString();
            });

        }

        private void Save_Handler(object sender, EventArgs e)
        {
           
            int max, cost;
            bool result1 = int.TryParse(_fee.Texts, out cost);
            bool result2 = int.TryParse(_max.Texts, out max); 
            if (result1 && result2)
            {
                IDataUpdater updater = new DBUpdater(_clinicDbContextFactory);
                updater.UpdateParameters(cost, max);
            }
        }
    }
}
