namespace ClinicManagement.Models
{
    public class Method
    {
        public Method(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        public Guid Id { get; }
        public string Name { get; }
    }
}
