namespace ClinicManagement.Models
{
    public class ImportDetail
    {
        public ImportDetail(Guid importId, Guid medicineId, string name, string unitName, uint quantity, uint price)
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
        public uint Quantity { get; }
        public uint Price { get; }
    }
}
