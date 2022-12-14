using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.DTOs
{
    public class MedicalNoteDetailDTO
    {
        [ForeignKey("MedicalNote")]
        public Guid MedicalNoteId { get; set; }
        public virtual MedicalNoteDTO MedicalNote { get; set; }
        [ForeignKey("Medicine")]
        public Guid MedicineId { get; set; }
        public virtual MedicineDTO Medicine { get; set; }
        public uint Quantity { get; set; }
        [ForeignKey("Method")]
        public Guid MethodId { get; set; }
        public MethodDTO  Method { get; set; }
    }
}
