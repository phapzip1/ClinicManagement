namespace ClinicManagement.Models
{
    public class Medicine
    {
        public Medicine(Guid id, string name, Guid unitId, int stock, int price)
        {
            Id = id;
            Name = name;
            UnitId = unitId;
            Stock = stock;
            Price = price;
        }

        public Medicine(Guid id, string name, Guid unitId, string unitName, int stock, int price)
        {
            Id = id;
            Name = name;
            UnitId = unitId;
            UnitName = unitName;
            Stock = stock;
            Price = price;
        }

        public Guid Id { get; }
        public string Name { get; }
        public Guid UnitId { get; }
        public int Stock { get; }
        public int Price { get; }
        public string UnitName { get; }

    }
}
