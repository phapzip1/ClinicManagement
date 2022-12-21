using ClinicManagement.DbContexts;
using ClinicManagement.Services;

namespace ClinicManagement.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private ClinicDbContextFactory factory;
        private IDataUpdater updater;
        public ChangePasswordForm()
        {
            InitializeComponent();
            factory = new ClinicDbContextFactory(Program.Configuration.GetSection("ConnectionStrings").Value.ToString());
            updater = new DBUpdater(factory);
        }

        private void ConfirmHandler(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_repassword.Texts) && !string.IsNullOrEmpty(_repassword.Texts))
            {
                if (_repassword.Texts == _password.Texts)
                {
                    updater.UpdatePassword(_password.Texts).ContinueWith(res =>
                    {
                        MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    });
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelHandler(object sender, EventArgs e)
        {
            Close();
        }

    }
}
