using ClinicManagement.Classes;
using ClinicManagement.DbContexts;
using ClinicManagement.Models;
using ClinicManagement.Services;
using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicManagement.Forms
{
    public partial class StatisticForm : Form
    {
        int yearnow = DateTime.Now.Year;
        int monthnow = DateTime.Now.Month;

        private BindingSource medicineDetailBinding;
        private ClinicDbContextFactory factory;
        private IDataProvider provider;

        public StatisticForm()
        {
            InitializeComponent();
            factory = new ClinicDbContextFactory(Program.Configuration.GetSection("ConnectionStrings").Value.ToString()); // create location contact 
            provider = new DBProvider(factory); // receive data 
            medicineDetailBinding = new BindingSource() { DataSource = new List<IndexStatistic>() }; // create binding
            dataGridView1.DataSource = medicineDetailBinding;


            dataGridView1.AllowUserToAddRows = false;         
            saveFileDialog1.Filter = "Excel |*.xlsx";
            saveFileDialog1.Title = "Báo cáo doanh thu theo tháng";
           
            for (int i=2000; i <= yearnow ; i++)  // fill cbbYear
            {
                cbbYear.Items.Add(i.ToString());
            }
            
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Báo cáo";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();                       
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Chúc mừng. Bạn đã xuất dữ liệu ra Excel thành công!","Thông Báo !!", MessageBoxButtons.OK,MessageBoxIcon.Information );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {                      
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Chưa có thông tin để in. Vui lòng chọn 'Xem báo cáo' trước khi in!", "Thông Báo !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dataGridView1, saveFileDialog1.FileName);
            }
        }

        private void btnSeeInformation_Click_1(object sender, EventArgs e)
        {
            int totalpatients = 0;
            int totalrevenue = 0;
            string month = cbbMonth.SelectedItem.ToString();          
            string year = cbbYear.SelectedItem.ToString();

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            provider.GetStatistic(int.Parse(month), int.Parse(year)).ContinueWith(res =>
            {
                if (res.Result.Count() >= 1) {
                    dataGridView1.Invoke((MethodInvoker)delegate
                    {
                        int i = 1;
                        foreach (var item in res.Result)
                        {
                            medicineDetailBinding.Add(new IndexStatistic(i++, item));
                            totalpatients += item.PatientCount;
                            totalrevenue += item.Revenue;
                        }
                        lbltotalpatients.Text = totalpatients.ToString() + " người";
                        lbltotalrevenue.Text = totalrevenue.ToString() + " VNĐ";
                        groupBox1.Text = "Tổng hợp báo cáo tháng " + month.ToString() + " năm " + year.ToString();
                    });

                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin. Vui lòng chọn thời gian khác !", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbltotalpatients.Text = "........................................";
                    lbltotalrevenue.Text = "........................................";
                    groupBox1.Text = "Tổng hợp báo cáo";
                }
                
            });
        }
        private void StatisticForm_Load(object sender, EventArgs e)
        {          
            cbbMonth.SelectedItem = monthnow.ToString();          
            cbbYear.SelectedItem = yearnow.ToString();
        }
    }
}