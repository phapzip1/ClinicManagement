using ClinicManagement.DbContexts;
using ClinicManagement.Models;
using ClinicManagement.Services;

namespace ClinicManagement.Forms
{
    public partial class PatientQueue : Form
    {
        private ClinicDbContextFactory factory;
        private IDataProvider provider;
        private BindingSource binding;
        public PatientQueue()
        {
            InitializeComponent();
            factory = new ClinicDbContextFactory(Program.Configuration.GetSection("ConnectionStrings").Value.ToString());
            provider = new DBProvider(factory);
            binding = new BindingSource() { DataSource = Program.PatientQueue };
            dataGridView1.DataSource = binding;
            dataGridView1.Columns["Id"].Visible = false;
        }


        private void Append_Handler(object sender, EventArgs e)
        {
            if (binding.List.Count > 0)
            {
                InforForm.PatientNow_id = ((Patient)binding[0]).Id;
                InforForm.Next_Patient = ((Patient)binding[0]).Fullname;
                binding.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Không còn bệnh nhân nào");
            }
        }

        private void Remove_Handler(object sender, EventArgs e)
        {
            if (binding.List.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                binding.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Không còn bệnh nhân nào");
            }
        }
    }
}
