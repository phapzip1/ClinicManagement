
using ClinicManagement.Models;

namespace ClinicManagement.Services
{
    public interface IDataProvider
    {
        Task<IEnumerable<Patient>> GetAllPatients();
        Task<IEnumerable<Medicine>> GetMedicines();
        Task<IEnumerable<Bill>> GetAllBills();
        Task<IEnumerable<Illness>> GetAllIllness();
        Task<IEnumerable<UsageReport>> GetAllUsageReports();
        Task<IEnumerable<UsageReport>> GetAllUsageReports(int month, int year);
        Task<IEnumerable<Statistic>> GetStatistic(int month, int year);
        Task<IEnumerable<ImportReport>> GetImportReport(int month, int year);
        Task<bool> VerifyPassword(string password);
        Task<Dictionary<string, int>> GetParams(); 
    }
}
