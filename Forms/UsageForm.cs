using ClinicManagement.Classes;
using ClinicManagement.DbContexts;
using ClinicManagement.Models;
using ClinicManagement.Services;
using DatabaseProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;
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
        Guid guid1;
        bool isAdd = false;

        private IDataProvider provider;
        private BindingSource UnitUsageBinding;
        private BindingSource UsageUsageBinding;
        private ClinicDbContextFactory _clinicDbContextFactory;
        private IDataUpdater updater;

        public UsageForm()
        {
            InitializeComponent();

            _clinicDbContextFactory = new ClinicDbContextFactory(Program.Configuration.GetSection("ConnectionStrings").Value.ToString());

            UnitUsageBinding = new BindingSource(){ DataSource= new List<Unit>()};
            UsageUsageBinding = new BindingSource() { DataSource= new List<Method>()};

            provider = new DBProvider(_clinicDbContextFactory);
            updater = new DBUpdater(_clinicDbContextFactory);

            dtgvUnit.DataSource = UnitUsageBinding;
            dtgvUnit.Columns["Id"].Visible= false;

            dtgvUsage.DataSource= UsageUsageBinding;
            dtgvUsage.Columns["Id"].Visible= false;

            ResetMonitor1();
            ReserMonitor2();
        }

        //Hàm 
        private void ResetMonitor1()
        {
            tbxUnitName.Text = string.Empty;
            tbxUnitName.ReadOnly= false;
        }

        private void ReserMonitor2()
        {
            tbxUsageName.Text = string.Empty;
            tbxUsageName.ReadOnly= false;
        }
        //Xử lý
        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            guid1= Guid.NewGuid();
            tbxUnitName.ReadOnly= false;
            isAdd= true;
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
            if (tbxUnitName.Texts.Length == 0)
            {
                MessageBox.Show("Phải có tên đơn vị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isAdd == false)
            {
                int index = dtgvUnit.SelectedRows[0].Index;
                Guid id =((Unit)UnitUsageBinding.List[index]).Id;
                string unitname = tbxUnitName.Texts.ToString();
                updater.UpdateUnit(new Unit(id, unitname)).ContinueWith(res =>
                {
                    getUnit();
                });
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
                        dataCreator.CreateUnit(new Models.Unit(guid1, tbxUnitName.Texts.ToString()));
                        MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getUnit();
                        isAdd= false;
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
            else if (isAdd == false)
            {
                int index = dtgvUsage.SelectedRows[0].Index;
                Guid id = ((Unit)UsageUsageBinding.List[index]).Id;
                string usagename = tbxUsageName.Texts.ToString();
                updater.UpdateUnit(new Unit(id, usagename)).ContinueWith(res =>
                {
                    getMethod();
                });
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
                        dataCreator.CreateMethod(new Models.Method(guid, tbxUsageName.Texts.ToString()));
                        MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getMethod();
                        isAdd= false;
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
            guid1= Guid.NewGuid();
            tbxUsageName.ReadOnly= false;
            isAdd= true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUnitDel_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dtgvUnit.SelectedRows[0].Index;
                Guid id = ((Unit)UnitUsageBinding.List[index]).Id;
                updater.RemoveUnit(id).ContinueWith(res =>
                {
                    getUnit();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsageDel_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dtgvUsage.SelectedRows[0].Index;
                Guid id = ((Method)UsageUsageBinding.List[index]).Id;
                updater.RemoveMethod(id).ContinueWith(res =>
                {
                    getMethod();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNotSaveUsage_Click(object sender, EventArgs e)
        {

        }

        private void dtgvUnit_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UsageForm_Load(object sender, EventArgs e)
        {
            //Unit
            getUnit();

            //Usage (Method)
            getMethod();
        }

        private void getMethod()
        {
            provider.GetAllMethods().ContinueWith(res =>
            {
                if (IsHandleCreated)
                {
                    if (res.Result.Count() >= 1)
                    {
                        dtgvUsage.Invoke((MethodInvoker)delegate
                        {
                            UsageUsageBinding.Clear();
                            int i = 1;
                            foreach (var item in res.Result)
                            {
                                UsageUsageBinding.Add(item);
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

        private void getUnit()
        {
            provider.GetAllUnits().ContinueWith(res =>
            {
                if (IsHandleCreated)
                {
                    if (res.Result.Count() >= 1)
                    {
                        dtgvUnit.Invoke((MethodInvoker)delegate
                        {
                            UnitUsageBinding.Clear();
                            int i = 1;
                            foreach (var item in res.Result)
                            {
                                UnitUsageBinding.Add(item);
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

        private void UsageForm_LocationChanged(object sender, EventArgs e)
        {

        }
    }
}
