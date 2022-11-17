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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ClinicManagement.Forms
{
    public partial class ImportStatistic : Form
    {
        DataTable dtBAOCAONHAPTHUOC = new DataTable();      
        DBAccess dBAccess = new DBAccess();
        public ImportStatistic()
        {
            InitializeComponent();
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "MM yyyy";
            dateTimePicker3.ShowUpDown = true;

            dataGridView1.AllowUserToAddRows = false;
            saveFileDialog1.Filter = "Excel |*.xlsx";
            saveFileDialog1.Title = "Báo cáo doanh thu theo tháng";
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
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dataGridView1, saveFileDialog1.FileName);
            }
        }
        private void btnSeeInformation3_Click(object sender, EventArgs e)
        {
            string month = dateTimePicker3.Value.ToString("MM");
            string year = dateTimePicker3.Value.ToString("yyyy");

            dtBAOCAONHAPTHUOC.Clear();
            dataGridView1.Rows.Clear();
            

            string query1 = "Select CTNHAPTHUOC.MATHUOC , THUOC.MADONVI, TENDV, SLNHAP, SLTON, PHIEUNHAPTHUOC.TONGTIEN from CTNHAPTHUOC, PHIEUNHAPTHUOC, THUOC, DONVI Where CTNHAPTHUOC.SOPHIEU = PHIEUNHAPTHUOC.SOPHIEU and CTNHAPTHUOC.MATHUOC = THUOC.MATHUOC and THUOC.MADONVI = DONVI.MADV and month(NGAYLAP) = '" + Int32.Parse(month) + "' and year(NGAYLAP) = '" + Int32.Parse(year) + "'";
            dBAccess.readDatathroughAdapter(query1, dtBAOCAONHAPTHUOC);

            if (dtBAOCAONHAPTHUOC.Rows.Count >= 1)
            {
                for (int i = 0; i < dtBAOCAONHAPTHUOC.Rows.Count; i++)
                {   
                    dataGridView1.Rows.Add(i + 1, dtBAOCAONHAPTHUOC.Rows[i]["MATHUOC"].ToString(), dtBAOCAONHAPTHUOC.Rows[i]["MADONVI"].ToString(), dtBAOCAONHAPTHUOC.Rows[i]["TENDV"].ToString(), dtBAOCAONHAPTHUOC.Rows[i]["SLNHAP"].ToString(), dtBAOCAONHAPTHUOC.Rows[i]["SLTON"].ToString(), dtBAOCAONHAPTHUOC.Rows[i]["TONGTIEN"].ToString());

                }
            }
            else            
                MessageBox.Show("Không tìm thấy thông tin. Vui lòng chọn thời gian khác !", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);           
        }
    }
}
