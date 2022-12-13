using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.DTOs
{
    public class IllnessDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Symptom { get; set; }
    }
}
