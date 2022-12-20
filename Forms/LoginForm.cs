using ClinicManagement.DbContexts;
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
    public partial class LoginForm : Form
    {
        private ClinicDbContextFactory factory;
        private IDataProvider provider;
        private bool success = false;

        public bool IsSuccess { get => success; }

        public LoginForm()
        {
            InitializeComponent();
            factory = new ClinicDbContextFactory(Program.Configuration.GetSection("ConnectionStrings").Value.ToString());
            provider = new DBProvider(factory);
        }

        private void LoginHandler(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_username.Texts) && !string.IsNullOrEmpty(_password.Texts))
            {
                string uname = _username.Texts, password = _password.Texts;
                if (uname == "admin")
                {
                    provider.VerifyPassword(password).ContinueWith(res =>
                    {
                        if (res.Result)
                        {
                            if (IsHandleCreated)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    MessageBox.Show("Đăng nhập thành công");
                                    this.success = true;
                                    this.Close();
                                });
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                        }
                    });
                }
                else
                {
                    MessageBox.Show("Username hoặc mật khẩu không chính xác");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
        }

        private void CancelHandler(object sender, EventArgs e)
        {
            Close();
        }
    }
}
