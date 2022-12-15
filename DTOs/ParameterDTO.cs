using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.DTOs
{
    public class ParameterDTO
    {
        [Key]
        public string Id { get; set; }
        public int MedicalCost { get; set; }
        public int MaxPatient { get; set; }
        public string Password { get; set; }
    }
}
