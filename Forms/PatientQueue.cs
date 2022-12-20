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

        private void Add_Handler(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_patient.Texts))
            {
                string id = _patient.Texts;
                Patient obj = Program.PatientQueue.FirstOrDefault(p => p.Id == id);
                if (obj == null)
                {
                    provider.GetPatientById(id).ContinueWith(res =>
                    {
                        if (!res.IsFaulted)
                        {
                            if (IsHandleCreated)
                            {
                                dataGridView1.Invoke((MethodInvoker)delegate
                                {
                                    binding.Add(res.Result);
                                    Program.PatientQueue.Add(res.Result);
                                });
                            }
                        }
                    });
                }
                else
                {
                    MessageBox.Show("Đã tồn tại bệnh nhân!");
                }
            }
            else
            {
                MessageBox.Show("Trường mã bệnh nhân trống!");
            }
        }

        private void Append_Handler(object sender, EventArgs e)
        {
            if (binding.List.Count > 0)
            {
                binding.Remove(binding.List[0]);
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
