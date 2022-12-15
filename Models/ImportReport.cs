namespace ClinicManagement.Models
{
    public class ImportReport
    {
        public ImportReport(string medicineName, string unitName, int quantity, int price)
        {
            MedicineName = medicineName;
            UnitName = unitName;
            Quantity = quantity;
            Price = price;
        }

        public string MedicineName { get; }
        public string UnitName { get; }
        public int Quantity { get; }
        public int Price { get; }
        public int Sum
        {
            get => Quantity * Price;
        }
    }
}
