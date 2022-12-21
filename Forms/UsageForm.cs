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
        bool isAdd1 = false;
        bool isAdd2 = false;    

        private IDataProvider provider;
        private BindingSource UnitUsageBinding;
        private BindingSource UsageUsageBinding;
        private ClinicDbContextFactory _clinicDbContextFactory;
        private IDataUpdater updater;

        public UsageForm()
        {
            InitializeComponent();

            //Nối với csdl
            _clinicDbContextFactory = new ClinicDbContextFactory(Program.Configuration.GetSection("ConnectionStrings").Value.ToString());
            provider = new DBProvider(_clinicDbContextFactory);
            updater = new DBUpdater(_clinicDbContextFactory);

            //Xử lý datagridview
            UnitUsageBinding = new BindingSource(){ DataSource= new List<Unit>()};
            UsageUsageBinding = new BindingSource() { DataSource= new List<Method>()};

            dtgvUnit.DataSource = UnitUsageBinding;
            dtgvUnit.Columns["Id"].Visible= false;

            dtgvUsage.DataSource= UsageUsageBinding;
            dtgvUsage.Columns["Id"].Visible= false;

            //ResetMonitor1();
            //ReserMonitor2();
        }

        //Hàm 
        #region Hàm
        private void ResetMonitor1()
        {
            tbxUnitName.Texts = "";
            tbxUnitName.ReadOnly= false;
        }

        private void ReserMonitor2()
        {
            tbxUsageName.Texts = "";
            tbxUsageName.ReadOnly= false;
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
                        MessageBox.Show("Không tìm thấy cách dùng!", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Không tìm thấy đơn vị!", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            });
        }
        #endregion

        //Xử lý

        //Thêm đơn vị
        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            guid1= Guid.NewGuid();
            ResetMonitor1();
            isAdd1= true;
        }

        //Lưu cái thêm || Chỉnh sửa những gì chọn trên dtgv
        private void btnSaveUnit_Click(object sender, EventArgs e)
        {
            //Cập nhật
            if (isAdd1 == false)
            {
                //Hàng hiện tại
                int index = dtgvUnit.SelectedRows[0].Index;
                //Lấy id từ hàng hiện tại dtgv
                Guid id =((Unit)UnitUsageBinding.List[index]).Id;

                string unitname = tbxUnitName.Texts.ToString();
                updater.UpdateUnit(new Unit(id, unitname)).ContinueWith(res =>
                {
                    getUnit();
                    MessageBox.Show("Cập nhật đơn vị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
            }
            //Thêm
            else
            {
                if (tbxUnitName.Texts.Length == 0)
                {
                    MessageBox.Show("Phải có tên đơn vị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                        isAdd1= false;
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
            DialogResult= MessageBox.Show("Bạn chắc chắn muốn huỷ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                ResetMonitor1();
                isAdd1= false;
                dtgvUnit.ClearSelection();
            }
        }

        private void btnSaveUsage_Click(object sender, EventArgs e)
        {
            if (isAdd2 == false)
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
                if (tbxUnitName.Texts.Length == 0)
                {
                    MessageBox.Show("Hãy nhập tên đơn vị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    ClinicDbContextFactory _clinicDbContextFactory = new ClinicDbContextFactory(InforForm.Connects_String);
                    using (ClinicDbContext dbContext = _clinicDbContextFactory.CreateDbContext())
                    {
                        IDataCreator dataCreator = new DBCreator(_clinicDbContextFactory);
                        dbContext.Database.Migrate();
                        dataCreator.CreateMethod(new Models.Method(guid1, tbxUsageName.Texts.ToString()));
                        MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getMethod();
                        isAdd2= false;
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
            isAdd2= true;
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
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNotSaveUsage_Click(object sender, EventArgs e)
        {
            DialogResult= MessageBox.Show("Bạn chắc chắn muốn huỷ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                ReserMonitor2();
                isAdd2= false;
                dtgvUsage.ClearSelection();
            }
        }

        private void UsageForm_Load(object sender, EventArgs e)
        {
            //Unit
            getUnit();

            //Usage (Method)
            getMethod();
        }

        private void UsageForm_LocationChanged(object sender, EventArgs e)
        {

        }

        private void dtgvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvUnit.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                //int index = dtgvUnit.SelectedRows[0].Index;

                DataGridViewRow row = this.dtgvUnit.Rows[e.RowIndex];
                tbxUnitName.Texts = row.Cells[1].Value.ToString();
                //string value = dtgvUsage.SelectedRows[0].Cells["Unit"].Value + string.Empty;

                //tbxUnitName.Text = value;   
            }
        }

        private void dtgvUsage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvUsage.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string value = dtgvUsage.SelectedRows[0].Cells[1].Value + string.Empty;

                tbxUsageName.Texts = value;
            }
        }
    }
}
