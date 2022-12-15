using DatabaseProject;
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
            //tbxUnitID.ReadOnly= true;
            int _id = 1;
            _id = dBAccess.executeQuery("SELECT TOP 1 MADV FROM DONVI ORDER BY MADV DESC");
            if (_id > 1) { _id = _id + 1; }
            else _id = 1;
            //tbxUnitID.Texts = _id.ToString();
        }

        private void btnUpdateUnit_Click(object sender, EventArgs e)
        {
            string tendv = tbxUsageName.Texts.ToString();
            if(tendv.Length > 20)
                MessageBox.Show("Tên đơn vị quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSaveUnit_Click(object sender, EventArgs e)
        {

        }

        private void btnNotSaveUnit_Click(object sender, EventArgs e)
        {
            ResetMonitor1();
        }
    }
}
