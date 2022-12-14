using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.DTOs
{
    public class ParameterDTO
    {
        [Key]
        public string Id { get; set; }
        public uint MedicalCost { get; set; }
        public uint MaxPatient { get; set; }
    }
}
