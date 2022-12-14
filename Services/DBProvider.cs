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

        public async Task<IEnumerable<Medicine>> GetMedicines()
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                return await dbContext.Medicines.Join(dbContext.Units, p => p.UnitId, f => f.Id, (p, f) => new { medicine = p, unit = f })
                    .Select(obj => new Medicine(obj.medicine.Id, obj.medicine.Name, obj.unit.Id, obj.unit.Name, obj.medicine.Stock, obj.medicine.Price))
                    .ToListAsync();
            }
        }

        public async Task<IEnumerable<Bill>> GetAllBills()
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                return await dbContext.Bills.Join(dbContext.MedicalNotes, p => p.MedicalNoteId, f => f.Id, (p, f) => new { bill = p, medicalnote = f })
                    .Join(dbContext.Patients, p => p.medicalnote.PatientId, f => f.Id, (p, f) => new { bill = p.bill, medicalnote = p.medicalnote, patient = f })
                    .Select(obj => new Bill(obj.bill.Id, obj.medicalnote.Id, obj.patient.Fullname, obj.bill.MedicineCost, obj.bill.MedicalCost))
                    .ToListAsync();

            }
        }

        public async Task<IEnumerable<Illness>> GetAllIllness()
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                return await dbContext.Illness.Select(obj => new Illness(obj.Id, obj.Name, obj.Symptom)).ToListAsync();
            }
        }

        public async Task<IEnumerable<UsageReport>> GetAllUsageReports()
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                return await dbContext.Medicines.Join(dbContext.Units, p => p.UnitId, f => f.Id, (p, f) => new { medicine = p, unit = f })
                    .Join(dbContext.MedicalNoteDetail, p => p.medicine.Id, f => f.MedicineId, (p, f) => new { medicine = p.medicine, unit = p.unit, detail = f })
                    .Join(dbContext.MedicalNotes, p => p.detail.MedicalNoteId, f => f.Id, (p, f) => new { medicine = p.medicine, unit = p.unit, detail = p.detail, note = f })
                    .GroupBy(p => new { Id = p.medicine.Id, Name = p.medicine.Name, UnitId = p.unit.Id, UnitName = p.unit.Name })
                    .Select(obj => new UsageReport(obj.Key.Name, obj.Key.UnitName, (uint)obj.Sum(p => p.detail.Quantity), (uint)obj.Count()))
                    .ToListAsync();
            }
        }

        public async Task<IEnumerable<UsageReport>> GetAllUsageReports(int month, int year)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                return await dbContext.Medicines.Join(dbContext.Units, p => p.UnitId, f => f.Id, (p, f) => new { medicine = p, unit = f })
                    .Join(dbContext.MedicalNoteDetail, p => p.medicine.Id, f => f.MedicineId, (p, f) => new { medicine = p.medicine, unit = p.unit, detail = f })
                    .Join(dbContext.MedicalNotes, p => p.detail.MedicalNoteId, f => f.Id, (p, f) => new { medicine = p.medicine, unit = p.unit, detail = p.detail, note = f })
                    .Where(p => p.note.CreateIn.Month == month && p.note.CreateIn.Year == year)
                    .GroupBy(p => new { Id = p.medicine.Id, Name = p.medicine.Name, UnitId = p.unit.Id, UnitName = p.unit.Name })
                    .Select(obj => new UsageReport(obj.Key.Name, obj.Key.UnitName, (uint)obj.Sum(p => p.detail.Quantity), (uint)obj.Count()))
                    .ToListAsync();
            }
        }

        public async Task<IEnumerable<Statistic>> GetStatistic(int month, int year)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                return await dbContext.Bills.Join(dbContext.MedicalNotes, p => p.MedicalNoteId, f => f.Id, (p, f) => new {bill = p, note = f })
                    .Where(p => p.note.CreateIn.Month == month && p.note.CreateIn.Year == year)
                    .GroupBy(p =>  new { p.note.CreateIn.Day })
                    .Select(obj => new Statistic((uint)obj.Key.Day, (uint)obj.Count(), (uint)obj.Sum(p => p.bill.MedicalCost + p.bill.MedicineCost)))
                    .ToListAsync();
            }
        }
    }
}
