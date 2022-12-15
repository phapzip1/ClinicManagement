namespace ClinicManagement.Models
{
    public class Bill
    {
        public Bill(Guid id, Guid medicalNoteId, string name, int medicineCost, int medicalCost)
        {
            Id = id;
            MedicalNoteId = medicalNoteId;
            Name = name;
            MedicineCost = medicineCost;
            MedicalCost = medicalCost;
        }

        public Guid Id { get; }
        public Guid MedicalNoteId { get; }
        public string Name { get; }
        public int MedicineCost { get; }
        public int MedicalCost { get; }
    }
}
