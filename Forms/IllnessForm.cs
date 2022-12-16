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

namespace ClinicManagement.Forms
{
    public partial class IllnessForm : Form
    {
        public IllnessForm()
        {
            InitializeComponent();

            ResetMonitor();
        }

        //Hàm
        private void ResetMonitor()
        {
            tbxIllnessName.Texts = string.Empty;
            tbxIllnessName.ReadOnly= true;
            tbxIllnessSympton.Texts = string.Empty;
            tbxIllnessSympton.ReadOnly= true;
        }

        private void StartMonitor()
        {
            tbxIllnessName.Texts = string.Empty;
            tbxIllnessName.ReadOnly= false;
            tbxIllnessSympton.Texts = string.Empty;
            tbxIllnessSympton.ReadOnly= false;
        }

        //Sự kiện

        private void btnAddIllness_Click(object sender, EventArgs e)
        {
            StartMonitor();
        }

        private void btnUpdateIllness_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveIllness_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();

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
                        MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNotSaveIllness_Click(object sender, EventArgs e)
        {
            DialogResult= MessageBox.Show("Bạn chắc chắn muốn huỷ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                ResetMonitor();
            }
        }
    }
}
