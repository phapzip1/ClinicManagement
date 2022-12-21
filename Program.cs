using ClinicManagement.DbContexts;
using ClinicManagement.Forms;
using ClinicManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ClinicManagement
{
    internal static class Program
    {
        public static IConfiguration Configuration;
        public static List<Patient> PatientQueue;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {         
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            PatientQueue = new List<Patient>();

            ClinicDbContextFactory _clinicDbContextFactory = new ClinicDbContextFactory(Configuration.GetSection("ConnectionStrings").Value.ToString());
            using (ClinicDbContext dbContext = _clinicDbContextFactory.CreateDbContext())
            {
                dbContext.Database.Migrate();

                //IDataCreator dataCreator = new DBCreator(_clinicDbContextFactory);
                //dataCreator.CreatePatient(new Models.Patient("8", "test", "male", DateTime.Now, "345"));
            }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            if (!loginForm.IsSuccess)
            {
                if (System.Windows.Forms.Application.MessageLoop)
                {
                    // Use this since we are a WinForms app
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    // Use this since we are a console app
                    System.Environment.Exit(1);
                }
            }

            Application.Run(new Form1());
        }
    }
}