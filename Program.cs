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
                dbContext.Database.Migrate();
            }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}