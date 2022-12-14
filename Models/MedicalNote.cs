namespace ClinicManagement.Models
{
    public class MedicalNote
    {
        public MedicalNote(Guid id, string patientId, string patientName, Guid illnessId, string illnessName, string symtoms, DateTime createIn, IEnumerable<MedicalNoteDetail> details)
        {
            Id = id;
            PatientId = patientId;
            PatientName = patientName;
            IllnessId = illnessId;
            IllnessName = illnessName;
            Symtoms = symtoms;
            CreateIn = createIn;
            Details = details;
        }

        public Guid Id { get; }
        public string PatientId { get; }
        public string PatientName { get; }
        public Guid IllnessId { get; }
        public string IllnessName { get; }
        public string Symtoms { get; }
        public DateTime CreateIn { get; }
        public IEnumerable<MedicalNoteDetail> Details { get; }
    }
}
