
using ClinicManagement.Models;

namespace ClinicManagement.Services
{
    public interface IDataProvider
    {
        Task<IEnumerable<Patient>> GetAllPatients();
        Task<Patient> GetPatient(string Id);
        Task<IEnumerable<Medicine>> GetMedicines();
        Task<IEnumerable<Bill>> GetAllBills();
        Task<IEnumerable<Unit>> GetAllUnits();
        Task<IEnumerable<Method>> GetAllMethods();  
        Task<IEnumerable<Illness>> GetAllIllness();
        Task<IEnumerable<MedicalNote>> GetAllMedicalNote(string patientId);
        Task<IEnumerable<UsageReport>> GetAllUsageReports();
        Task<IEnumerable<UsageReport>> GetAllUsageReports(int month, int year);
        Task<IEnumerable<Statistic>> GetStatistic(int month, int year);
        Task<IEnumerable<ImportReport>> GetImportReport(int month, int year);
        Task<bool> VerifyPassword(string password);
        Task<Dictionary<string, int>> GetParams(); 
    }
}
