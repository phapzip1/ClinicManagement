using ClinicManagement.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ClinicManagement
{
    internal static class Program
    {
        public static IConfiguration Configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            ClinicDbContextFactory _clinicDbContextFactory = new ClinicDbContextFactory(Configuration.GetSection("ConnectionStrings").Value.ToString());
            using (ClinicDbContext dbContext = _clinicDbContextFactory.CreateDbContext())
            {

                //dbContext.Database.Migrate();

                IDataCreator dataCreator = new DBCreator(_clinicDbContextFactory);
                dataCreator.CreatePatient(new Models.Patient("7", "sang", "male", DateTime.Now, "faikfa"));
            }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}