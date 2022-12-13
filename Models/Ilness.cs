namespace ClinicManagement.Models
{
    public class Ilness
    {
        public Ilness(Guid id, string name, string symptom)
        {
            Id = id;
            Name = name;
            Symptom = symptom;
        }

        public Guid Id { get; }
        public string Name { get; }
        public string Symptom { get; }
    }
}
