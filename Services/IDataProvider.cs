using ClinicManagement.Models;

namespace ClinicManagement.Services
{
    public interface IDataProvider
    {
        Task<IEnumerable<Patient>> GetAllPatients();
    }
}
