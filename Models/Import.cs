namespace ClinicManagement.Models
{
    public class Import
    {
        public Import(Guid id, DateTime createIn, int price, IEnumerable<ImportDetail> details)
        {
            Id = id;
            CreateIn = createIn;
            Price = price;
            Details = details;
        }

        public Guid Id { get; }
        public DateTime CreateIn { get; }
        public int Price { get; }
        public IEnumerable<ImportDetail> Details { get; }
    }
}
