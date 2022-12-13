using ClinicManagement.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagement
{
    internal static class Program
    {
        private const string CONNECTION_STRING = "Server=DESKTOP-OUTFK9N;Database=Clinic;Integrated Security=true;Trust Server Certificate=true;";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlServer("Server=DESKTOP-OUTFK9N;Database=Clinic;Integrated Security=true;Trust Server Certificate=true;").Options;

            using (ClinicDbContext dbContext = new ClinicDbContext(options))
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