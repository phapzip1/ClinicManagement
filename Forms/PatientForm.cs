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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Rectangle = System.Drawing.Rectangle;

namespace ClinicManagement.Forms
{
    public partial class PatientForm : Form
    {
        //Giá trị
        bool isAdd = false;

        int nextP = 0;
        string patient_Name = "";
        Queue<QueueInfor> queue = new Queue<QueueInfor>();

        //Data
        static Guid patient = new Guid();
        InforForm InforForm = new InforForm();
        Patient aPatient;
        private IDataProvider provider;
        private IDataUpdater updater;
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
            updater = new DBUpdater(_clinicDbContextFactory);

            patientDetailBinding = new BindingSource() { DataSource = new List<Patient>() }; // create binding

            dtgvPatientList.DataSource = patientDetailBinding;

            ResetMonitor();

            // fill cbxGender
            cbxGender.Items.Add("Nam");
            cbxGender.Items.Add("Nữ");

            dtgvPatientList.ReadOnly= true;

            dtpkBob.MaxDate= DateTime.Now.AddDays(+1).Date;
        }

        //Hàm
        #region Hàm
        private void ResetMonitor()
        {
            tbxPatientID.Texts = "";
            //tbxPatientID.ReadOnly = true;
            tbxPatientName.Texts = "";
            tbxPatientName.ReadOnly = false;
            tbxPatientAddress.Texts = "";
            tbxPatientAddress.ReadOnly = false;
            cbxGender.SelectedIndex = -1;
            dtpkBob.Value = DateTime.Today;
        }
        #endregion

        //Sự kiện
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResetMonitor();
            tbxPatientID.ReadOnly = false;
            isAdd= true;
        }

        private void getPatient()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxPatientID.Texts.ToString() == string.Empty)
            {
                MessageBox.Show("ID không thể để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            if (res.Result.Gender == "Nam")
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
                else if (tbxPatientID.Texts == string.Empty)
                {
                    MessageBox.Show("Hãy điền mã bệnh nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    InforForm.PatientNow_id= tbxPatientID.Texts;
                    InforForm.Next_Patient= tbxPatientName.Texts;
                } 
                    
            });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isDigitPresent = tbxPatientID.Texts.ToString().Any(c => char.IsDigit(c));

            if (tbxPatientName.Texts.ToString().Length> 30)
            {
                MessageBox.Show("Tên không thể dài quá 30 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbxPatientID.Texts.ToString() == string.Empty)
            {
                MessageBox.Show("ID không thể để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isDigitPresent == false)
            {
                MessageBox.Show("ID chỉ bao gồm số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbxPatientName.Texts.ToString() == string.Empty)
            {
                MessageBox.Show("Tên không thể để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxGender.Texts.ToString() == string.Empty)
            {
                MessageBox.Show("Mời bạn chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbxPatientAddress.Texts.ToString() == string.Empty)
            {
                MessageBox.Show("Mời bạn nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Quy định
                if (isAdd)
                {
                    //Lưu thông tin bệnh nhân
                    try
                    {
                        isAdd= false;
                        ClinicDbContextFactory _clinicDbContextFactory = new ClinicDbContextFactory(InforForm.Connects_String);
                        using (ClinicDbContext dbContext = _clinicDbContextFactory.CreateDbContext())
                        {
                            IDataCreator dataCreator = new DBCreator(_clinicDbContextFactory);
                            dbContext.Database.Migrate();
                            dataCreator.CreatePatient(new Models.Patient(tbxPatientID.Texts.ToString(), tbxPatientName.Texts.ToString(), cbxGender.Texts.ToString(), dtpkBob.Value, tbxPatientAddress.Texts.ToString()));

                            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            getPatient();
                            //Đặt màn hình về mặc định
                            ResetMonitor();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Hàng hiện tại
                    int index = dtgvPatientList.SelectedRows[0].Index;
                    //Lấy id từ hàng hiện tại dtgv
                    string id = tbxPatientID.Texts.ToString();
                    string fullname = tbxPatientName.Texts.ToString();
                    string gender = cbxGender.Texts.ToString();
                    DateTime dob = dtpkBob.Value;
                    string address = tbxPatientAddress.Texts.ToString();

                    updater.UpdatePatient(new Patient(id, fullname, gender, dob, address)).ContinueWith(res =>
                    {
                        getPatient();
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    });
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn huỷ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                ResetMonitor();
                dtgvPatientList.ClearSelection();
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            getPatient();
        }

        private void dtgvPatientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvPatientList.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string id = dtgvPatientList.SelectedRows[0].Cells[0].Value + string.Empty;
                string fullname = dtgvPatientList.SelectedRows[0].Cells[1].Value + string.Empty;
                string gender = dtgvPatientList.SelectedRows[0].Cells[2].Value + string.Empty;
                string dob = dtgvPatientList.SelectedRows[0].Cells[3].Value + string.Empty;
                string address = dtgvPatientList.SelectedRows[0].Cells[4].Value + string.Empty;

                tbxPatientID.Texts = id;
                tbxPatientName.Texts = fullname;
                tbxPatientAddress.Texts = address;
                cbxGender.Texts = gender;
                dtpkBob.Text = dob;
            }
        }

        private void AppendHandler(object sender, EventArgs e)
        {
            string id = tbxPatientID.Texts.ToString();
            if (!string.IsNullOrEmpty(id))
            {
                if (Program.PatientQueue.Where(p => p.Id == id).ToList().Count == 0)
                {
                    provider.GetPatient(id).ContinueWith(res =>
                    {
                        if (!res.IsFaulted)
                        {
                            if (res.Result != null && IsHandleCreated)
                            {
                                if (IsHandleCreated)
                                {
                                    tbxPatientID.Invoke((MethodInvoker)delegate
                                    {
                                        Program.PatientQueue.Add(res.Result);
                                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    });
                                }
                            }
                        }
                    });
                }
                else
                {
                    MessageBox.Show("Bệnh nhân đã có trong hàng đợi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 bệnh nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbxPatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
