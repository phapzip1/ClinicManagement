using ClinicManagement.DbContexts;
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
    }
}
