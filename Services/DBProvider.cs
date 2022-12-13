using ClinicManagement.DbContexts;
using ClinicManagement.DTOs;
using ClinicManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagement.Services
{
    public class DBProvider : IDataProvider
    {
        private readonly ClinicDbContextFactory _dbContextFactory;

        public DBProvider(ClinicDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<Patient>> GetAllPatients()
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<PatientDTO> patientDTOs = await dbContext.Patients.ToListAsync();
                return patientDTOs.Select(r => new Patient(r.Id, r.Fullname, r.Gender, r.Dob, r.Address));
            }
        }

        public async Task<IEnumerable<MedicalNote>> GetAllMedicalNote()
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                return await dbContext.MedicalNotes
                            .Join(dbContext.Patients, m => m.PatientId, f => f.Id, (m, f) => new { m, f })
                            .Join(dbContext.Illness, m => m.m.IllnessId, f => f.Id, (m, f) => new { medicalnote = m.m, patient = m.f, illness = f })
                            .Select(obj => new MedicalNote(
                                obj.medicalnote.Id,
                                obj.patient.Id,
                                obj.patient.Fullname,
                                obj.illness.Id,
                                obj.illness.Name,
                                obj.medicalnote.CreateIn,
                                GetMedicalNoteDetail(obj.medicalnote.Id)
                               )).ToListAsync();

            }
        }

        private IEnumerable<MedicalNoteDetail> GetMedicalNoteDetail(Guid id)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
               return dbContext.MedicalNoteDetail.Join(dbContext.Medicines, p => p.MedicineId, f => f.Id, (p, f) => new { detail = p, medicine = f })
                                            .Join(dbContext.Units, p => p.medicine.Id, f => f.Id, (p, f) => new { detail = p.detail, medicine = p.medicine, unit = f })
                                            .Join(dbContext.Methods, p => p.detail.MethodId, f => f.Id, (p, f) => new { detail = p.detail, medicine = p.medicine, unit = p.unit, method = f })
                                            .Where(obj => obj.detail.MedicalNoteId == id)
                                            .ToList()
                                            .Select(obj => new MedicalNoteDetail(obj.detail.MedicalNoteId, obj.medicine.Id, obj.medicine.Name, obj.unit.Id, obj.unit.Name, obj.detail.Quantity, obj.method.Id, obj.method.Name));
                                            
            }
        }
    }
}
