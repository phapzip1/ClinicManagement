using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.DTOs
{
    public class ImportDTO
    {
        [Key]
        public Guid Id { get; set; }
        public uint Price { get; set; }
        public DateTime CreateIn { get; set; }
    }
}
