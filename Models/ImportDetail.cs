namespace ClinicManagement.Models
{
    public class ImportDetail
    {
        public ImportDetail(Guid importId, Guid medicineId, string name, string unitName, int quantity, int price)
        {
            ImportId = importId;
            MedicineId = medicineId;
            Name = name;
            UnitName = unitName;
            Quantity = quantity;
            Price = price;
        }

        public Guid ImportId { get; }
        public Guid MedicineId { get; }
        public string Name { get; }
        public string UnitName { get; }
        public int Quantity { get; }
        public int Price { get; }

        public int Sum
        {
            get => Quantity * Price; 
        }
    }
}
