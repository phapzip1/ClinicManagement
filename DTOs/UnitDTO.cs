using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.DTOs
{
    public class UnitDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
