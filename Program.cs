using ClinicManagement.DbContexts;
using ClinicManagement.Services;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagement
{
    internal static class Program
    {
        private const string CONNECTION_STRING = "Server=.;Database=Clinic;Integrated Security=true;Trust Server Certificate=true;";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DbContextOptions options = new DbContextOptionsBuilder().UseSqlServer("Server=.;Database=Clinic;Integrated Security=true;Trust Server Certificate=true;").Options;
            ClinicDbContextFactory clinicDbContextFactory = new ClinicDbContextFactory(CONNECTION_STRING);

            using (ClinicDbContext dbContext = clinicDbContextFactory.CreateDbContext())
            {

                dbContext.Database.Migrate();

                IDataCreator dataCreator = new DBCreator(clinicDbContextFactory);
                dataCreator.CreatePatient(new Models.Patient("7", "sang", "male", DateTime.Now, "faikfa"));
            }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}