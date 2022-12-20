using ClinicManagement.DbContexts;
using ClinicManagement.Models;
using ClinicManagement.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ClinicManagement.Forms
{
    public partial class IllnessForm : Form
    {
        private IDataProvider provider;
        private BindingSource IllnessBinding;
        private ClinicDbContextFactory _clinicDbContextFactory;
        private IDataUpdater updater;

        bool isSave = false;
        public IllnessForm()
        {
            InitializeComponent();

            _clinicDbContextFactory = new ClinicDbContextFactory(Program.Configuration.GetSection("ConnectionStrings").Value.ToString());
            provider = new DBProvider(_clinicDbContextFactory);
            updater = new DBUpdater(_clinicDbContextFactory);

            //dtgv
            IllnessBinding = new BindingSource() { DataSource= new List<Illness>() };

            dtgvIllnessList.DataSource = IllnessBinding;
            dtgvIllnessList.Columns["Id"].Visible = false;

            ResetMonitor();
        }

        //Hàm
        private void ResetMonitor()
        {
            tbxIllnessName.Texts = string.Empty;
            tbxIllnessName.ReadOnly= false;
            tbxIllnessSympton.Texts = string.Empty;
            tbxIllnessSympton.ReadOnly= false;
        }

        private void StartMonitor()
        {
            tbxIllnessName.Texts = string.Empty;
            tbxIllnessName.ReadOnly= false;
            tbxIllnessSympton.Texts = string.Empty;
            tbxIllnessSympton.ReadOnly= false;
        }
        private void getIllness()
        {
            provider.GetAllIllness().ContinueWith(res =>
            {
                if (IsHandleCreated)
                {
                    if (res.Result.Count() >= 1)
                    {
                        dtgvIllnessList.Invoke((MethodInvoker)delegate
                        {
                            IllnessBinding.Clear();
                            int i = 1;
                            foreach (var item in res.Result)
                            {
                                IllnessBinding.Add(item);
                            }
                        });
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin!", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            });
        }

        //Sự kiện

        private void btnAddIllness_Click(object sender, EventArgs e)
        {
            StartMonitor();
            isSave= true;
        }
        private void btnSaveIllness_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();
            if (isSave)
            {
                if (tbxIllnessSympton.Texts.Length == 0)
                {
                    MessageBox.Show("Hãy nhập triệu chứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tbxIllnessName.Texts.Length == 0)
                {
                    MessageBox.Show("Hãy nhập tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        ClinicDbContextFactory _clinicDbContextFactory = new ClinicDbContextFactory(InforForm.Connects_String);
                        using (ClinicDbContext dbContext = _clinicDbContextFactory.CreateDbContext())
                        {
                            IDataCreator dataCreator = new DBCreator(_clinicDbContextFactory);
                            dbContext.Database.Migrate();
                            dataCreator.CreateIllness(new Models.Illness(guid, tbxIllnessName.Texts.ToString(), tbxIllnessSympton.Texts.ToString()));
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getIllness();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                int index = dtgvIllnessList.SelectedRows[0].Index;
                Guid id = ((Illness)IllnessBinding.List[index]).Id;
                string illnessname = tbxIllnessName.Texts.ToString();
                string sympton = tbxIllnessSympton.Texts.ToString();
                updater.UpdateIllness(new Illness(id, illnessname, sympton)).ContinueWith(res =>
                {
                    getIllness();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
            }
        }

        private void btnNotSaveIllness_Click(object sender, EventArgs e)
        {
            DialogResult= MessageBox.Show("Bạn chắc chắn muốn huỷ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                ResetMonitor();
                isSave= false;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dtgvIllnessList.SelectedRows[0].Index;
                Guid id = ((Illness)IllnessBinding.List[index]).Id;
                updater.RemoveIllness(id).ContinueWith(res =>
                {
                    getIllness();
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IllnessForm_Load(object sender, EventArgs e)
        {
            getIllness();
        }
    }
}
