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
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM yyyy";
            dateTimePicker1.ShowUpDown = true;

            // data: STT, Ngày, Số Bệnh Nhân, Doanh Thu, Tỷ Lệ. (Báo cáo doanh thu theo tháng)
            // tháng, năm --> tên thuốc, đơn vị, số lượng nhập, số lượng tồn kho, Tổng chi phí "full".(Báo cáo nhập thuốc)
        }

    }
}
