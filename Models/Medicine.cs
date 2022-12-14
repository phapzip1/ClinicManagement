namespace ClinicManagement.Models
{
    public class Medicine
    {
        public Medicine(Guid id, string name, Guid unitId, uint stock, uint price)
        {
            Id = id;
            Name = name;
            UnitId = unitId;
            Stock = stock;
            Price = price;
        }

        public Guid Id { get; }
        public string Name { get; }
        public Guid UnitId { get; }
        public uint Stock { get; }
        public uint Price { get; }


    }
}
