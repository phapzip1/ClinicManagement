using ClinicManagement.DbContexts;
using ClinicManagement.Services;
using Microsoft.EntityFrameworkCore;
using ClinicManagement.Models;

namespace ClinicManagement
{
    internal static class Program
    {
        private const string CONNECTION_STRING = "server=clinic-do-user-13077884-0.b.db.ondigitalocean.com;port=25060;database=clinic;user=doadmin;password=AVNS_9tiZWj1IIbWbJFEFmxw;";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ClinicDbContextFactory _clinicDbContextFactory = new ClinicDbContextFactory(CONNECTION_STRING);
            using (ClinicDbContext dbContext = _clinicDbContextFactory.CreateDbContext())
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