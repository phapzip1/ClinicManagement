using Microsoft.Office.Interop.Excel;

namespace ClinicManagement.Models
{
    public class UsageReport
    {
        public UsageReport(string name, string unitName, int quantity, int time)
        {
            Name = name;
            UnitName = unitName;
            Quantity = quantity;
            Time = time;
        }
        public UsageReport (UsageReport usageReport)
        {
            Name = usageReport.Name;
            UnitName = usageReport.UnitName;
            Quantity = usageReport.Quantity;
            Time = usageReport.Time;
        }

        public string Name { get; }
        public string UnitName { get; }
        public int Quantity { get; }
        public int Time { get; }
    }
}
