using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.DTOs
{
    public class MethodDTO
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
