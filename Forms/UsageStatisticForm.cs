using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace ClinicManagement.Forms
{
    public partial class UsageStatisticForm : Form
    {
        DataTable dtBAOCAOSUDUNGTHUOC = new DataTable();       
        DBAccess dBAccess = new DBAccess();
        int yearnow = DateTime.Now.Year;
        int monthnow = DateTime.Now.Month;
        public UsageStatisticForm()
        {
            InitializeComponent();            

            dataGridView4.AllowUserToAddRows = false;         
            saveFileDialog1.Filter = "Excel |*.xlsx";
            saveFileDialog1.Title = "Báo cáo doanh thu theo tháng";


            cbbMonth.Texts = "10";
            cbbYear.Texts = "2022";
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
                MessageBox.Show("Chúc mừng. Bạn đã xuất dữ liệu ra Excel thành công!", "Thông Báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dataGridView4.Rows.Count == 0)
                MessageBox.Show("Chưa có thông tin để in. Vui lòng chọn 'Xem báo cáo' trước khi in!", "Thông Báo !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dataGridView4, saveFileDialog1.FileName);
            }
        }
        private void btnSeeInformation2_Click(object sender, EventArgs e)
        {
            string month = cbbMonth.SelectedItem.ToString();
            string year = cbbYear.SelectedItem.ToString();

            dataGridView4.Rows.Clear();
            dtBAOCAOSUDUNGTHUOC.Clear();
            string query = "Select * from BAOCAOSUDUNGTHUOC Where THANG = '" + Int32.Parse(month) + "' and NAM = '" + Int32.Parse(year) + "'";
            dBAccess.readDatathroughAdapter(query, dtBAOCAOSUDUNGTHUOC);


            if (dtBAOCAOSUDUNGTHUOC.Rows.Count >= 1)
            {
                for (int i = 0; i < dtBAOCAOSUDUNGTHUOC.Rows.Count; i++)
                {   // STT, Thuốc, đơn vị tính, số lượng, số lần dùng
                    dataGridView4.Rows.Add(i + 1, dtBAOCAOSUDUNGTHUOC.Rows[i]["MATHUOC"].ToString(), dtBAOCAOSUDUNGTHUOC.Rows[i]["DONVITINH"].ToString(), dtBAOCAOSUDUNGTHUOC.Rows[i]["SLDUNG"].ToString(), dtBAOCAOSUDUNGTHUOC.Rows[i]["SOLANDUNG"].ToString());

                }            
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin. Vui lòng chọn thời gian khác !", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UsageStatisticForm_Load(object sender, EventArgs e)
        {
            cbbMonth.SelectedItem = monthnow.ToString();
            cbbYear.SelectedItem = yearnow.ToString();
        }
    }
}
