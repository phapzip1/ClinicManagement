using ClinicManagement.DTOs;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagement.DbContexts
{
    public class ClinicDbContext : DbContext
    {
        public ClinicDbContext(DbContextOptions options) : base(options){
        }
        public DbSet<PatientDTO> Patients { get; set; }
        public DbSet<MedicineDTO> Medicines { get; set; }
        public DbSet<IllnessDTO> Illness { get; set; }
        public DbSet<UnitDTO> Units { get; set; }
        public DbSet<MedicalNoteDTO> MedicalNotes { get; set; }
        public DbSet<MethodDTO> Methods { get; set; }
        public DbSet<MedicalNoteDetailDTO> MedicalNoteDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MedicalNoteDetailDTO>().HasKey(e => new {e.MedicineId, e.MedicalNoteId });
        }
    }
}
