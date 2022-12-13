using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.DTOs
{
    public class MedicineDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Unit")]
        public Guid UnitId { get; set; }
        public UnitDTO Unit { get; set;}
        public uint Stock { get; set; }
        public uint Price { get; set; }
    }
}
