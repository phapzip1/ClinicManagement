using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.DTOs
{
    public class MedicalNoteDTO
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Patient")]
        public string PatientId { get; set; }
        public virtual PatientDTO Patient { get; set; }
        [ForeignKey("Illness")]
        public Guid IllnessId { get; set; }
        public virtual IllnessDTO Illness { get; set; }
        public string Symtoms { get; set; }
        public DateTime CreateIn { get; set; }
    }
}
