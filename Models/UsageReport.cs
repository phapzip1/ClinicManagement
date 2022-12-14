namespace ClinicManagement.Models
{
    public class UsageReport
    {
        public UsageReport(string name, string unitName, uint quantity, uint time)
        {
            Name = name;
            UnitName = unitName;
            Quantity = quantity;
            Time = time;
        }

        public string Name { get; }
        public string UnitName { get; }
        public uint Quantity { get; }
        public uint Time { get; }
    }
}
