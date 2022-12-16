using ClinicManagement.DbContexts;
using ClinicManagement.DTOs;
using ClinicManagement.Models;
using ClinicManagement.Services;
using DatabaseProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Office.Interop.Excel;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Rectangle = System.Drawing.Rectangle;

namespace ClinicManagement.Forms
{
    public partial class PatientForm : Form
    {
        //Giá trị
        bool timer = false;
        //DBAccess dBAccess = new DBAccess();

        int max_Patient = 40;
        int nextP = 0;

        static Guid patient = new Guid();
        InforForm InforForm = new InforForm();
        Patient aPatient;

        //Khởi tạo
        public PatientForm()
        {
            InitializeComponent();

            lblNextPatient.Text = Models.InforForm.Next_Patient.ToString();
            ResetMonitor();

            try
            {
                /*
                 * Nạp số bệnh nhân tối đa trong ngày vào max_Patient
                 */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // fill cbxGender
            cbxGender.Items.Add("Nam");
            cbxGender.Items.Add("Nữ");
        }

        //Hàm
        private void ResetMonitor()
        {
            //Đặt màn hình về mặc định
            tbxPatientID.Texts = "";
            tbxPatientID.ReadOnly = true;
            tbxPatientName.Texts = "";
            tbxPatientName.ReadOnly = true;
            tbxPatientAddress.Texts = "";
            tbxPatientAddress.ReadOnly = true;
            dtpkBob.Value = DateTime.Now;
            cbxGender.SelectedIndex = -1;
            //timerPatient.Enabled = false;
        }

        private void StartMonitor()
        {
                tbxPatientID.Texts = "";
                tbxPatientID.ReadOnly = false;
                tbxPatientName.Texts = "";
                tbxPatientName.ReadOnly = false;
                tbxPatientAddress.Texts = "";
                tbxPatientAddress.ReadOnly = false;
            cbxGender.SelectedIndex = -1;
                dtpkBob.Value = DateTime.Today;
        }

        private void LoadDtgv()
        {

        }

        //Sự kiện
        private void btnAdd_Click(object sender, EventArgs e)
        {
            StartMonitor();
            //Tạo mã bệnh nhân mới
            //tbxPatientID.Texts = patient.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ClinicDbContextFactory _dbContextFactory = new ClinicDbContextFactory(InforForm.Connects_String);
                using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
                {
                    //IDataProvider dataProvider = new DBProvider(_dbContextFactory);
                    dbContext.Database.Migrate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (InforForm.Patient_Count >= max_Patient) {
                MessageBox.Show("Vượt quá số bệnh nhân có thể tiếp nhận trong ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(tbxPatientIDNow.Texts == string.Empty) {
                MessageBox.Show("Hãy điền mã bệnh nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            else
            {
                InforForm.Patient_Count++;

                dtgvQueue.Rows.Add("1", "1");
                dtgvQueue.Rows.Add("2", "2");
                dtgvQueue.Rows.Add("3", "3");
                
                if (dtgvQueue.Rows.Count > 0)
                {
                    dtgvQueue.Rows[1].Selected= true;
                    int firstRowIndex = dtgvQueue.SelectedRows.Count - 1;
                    Models.InforForm.Next_Patient = dtgvQueue.SelectedRows[firstRowIndex].Cells[0].Value.ToString();
                    dtgvQueue.Rows[1].Selected= false;
                    lblNextPatient.Text = InforForm.Next_Patient;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender;
            if (cbxGender.SelectedItem.ToString() == "Nam") { gender = "male"; }
            else { gender = "female"; }

            //aPatient = new Patient(tbxPatientID.Text.ToString(), fullname, gender, dtpkBob.Value, tbxPatientAddress.Text.ToString());

            //Quy định
            if (tbxPatientName.Texts.ToString().Length> 30)
            {
                MessageBox.Show("Tên quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(tbxPatientID.Texts.ToString() == "")
            {
                MessageBox.Show("ID không thể để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Lưu thông tin bệnh nhân
            try
            {
                ClinicDbContextFactory _clinicDbContextFactory = new ClinicDbContextFactory(InforForm.Connects_String);
                using (ClinicDbContext dbContext = _clinicDbContextFactory.CreateDbContext())
                {
                    IDataCreator dataCreator = new DBCreator(_clinicDbContextFactory);
                    dbContext.Database.Migrate();
                    dataCreator.CreatePatient(new Models.Patient(tbxPatientID.Texts.ToString(), tbxPatientName.Texts.ToString(), gender, dtpkBob.Value, tbxPatientAddress.Texts.ToString()));

                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //lblNiceSave.Show();
                    //timerPatient.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Đặt màn hình về mặc định
            ResetMonitor();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn huỷ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            ResetMonitor();
        }

        private void timerPatient_Tick(object sender, EventArgs e)
        {
            //lblNiceSave.Hide();
            //timerPatient.Enabled = false;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string searchValue = tbxPatientIDNow.Text.ToString();

            dtgvQueue.Rows.Remove(dtgvQueue.Rows[0]);

            if (dtgvQueue.Rows.Count > 0)
            {
                dtgvQueue.Rows[1].Selected= true;
                int firstRowIndex = dtgvQueue.SelectedRows.Count - 1;
                Models.InforForm.Next_Patient = dtgvQueue.SelectedRows[firstRowIndex].Cells[0].Value.ToString();
                MessageBox.Show(InforForm.Next_Patient, "Tb", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgvQueue.Rows[1].Selected= false;
                lblNextPatient.Text = InforForm.Next_Patient;
            }
        }

        private void rbtnPatientFemale_Paint(object sender, PaintEventArgs e)
        {
            Graphics graph = e.Graphics;

            //Draw border
            using (Pen penBorder = new Pen(Color.CornflowerBlue, 2))
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            DataGridViewRow curr_row = dtgvQueue.Rows[0];
            int curr_index = dtgvQueue.Rows.GetLastRow(DataGridViewElementStates.Visible);
            dtgvQueue.Rows.Remove(curr_row);
            dtgvQueue.Rows.Insert(curr_index, curr_row);

            if (dtgvQueue.Rows.Count > 0)
            {
                dtgvQueue.Rows[1].Selected= true;
                int firstRowIndex = dtgvQueue.SelectedRows.Count - 1;
                Models.InforForm.Next_Patient = dtgvQueue.SelectedRows[firstRowIndex].Cells[0].Value.ToString();
                MessageBox.Show(InforForm.Next_Patient, "Tb", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgvQueue.Rows[1].Selected= false;
                lblNextPatient.Text = InforForm.Next_Patient;
            }
        }
    }
}
