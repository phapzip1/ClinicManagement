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

        public string Name { get; }
        public string UnitName { get; }
        public int Quantity { get; }
        public int Time { get; }
    }
}
