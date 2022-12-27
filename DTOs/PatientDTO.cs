using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.DTOs
{
    public class PatientDTO
    {
        [Key]
        public string Id { get; set; }
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public ICollection<MedicalNoteDTO> Notes { get; set; }
    }
}
