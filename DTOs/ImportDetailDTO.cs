using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.DTOs
{
    public class ImportDetailDTO
    {
        [ForeignKey("Import")]
        public Guid ImportId;
        public ImportDTO ImportDTO;
        [ForeignKey("Medicine")]
        public Guid MedicineId;
        public MedicineDTO MedicineDTO;
        public uint Quantity;
        public uint Price;
    }
}
