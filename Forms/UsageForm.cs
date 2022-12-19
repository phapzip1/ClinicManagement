using ClinicManagement.DbContexts;
using ClinicManagement.Models;
using ClinicManagement.Services;
using DatabaseProject;
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
    public partial class UsageForm : Form
    {
        DBAccess dBAccess = new DBAccess();

        public UsageForm()
        {
            InitializeComponent();

            ResetMonitor1();
            ReserMonitor2();
        }

        //Hàm 
        private void ResetMonitor1()
        {
            //tbxUnitID.Texts = string.Empty;
            tbxUnitName.Text = string.Empty;

            //tbxUnitID.ReadOnly= false;
            tbxUnitName.ReadOnly= false;
        }

        private void ReserMonitor2()
        {
            //tbxUsageID.Text = string.Empty;
            tbxUsageName.Text = string.Empty;

           // tbxUsageID.ReadOnly= false;
            tbxUsageName.ReadOnly= false;
        }
        //Xử lý
        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            tbxUnitName.ReadOnly= false;
        }

        private void btnUpdateUnit_Click(object sender, EventArgs e)
        {
            string tendv = tbxUsageName.Texts.ToString();
            if(tendv.Length > 20)
                MessageBox.Show("Tên đơn vị quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

            }
        }

        private void btnSaveUnit_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();

            if (tbxUnitName.Texts.Length == 0)
            {
                MessageBox.Show("Hãy nhập tên đơn vị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        dataCreator.CreateUnit(new Models.Unit(guid, tbxUnitName.Texts.ToString()));
                        MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNotSaveUnit_Click(object sender, EventArgs e)
        {
            ResetMonitor1();
        }

        private void btnSaveUsage_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();

            if (tbxUnitName.Texts.Length == 0)
            {
                MessageBox.Show("Hãy nhập tên đơn vị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        //dataCreator.CreateUsageReport(new Models.Unit(guid, tbxUnitName.Texts.ToString()));
                        MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddUsage_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchUnit_Click(object sender, EventArgs e)
        {

        }
    }
}
