using ClinicManagement.Classes;
using ClinicManagement.DbContexts;
using ClinicManagement.DTOs;
using ClinicManagement.Models;
using ClinicManagement.Services;
using DatabaseProject;
using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Office.Interop.Excel;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
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

        int nextP = 0;
        string patient_Name = "";
        Queue<QueueInfor> queue = new Queue<QueueInfor>();

        //Data
        static Guid patient = new Guid();
        InforForm InforForm = new InforForm();
        Patient aPatient;
        private IDataProvider provider;
        private BindingList<ComboboxItem> bindingLists;
        private BindingSource patientDetailBinding;

        private ClinicDbContextFactory _clinicDbContextFactory;

        private Dictionary<string, int> dic;

        //Khởi tạo
        public PatientForm()
        {
            InitializeComponent();

            _clinicDbContextFactory = new ClinicDbContextFactory(Program.Configuration.GetSection("ConnectionStrings").Value.ToString());
            bindingLists = new BindingList<ComboboxItem>();

            provider = new DBProvider(_clinicDbContextFactory); // receive data 

            patientDetailBinding = new BindingSource() { DataSource = new List<Patient>() }; // create binding

            dtgvPatientList.DataSource = patientDetailBinding;

            lblNextPatient.Text = Models.InforForm.Next_Patient.ToString();
            ResetMonitor();

            // fill cbxGender
            cbxGender.Items.Add("Nam");
            cbxGender.Items.Add("Nữ");

            dtgvQueue.AllowUserToAddRows = false;
            dtgvQueue.ReadOnly= true;
            dtgvPatientList.ReadOnly= true;
        }

        //Hàm
        #region Hàm
        private void ResetMonitor()
        {
            //Đặt màn hình về mặc định
            //tbxPatientID.Texts = "";
            //tbxPatientID.ReadOnly = true;
            //tbxPatientName.Texts = "";
            //tbxPatientName.ReadOnly = true;
            //tbxPatientAddress.Texts = "";
            //tbxPatientAddress.ReadOnly = true;
            //dtpkBob.Value = DateTime.Now;
            //cbxGender.SelectedIndex = -1;

            tbxPatientID.Texts = "";
            tbxPatientID.ReadOnly = false;
            tbxPatientName.Texts = "";
            tbxPatientName.ReadOnly = false;
            tbxPatientAddress.Texts = "";
            tbxPatientAddress.ReadOnly = false;
            cbxGender.SelectedIndex = -1;
            dtpkBob.Value = DateTime.Today;
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

        private void UpLoadDtgv()
        {
            dtgvQueue.DataSource = queue.ToList();
            dtgvQueue.Show();
        }
        #endregion

        //Sự kiện
        private void btnAdd_Click(object sender, EventArgs e)
        {
            StartMonitor();
            //Tạo mã bệnh nhân mới
            //tbxPatientID.Texts = patient.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = tbxPatientID.Texts.ToString();
            try
            {
                provider.GetPatient(id).ContinueWith(res =>
                {
                    if(res.Result != null)
                    {
                        tbxPatientName.Invoke((MethodInvoker)delegate
                        {
                            tbxPatientName.Texts = res.Result.Fullname;
                            tbxPatientAddress.Texts = res.Result.Address;
                            if (res.Result.Gender == "male")
                            {
                                cbxGender.SelectedIndex = 0;
                            }
                            else { cbxGender.SelectedIndex = 1; }
                            dtpkBob.Value = res.Result.Dob;
                        });
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            provider.GetParams().ContinueWith(res =>
            {
                int max_Patient = res.Result["MaxPatients"];
                if (InforForm.Patient_Count >= max_Patient)
                {
                    MessageBox.Show("Vượt quá số bệnh nhân có thể tiếp nhận trong ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tbxPatientIDNow.Texts == string.Empty)
                {
                    MessageBox.Show("Hãy điền mã bệnh nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
            
            InforForm.Patient_Count++;
            InforForm.Next_Patient = InforForm.Patient_Count.ToString();
            lblNextPatient.Text = InforForm.Next_Patient;

            queue.Enqueue(new QueueInfor(lblNextPatient.Text, tbxPatientIDNow.Texts.ToString()));
            UpLoadDtgv();
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

                    dtgvPatientList.Rows.Add(new Models.Patient(tbxPatientID.Texts.ToString(), tbxPatientName.Texts.ToString(), gender, dtpkBob.Value, tbxPatientAddress.Texts.ToString()));
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
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            InforForm.PatientNow_id= tbxPatientIDNow.Text.ToString();

            queue.Dequeue();
            UpLoadDtgv();
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
            queue.Dequeue();
            UpLoadDtgv();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            try
            {
                provider.GetAllPatients().ContinueWith(res =>
                {
                    if (IsHandleCreated)
                    {
                        if (res.Result.Count() >= 1)
                        {
                            dtgvPatientList.Invoke((MethodInvoker)delegate
                            {
                                patientDetailBinding.Clear();
                                foreach (var item in res.Result)
                                {
                                    patientDetailBinding.Add(item);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
