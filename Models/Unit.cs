namespace ClinicManagement.Models
{
    public class Unit
    {
        public Unit(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        public Guid Id { get;}
        public string Name { get;}

    }
}
