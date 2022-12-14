using ClinicManagement.DbContexts;
using ClinicManagement.DTOs;
using ClinicManagement.Models;

namespace ClinicManagement.Services
{
    public class DBCreator : IDataCreator
    {
        private readonly ClinicDbContextFactory _dbContextFactory;

        public DBCreator(ClinicDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }


        public async Task CreatePatient(Patient patient)
        {
            using (ClinicDbContext context = _dbContextFactory.CreateDbContext())
            {
                PatientDTO patientDTO = ToPatientDIO(patient);
                context.Patients.Add(patientDTO);
                await context.SaveChangesAsync();
            }
        }

        public async Task CreateMedicalNote(MedicalNote medicalNote)
        {
            using (ClinicDbContext context = _dbContextFactory.CreateDbContext())
            {
                MedicalNoteDTO medicalNoteDTO = ToMedicalNoteDTO(medicalNote);
                context.MedicalNotes.Add(medicalNoteDTO);
                context.MedicalNoteDetail.AddRange(medicalNote.Details.Select(e => ToMedicalNoteDetailDTO(e)));
                await context.SaveChangesAsync();
            }
        }

        public async Task CreateImport(Import import)
        {
            using (ClinicDbContext context = _dbContextFactory.CreateDbContext())
            {
                ImportDTO importDTO = new ImportDTO()
                {


                };
            }
        }

        private MedicalNoteDetailDTO ToMedicalNoteDetailDTO(MedicalNoteDetail detail)
        {
            return new MedicalNoteDetailDTO()
            {
                MedicalNoteId = detail.MedicalNoteId,
                MedicineId = detail.MedicineId,
                Quantity = detail.Quantity,
                MethodId = detail.MethodId,
            };
        }

        private MedicalNoteDTO ToMedicalNoteDTO(MedicalNote medicalNote)
        {
            return new MedicalNoteDTO()
            {
                Id = medicalNote.Id,
                PatientId = medicalNote.PatientId,
                IllnessId = medicalNote.IllnessId,
                Symtoms = medicalNote.Symtoms,
                CreateIn = medicalNote.CreateIn,
            };
        }

        private PatientDTO ToPatientDIO(Patient patient)
        {
            return new PatientDTO()
            {
                Id = patient.Id,
                Fullname = patient.Fullname,
                Gender = patient.Gender,
                Dob = patient.Dob,
                Address = patient.Address
            };
        }

        
    }
}
