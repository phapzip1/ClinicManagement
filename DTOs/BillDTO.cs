using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.DTOs
{
    public class BillDTO
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("MedicalNote")]
        public Guid MedicalNoteId { get; set; }
        public virtual MedicalNoteDTO MedicalNote { get; set; }
        public string Name { get; set; }
        public uint MedicineCost { get; set; }
        public uint MedicalCost { get; set; }
    }
}
