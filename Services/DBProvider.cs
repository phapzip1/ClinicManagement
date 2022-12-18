using ClinicManagement.DbContexts;
using ClinicManagement.DTOs;
using ClinicManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

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
                            .Join(dbContext.Patients, m => m.PatientId, f => f.Id, (m, f) => new { notes = m, patient = f })
                            .Join(dbContext.Illness, m => m.notes.IllnessId, f => f.Id, (m, f) => new { notes = m.notes, patient = m.patient, illness = f })
                            .Select(obj => new MedicalNote(
                                obj.notes.Id,
                                obj.patient.Id,
                                obj.patient.Fullname,
                                obj.illness.Id,
                                obj.illness.Name,
                                obj.notes.Symtoms,
                                obj.notes.CreateIn,
                                null
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
                return await dbContext.MedicalNotes
                    .Join(dbContext.MedicalNoteDetail, p => p.Id, f => f.MedicalNoteId, (p, f) => new { notes = p, detail = f })
                    .Join(dbContext.Medicines, p => p.detail.MedicineId, f => f.Id, (p, f) => new { notes = p.notes, medicine = f, detail = p.detail })
                    .Join(dbContext.Units, p => p.medicine.UnitId, f => f.Id, (p, f) => new { notes = p.notes, medicine = p.medicine, detail = p.detail, unit = f })
                    .GroupBy(p => new { id = p.medicine.Id, name = p.medicine.Name, unit = p.unit.Name })
                    .Select(obj => new UsageReport(obj.Key.name, obj.Key.unit, obj.Sum(p => p.detail.Quantity), obj.Count()))
                    .ToListAsync();
            }
        }

        public async Task<IEnumerable<UsageReport>> GetAllUsageReports(int month, int year)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                DateTime start = new DateTime(year, month, 1);
                DateTime end = start.AddMonths(1).AddDays(-1);

                return await dbContext.MedicalNotes
                    .Where(p => p.CreateIn > start && p.CreateIn < end)
                    .Join(dbContext.MedicalNoteDetail, p => p.Id, f => f.MedicalNoteId, (p, f) => new { notes = p, detail = f })
                    .Join(dbContext.Medicines, p => p.detail.MedicineId, f => f.Id, (p, f) => new { notes = p.notes, medicine = f, detail = p.detail })
                    .Join(dbContext.Units, p => p.medicine.UnitId, f => f.Id, (p, f) => new { notes = p.notes, medicine = p.medicine, detail = p.detail, unit = f })
                    .GroupBy(p => new { id = p.medicine.Id, name = p.medicine.Name, unit = p.unit.Name })
                    .Select(obj => new UsageReport(obj.Key.name, obj.Key.unit, obj.Sum(p => p.detail.Quantity), obj.Count()))
                    .ToListAsync();

            }
        }

        public async Task<IEnumerable<Statistic>> GetStatistic(int month, int year)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                DateTime start = new DateTime(year, month, 1);
                DateTime end = start.AddMonths(1).AddDays(-1);

                return await dbContext.Bills
                    .Join(dbContext.MedicalNotes, p => p.MedicalNoteId, f => f.Id, (p, f) => new { Id = p.Id, noteId = f.Id,  medicalcost = p.MedicalCost, medicinecost = p.MedicineCost, createin = f.CreateIn})
                    .Where(p => p.createin >= start && p.createin <= end)
                    .GroupBy(p => EF.Property<DateTime>(p, "createin").Date)
                    .Select(obj => new Statistic(obj.Key, obj.Count(), obj.Sum(p => p.medicalcost + p.medicinecost)))
                    .ToListAsync();
            }
        }

        public async Task<IEnumerable<ImportReport>> GetImportReport(int month, int year)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                DateTime start = new DateTime(year, month, 1);
                DateTime end = start.AddMonths(1).AddDays(-1);

                return await dbContext.Imports.Join(dbContext.ImportDetail, p => p.Id, f => f.ImportId, (p, f) => new { import = p, detail = f })
                    .Join(dbContext.Medicines, p => p.detail.MedicineId, f => f.Id, (p, f) => new { import = p.import, detail = p.detail, medicine = f })
                    .Join(dbContext.Units, p => p.medicine.UnitId, f => f.Id, (p, f) => new { id = p.detail.MedicineId, name = p.medicine.Name, unitname = f.Name, quantity = p.detail.Quantity, price = p.detail.Price * p.detail.Quantity, createin = p.import.CreateIn })
                    .Where(p => p.createin >= start && p.createin <= end )
                    .GroupBy(p => new { Id = p.id, Name = p.name, Unitname = p.unitname})
                    .Select(obj => new ImportReport(obj.Key.Name, obj.Key.Unitname, obj.Sum(p => p.quantity), obj.Sum(p => p.price)))
                    .ToListAsync();
            }
        }

        public async Task<Dictionary<string, int>> GetParams()
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var pair = dbContext.Parameters.SingleOrDefault(p => p.Id == "1");
                if (pair != null)
                {
                    Dictionary<string, int> dic = new Dictionary<string, int>();
                    dic.Add("MaxPatients", pair.MaxPatient);
                    dic.Add("MedicalCost", pair.MedicalCost);
                    return dic;
                }
                return null;
            }
        }

        public async Task<bool> VerifyPassword(string password)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                /* Fetch the stored value */
                string savedPasswordHash = dbContext.Parameters.SingleOrDefault(p => p.Id == "1").Password;
                /* Extract the bytes */
                byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
                /* Get the salt */
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                /* Compute the hash on the password the user entered */
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
                byte[] hash = pbkdf2.GetBytes(20);
                /* Compare the results */
                for (int i = 0; i < 20; i++)
                    if (hashBytes[i + 16] != hash[i])
                        return false;
                return true;
            }
        }
    }
}
