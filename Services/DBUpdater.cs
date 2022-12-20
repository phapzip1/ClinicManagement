using ClinicManagement.DbContexts;
using ClinicManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace ClinicManagement.Services
{
    public class DBUpdater : IDataUpdater
    {
        private readonly ClinicDbContextFactory _dbContextFactory;

        public DBUpdater(ClinicDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task RemoveIllness(Guid illnessId)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var obj = dbContext.Illness.FirstOrDefault(p => p.Id == illnessId);
                if (obj != null)
                {
                    dbContext.Illness.Remove(obj);
                    await dbContext.SaveChangesAsync();
                }
            }
        }

        public async Task RemoveMedicine(Guid medicineId)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var obj = dbContext.Medicines.FirstOrDefault(p => p.Id == medicineId);
                if (obj != null)
                {
                    dbContext.Medicines.Remove(obj);
                    await dbContext.SaveChangesAsync();
                }
            }
        }

        public async Task RemoveMethod(Guid methodId)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var obj = dbContext.Methods.FirstOrDefault(p => p.Id == methodId);
                dbContext.Methods.Remove(obj);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task RemovePatient(string patientId)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var obj = dbContext.Patients.FirstOrDefault(p => p.Id == patientId);
                if (obj != null)
                {
                    dbContext.Patients.Remove(obj);
                    await dbContext.SaveChangesAsync();
                };
            }
        }

        public async Task RemoveUnit(Guid unitId)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var obj = dbContext.Units.FirstOrDefault(p => p.Id == unitId);
                if (obj != null)
                {
                    dbContext.Units.Remove(obj);
                    await dbContext.SaveChangesAsync();
                };
            }
        }

        public async Task UpdateIllness(Illness illness)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var obj = dbContext.Illness.FirstOrDefault(p => p.Id == illness.Id);
                if (obj != null)
                {
                    obj.Name = illness.Name;
                    obj.Symptom = illness.Symptom;
                    dbContext.Illness.Update(obj);
                    await dbContext.SaveChangesAsync();
                }
            }
        }

        public async Task UpdateMedicine(Medicine medicine)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var obj = dbContext.Medicines.FirstOrDefault(p => p.Id == medicine.Id);
                if (obj != null)
                {
                    obj.Price = medicine.Price;
                    obj.Stock = medicine.Stock;
                    obj.UnitId = medicine.UnitId;
                    obj.Name = medicine.Name;
                    dbContext.Medicines.Update(obj);
                    await dbContext.SaveChangesAsync();
                }
            }
        }


        public async Task UpdateMethod(Method method)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var obj = dbContext.Methods.FirstOrDefault(p => p.Id == method.Id);
                obj.Name = method.Name;
                dbContext.Methods.Update(obj);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateParameters(int medicalCost, int maxPatients)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var param = dbContext.Parameters.SingleOrDefault(p => p.Id == "1");
                if (param != null)
                {
                    param.MedicalCost = medicalCost;
                    param.MaxPatient = maxPatients;
                    dbContext.Parameters.Update(param);
                    await dbContext.SaveChangesAsync();
                }
            }
        }

        public async Task UpdatePassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                string newpass = Convert.ToBase64String(hashBytes);
                var param = dbContext.Parameters.SingleOrDefault(p => p.Id == "1");
                param.Password = newpass;
                dbContext.Parameters.Update(param);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdatePatient(Patient patient)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var obj = dbContext.Patients.FirstOrDefault(p => p.Id == patient.Id);
                if (obj != null)
                {
                    obj.Fullname = patient.Fullname;
                    obj.Address = patient.Address;
                    obj.Gender = patient.Gender;
                    obj.Dob = patient.Dob;

                    dbContext.Patients.Update(obj);
                    await dbContext.SaveChangesAsync();
                }
            }
        }

        public async Task UpdateUnit(Unit unit)
        {
            using (ClinicDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var obj = dbContext.Units.FirstOrDefault(p => p.Id == unit.Id);
                obj.Name = unit.Name;
                dbContext.Units.Update(obj);
                await dbContext.SaveChangesAsync();
            }
        }

        
    }
}
