using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.DTOs
{
    public class ImportDetailDTO
    {
        [ForeignKey("Import")]
        public Guid ImportId { get; set; }
        public virtual ImportDTO Import { get; set; }
        [ForeignKey("Medicine")]
        public Guid MedicineId { get; set; }
        public virtual MedicineDTO Medicine { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
