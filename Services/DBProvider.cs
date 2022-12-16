using ClinicManagement.DbContexts;
using ClinicManagement.DTOs;
using ClinicManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace ClinicManagement.Services
{
    public class DBProvider //: IDataProvider
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
                                obj.medicalnote.Symtoms,
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
                    .Select(obj => new UsageReport(obj.Key.Name, obj.Key.UnitName, obj.Sum(p => p.detail.Quantity), obj.Count()))
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
                    .Select(obj => new UsageReport(obj.Key.Name, obj.Key.UnitName, obj.Sum(p => p.detail.Quantity), obj.Count()))
                    .ToListAsync();
            }
        }

        //public async Task<IEnumerable<Statistic>> GetStatistic(int month, int year)
        //{
        //    using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
        //    {
        //        DbFunctions

        //        //var list = await dbContext.Bills
        //        //    .Join(dbContext.MedicalNotes, p => p.MedicalNoteId, f => f.Id, (p, f) => new { bill = p, note = f })
        //        //    .Where(p =>  == month && p.note.CreateIn.Value.Year == year)
        //        //    .GroupBy(p => new { p.note.CreateIn.Day })
        //        //    .Select(obj => new { Day = obj.Key.Day, Count = obj.Count(), Sum = obj.Sum(p => p.bill.MedicalCost + p.bill.MedicineCost) })
        //        //    .Select(obj => new Statistic(1, 1, obj.bill.MedicineCost + obj.bill.MedicalCost))
        //        //    .ToListAsync();
        //        //return list;
        //    }
        //}

        public async Task<IEnumerable<ImportReport>> GetImportReport(int month, int year)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                return await dbContext.Imports.Join(dbContext.ImportDetail, p => p.Id, f => f.ImportId, (p, f) => new { import = p, detail = f })
                    .Join(dbContext.Medicines, p => p.detail.MedicineId, f => f.Id, (p, f) => new { import = p.import, detail = p.detail, medicine = f })
                    .Join(dbContext.Units, p => p.medicine.UnitId, f => f.Id, (p, f) => new { import = p.import, detail = p.detail, medicine = p.medicine, unit = f })
                    .Where(p => p.import.CreateIn.Month == month && p.import.CreateIn.Year == year)
                    .GroupBy(p => new { Id = p.medicine.Id, Name = p.medicine.Name, UnitId = p.unit.Id, UnitName = p.unit.Name })
                    .Select(obj => new ImportReport(obj.Key.Name, obj.Key.UnitName, obj.Sum(p => p.detail.Quantity), obj.Sum(p => p.detail.Quantity * p.detail.Price)))
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
