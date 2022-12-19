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

        public ImportReport (ImportReport importReport)
        {
            this.MedicineName = importReport.MedicineName;
            this.UnitName = importReport.UnitName;
            this.Quantity = importReport.Quantity;
            this.Price = importReport.Price;
        }

        public string MedicineName { get; }
        public string UnitName { get; }
        public int Quantity { get; }
        public int Price { get; }
    }
}
